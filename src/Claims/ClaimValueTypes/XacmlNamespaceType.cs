#pragma warning disable
using System.Linq.Expressions;
using Microsoft.VisualBasic;
using System.Net;
using System;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;
using Dgmjr.Identity.Claims.Abstractions;
using Dgmjr.Identity.Claims.ClaimValueTypes;

namespace Dgmjr.Identity.Claims.ClaimValueTypes;

using System.Numerics;
using Abstractions;

/// <summary>A URI pattern for representing a claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="ShortUriPrefix" path="/value" />) namespace</summary>
public abstract class XacmlNamespaceType<TSelf, TValue> : ClaimValueType<TSelf, TValue>
    where TSelf : XacmlNamespaceType<TSelf, TValue>
{
    /// <summary>The name of the claim value type <inheritdoc cref="Name" path="/value" /></summary>
    /// <value>xacml</value>
    public new const string _ShortUriPrefix = "xacml";
    /// <value>urn:oasis:names:tc:xacml</value>
    public new const string _LongUriPrefix = $"urn:oasis:names:tc:xacml";
    public new const string _Name = "";
    public new const string _LongUriSeparator = ":";
    public new const string _ShortUriSeparator = ":";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string LongUriPrefix => _LongUriPrefix;
    public override string ShortUriPrefix => _ShortUriPrefix;
    public override string Name => _Name;
    public override string LongUriSeparator => _LongUriSeparator;
    public override string ShortUriSeparator => _ShortUriSeparator;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}


/// <summary>A URI pattern for representing the <inheritdoc cref="Name" path="/value" /> claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="XacmlNamespaceType.ShortUriPrefix" path="/value" />) namespace</summary>
public class Rfc822Name : XacmlNamespaceType<Rfc822Name, SNMEml>, IClaimValueType<Rfc822Name, SNMEml>
{
    /// <inheritdoc />
    public static Rfc822Name Instance => new Rfc822Name();

    public Rfc822Name() { }

    /// <value><inheritdoc cref="XacmlNamespaceType{Rfc822Name, SNMEml}._LongUriPrefix" path="/value" />:1.0:data-type</value>
    public new const string _LongUriPrefix = $"{XacmlNamespaceType<Rfc822Name, SNMEml>._LongUriString}:1.0:data-type";
    /// <value>rfc822Name</value>
    public new const string _Name = "rfc822Name";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}{_ShortUriSeparator}{{0}}";
    public new const string _ShortUriString = $"X509:<RFC822>{{0}}";

    public override string LongUriPrefix => _LongUriPrefix;
    public override string ShortUriPrefix => _ShortUriPrefix;
    public override string Name => _Name;
    public override string LongUriSeparator => _LongUriSeparator;
    public override string ShortUriSeparator => _ShortUriSeparator;
    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string ShortUriString => Format(_ShortUriString, StringValue);
}
/// <summary>A URI pattern for representing the <inheritdoc cref="Name" path="/value" /> claim type in the <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="XacmlNamespaceType.ShortUriPrefix" path="/value" />) namespace</summary>
public class X500Name : SoapClaimType<X500Name, X500DN>
{
    public static X500Name Instance => new X500Name();

    public X500Name() { }

    public new const string _LongUriPrefix = $"{SoapClaimType<X500Name, X500DN>._LongUriPrefix}{SoapClaimType<X500Name, X500DN>._LongUriSeparator}claims";
    /// <summary>
    /// 
    /// </summary>
    /// <value>x500Name</value>
    public new const string _Name = "x500Name";

    /// <summary>The URI for the claim value type <inheritdoc cref="SoapClaimType{X500Name, X500DN]._LongUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="SoapClaimType{X500Name, X500DN}._LongUriPrefix" path="/value//node()" /><inheritdoc cref="SoapClaimType{X500Name, X500DN>._LongUriSeparator" path="//value" /><inheritdoc cref="_Name" path="//value" /></value>
    public new const string _LongUriString = $"{SoapClaimType<X500Name, X500DN>._LongUriPrefix}{SoapClaimType<X500Name, X500DN>._LongUriSeparator}{_Name}={{0}}";
    /// <summary>The URI for the claim value type <inheritdoc cref="SoapClaimType{X500Name, X500DN}.ShortUriString" path="/value" /></summary>
    /// <value><inheritdoc cref="SoapClaimType{X500Name, X500DN}._LongUriPrefix" path="//value" /><inheritdoc cref="SoapClaimType{X500Name, X500DN}_LongUriSeparator" path="//value" /><inheritdoc cref="_Name" path="//value" /></value>
    public new const string _ShortUriString = $"{SoapClaimType<X500Name, X500DN>._ShortUriPrefix}{SoapClaimType<X500Name, X500DN>._ShortUriSeparator}{_Name}={{0}}";
    public new const string _ShortUriPrefix = SoapClaimType<X500Name, X500DN>._ShortUriPrefix;
    public new const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;
    public new const string _LongUriSeparator = _ShortUriSeparator;


    public override string Name => _Name;
    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string ShortUriString => Format(_ShortUriString, StringValue);
}


public class IpAddress : XacmlNamespaceType<IpAddress, System.Net.IPAddress>, IClaimValueType<IpAddress, System.Net.IPAddress>
{
    public static IpAddress Instance => new IpAddress();

    public IpAddress() { }

    public new const string _LongUriPrefix = $"{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._LongUriPrefix}{_LongUriSeparator}2.0:data-type";
    public new const string _ShortUriPrefix = $"{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._ShortUriPrefix}";
    public new const string _Name = "ipAddress";
    public new const string _LongUriString = $"{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._LongUriPrefix}{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._LongUriSeparator}{_Name}{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._LongUriSeparator}{{0}}";
    public new const string _ShortUriString = $"{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._ShortUriPrefix}{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._ShortUriSeparator}{_Name}{XacmlNamespaceType<IpAddress, System.Net.IPAddress>._ShortUriSeparator}{{0}}";

    public override string Name => _Name;
    public override string ShortUriString => Format(_ShortUriString, StringValue);
    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string StringValue { get => Value.ToString(); set => Value = IPAddress.Parse(value); }
    public override IPAddress Value { get; set; }
}
