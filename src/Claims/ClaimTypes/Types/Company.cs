/* 
 * Company.cs
 * 
 *   Created: 2023-07-06-10:48:44
 *   Modified: 2023-07-06-10:48:44
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Claims;

public class Company : LdapClaimType<Company, string>
{
    static readonly string[] _synonyms = new[] { "urn:oid:1.2.840.113556.1.2.146" };

    public static readonly IClaimType Instance = new Company();

    /// <value>company</value>
    public new const string _Name = "company";

    /// <value><inheritdoc cref="LdapClaimType.LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public new const string _LongUriString = LongUriPrefix + Constants.DefaultShortUriSeparator + Name;
    /// <value><inheritdoc cref="LdapClaimType._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public new const string _ShortUriString = _ShortUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <inheritdoc cref="Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="ShortUriString" />
    public override string ShortUriString => _ShortUriString;


    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }
}
