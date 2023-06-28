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
    /// <summary>The singleton instance of the <see cref="Role" /> class.</summary>
    /// <returns>an instance of the <see cref="Role" /> class</returns>
    public static readonly IClaimType Instance = new Role();
    private Role() { }
    public const string Name = "role";

    string IClaimTypeOrValue.Name => Name;
}
