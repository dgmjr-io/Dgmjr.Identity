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

/// <summary>Definition: (l in RFC 2256) Locality component of a subject?s address information. According to RFC 2256: “This attribute contains the name of a locality, such as a city, county or other geographic region.” e.g. Redmond.</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality</value>
public sealed class Locality : Soap2005ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "l", "urn:oid:2.5.4.7" };

    /// <summary>The singleton instance of the <see cref="Locality" /> class.</summary>
    /// <returns>an instance of the <see cref="Locality" /> class</returns>
    public static readonly IClaimType Instance = new Locality();
    private Locality() { }
    /// <value>locality</value>
    public const string _Name = "locality";
    public new const string _Description = "Definition: (l in RFC 2256) Locality component of a subject?s address information. According to RFC 2256: “This attribute contains the name of a locality, such as a city, county or other geographic region.” e.g. Redmond";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{IsPersistent, bool}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = _LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{IsPersistent, bool}._ShortUriPrefix" /><inheritdoc cref="Soap2005ClaimBaseType{IsPersistent, bool}._ShortUriSeparator" /><inheritdoc cref="_Name" /></value>
    public new const string _ShortUriString = _LongUriString;

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;

    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
