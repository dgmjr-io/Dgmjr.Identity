/* 
 * LdapClaimType.cs
 * 
 *   Created: 2023-07-06-10:49:26
 *   Modified: 2023-07-06-10:49:26
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Diagnostics.Contracts;

namespace Dgmjr.Identity.Claims;

public class LdapClaimType<TClaimType, TValue> : ClaimType<TClaimType, TValue>
{
    /// <inheritdoc cref="Constants.Ldap" />
    public new const string _LongUriPrefix = Constants.Ldap;
    /// <value>ldap</value>
    public new const string _ShortUriPrefix = Constants.ldap;

    /// <value>[placeholder]</value>
    public new const string _Name = "[placeholder]";

    /// <inheritdoc cref="_Name" />
    public abstract override string Name { get; set; }

    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = _LongUriPrefix + _Name;
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = ShortUriPrefix + Constants.DefaultShortUriSeparator + Name;
    public override string[] Synonyms { get => base.Synonyms; init => base.Synonyms = value; }
}
