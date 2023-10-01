/*
 * RoleManager.cs
 *
 *   Created: 2022-12-13-08:45:40
 *   Modified: 2022-12-13-08:45:40
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Dgmjr.Identity;

public class RoleManager : Microsoft.AspNetCore.Identity.RoleManager<Role>
{
    public RoleManager(
        IRoleStore<Role> store,
        IEnumerable<IRoleValidator<Role>> roleValidators,
        ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors,
        ILogger<RoleManager<Role>> logger
    )
        : base(store, roleValidators, keyNormalizer, errors, logger) { }
}
