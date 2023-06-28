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

/// <summary>The URI for a claim that specifies a hash value</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash</value>
public sealed class Hash : Soap2005ClaimBaseType, IClaimType
{
    /// <summary>The singleton instance of the <see cref="Hash" /> class.</summary>
    /// <returns>an instance of the <see cref="Hash" /> class</returns>
    public static readonly IClaimType Instance = new Hash();
    private Hash() { }
    public const string Name = "hash";

    string IClaimTypeOrValue.Name => Name;
}
