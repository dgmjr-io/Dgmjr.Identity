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

/// <summary>The URI for a claim that specifies a hash value</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash</value>
public sealed class Hash : Soap2005ClaimBaseType<Hash, string>, IClaimType
{
    /// <summary>The singleton instance of the <see cref="Hash" /> class.</summary>
    /// <returns>an instance of the <see cref="Hash" /> class</returns>
    public static readonly IClaimType Instance = new Hash();
    private Hash() { }
    /// <value>hash</value>
    public const string _Name = "hash";

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{Hash, string}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{Hash, string}._ShortUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = _LongUriString;

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
