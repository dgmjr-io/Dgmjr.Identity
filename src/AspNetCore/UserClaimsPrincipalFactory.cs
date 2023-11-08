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

public class UserClaimsPrincipalFactory<TUser>(
    UserManager<TUser> userManager, IOptions<IdentityOptions> optionsAccessor)
    : MSID.UserClaimsPrincipalFactory<TUser>(userManager, optionsAccessor)
    where TUser : class, IIdentityUserBase {}
