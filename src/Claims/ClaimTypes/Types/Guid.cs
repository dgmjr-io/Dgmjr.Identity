/* 
 * Guid.cs
 * 
 *   Created: 2023-07-06-11:23:38
 *   Modified: 2023-07-06-11:23:38
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Claims;

public class Guid : LdapClaimType<Guid, System.Guid>
{
    static readonly string[] _synonyms = new[] { "urn:oid:1.2.840.113556.1.4.2", "urn:oid:0.9.2342.19200300.100.1.1" };

    /// <value>objectGUID</value>
    public new const string _Name = "objectGUID";

    /// <value><inheritdoc cref="LdapClaimType{Guid, System.Guid}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = LongUriPrefix + Constants.DefaultShortUriSeparator + Name;

    /// <inheritdoc cref="_LongUriString" />
    public new const string _ShortUriString = _LongUriString;

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
