/*
 * PersonalDataProtector.cs
 *
 *   Created: 2022-12-13-09:04:12
 *   Modified: 2022-12-13-09:04:12
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;

// using StringDictionary = System.Collections.Generic.Dictionary<string, string>;

namespace Dgmjr.Identity.DataProtection;

public class PersonalDataProtector : IPersonalDataProtector
{
    private readonly ProtectorAlgorithm _defaultAlgorithm = ProtectorAlgorithm.Aes256Hmac512;
    private readonly ILookupProtectorKeyRing _keyRing;

    public PersonalDataProtector(ILookupProtectorKeyRing keyRing)
    {
        _keyRing = keyRing;
    }

    public string Protect(string? data)
    {
        // Get the default algorithms.
        // We does this so we can embed the algorithm details used in the cipher text so we can
        // change algorithms as yet another collision appears in a hashing algorithm.
        // See https://media.blackhat.com/bh-us-10/whitepapers/Sullivan/BlackHat-USA-2010-Sullivan-Cryptographic-Agility-wp.pdf
        ProtectorAlgorithmHelper.GetAlgorithms(
            _defaultAlgorithm,
            out SymmetricAlgorithm encryptingAlgorithm,
            out KeyedHashAlgorithm signingAlgorithm,
            out int keyDerivationIterationCount
        );

        // Use the newest key from the keyring.
        // We know this is a guid, because that's how our keyring works underneath,
        // so we can prepend this later to the result.
        string keyId = _keyRing.CurrentKeyId;
        var masterKey = Key(keyId);

        // Convert the string to bytes, because encryption works on bytes, not strings.
        var plainText = Encoding.UTF8.GetBytes(data);
        byte[] cipherTextAndIV;

        // Derive a key for encryption from the master key
        encryptingAlgorithm.Key = DerivedEncryptionKey(
            masterKey,
            encryptingAlgorithm,
            keyDerivationIterationCount
        );

        // When the underlying encryption class is created it has a random IV by default
        // So we don't need to do anything IV wise.

        // And encrypt
        using (var ms = new MemoryStream())
        using (
            var cs = new CryptoStream(
                ms,
                encryptingAlgorithm.CreateEncryptor(),
                CryptoStreamMode.Write
            )
        )
        {
            cs.Write(plainText);
            cs.FlushFinalBlock();
            var encryptedData = ms.ToArray();

            cipherTextAndIV = CombineByteArrays(encryptingAlgorithm.IV, encryptedData);
        }

        // Now get a signature for the data so we can detect tampering in situ.
        byte[] signature = SignData(
            cipherTextAndIV,
            masterKey,
            encryptingAlgorithm,
            signingAlgorithm,
            keyDerivationIterationCount
        );

        // Add the signature to the cipher text.
        var signedData = CombineByteArrays(signature, cipherTextAndIV);

        // Add our algorithm identifier to the combined signature and cipher text.
        var algorithmIdentifier = BitConverter.GetBytes((int)_defaultAlgorithm);
        byte[] dataPlusAlgorithmId = CombineByteArrays(algorithmIdentifier, signedData);

        // Now we need to put our key identifier in. In our implementation this is a GUID
        // so let's convert it back to one, then turn it to bytes.
        byte[] output = CombineByteArrays(global::System.Guid.Parse(keyId).ToByteArray(), dataPlusAlgorithmId);

        // Clean everything up.
        encryptingAlgorithm.Clear();
        signingAlgorithm.Clear();
        encryptingAlgorithm.Dispose();
        signingAlgorithm.Dispose();

        Array.Clear(plainText, 0, plainText.Length);

        // Return the results as a string.
        return output.ToBase64String();
    }

    public string Unprotect(string? data)
    {
        byte[] plainText;

        // Take our string and convert it back to bytes.
        var payload = data.FromBase64String();

        var offset = 0;

        // First we extract our key ID and then the appropriate key.
        byte[] keyIdAsBytes = new byte[16];
        Buffer.BlockCopy(payload, offset, keyIdAsBytes, 0, 16);
        var keyIdAsGuid = new Guid(keyIdAsBytes);
        var keyId = keyIdAsGuid.ToString();
        var masterKey = Key(keyId);
        offset = 16;

        // Next read the saved algorithm details and create instances of those algorithms.
        byte[] algorithmIdentifierAsBytes = new byte[4];
        Buffer.BlockCopy(payload, offset, algorithmIdentifierAsBytes, 0, 4);
        var algorithmIdentifier = (ProtectorAlgorithm)(
            BitConverter.ToInt32(algorithmIdentifierAsBytes, 0)
        );
        ProtectorAlgorithmHelper.GetAlgorithms(
            _defaultAlgorithm,
            out SymmetricAlgorithm encryptingAlgorithm,
            out KeyedHashAlgorithm signingAlgorithm,
            out int keyDerivationIterationCount
        );
        offset += 4;

        // Now extract the signature
        byte[] signature = new byte[signingAlgorithm.HashSize / 8];
        Buffer.BlockCopy(payload, offset, signature, 0, signingAlgorithm.HashSize / 8);
        offset += signature.Length;

        // And finally grab the rest of the data
        var dataLength = payload.Length - offset;
        byte[] cipherTextAndIV = new byte[dataLength];
        Buffer.BlockCopy(payload, offset, cipherTextAndIV, 0, dataLength);

        // Check the signature before anything else is done to detect tampering and avoid
        // oracles.
        byte[] computedSignature = SignData(
            cipherTextAndIV,
            masterKey,
            encryptingAlgorithm,
            signingAlgorithm,
            keyDerivationIterationCount
        );
        if (!ByteArraysEqual(computedSignature, signature))
        {
            throw new CryptographicException(@"Invalid Signature.");
        }
        signingAlgorithm.Clear();
        signingAlgorithm.Dispose();

        // The signature is valid, so now we can work on decrypting the data.
        var ivLength = encryptingAlgorithm.BlockSize / 8;
        byte[] initializationVector = new byte[ivLength];
        byte[] cipherText = new byte[cipherTextAndIV.Length - ivLength];
        // The IV is embedded in the cipher text, so we extract it out.
        Buffer.BlockCopy(cipherTextAndIV, 0, initializationVector, 0, ivLength);
        // Then we get the encrypted data.
        Buffer.BlockCopy(
            cipherTextAndIV,
            ivLength,
            cipherText,
            0,
            cipherTextAndIV.Length - ivLength
        );

        encryptingAlgorithm.Key = DerivedEncryptionKey(
            masterKey,
            encryptingAlgorithm,
            keyDerivationIterationCount
        );
        encryptingAlgorithm.IV = initializationVector;

        // Decrypt
        using (var ms = new MemoryStream())
        using (
            var cs = new CryptoStream(
                ms,
                encryptingAlgorithm.CreateDecryptor(),
                CryptoStreamMode.Write
            )
        )
        {
            cs.Write(cipherText);
            cs.FlushFinalBlock();
            plainText = ms.ToArray();
        }
        encryptingAlgorithm.Clear();
        encryptingAlgorithm.Dispose();

        // And convert from the bytes back to a string.
        return Encoding.UTF8.GetString(plainText);
    }

    public byte[] Key(string keyId)
    {
        return _keyRing[keyId].FromBase64String();
    }

    private static byte[] SignData(
        byte[] cipherText,
        byte[] masterKey,
        SymmetricAlgorithm symmetricAlgorithm,
        KeyedHashAlgorithm hashAlgorithm,
        int keyDerivationIterationCount
    )
    {
        hashAlgorithm.Key = DerivedSigningKey(
            masterKey,
            symmetricAlgorithm,
            keyDerivationIterationCount
        );
        byte[] signature = hashAlgorithm.ComputeHash(cipherText);
        hashAlgorithm.Clear();
        return signature;
    }

    private static byte[] DerivedSigningKey(
        byte[] key,
        SymmetricAlgorithm algorithm,
        int keyDerivationIterationCount
    )
    {
        return KeyDerivation.Pbkdf2(
            @"PersonalDataSigning",
            key,
            KeyDerivationPrf.HMACSHA512,
            keyDerivationIterationCount,
            algorithm.KeySize / 8
        );
    }

    private static byte[] DerivedEncryptionKey(
        byte[] key,
        SymmetricAlgorithm algorithm,
        int keyDerivationIterationCount
    )
    {
        return KeyDerivation.Pbkdf2(
            @"PersonalDataEncryption",
            key,
            KeyDerivationPrf.HMACSHA512,
            keyDerivationIterationCount,
            algorithm.KeySize / 8
        );
    }

    private static byte[] CombineByteArrays(byte[] left, byte[] right)
    {
        byte[] output = new byte[left.Length + right.Length];
        Buffer.BlockCopy(left, 0, output, 0, left.Length);
        Buffer.BlockCopy(right, 0, output, left.Length, right.Length);

        return output;
    }

    [MethodImpl(MethodImplOptions.NoOptimization)]
    private static bool ByteArraysEqual(byte[] a, byte[] b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (a == null || b == null || a.Length != b.Length)
        {
            return false;
        }

        bool areSame = true;
        for (int i = 0; i < a.Length; i++)
        {
            areSame &= (a[i] == b[i]);
        }
        return areSame;
    }
}
