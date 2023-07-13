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

/// <summary>The URI for a claim that specifies the webpage of an entity</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage</value>
public sealed class Webpage : Soap2005ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { $"{Constants.ldap}{Constants.DefaultShortUriSeparator}wWWHomePage" };

    /// <summary>The singleton instance of the <see cref="Webpage" /> class.</summary>
    /// <returns>an instance of the <see cref="Webpage" /> class</returns>
    public static readonly IClaimType Instance = new Webpage();
    private Webpage() { }
    /// <value>webpage</value>
    public new const string _Name = "webpage";

    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
}
