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

/// <summary>The URI for a claim that specifies a user principal name (UPN)</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn</value>
public sealed class Upn : Soap2005ClaimBaseType<Upn, EmailAddress>
{
    readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "userPrincipalName", "urn:oid:0.9.2342.19200300.100.1.1", "urn:oid:1.2.840.113556.1.4.656", "sub", "urn:oasis:names:tc:SAML:2.0:nameid-format:unspecified", "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified", "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent", };

    /// <summary>The singleton instance of the <see cref="Upn" /> class.</summary>
    /// <returns>an instance of the <see cref="Upn" /> class</returns>
    public static readonly IClaimType Instance = new Upn();
    private Upn() { }
    /// <value>upn</value>
    public const string _Name = "upn";

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{Upn, EmailAddress}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <value><inheritdoc cref="Soap2005ClaimBaseType{Upn, EmailAddress}._ShortUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = _ShortUriPrefix + Constants.DefaultShortUriSeparator + _Name;

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
