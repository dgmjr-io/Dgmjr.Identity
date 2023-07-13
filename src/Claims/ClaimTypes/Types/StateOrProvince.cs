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

/// <summary>Definition: (st in RFC 2256) Abbreviation for state or province name of a subject?s address information. According to RFC 2256: “This attribute contains the full name of a state or province. The values should be coordinated on a national level and if well-known shortcuts exist – like the two-letter state abbreviations in the US – these abbreviations are preferred over longer full names.” e.g. WA.</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince</value>
public sealed class StateOrProvince : Soap2005ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { "urn:oid:2.5.4.7" };

    /// <summary>The singleton instance of the <see cref="StateOrProvince" /> class.</summary>
    /// <returns>an instance of the <see cref="StateOrProvince" /> class</returns>
    public static readonly IClaimType Instance = new StateOrProvince();
    private StateOrProvince() { }
    public const string _Name = "stateorprovince";
    public const string _Desctiption = "Definition: (st in RFC 2256) Abbreviation for state or province name of a subject?s address information. According to RFC 2256: “This attribute contains the full name of a state or province. The values should be coordinated on a national level and if well-known shortcuts exist – like the two-letter state abbreviations in the US – these abbreviations are preferred over longer full names.” e.g. WA.";

    public override string Name => _Name;
}
