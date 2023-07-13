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

/// <summary>The URI for a claim that specifies the gender of an entity</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender</value>
public sealed class Gender : Soap2005ClaimBaseType, IClaimType, IClaimTypeWithValue<int>
{
    /// <summary>The singleton instance of the <see cref="Gender" /> class.</summary>
    /// <returns>an instance of the <see cref="Gender" /> class</returns>
    public static readonly IClaimType Instance = new Gender();
    public static IClaimTypeWithValue<int> Create(int value) => new Gender { Value = value };
    private Gender() { }
    public const string _Name = "gender";

    public override string Name => _Name;

    public int Value { get; set; }
}
