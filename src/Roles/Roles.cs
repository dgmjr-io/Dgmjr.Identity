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
using Dgmjr.Identity;
using Dgmjr.Identity.Claims.Abstractions;


public interface IRole : IClaimTypeOrValue
{
}

public abstract class Role : ClaimValueOrTypeBase, IRole, IClaimTypeOrValue
{
    /// <summary>The base URI for roles</summary>
    /// <value>https://dgmjr.io/identity/role</value>
    public new const string LongUriPrefix = Constants.DefaultLongUriPrefix + "/" + Constants.identity + "/" + Constants.role;
    /// <summary>The shorter base URI for roles</summary>
    /// <value>dgmjr:identity:role</value>
    public new const string ShortUriPrefix = $"dgmjr:identity:role";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";
    public new const string Name = "[placeholder]";
    public new const string Description = $"A role for {Name}s.";
    public new const string ShortUriSeparator = ":";
    public new const string LongUriSeparator = "/";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
    string IClaimTypeOrValue.Description => Description;
}


/// <summary>The URI for the <inheritdoc cref="Names.Admin" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.Admin" path="/value" /></value>
public class Admin : Role, IClaimTypeOrValue
{
    public new const string Name = "Admin";
    public new const string LongUriString = $"{Role.LongUriPrefix}{Role.LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{Role.ShortUriPrefix}{Role.ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}

/// <summary>The URI for the <inheritdoc cref="Names.Administrator" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.Administrator" path="/value" /></value>
public class Administrator : Role, IClaimTypeOrValue
{
    public new const string Name = Names.Administrator;
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}

/// <summary>The URI for the <inheritdoc cref="Names.GroupAdministrator" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
public class GroupAdministrator : Role, IClaimTypeOrValue
{

    public new const string Name = Names.GroupAdministrator;
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}

/// <summary>The URI for the <inheritdoc cref="Names.User" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.User" path="/value" /></value>
public class User : Role, IClaimTypeOrValue
{
    public new const string Name = Names.User;
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}

/// <summary>The URI for the <inheritdoc cref="Names.GroupMember" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.GroupMember" path="/value" /></value>
public class GroupMember : Role, IClaimTypeOrValue
{
    public new const string Name = Names.GroupMember;
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Names.Admin}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Names.Admin}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}
/// <summary>The URI for the <inheritdoc cref="Names.Voter" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.Voter" path="/value" /></value>
public class Voter : Role, IClaimTypeOrValue
{
    public new const string Name = Names.Voter;
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Names.Voter}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Names.Voter}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}
/// <summary>The URI for the <inheritdoc cref="Names.Contestant" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.Contestant" path="/value" /></value>
public class Contestant : Role, IClaimTypeOrValue
{
    public new const string Name = Names.Contestant;
    public new const string LongUriString = $"{LongUriPrefix}{Role.LongUriSeparator}{Names.Contestant}";
    public new const string ShortUriString = $"{ShortUriPrefix}{Role.ShortUriSeparator}{Names.Contestant}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}
/// <summary>The URI for the <inheritdoc cref="Names.Anonymous" path="/value" /> role</summary>
/// <value><inheritdoc cref="Names.Anonymous" path="/value" /></value>
public class Anonymous : Role, IClaimTypeOrValue
{
    public new const string Name = Names.Anonymous;
    public new const string LongUriString = $"{Role.LongUriPrefix}{Role.LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{Role.ShortUriPrefix}{Role.ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => LongUriString;
}

public static class Names
{
    /// <summary>The founder of the group (normally also the group's owner)</summary>
    /// <value>founder</value>
    public const string Founder = "founder";
    /// <summary>The owner of the group (normally also the group's founder)</summary>
    /// <value>owner</value>
    public const string Owner = "owner";
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
    /// <value><inheritdoc cref="Admin" path="/value" /></value>
    public const string Administrator = "administrator";

    /// <summary>The name of the <inheritdoc cref="GroupAdministrator" path="/value" /> role</summary>
    /// <value>group_administrator</value>
    public const string GroupAdministrator = "group_administrator";

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
    /// <summary>The name of the <inheritdoc cref="Anonymous" path="/value" /> role</summary>
    /// <value>snonymous</value>
    public const string Anonymous = "snonymous";
}
