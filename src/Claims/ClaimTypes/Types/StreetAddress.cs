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

/// <summary>Definition: (street in RFC 2256) Street address component of a subject?s address information. According to RFC 2256: “This attribute contains the physical address of the object to which the entry corresponds, such as an address for package delivery.” Its content is arbitrary, but typically given as a PO Box number or apartment/house number followed by a street name, e.g. 303 Mulberry St.</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress</value>
public sealed class StreetAddress : Soap2005ClaimBaseType<StreetAddress, string>
{
    static readonly string[] _synonyms = new string[] { Constants.ldap + Constants.DefaultShortUriSeparator + "streetAddressaa", "urn:oid:1.2.840.113556.1.2.256", "urn:oid:2.5.4.9" };

    /// <summary>The singleton instance of the <see cref="StreetAddress" /> class.</summary>
    /// <returns>an instance of the <see cref="StreetAddress" /> class</returns>
    public static readonly IClaimType Instance = new StreetAddress();
    private StreetAddress() { }
    /// <value>streetaddress</value>
    public const string _Name = "streetaddress";
    public new const string _Description = "Definition: (street in RFC 2256) Street address component of a subject?s address information. According to RFC 2256: “This attribute contains the physical address of the object to which the entry corresponds, such as an address for package delivery.” Its content is arbitrary, but typically given as a PO Box number or apartment/house number followed by a street name, e.g. 303 Mulberry St.";

    /// <inheritdoc cref="Name" path="/value" />
    public override string Name => _Name;

    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._LongUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._LongUriPrefix" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = Soap2005ClaimBaseType<StreetAddress, string>._LongUriPrefix + Soap2005ClaimBaseType<StreetAddress, string>._LongUriSeparator + _Name;

    /// <inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;.LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <value><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._ShortUriPrefix" path="/value" /><inheritdoc cref="Soap2005ClaimBaseType&lt;StreetAddress, string&gt;._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public override string ShortUriString => _ShortUriString;

    public override string[] Synonyms { get => base.Synonyms.Concat(_synonyms).ToArray(); init => base.Synonyms = value; }
}
