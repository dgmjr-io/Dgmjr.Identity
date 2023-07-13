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

/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent</value>
public sealed class IsPersistent : MicrosoftSoap2008ClaimBaseType<IsPersistent, bool>, IClaimType
{
    /// <summary>The singleton instance of the <see cref="IsPersistent" /> class.</summary>
    /// <returns>an instance of the <see cref="IsPersistent" /> class</returns>
    public static readonly IClaimType Instance = new IsPersistent();
    private IsPersistent() { }
    /// <value>ispersistent</value>
    public const string _Name = "ispersistent";

    /// <value><inheritdoc cref="MicrosoftSoap2008ClaimBaseType{IsPersistent, bool}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = _LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <value><inheritdoc cref="MicrosoftSoap2008ClaimBaseType{IsPersistent, bool}._ShortUriPrefix" /><inheritdoc cref="MicrosoftSoap2008ClaimBaseType{IsPersistent, bool}._ShortUriSeparator" /><inheritdoc cref="_Name" /></value>
    public new const string _ShortUriString = _LongUriString;

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;

    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
