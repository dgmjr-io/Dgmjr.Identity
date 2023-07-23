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

/// <summary>The URI for a claim that specifies the method with which an entity was authenticated</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod</value>
public sealed class AuthenticationMethod : MicrosoftSoap2008BaseClaimType, IClaimType
{
    /// <summary>The singleton instance of the <see cref="AnonyAuthenticationMethodmous" /> class.</summary>
    /// <returns>an instance of the <see cref="AuthenticationMethod" /> class</returns>
    public static readonly IClaimType Instance = new AuthenticationMethod();
    private AuthenticationMethod() { }
    /// <value>authenticatiomethod</value>
    public const string _Name = "authenticationmethod";

    /// <value><inheritdoc cref="MicrosoftSoap2008BaseClaimType._LongUriPrefix" path="/value" /><inheritdoc cref="MicrosoftSoap2008BaseClaimType._LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="MicrosoftSoap2008BaseClaimType._ShortUriPrefix" path="/value" /><inheritdoc cref="MicrosoftSoap2008BaseClaimType._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
