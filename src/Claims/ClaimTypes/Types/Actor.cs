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

/// <summary>The URI for a claim that specifies the actor</summary>
/// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor</value>
public sealed class Actor : Soap2009BaseClaimType, IClaimType<Actor>
{
    /// <summary>The singleton instance of the <see cref="Actor" /> class.</summary>
    /// <returns>an instance of the <see cref="Actor" /> class</returns>
    public static IClaimType Instance => new Actor();
    public Actor() { }
    public const string Name = "actor";

    string IClaimTypeOrValue.Name => Name;
}
