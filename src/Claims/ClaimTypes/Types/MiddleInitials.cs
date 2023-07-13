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

public class MiddleInitials : LdapClaimType<MiddleInitials, char>
{
    static readonly string[] _synonyms = new[] { "urn:oid:2.5.4.43" };

    /// <value>middleName</value>
    public new const string _Name = "middleName";

    /// <value><inheritdoc cref="LdapClaimType{MiddleInitials, char}._LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public new const string _LongUriString = _LongUriPrefix + Constants.DefaultLongUriSeparator + _Name;

    /// <value><inheritdoc cref="LdapClaimType{MiddleInitials, char}._ShortUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
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
