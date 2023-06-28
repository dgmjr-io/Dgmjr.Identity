#pragma warning disable
using System.Net;
using System;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;

namespace Dgmjr.Identity.ClaimValueTypes;
using Abstractions;

/// <summary>A URI pattern for representing a claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="ShortUriPrefix" path="/value" />) namespace</summary>
public abstract class XacmlNamespaceType<TValue> : ClaimValueType<TValue>, IClaimValueType
{
    /// <summary>The name of the claim value type <inheritdoc cref="Name" path="/value" /></summary>
    /// <value>xacml</value>
    public new const string ShortUriPrefix = "xacml";
    /// <value>urn:oasis:names:tc:xacml</value>
    public new const string LongUriPrefix = $"urn:oasis:names:tc:xacml";
    public new const string Name = "";
    public new const string LongUriSeparator = ":";
    public new const string ShortUriSeparator = ":";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    type IClaimValueType.UnderlyingType => typeof(void);
    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
}


/// <summary>A URI pattern for representing the <inheritdoc cref="Name" path="/value" /> claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="XacmlNamespaceType.ShortUriPrefix" path="/value" />) namespace</summary>
public class Rfc822Name : XacmlNamespaceType<EmailAddress>, IClaimValueType<Rfc822Name, EmailAddress>
{
    /// <inheritdoc />
    public static IClaimValueType Instance => new Rfc822Name();

    public Rfc822Name() { }

    /// <value><inheritdoc cref="XacmlNamespaceType.LongUriPrefix" path="/value" />:1.0:data-type</value>
    public new const string LongUriPrefix = $"{XacmlNamespaceType.LongUriPrefix}:1.0:data-type";
    /// <value>rfc822Name</value>
    public new const string Name = "rfc822Name";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    type IClaimValueType.UnderlyingType => typeof(EmailAddresss);
    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
}
/// <summary>A URI pattern for representing the <inheritdoc cref="Name" path="/value" /> claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="XacmlNamespaceType.ShortUriPrefix" path="/value" />) namespace</summary>
public class X500Name : XacmlNamespaceType, IClaimValueType
{
    public static IClaimValueType Instance => new X500Name();

    public X500Name() { }

    /// <value><inheritdoc cref="XacmlNamespaceType.LongUriPrefix" path="/value" />:1.0:data-type</value>
    public new const string LongUriPrefix = $"{XacmlNamespaceType.LongUriPrefix}:1.0:data-type";
    /// <value>x500Name</value>
    public new const string Name = "x500Name";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";


    string IClaimTypeOrValue.Name => Name;
    type IClaimValueType.UnderlyingType => typeof(System.Security.Cryptography.X509Certificates.X500DistinguishedName);
    string IClaimTypeOrValue.LongUriString => $"{LongUriPrefix}{LongUriSeparator}{Name}";
    string IClaimTypeOrValue.ShortUriString => $"{ShortUriPrefix}{ShortUriSeparator}{Name}";
}


public class IpAddress : XacmlNamespaceType, IClaimValueType<IpAddress, System.Net.IPAddress>
{
    public static IClaimValueType Instance => new IpAddress();

    public IpAddress() { }

    public new const string Name = "2.0:data-type:ipAddress";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.LongUriString => LongUriString;

    type IClaimValueType.UnderlyingType => typeof(System.Net.IPAddress);
}
