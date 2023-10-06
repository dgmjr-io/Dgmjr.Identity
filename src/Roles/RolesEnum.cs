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

namespace Dgmjr.Identity.Roles.Enums;

using Dgmjr.Identity.Roles;
using System.ComponentModel.DataAnnotations;

[GenerateEnumerationRecordStruct("Role", "Dgmjr.Identity")]
public enum Role
{
    /// <summary>The base URI for roles</summary>
    [Uri($"{Constants.UriString}/{Names.Role}")]
    BaseUri = 0,

    /// <summary>The <inheritdoc cref="Admin" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.Admin" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.Admin}")]
    [Display(Name = Names.Admin)]
    Admin = 1,

    /// <summary>The <inheritdoc cref="Administrator" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.Administrator" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.Administrator}")]
    [Display(Name = Names.Administrator)]
    Administrator = 2,

    /// <summary>The <inheritdoc cref="GroupAdministrator" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.GroupAdministrator}")]
    GroupAdministrator = 3,

    /// <summary>The <inheritdoc cref="Owner" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.Owner" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.Owner}")]
    [Display(Name = Names.Owner)]
    Owner = 4,

    /// <summary>The <inheritdoc cref="User" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.User" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.User}")]
    [Display(Name = Names.User)]
    User = 5,

    /// <summary>The <inheritdoc cref="GroupMember" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.GroupMember" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.GroupMember}")]
    [Display(Name = Names.GroupMember)]
    GroupMember = 6,

    /// <summary>The <inheritdoc cref="Voter" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.Voter" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.Voter}")]
    [Display(Name = Names.Voter)]
    Voter = 7,

    /// <summary>The <inheritdoc cref="Contestant" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.Contestant" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.Contestant}")]
    [Display(Name = Names.Contestant)]
    Contestant = 8,

    /// <summary>The <inheritdoc cref="AnonymousUser" path="/value" /></summary>
    /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc cref="Names.Anonymous" path="/value" /></value>
    [Uri($"{Constants.UriString}/{Names.Anonymous}")]
    [Display(Name = Names.Anonymous)]
    AnonymousUser = 9
}
