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
using Dgmjr.Identity.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Dgmjr.Identity;

public class RoleManager<TRole> : MSID.RoleManager<TRole>
    where TRole : class, IIdentityRoleBase
{
    public RoleManager(IRoleStore<TRole> store,
                       IEnumerable<IRoleValidator<TRole>> roleValidators,
                       ILookupNormalizer keyNormalizer,
                       IdentityErrorDescriber errors,
                       ILogger<RoleManager<TRole>> logger)
        : base(store, roleValidators, keyNormalizer,
               errors as MSID.IdentityErrorDescriber, logger)
    { }
}
