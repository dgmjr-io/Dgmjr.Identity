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

public static partial class Constants
{
    /// <value>https://</value>
    public const string Scheme = "https://";

    /// <value>dgmjr.io/roles</value>
    public const string Namespace = "dgmjr.io/roles";

    /// <value>role</value>
    public const string Name = "role";

    /// <value><inheritdoc cref="Scheme" path="/value" /><inheritdoc cref="Namespace" path="/value" /></value>
    public const string UriString = $"{Scheme}{Namespace}";
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

    /// <summary>The name of the <inheritdoc cref="Role" path="/value" /> role.</summary>
    /// <value><c>role</c></value>
    public const string Role = "role";
}
