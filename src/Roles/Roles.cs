// /*
//  * Roles.cs
//  *
//  *   Created: 2023-03-19-05:02:09
//  *   Modified: 2023-03-19-05:02:09
//  *
//  *   Author: David G. Moore, Jr. <david@dgmjr.io>
//  *
//  *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */
// namespace Dgmjr.Identity.Roles;

// using System;
// using static Dgmjr.Identity.Role;
// using DgmjrR = Dgmjr.Identity.Role;
// using Dgmjr.Abstractions;

// /// <summary><inheritdoc cref="Names.Scheme" path="/summary" /></summary>
// /// <value><inheritdoc cref="Names.Scheme" path="/value" /></value>
// public sealed record class BaseUri : Role, IIdentityComponent
// {
//     public static IRole Instance = new BaseUri();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.Admin" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Admin" path="/value" /></value>

// public sealed record class Admin : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.Admin" path="/value" /></value>
//     public new const string Name = Names.Admin;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Admin" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Admin}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private Admin() { }

//     public static IRole Instance = new Admin();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.Administrator" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Administrator" path="/value" /></value>

// public sealed record class Administrator : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.Administrator" path="/value" /></value>
//     public new const string Name = Names.Administrator;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Administrator" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Administrator}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private Administrator() { }

//     public static IRole Instance = new Administrator();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.GroupAdministrator" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>

// public sealed record class GroupAdministrator : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
//     public new const string Name = Names.GroupAdministrator;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.GroupAdministrator" path="/value" /></value>
//     public new const string UriString =
//         $"{Names.Scheme}{DgmjrR.Namespace}/{Names.GroupAdministrator}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private GroupAdministrator() { }

//     public static IRole Instance = new GroupAdministrator();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.Owner" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Owner" path="/value" /></value>

// public sealed record class Owner : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.Owner" path="/value" /></value>
//     public new const string Name = Names.Owner;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Owner" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Owner}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private Owner() { }

//     public static IRole Instance = new Owner();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.User" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.User" path="/value" /></value>

// public sealed record class User : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.User" path="/value" /></value>
//     public new const string Name = Names.User;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.User" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.User}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private User() { }

//     public static IRole Instance = new User();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.GroupMember" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.GroupMember" path="/value" /></value>

// public sealed record class GroupMember : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.GroupMember" path="/value" /></value>
//     public new const string Name = Names.GroupMember;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.GroupMember" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.GroupMember}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private GroupMember() { }

//     public static IRole Instance = new GroupMember();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.Voter" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Voter" path="/value" /></value>

// public sealed record class Voter : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.Voter" path="/value" /></value>
//     public new const string Name = Names.Voter;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Voter" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Voter}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private Voter() { }

//     public static IRole Instance = new Voter();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.Contestant" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Contestant" path="/value" /></value>

// public sealed record class Contestant : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.Contestant" path="/value" /></value>
//     public new const string Name = Names.Contestant;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Contestant" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Contestant}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private Contestant() { }

//     public static IRole Instance = new Contestant();
// }

// /// <summary>The URI for the <inheritdoc cref="Names.Anonymous" path="/value" /> role</summary>
// /// <value><inheritdoc cref="BaseUri" path="/value" />/<inheritdoc cref="Names.Anonymous" path="/value" /></value>

// public sealed record class Anonymous : DgmjrR, IIdentityComponent
// {
//     /// <value><inheritdoc cref="Names.Anonymous" path="/value" /></value>
//     public new const string Name = Names.Anonymous;

//     /// <value><inheritdoc cref="Names.Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" />/<inheritdoc cref="Names.Anonymous" path="/value" /></value>
//     public new const string UriString = $"{Names.Scheme}{DgmjrR.Namespace}/{Names.Anonymous}";

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     string IHaveAUriString.UriString => UriString;

//     /// <value><inheritdoc cref="UriString" path="/value" /></value>
//     uri IIdentityComponent.Uri => uri.From(UriString);

//     private Anonymous() { }

//     public static IRole Instance = new Anonymous();
// }
