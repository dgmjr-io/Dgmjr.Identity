#pragma warning disable
using System;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;

namespace Dgmjr.Identity.ClaimValueTypes;
using Abstractions;

/// <summary>A URI pattern for representing a claim type in the  http://schemas.xmlsoap.org/ namespace</summary>
public abstract class XmlSignatureConstantClaimType : ClaimValueType, IClaimValueType
{
    /// <summary>The name of the claim value type <inheritdoc cref="Name" path="/value" /></summary>
    /// <value>ds</value>
    public new const string ShortUriPrefix = "ds";
    public new const string LongUriPrefix = $"http://www.w3.org/2000/09/xmldsig";
    public new const string Name = "";
    public new const string LongUriSeparator = "#";
    public new const string ShortUriSeparator = ":";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
}


public class DsaKeyValue : XmlSignatureConstantClaimType, IClaimValueType, IClaimTypeOrValue
{
    public static IClaimValueType Instance => new DsaKeyValue();

    public DsaKeyValue() { }

    public new const string Name = "DSAKeyValue";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Security.Cryptography.Xml.DSAKeyValue);
}


public class KeyInfo : XmlSignatureConstantClaimType, IClaimValueType
{
    public static IClaimValueType Instance => new KeyInfo();

    public KeyInfo() { }

    public new const string Name = "KeyInfo";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Security.Cryptography.Xml.KeyInfo);
}


public class RSAKeyValue : XmlSignatureConstantClaimType, IClaimValueType, IClaimTypeOrValue
{
    public static IClaimValueType Instance => new RSAKeyValue();

    public RSAKeyValue() { }

    public new const string Name = "RSAKeyValue";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Security.Cryptography.Xml.RSAKeyValue);
}

public class X509Certificate : XmlSignatureConstantClaimType, IClaimValueType<X509Certificate, System.Security.Cryptography.X509Certificates.X509Certificate>, IClaimValueType
{
    public static IClaimValueType Instance => new X509Certificate();

    public X509Certificate() { }

    public new const string Name = "RSAKeyValue";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Security.Cryptography.X509Certificates.X509Certificate);
}
