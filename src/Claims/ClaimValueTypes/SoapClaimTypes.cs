#pragma warning disable
using System.Linq.Expressions;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;
using Dgmjr.Identity.Claims.Abstractions;

namespace Dgmjr.Identity.Claims.ClaimValueTypes;

using System.Reflection.Emit;
using Abstractions;

/// <summary>A URI pattern for representing a claim type in the <inheritdoc cref="_LongUriPrefix" path="/value/node()" /> (<inheritdoc cref="ShortUriPrefix" path="/value/node()" />) namespace</summary>
public abstract class SoapClaimType<TSelf, TValue> : ClaimValueType<TSelf, TValue>, IClaimTypeOrValue
    where TSelf : SoapClaimType<TSelf, TValue>
{
    /// <summary>The the name for the claim type namespace for claim value types in the "<inheritdoc cref="_ShortUriPrefix" path="/value" />" namespace</summary>
    /// <value>ws</value>
    public new const string _ShortUriPrefix = "ws";
    /// <summary>The the name for the claim type namespace for claim value types in the namespace "<inheritdoc cref="_LongUriPrefix" path="/value//node()" />"</summary>
    /// <value>http://schemas.xmlsoap.org</value>
    public new const string _LongUriPrefix = $"http://schemas.xmlsoap.org";
    /// <inheritdoc cref="Constants.@default" select="/value" />
    public new const string _Name = Constants.@default;
    /// <inheritdoc cref="Constants.DefaultLongUriSeparator" />
    public new const string _LongUriSeparator = Constants.DefaultLongUriSeparator;
    /// <inheritdoc cref="Constants.DefaultShortUriSeparator" />
    public new const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;

    /// <inheritdoc cref="_LongUriPrefix" path="//node()" />
    public override string LongUriPrefix => _LongUriPrefix;
    /// <inheritdoc cref="_ShortUriPrefix" path="//node()" />
    public override string ShortUriPrefix => _ShortUriPrefix;
    /// <inheritdoc cref="_Name" path="//node()" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriSeparator" path="//node()" />
    public override string LongUriSeparator => _LongUriSeparator;
    /// <inheritdoc cref="_ShortUriSeparator" path="//node()" />
    public override string ShortUriSeparator => _ShortUriSeparator;
    /// <inheritdoc cref="_LongUriPrefix" path="//value" /><inheritdoc cref="_LongUriSeparator" path="//value" /><inheritdoc cref="_Name" path="/value" />
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <inheritdoc cref="_LongUriString" path="//node()" />
    public override string LongUriString => $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="//value" /><inheritdoc cref="_Name" path="/value" />
    public override string ShortUriString => $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}".Replace(LongUriSeparator, ShortUriSeparator);
}


/// <summary>
/// The name of the claim value type <inheritdoc cref="LongUriString" path="/value" />
/// </summary>
public class DnsName : SoapClaimType<DnsName, string>
{
    public static DnsName Instance => new DnsName();

    public DnsName() { }

    public new const string _LongUriPrefix = $"{SoapClaimType<DnsName, string>._LongUriPrefix}{SoapClaimType<DnsName, string>._LongUriSeparator}claims";
    /// <summary>
    /// 
    /// </summary>
    /// <value>dns</value>
    public new const string _Name = "dns";

    /// <summary>The URI for the claim value type <inheritdoc cref="DnsName._LongUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="DnsName._LongUriPrefix" path="/value//node()" /><inheritdoc cref="SoapClaimType{DnsName, string}.LongUriSeparator" path="//value" /><inheritdoc cref="Name" path="//value" /></value>
    public new const string _LongUriString = $"{SoapClaimType<DnsName, string>._LongUriPrefix}{SoapClaimType<DnsName, string>._LongUriSeparator}{_Name}";
    /// <summary>The URI for the claim value type <inheritdoc cref="SoapClaimType{DnsName, string}.ShortUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="SoapClaimType{DnsName, string}.LongUriPrefix" path="//value" /><inheritdoc cref="SoapClaimType{DnsName, string}.LongUriSeparator" path="//value" /><inheritdoc cref="Name" path="//value" /></value>
    public new const string _ShortUriString = $"{SoapClaimType<DnsName, string>._ShortUriPrefix}{SoapClaimType<DnsName, string>._LongUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}


public class EmailAddresss : SoapClaimType<EmailAddresss, SNMEml>
{
    public static EmailAddresss Instance => new EmailAddresss();

