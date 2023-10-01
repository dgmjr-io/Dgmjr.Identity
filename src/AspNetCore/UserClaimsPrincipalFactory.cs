/*
 * UserClaimsPrincipalFactory.cs
 *
 *   Created: 2022-12-13-08:51:24
 *   Modified: 2022-12-13-08:51:24
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Dgmjr.Identity;

public class UserClaimsPrincipalFactory : UserClaimsPrincipalFactory<User>
{
    public UserClaimsPrincipalFactory(
        UserManager<User> userManager,
        IOptions<IdentityOptions> optionsAccessor
    )
        : base(userManager, optionsAccessor) { }
}
