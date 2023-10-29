/*
 * UserValidator.cs
 *
 *   Created: 2022-12-13-08:56:44
 *   Modified: 2022-12-13-08:56:44
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace Dgmjr.Identity;

public class UserValidator<TUser>(IdentityErrorDescriber? errors = null)
    : Microsoft.AspNetCore.Identity.UserValidator<TUser>(errors)
    where TUser : class, IIdentityUserBase { }