    public EmailAddresss() { }

    /// <summary>
    /// 
    /// </summary>
    /// <value>emailaddress</value>
    public new const string _Name = "emailaddress";

    public new const string _LongUriPrefix = SoapClaimType<EmailAddresss, SNMEml>._LongUriPrefix;
    public new const string _ShortUriPrefix = SoapClaimType<EmailAddresss, SNMEml>._ShortUriPrefix;
    public new const string _LongUriSeparator = Constants.DefaultLongUriSeparator;
    public new const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;

    /// <summary>The URI for the claim value type <inheritdoc cref="SoapClaimType{EmailAddresss, SNMEml}._LongUriString" path="/value/node()" /></summary>
    /// <value><inheritdoc cref="SoapClaimType{EmailAddresss, SNMEml}._LongUriPrefix" path="/value//node()" /><inheritdoc cref="SoapClaimType.LongUriSeparator" path="//value" /><inheritdoc cref="Name" path="//value" /></value>
    public new const string _LongUriString = $"{SoapClaimType<EmailAddresss, SNMEml>._LongUriPrefix}{SoapClaimType<EmailAddresss, SNMEml>._LongUriSeparator}{_Name}";
    /// <summary>The URI for the claim value type <inheritdoc cref="_ShortUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="SoapClaimType{EmailAddresss, SNMEml}.LongUriPrefix" path="//value" /><inheritdoc cref="SoapClaimType.LongUriSeparator" path="//value" /><inheritdoc cref="Name" path="//value" /></value>
    public new const string _ShortUriString = $"{SoapClaimType<EmailAddresss, SNMEml>._ShortUriPrefix}{EmailAddresss._LongUriSeparator}{_Name}";

    public override string Name => _Name;
    /// <summary><inheritdoc cref="_ShortUriString" path="//summary//node()" /></summary>
    public override string ShortUriString => _ShortUriString;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
}

public class Rsa : SoapClaimType<Rsa, SSCRsa>, IClaimValueType<Rsa, SSCRsa>, IClaimValueType
{
    public static Rsa Instance => new Rsa();

    public Rsa() { }

    public new const string _LongUriPrefix = $"{SoapClaimType<Rsa, SSCRsa>._LongUriPrefix}{SoapClaimType<Rsa, SSCRsa>._LongUriSeparator}ws/2005/05/identity/claims";
    public new const string _Name = "rsa";
    public new const string _LongUriString = $"{SoapClaimType<Rsa, SSCRsa>._LongUriPrefix}{SoapClaimType<Rsa, SSCRsa>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{SoapClaimType<Rsa, SSCRsa>._ShortUriPrefix}{SoapClaimType<Rsa, SSCRsa>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string ShortUriString => _ShortUriString;
    public override string LongUriString => _LongUriString;
}

public class UpnName : SoapClaimType<UpnName, SNMEml>
{
    public static UpnName Instance => new UpnName();

    public UpnName() { }

    public new const string _LongUriPrefix = $"{SoapClaimType<UpnName, SNMEml>._LongUriPrefix}{SoapClaimType<UpnName, SNMEml>._LongUriSeparator}{_Name}";
    public new const string _Name = "upn";
    public new const string _LongUriString = $"{_LongUriPrefix}={{0}}";
    public new const string _ShortUriString = $"X509:<UPN>{{0}}";

    public override string Name => _Name;
    public override string ShortUriString => string.Format(_ShortUriString, StringValue);
    public override string LongUriString => string.Format(_LongUriString, StringValue);
}
