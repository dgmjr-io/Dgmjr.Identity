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
// using Dgmjr.Identity.Roles;

// namespace Dgmjr.Identity;

// public partial record class RoleBase : IHaveAName, IRole
// {
//     /// <value><inheritdoc cref="Constants.Scheme" path="/value" /></value>
//     public const string Scheme = Constants.Scheme;

//     /// <value><inheritdoc cref="Constants.Namespace" path="/value"
//     /></value> public const string Namespace = Constants.Namespace;

//     /// <value><inheritdoc cref="Scheme" path="/value" /></value>
//     string IRole.Scheme => Scheme;

//     /// <value><inheritdoc cref="Namespace" path="/value" /></value>
//     string IIdentityComponent.Namespace => Namespace;

//     /// <value>role</value>
//     string IIdentityComponent.ShortNamespace => "role";

//     /// <value><inheritdoc cref="IHaveAName.Name" path="/value" /></value>
//     string IIdentityComponent.Name => ((IHaveAName)this).Name;
// }
