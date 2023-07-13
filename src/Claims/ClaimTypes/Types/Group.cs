using Microsoft.VisualBasic;
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

/// <summary>The URI for a claim that specifies the groups to which an entity belongs</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/group</value>
public sealed class Group : MicrosoftSoap2008ClaimBaseType, IClaimType
{
    static readonly string[] _synonyms = new[] { Constants.ldap + Constants.DefaultShortUriSeparator + "memberOf", Constants.Ldap + "memberOf", "urn:oid:1.2.840.113556.1.2.102" };

    /// <summary>The singleton instance of the <see cref="GroupSid" /> class.</summary>
    /// <returns>an instance of the <see cref="GroupSid" /> class</returns>
    public static readonly IClaimType Instance = new Group();
    private Group() { }
    public new const string _LongUriPrefix = MicrosoftSoap2008ClaimBaseType.LongUriPrefix + "/claims";
    public const string _Name = "group";

    public override string Name => _Name;

    public override string[] Synonyms
    {
        get => base.Synonyms.Concat(_synonyms).ToArray();
        init => base.Synonyms = value;
    }
}
