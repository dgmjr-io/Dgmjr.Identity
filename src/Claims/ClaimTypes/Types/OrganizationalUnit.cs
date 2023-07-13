/* 
 * OrganizationalUnit.cs
 * 
 *   Created: 2023-07-08-12:18:13
 *   Modified: 2023-07-08-12:18:13
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Claims;

public class OrganizationalUnit : LdapClaimType<OrganizationalUnit, string>
{
    static readonly string[] _synonyms = new[] { "urn:oid:2.5.4.11" };

    /// <value>o</value>
    public new const string _Name = "o";

    /// <value><inheritdoc cref="LdapClaimType{OrganizationalUnit, string}._LongUriPrefix" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <value><inheritdoc cref="LdapClaimType{OrganizationalUnit, string}._ShortUriPrefix" path="/value" /><inheritdoc cref="LdapClaimType{OrganizationalUnit, string}._ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = LongUriString;

    /// <inheritdoc cref="Name" />
    public override string Name => _Name;

    /// <inheritdoc cref="LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="LongUriString" />
    public override string ShortUriString => _ShortUriString;


    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }
}
