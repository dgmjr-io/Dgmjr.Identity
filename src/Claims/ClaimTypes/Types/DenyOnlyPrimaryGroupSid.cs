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

/// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid</value>
public sealed class DenyOnlyPrimaryGroupSid : MicrosoftSoap2008ClaimBaseType<DenyOnlyPrimaryGroupSid, string>
{
    /// <summary>The singleton instance of the <see cref="DenyOnlyPrimaryGroupSid" /> class.</summary>
    /// <returns>an instance of the <see cref="DenyOnlyPrimaryGroupSid" /> class</returns>
    public static readonly IClaimType Instance = new DenyOnlyPrimaryGroupSid();
    private DenyOnlyPrimaryGroupSid() { }
    /// <value>denyonlyprimarygroupsid</value>
    public const string _Name = "denyonlyprimarygroupsid";

    /// <value><inheritdoc cref="MicrosoftSoap2008ClaimBaseType{DenyOnlyPrimaryGroupSid, string}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public new const string _LongUriString = _LongUriPrefix + Constants.DefaultShortUriSeparator + _Name;
    /// <value><inheritdoc cref="MicrosoftSoap2008ClaimBaseType{DenyOnlyPrimaryGroupSid, string}._ShortUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public new const string _ShortUriString = _ShortUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;


    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }
}
