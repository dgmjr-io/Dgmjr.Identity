/* 
 * Title.cs
 * 
 *   Created: 2023-07-06-11:01:53
 *   Modified: 2023-07-06-11:01:53
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Claims;

public class Organization : LdapClaimType, IClaimTypeOrValue
{
    static readonly string[] _synonyms = new[] { "urn:oid:2.5.4.10" };

    /// <value>o</value>
    public new const string _Name = "o";

    /// <value><inheritdoc cref="LdapClaimType.LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public new const string _LongUriString = LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <inheritdoc cref="LongUriString" />
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
