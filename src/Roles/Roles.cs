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
namespace Dgmjr.Identity;

public partial class Role
{
    public virtual bool Equals(Role? other) => other?.Uri == Uri;
}

public static class Roles
{
    /// <summary>The base URI for roles</summary>
    /// <value>urn:identity:role</value>
    public const string BaseUri = "urn:identity:role";

    /// <summary>The URI for the <inheritdoc cref="Names.Admin" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Admin" path="/value" /></value>
    public const string Admin = $"{BaseUri}:{Names.Admin}";
    /// <summary>The URI for the <inheritdoc cref="Names.Administrator" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Administrator" path="/value" /></value>
    public const string Administrator = $"{BaseUri}:{Names.Administrator}";
    /// <summary>The URI for the <inheritdoc cref="Names.GroupAdministrator" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
    public const string GroupAdministrator = $"{BaseUri}:{Names.GroupAdministrator}";
    /// <summary>The URI for the <inheritdoc cref="Names.Owner" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Owner" path="/value" /></value>
    public const string Owner = $"{BaseUri}:{Names.Owner}";
    /// <summary>The URI for the <inheritdoc cref="Names.User" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.User" path="/value" /></value>
    public const string User = $"{BaseUri}:{Names.User}";
    /// <summary>The URI for the <inheritdoc cref="Names.GroupMember" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.GroupMember" path="/value" /></value>
    public const string GroupMember = $"{BaseUri}:{Names.GroupMember}";
    /// <summary>The URI for the <inheritdoc cref="Names.Voter" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Voter" path="/value" /></value>
    public const string Voter = $"{BaseUri}:{Names.Voter}";
    /// <summary>The URI for the <inheritdoc cref="Names.Contestant" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Contestant" path="/value" /></value>
    public const string Contestant = $"{BaseUri}:{Names.Contestant}";
    /// <summary>The URI for the <inheritdoc cref="Names.Anonymous" path="/value" /> role</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="Names.Anonymous" path="/value" /></value>
    public const string Anonymous = $"{BaseUri}:{Names.Anonymous}";

    public static class Names
    {
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
        /// <value>admin</value>
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
            /// <inheritdoc cref="DgmjrR.Admin" />
            public static readonly uri Admin = uri.From(DgmjrR.Admin.Uri);

            /// <inheritdoc cref="DgmjrR.Administrator" />
            public static readonly uri Administrator = uri.From(DgmjrR.Administrator.Uri);

            /// <inheritdoc cref="DgmjrR.GroupAdministrator" />
            public static readonly uri GroupAdministrator = uri.From(DgmjrR.GroupAdministrator.Uri);

            /// <inheritdoc cref="DgmjrR.Owner" />
            public static readonly uri Owner = uri.From(DgmjrR.Owner.Uri);

            /// <inheritdoc cref="DgmjrR.User" />
            public static readonly uri User = uri.From(DgmjrR.User.Uri);

            /// <inheritdoc cref="DgmjrR.GroupMember" />
            public static readonly uri GroupMember = uri.From(DgmjrR.GroupMember.Uri);

            /// <inheritdoc cref="DgmjrR.Voter" />
            public static readonly uri Voter = uri.From(DgmjrR.Voter.Uri);

            /// <inheritdoc cref="DgmjrR.Contestant" />
            public static readonly uri Contestant = uri.From(DgmjrR.Contestant.Uri);
        }
    }
}
