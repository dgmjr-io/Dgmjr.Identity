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
using Dgmjr.Identity.Claims.Abstractions;

/// <summary>Definition: (sn in RFC 2256) Surname or family name of a subject. According to RFC 2256: “This is the X.500 surname attribute which contains the family name of a person.”</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname</value>
public sealed class Surname : Soap2005ClaimBaseType<Surname, string>
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "sn", Constants.Ldap + "sn", "urn:oid:2.5.4.4" };

    /// <summary>The singleton instance of the <see cref="Surname" /> class.</summary>
    /// <returns>an instance of the <see cref="Surname" /> class</returns>
    public static readonly IClaimType Instance = new Surname();
    private Surname() { }
    /// <value>surname</value>
    public const string _Name = "surname";
    public const string _Description = "Definition: (sn in RFC 2256) (sn in [RFC 2256]) Surname or family name of a Subject. According to RFC 2256: This is the X.500 surname attribute which contains the family name of a person.";

    /// <inheritdoc cref="_Description" />
    public override string Description => _Description;

    /// <inheritdoc cref="Name" path="/value" />
    public override string Name => _Name;

    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._LongUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._LongUriPrefix" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = Soap2005ClaimBaseType<StreetAddress, string>._LongUriPrefix + Soap2005ClaimBaseType<StreetAddress, string>._LongUriSeparator + _Name;

    /// <inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;.LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._ShortUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public override string ShortUriString => _ShortUriString;

    public override string[] Synonyms { get => base.Synonyms.Concat(_synonyms).ToArray(); init => base.Synonyms = value; }
}
