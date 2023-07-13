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

/// <summary>The URI for a claim that specifies the role of an entity</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/role</value>
public sealed class Role : MicrosoftSoap2008ClaimBaseType, IClaimType
{
    static string[] _synonyms = new[] { $"{Constants.ldap}{Constants.DefaultShortUriSeparator}memberOf", Constants.Ldap + "memberOf", "urn:oid:1.2.840.113556.1.2.102" };

    /// <summary>The singleton instance of the <see cref="Role" /> class.</summary>
    /// <returns>an instance of the <see cref="Role" /> class</returns>
    public static readonly IClaimType Instance = new Role();
    private Role() { }
    public const string _Name = "role";

    public override string Name => _Name;

    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }
}
