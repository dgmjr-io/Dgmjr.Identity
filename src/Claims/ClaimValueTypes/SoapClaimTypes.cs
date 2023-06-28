#pragma warning disable
using System;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;

namespace Dgmjr.Identity.ClaimValueTypes;
using Abstractions;

/// <summary>A URI pattern for representing a claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="ShortUriPrefix" path="/value" />) namespace</summary>
public abstract class SoapClaimType : ClaimValueType, IClaimTypeOrValue
{
    /// <summary>The the name for the claim type namespace for claim value types in "<inheritdoc cref="ShortUriPrefix" path="/value" />'</summary>
    /// <value>ws</value>
    public new const string ShortUriPrefix = "ws";
    /// <summary>The the name for the claim type namespace for claim value types in "<inheritdoc cref="LongUriPrefix" path="/value" />"</summary>
    /// <value>http://schemas.xmlsoap.org</value>
    public new const string LongUriPrefix = $"http://schemas.xmlsoap.org";
    public new const string Name = "";
    public new const string LongUriSeparator = "/";
    public new const string ShortUriSeparator = ":";

    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => $"{LongUriPrefix}{LongUriSeparator}{Name}";
    string IClaimTypeOrValue.ShortUriString => $"{ShortUriPrefix}{ShortUriSeparator}{Name}".Replace(LongUriSeparator, ShortUriSeparator);
}


/// <summary>
/// The name of the claim value type <inheritdoc cref="LongUriString" path="/value" />
/// </summary>
public class DnsName : SoapClaimType, IClaimValueType<DnsName>
{
    public static IClaimValueType Instance => new DnsName();

    public DnsName() { }

    public new const string LongUriPrefix = $"{SoapClaimType.LongUriPrefix}{LongUriSeparator}claims";
    /// <summary>
    /// 
    /// </summary>
    /// <value>dns</value>
    public new const string Name = "dns";

    /// <summary>The URI for the claim value type <inheritdoc cref="LongUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="DnsName.LongUriPrefix" path="/value//node()" /><inheritdoc cref="SoapClaimType.LongUriSeparator" path="//value" /><inheritdoc cref="Name" path="//value" /></value>
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    /// <summary>The URI for the claim value type <inheritdoc cref="ShortUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="DnsName.LongUriPrefix" path="//value" /><inheritdoc cref="SoapClaimType.LongUriSeparator" path="//value" /><inheritdoc cref="Name" path="//value" /></value>
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";


    string IClaimTypeOrValue.Name => Name;
    type IClaimValueType.UnderlyingType => typeof(System.String);
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;

}


public class EmailAddresss : SoapClaimType, IClaimValueType
{
    public static IClaimValueType Instance => new EmailAddresss();

    public EmailAddresss() { }

    public new const string LongUriPrefix = $"{SoapClaimType.LongUriPrefix}{LongUriSeparator}ws/2005/05/identity/claims";
    public new const string Name = "emailaddress";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    type IClaimValueType.UnderlyingType => typeof(EmailAddresss);
}


public class Rsa : SoapClaimType, IClaimValueType<Rsa, System.Security.Cryptography.RSA>, IClaimValueType
{
    public static IClaimValueType Instance => new Rsa();

    public Rsa() { }

    public new const string LongUriPrefix = $"{SoapClaimType.LongUriPrefix}{LongUriSeparator}ws/2005/05/identity/claims";
    public new const string Name = "rsa";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Security.Cryptography.RSA);
}

public class UpnName : SoapClaimType, IClaimValueType<UpnName>, IClaimValueType
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new UpnName();

    public UpnName() { }

    public new const string LongUriPrefix = $"{SoapClaimType.LongUriPrefix}{LongUriSeparator}claims";
    public new const string Name = "rsa";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    type IClaimValueType.UnderlyingType => typeof(EmailAddresss);
}
