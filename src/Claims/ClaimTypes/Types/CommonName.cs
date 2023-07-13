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

/// <summary>The URI for a claim that specifies the "common name" of an entity, <inheritdoc cref="CommonName" path="/value" /></summary>
/// <value><inheritdoc cref="Constants.Soap" path="/value" />/<inheritdoc cref="Name" path="/value" /></value>
public sealed class CommonName : SoapClaimBaseType, IClaimType
{
    static string[] _synonyms = new[] { Constants.Ldap + "cn", Constants.ldap + Constants.DefaultShortUriSeparator + "cn", "urn:oid:2.5.4.3" };
    /// <summary>The singleton instance of the <see cref="CommonName" /> class.</summary>
    /// <returns>an instance of the <see cref="CommonName" /> class</returns>
    public static readonly IClaimType Instance = new CommonName();
    private CommonName() { }

    /// <value>commonname</value>
    public const string _Name = "commonname";

    public override string Name => _Name;

    public override string[] Synonyms { get => base.Synonyms.Concat(_synonyms).ToArray(); init => base.Synonyms = value; }
}
