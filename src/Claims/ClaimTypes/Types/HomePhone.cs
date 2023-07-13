extern alias primitives;
using System.Security.AccessControl;
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

using primitives::System.Domain;
using Dgmjr.Identity.Claims.Abstractions;
using PhoneNumber = primitives::System.Domain.PhoneNumber;

/// <summary>The URI for a claim that specifies the home phone number of an entity</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone</value>
public sealed class HomePhone : Soap2005ClaimBaseType<HomePhone, PhoneNumber>
{
    /// <summary>The singleton instance of the <see cref="HomePhone" /> class.</summary>
    /// <returns>an instance of the <see cref="HomePhone" /> class</returns>
    public static readonly IClaimType Instance = new HomePhone();
    public static IClaimTypeWithValue<PhoneNumber> Create(PhoneNumber value) => new HomePhone { Value = value };
    private HomePhone() { }
    /// <value>homephone</value>
    public const string _Name = "homephone";

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{IsPersistent, bool}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
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
