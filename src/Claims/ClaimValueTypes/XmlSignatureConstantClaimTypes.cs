#pragma warning disable
namespace Dgmjr.Identity.Claims.ClaimValueTypes;
using System;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;
using Dgmjr.Identity.Claims.Abstractions;
using Abstractions;
using SSCXRsa = System.Xml.Linq.XElement;

/// <summary>A URI pattern for representing a claim type in the  http://schemas.xmlsoap.org/ namespace</summary>
public abstract class XmlSignatureConstantClaimType<TSelf, TValue> : ClaimValueType<TSelf, TValue>
    where TSelf : XmlSignatureConstantClaimType<TSelf, TValue>
{
    /// <summary>The name of the claim value type <inheritdoc cref="_Name" path="/value" /></summary>
    /// <value>http://www.w3.org/2000/09/xmldsig</value>
    public new const string _LongUriPrefix = "http://www.w3.org/2000/09/xmldsig";
    /// <value>#</value>
    public new const string _LongUriSeparator = "#";
    /// <value>ds</value>
    public new const string _ShortUriPrefix = "ds";
    /// <value>:</value>
    public new const string _ShortUriSeparator = ":";
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" />={0}</value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}{_LongUriSeparator}={{0}}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" />={0}</value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}={{0}}";
    /// <value>name</value>
    public new const string _Name = "name";

    /// <inheritdoc cref="_LongUriPrefix" />
    public override string LongUriPrefix => _LongUriPrefix;
    /// <inheritdoc cref="_ShortUriPrefix" />
    public override string ShortUriPrefix => _ShortUriPrefix;
    /// <inheritdoc cref="_LongUriSeparator" />
    public override string LongUriSeparator => _LongUriSeparator;
    /// <inheritdoc cref="_ShortUriSeparator" />
    public override string ShortUriSeparator => _ShortUriSeparator;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => Format(_LongUriString, StringValue);
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => Format(_ShortUriString, StringValue);
}


public class DsaKeyValue : XmlSignatureConstantClaimType<DsaKeyValue, SSCXDsa>
{
    public static DsaKeyValue Instance => new DsaKeyValue();

    public DsaKeyValue() { }
    /// <summary>
    /// Represents the name of the DSAKeyValue.
    /// </summary>
    public new const string _Name = "DSAKeyValue";

    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string ShortUriString => Format(_ShortUriString, StringValue);
}


public class KeyInfo : XmlSignatureConstantClaimType<KeyInfo, SSCXKI>
{
    public static KeyInfo Instance => new KeyInfo();

    public KeyInfo() { }

    public new const string _Name = "KeyInfo";
    public new const string _LongUriString = XmlSignatureConstantClaimType<KeyInfo, SSCXKI>._LongUriString + "={0}";
    public new const string _ShortUriString = XmlSignatureConstantClaimType<KeyInfo, SSCXKI>._ShortUriString + "={0}";

    public override string LongUriString => global::System.String.Format(_LongUriString, StringValue);
    public override string ShortUriString => global::System.String.Format(_ShortUriString, StringValue);
}

public class RSAKeyValue : XmlSignatureConstantClaimType<RSAKeyValue, SSCXRsa>
{
    public static RSAKeyValue Instance => new RSAKeyValue();

    public RSAKeyValue() { }

    public new const string _Name = "RSAKeyValue";
    public new const string _LongUriString = XmlSignatureConstantClaimType<RSAKeyValue, SSCXRsa>._LongUriString + "={0}";
    public new const string _ShortUriString = XmlSignatureConstantClaimType<RSAKeyValue, SSCXRsa>._ShortUriString + "={0}";

    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string ShortUriString => Format(_ShortUriString, StringValue);


    // public override System.Security.Cryptography.Xml.RSAKeyValue Value { get; set; }
    public override string StringValue { get => Value.ToString(); set => Value = SSCXRsa.Parse(value); }
}

public class X509Certificate : XmlSignatureConstantClaimType<X509Certificate, SSCX509>
{
    public static X509Certificate Instance => new X509Certificate();

    public X509Certificate() { }

    public new const string _Name = "X509Certificate";
    public new const string _LongUriString = XmlSignatureConstantClaimType<X509Certificate, SSCX509>._LongUriString + "={0}";
    public new const string _ShortUriString = XmlSignatureConstantClaimType<X509Certificate, SSCX509>._ShortUriString + "={0}";

    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string ShortUriString => Format(_ShortUriString, StringValue);

    // public override string StringValue { get => Value.}
}
