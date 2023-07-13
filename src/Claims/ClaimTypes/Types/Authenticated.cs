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

/// <summary>The URI for a claim that specifies details about whether an identity is authenticated</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated</value>
public sealed class Authenticated : Soap2005ClaimBaseType<Authenticated, bool>
{

    /// <summary>The singleton instance of the <see cref="Authenticated" /> class.</summary>
    /// <returns>an instance of the <see cref="Authenticated" /> class</returns>    
    public static readonly IClaimType Instance = new Authenticated();
    private Authenticated() { }
    /// <value>authenticated</value>ß
    public const string _Name = "authenticated";
    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;Authenticated, bool&gt;._LongUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;Authenticated, bool&gt;._LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;Authenticated, bool&gt;_ShortUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;Authenticated, bool&gt;_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
