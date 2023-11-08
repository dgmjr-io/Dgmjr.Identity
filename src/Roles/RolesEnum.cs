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

using Dgmjr.Identity.Roles;
using System.ComponentModel.DataAnnotations;

static class Foo {
  static readonly Dgmjr.Identity.Abstractions.IRole r =
      Dgmjr.Identity.Role.Admin.Instance;
}

[GenerateEnumerationRecordStruct(nameof(Role),
                                 $"{nameof(Dgmjr)}.{nameof(Dgmjr.Identity)}")]
public enum Role {
  /// <summary>The base URI for roles</summary>
  /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc
  /// cref="Names.Role" path="/value" /></value>
  /// [Uri($"{Constants.UriString}/{Names.Role}")]
  BaseUri = 0,

  /// <summary>The <inheritdoc cref="Admin" path="/value" /> role</summary>
  /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc
  /// cref="Names.Admin" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.Admin}")][Display(
      Name = Names.Admin, Description = "The administrator role")] Admin = 1,

  /// <summary>The <inheritdoc cref="Administrator" path="/value" />
  /// role</summary> <value><inheritdoc cref="Constants.UriString" path="/value"
  /// />/<inheritdoc cref="Names.Administrator" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.Administrator}")][Display(
      Name = Names.Administrator,
      Description = "The administrator role")] Administrator = 2,

  /// <summary>The <inheritdoc cref="GroupAdministrator" path="/value" />
  /// role</summary> <value><inheritdoc cref="Constants.UriString" path="/value"
  /// />/<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.GroupAdministrator}")][Display(
      Name = Names.GroupAdministrator,
      Description = "The group administrator role")] GroupAdministrator = 3,

  /// <summary>The <inheritdoc cref="Owner" path="/value" /> role</summary>
  /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc
  /// cref="Names.Owner" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.Owner}")][Display(
      Name = Names.Owner)] Owner = 4,

  /// <summary>The <inheritdoc cref="User" path="/value" /> role</summary>
  /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc
  /// cref="Names.User" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.User}")][Display(
      Name = Names.User, Description = "The user role")] User = 5,

  /// <summary>The <inheritdoc cref="GroupMember" path="/value" />
  /// role</summary> <value><inheritdoc cref="Constants.UriString" path="/value"
  /// />/<inheritdoc cref="Names.GroupMember" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.GroupMember}")][Display(
      Name = Names.GroupMember,
      Description = "The group member role")] GroupMember = 6,

  /// <summary>The <inheritdoc cref="Voter" path="/value" /> role</summary>
  /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc
  /// cref="Names.Voter" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.Voter}")][Display(
      Name = Names.Voter, Description = "The voter role")] Voter = 7,

  /// <summary>The <inheritdoc cref="Contestant" path="/value" /> role</summary>
  /// <value><inheritdoc cref="Constants.UriString" path="/value" />/<inheritdoc
  /// cref="Names.Contestant" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.Contestant}")][Display(
      Name = Names.Contestant,
      Description = "The contestant role")] Contestant = 8,

  /// <summary>The <inheritdoc cref="AnonymousUser" path="/value" />
  /// role</summary> <value><inheritdoc cref="Constants.UriString" path="/value"
  /// />/<inheritdoc cref="Names.Anonymous" path="/value" /></value>
  [Uri($"{Constants.UriString}/{Names.Anonymous}")][Display(
      Name = Names.Anonymous,
      Description = "The anonymous user role")] AnonymousUser = 9
}
