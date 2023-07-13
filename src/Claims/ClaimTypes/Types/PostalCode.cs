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

/// <summary>Definition: (postalCode in X.500) Postal code or zip code component of a subject?s address information. According to X.500(2001): “The postal code attribute type specifies the postal code of the named object. If this attribute value is present, it will be part of the object's postal address – zip code in USA, postal code for other countries.”</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode</value>
public sealed class PostalCode : Soap2005ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "postalCode", "urn:oid:2.5.4.17" };

    /// <summary>The singleton instance of the <see cref="PostalCode" /> class.</summary>
    /// <returns>an instance of the <see cref="PostalCode" /> class</returns>
    public static readonly IClaimType Instance = new PostalCode();
    private PostalCode() { }
    public const string _Name = "postalcode";
    public const string _Description = "Definition: (postalCode in X.500) Postal code or zip code component of a subject?s address information. According to X.500(2001): “The postal code attribute type specifies the postal code of the named object. If this attribute value is present, it will be part of the object's postal address – zip code in USA, postal code for other countries.”";

    public override string Name => _Name;
}
