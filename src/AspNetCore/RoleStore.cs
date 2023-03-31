/*
 * RoleStore.cs
 *
 *   Created: 2022-12-30-11:08:42
 *   Modified: 2022-12-30-11:08:43
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Identity;

public class RoleStore : Microsoft.AspNetCore.Identity.EntityFrameworkCore.RoleStore<Models.Role, IdentityDbContext, int, UserRole, RoleClaim>
{
    public RoleStore(IdentityDbContext context, IdentityErrorDescriber? describer = null) : base(context, describer)
    {
    }
}
