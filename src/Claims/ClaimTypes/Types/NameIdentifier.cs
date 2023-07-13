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

/// <summary>The URI for a claim that specifies the name of an entity</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier</value>
public sealed class NameIdentifier : Soap2005ClaimBaseType, IClaimType
{
    /// <summary>The singleton instance of the <see cref="Anonymous" /> class.</summary>
    /// <returns>an instance of the <see cref="Anonymous" /> class</returns>
    public static readonly IClaimType Instance = new NameIdentifier();
    private NameIdentifier() { }
    public const string _Name = "nameidentifier";

    public override string Name => _Name;
}