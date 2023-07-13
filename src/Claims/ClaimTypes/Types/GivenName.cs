/*
 * ClaimTypeUris.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity.Claims;

using System.Security;
using Dgmjr.Identity.Claims.Abstractions;

/// <summary>Definition: (givenName in RFC 2256) Preferred name or first name of a subject. According to RFC 2256: “This attribute is used to hold the part of a person's name which is not their surname nor middle name.”</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname</value>
public sealed class GivenName : Soap2005ClaimBaseType<GivenName, string>
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "givenName", "urn:oid:2.5.4.42" };

    /// <summary>The singleton instance of the <see cref="GivenName" /> class.</summary>
    /// <returns>an instance of the <see cref="GivenName" /> class</returns>
    public static readonly IClaimType Instance = new GivenName();
    public static IClaimTypeWithValue Create(string value) => new GivenName { Value = value };
    private GivenName() { }

    /// <value>givenname</value>
    public const string _Name = "givenname";

    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;GivenName, &gt;._LongUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;GivenName, &gt;._LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;GivenName, &gt;._ShortUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;GivenName, &gt;._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;

    public override string[] Synonyms => base.Synonyms.Concat(_synonyms).ToArray();
}
