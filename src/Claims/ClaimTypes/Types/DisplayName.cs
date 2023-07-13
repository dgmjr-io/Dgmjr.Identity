/* 
 * DisplayName.cs
 * 
 *   Created: 2023-07-06-11:28:40
 *   Modified: 2023-07-06-11:28:40
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;

namespace Dgmjr.Identity.Claims;

public class DisplayName : LdapClaimType<DisplayName, String>, IClaimTypeOrValue
{
    static readonly string[] _synonyms = new[] { "urn:oid:2.16.840.1.113730.3.1.241" };

    /// <value>displayName</value>
    public new const string _Name = "displayName";

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
