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

/// <summary>Definition: (c in RFC 2256) Country of a subject. According to RFC 2256: “This attribute contains a two-letter ISO 3166 country code.”</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country</value>
public sealed class Country : Soap2005ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "country", };
    /// <summary>The singleton instance of the <see cref="Country" /> class.</summary>
    /// <returns>an instance of the <see cref="Country" /> class</returns>
    public static readonly IClaimType Instance = new Country();
    private Country() { }
    public const string _Name = "country";
    public const string _Descriptiom = "Definition: (c in RFC 2256) Country of a subject. According to RFC 2256: “This attribute contains a two-letter ISO 3166 country code.”";

    public override string Name => _Name;

    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }
}
