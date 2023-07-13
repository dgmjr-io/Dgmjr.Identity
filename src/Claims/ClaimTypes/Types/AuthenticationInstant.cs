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

using System;
using Dgmjr.Identity.Claims.Abstractions;

/// <summary>The URI for a claim that specifies the instant at which an entity was authenticated</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant</value>
public sealed class AuthenticationInstant : MicrosoftSoap2008ClaimBaseType<AuthenticationInstant, DateTimeOffset>
{
    /// <summary>The singleton instance of the <see cref="AuthenticationInstant" /> class.</summary>
    /// <returns>an instance of the <see cref="AuthenticationInstant" /> class</returns>
    public static readonly IClaimType Instance = new AuthenticationInstant { Value = DateTimeOffset.UtcNow };
    private AuthenticationInstant() { }

    /// <value>authenticationinstant</value>
    public const string _Name = "authenticationinstant";
    /// <value><inheritdoc cref="MicrosoftSoap2008ClaimBaseType&gt;AuthenticationInstant, DateTimeOffset&lt;._LongUriPrefix" path="/value" /><inheritdoc cref="MicrosoftSoap2008ClaimBaseType&gt;AuthenticationInstant, DateTimeOffset&lt;._LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="MicrosoftSoap2008ClaimBaseType&gt;AuthenticationInstant, DateTimeOffset&lt;._ShortUriPrefix" path="/value" /><inheritdoc cref="MicrosoftSoap2008ClaimBaseType&gt;AuthenticationInstant, DateTimeOffset&lt;._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
