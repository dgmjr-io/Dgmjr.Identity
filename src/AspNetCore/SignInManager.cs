/*
 * SignInManager.cs
 *
 *   Created: 2022-12-13-08:52:17
 *   Modified: 2022-12-13-08:52:17
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Dgmjr.Identity;

public class SignInManager<TUser>(
        UserManager<TUser> userManager,
        IHttpContextAccessor contextAccessor,
        IUserClaimsPrincipalFactory<TUser> claimsFactory,
        IOptions<IdentityOptions> optionsAccessor,
        ILogger<SignInManager<TUser>> logger,
        IAuthenticationSchemeProvider schemes,
        IUserConfirmation<TUser> confirmation
    )
        : MSID.SignInManager<TUser>(
              userManager,
              contextAccessor,
              claimsFactory,
              optionsAccessor,
              logger,
              schemes,
              confirmation
          )
          where TUser : class, IIdentityUserBase { }
