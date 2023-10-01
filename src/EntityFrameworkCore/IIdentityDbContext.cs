/*
 * IIdentityDbContext.cs
 *
 *   Created: 2022-12-30-11:37:53
 *   Modified: 2022-12-30-11:37:54
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

using Microsoft.EntityFrameworkCore.Abstractions;

[GenerateInterface(typeof(IdentityDbContext))]
public partial interface IIdentityDbContext : IDbContext, IDbContext<IIdentityDbContext>
{
    // static string IDbContext.DefaultConnectionStringConfigurationKey => "IdentityDb";
    // public string DefaultConnectionStringConfigurationKey => "IdentityDb";
}
