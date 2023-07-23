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

/// <summary>The URI for a claim that specifies an authorization decision on an entity</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision</value>
public sealed class AuthorizationDecision : Soap2005BaseClaimType<AuthorizationDecision, DgmjrCvt.String>
{
    /// <summary>The singleton instance of the <see cref="AuthorizationDecision" /> class.</summary>
    /// <returns>an instance of the <see cref="AuthorizationDecision" /> class</returns>
    public static readonly IClaimType Instance = new AuthorizationDecision();
    private AuthorizationDecision() { }
    /// <value>authorizationdecision</value>
    public const string _Name = "authorizationdecision";

    /// <value><inheritdoc cref="Soap2005BaseClaimType._LongUriPrefix" path="/value" /><inheritdoc cref="Soap2005BaseClaimType._LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="Soap2005BaseClaimType._ShortUriPrefix" path="/value" /><inheritdoc cref="Soap2005BaseClaimType._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
