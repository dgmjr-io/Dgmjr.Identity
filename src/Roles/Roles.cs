/*
 * Roles.cs
 *
 *   Created: 2023-03-19-05:02:09
 *   Modified: 2023-03-19-05:02:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Dgmjr.Identity.Roles;

using System;
using static Dgmjr.Identity.Role;
using DgmjrR = Dgmjr.Identity.Role;

/// <summary><inheritdoc cref="Names.Scheme" path="/summary" /></summary>
/// <value><inheritdoc cref="Names.Scheme" path="/value" /></value>
public sealed record class BaseUri : Role, IIdentityComponent
{
    public static IRole Instance = new BaseUri();
}

/// <summary>The URI for the <inheritdoc cref="Names.Admin" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Admin" path="/value" /></value>

public sealed record class Admin : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.Admin" path="/value" /></value>
    public new const string Name = Names.Admin;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Admin" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Admin}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private Admin() { }

    public static IRole Instance = new Admin();
}

/// <summary>The URI for the <inheritdoc cref="Names.Administrator" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Administrator" path="/value" /></value>

public sealed record class Administrator : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.Administrator" path="/value" /></value>
    public new const string Name = Names.Administrator;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Administrator" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Administrator}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private Administrator() { }

    public static IRole Instance = new Administrator();
}

/// <summary>The URI for the <inheritdoc cref="Names.GroupAdministrator" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>

public sealed record class GroupAdministrator : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
    public new const string Name = Names.GroupAdministrator;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
    public new const string UriString =
        $"{Names.Scheme}{DgmjrR.Namespace}/{Names.GroupAdministrator}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private GroupAdministrator() { }

    public static IRole Instance = new GroupAdministrator();
}

/// <summary>The URI for the <inheritdoc cref="Names.Owner" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Owner" path="/value" /></value>

public sealed record class Owner : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.Owner" path="/value" /></value>
    public new const string Name = Names.Owner;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Owner" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Owner}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private Owner() { }

    public static IRole Instance = new Owner();
}

/// <summary>The URI for the <inheritdoc cref="Names.User" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.User" path="/value" /></value>

public sealed record class User : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.User" path="/value" /></value>
    public new const string Name = Names.User;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.User" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.User}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private User() { }

    public static IRole Instance = new User();
}

/// <summary>The URI for the <inheritdoc cref="Names.GroupMember" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.GroupMember" path="/value" /></value>

public sealed record class GroupMember : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.GroupMember" path="/value" /></value>
    public new const string Name = Names.GroupMember;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.GroupMember" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.GroupMember}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private GroupMember() { }

    public static IRole Instance = new GroupMember();
}

/// <summary>The URI for the <inheritdoc cref="Names.Voter" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Voter" path="/value" /></value>

public sealed record class Voter : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.Voter" path="/value" /></value>
    public new const string Name = Names.Voter;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Voter" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Voter}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private Voter() { }

    public static IRole Instance = new Voter();
}

/// <summary>The URI for the <inheritdoc cref="Names.Contestant" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Contestant" path="/value" /></value>

public sealed record class Contestant : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.Contestant" path="/value" /></value>
    public new const string Name = Names.Contestant;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Contestant" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Contestant}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private Contestant() { }

    public static IRole Instance = new Contestant();
}

/// <summary>The URI for the <inheritdoc cref="Names.Anonymous" path="/value" /> role</summary>
/// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Anonymous" path="/value" /></value>

public sealed record class Anonymous : DgmjrR, IIdentityComponent
{
    /// <value><inheritdoc cref="Names.Anonymous" path="/value" /></value>
    public new const string Name = Names.Anonymous;

    /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Anonymous" path="/value" /></value>
    public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Anonymous}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IIdentityComponent.Uri => uri.From(UriString);

    private Anonymous() { }

    public static IRole Instance = new Anonymous();
}

public static class Names
{
    /// <summary>The URI scheme for roles</summary>
    /// <value>https://</value>
    public const string Scheme = "https://";

    /// <summary>The founder of the group (normally also the group's owner)</summary>
    /// <value>founder</value>
    public const string Founder = "founder";

    /// <summary>A group's moderator</summary>
    /// <value>moderator</value>
    public const string Moderator = "moderator";

    /// <summary>A group member with the power to silence other group members</summary>
    /// <value>muter</value>
    public const string Muter = "muter";

    /// <summary>A "free"d user, one on whom the bot's restrictions do not apply</summary>
    /// <value>free</value>
    public const string Free = "free";

    /// <summary>The name of the <inheritdoc cref="Admin" path="/value" /> role</summary>
    /// <value>administrator</value>
    public const string Admin = Administrator;

    /// <summary>The name of the <inheritdoc cref="Administrator" path="/value" /> role</summary>
    /// <value>administrator</value>
    public const string Administrator = "administrator";

    /// <summary>The name of the <inheritdoc cref="GroupAdministrator" path="/value" /> role</summary>
    /// <value>group_administrator</value>
    public const string GroupAdministrator = "group_administrator";

    /// <summary>The name of the <inheritdoc cref="Owner" path="/value" /> role</summary>
    /// <value>owner</value>
    public const string Owner = "owner";

    /// <summary>The name of the <inheritdoc cref="User" path="/value" /> role</summary>
    /// <value>user</value>
    public const string User = "user";

    /// <summary>The name of the <inheritdoc cref="GroupMember" path="/value" /> role</summary>
    /// <value>group_member</value>
    public const string GroupMember = "group_member";

    /// <summary>The name of the <inheritdoc cref="Voter" path="/value" /> role</summary>
    /// <value>voter</value>
    public const string Voter = "voter";

    /// <summary>The name of the <inheritdoc cref="Contestant" path="/value" /> role</summary>
    /// <value>contestant</value>
    public const string Contestant = "contestant";

    /// <summary>The name of the <inheritdoc cref="Anonymous" path="/value" /> role.  Members of this role may log in "anonymously" and access basic API features.</summary>
    /// <value><c>anonymous_user</c></value>
    public const string Anonymous = "anonymous";

    public static class Uris
    {
        /// <inheritdoc cref="Roles.Admin" />
        public static readonly uri Admin = uri.From(Roles.Admin.UriString);

        /// <inheritdoc cref="Roles.Administrator" />
        public static readonly uri Administrator = uri.From(Roles.Administrator.UriString);

        /// <inheritdoc cref="Roles.GroupAdministrator" />
        public static readonly uri GroupAdministrator = uri.From(
            Roles.GroupAdministrator.UriString
        );

        /// <inheritdoc cref="Roles.Owner" />
        public static readonly uri Owner = uri.From(Roles.Owner.UriString);

        /// <inheritdoc cref="Roles.User" />
        public static readonly uri User = uri.From(Roles.User.UriString);

        /// <inheritdoc cref="Roles.GroupMember" />
        public static readonly uri GroupMember = uri.From(Roles.GroupMember.UriString);

        /// <inheritdoc cref="Roles.Voter" />
        public static readonly uri Voter = uri.From(Roles.Voter.UriString);

        /// <inheritdoc cref="Roles.Contestant" />
        public static readonly uri Contestant = uri.From(Roles.Contestant.UriString);
    }
}
