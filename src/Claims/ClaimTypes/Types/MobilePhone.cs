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

/// <summary>The URI for a claim that specifies the mobile phone number of an entity</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone</value>
public sealed class MobilePhone : Soap2005ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "mobile", "urn:oid:0.9.2342.19200300.100.1.41" };
    /// <summary>The singleton instance of the <see cref="MobilePhone" /> class.</summary>
    /// <returns>an instance of the <see cref="MobilePhone" /> class</returns>
    public static readonly IClaimType Instance = new MobilePhone();
    private MobilePhone() { }
    public const string _Name = "mobilephone";

    public override string Name => _Name;

    public override string[] Synonyms { get => base.Synonyms.Concat(_synonyms).ToArray(); init => base.Synonyms = value; }
}
