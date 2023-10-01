/*
 * Roles.cs
 *
 *   Created: 2022-12-16-04:49:57
 *   Modified: 2022-12-16-04:49:57
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Enums;

using System.ComponentModel.DataAnnotations;

[GenerateEnumerationClass("Role", "Dgmjr.Identity")]
public enum Role
{
    /// <summary>The base URI for roles</summary>
    [Uri("role:none")]
    BaseUri = 0,

    /// <summary>The <inheritdoc cref="Roles.Names.Admin" path="/value" /> role</summary>
    [Uri(Roles.Admin.UriString)]
    Admin = 1,

    /// <summary>The <inheritdoc cref="Roles.Names.Administrator" path="/value" /> role</summary>
    [Uri(Roles.Administrator.UriString)]
    Administrator = 2,

    /// <summary>The <inheritdoc cref="Roles.Names.GroupAdministrator" path="/value" /> role</summary>
    [Uri(Roles.GroupAdministrator.UriString)]
    GroupAdministrator = 3,

    /// <summary>The <inheritdoc cref="Roles.Names.Owner" path="/value" /> role</summary>
    [Uri(Roles.Owner.UriString)]
    Owner = 4,

    /// <summary>The <inheritdoc cref="Roles.Names.User" path="/value" /> role</summary>
    [Uri(Roles.User.UriString)]
    User = 5,

    /// <summary>The <inheritdoc cref="Roles.Names.GroupMember" path="/value" /> role</summary>
    [Uri(Roles.GroupMember.UriString)]
    GroupMember = 6,

    /// <summary>The <inheritdoc cref="Roles.Names.Voter" path="/value" /> role</summary>
    [Uri(Roles.Voter.UriString)]
    Voter = 7,

    /// <summary>The <inheritdoc cref="Roles.Names.Contestant" path="/value" /> role</summary>
    [Uri(Roles.Contestant.UriString)]
    Contestant = 8,

    /// <summary>The <inheritdoc cref="Roles.Names.Anonymous" path="/value" /> role</summary>
    [Uri(Roles.Anonymous.UriString)]
    AnonymousUser = 9
}
