/*
 * PasswordValidator.cs
 *
 *   Created: 2022-12-13-09:01:57
 *   Modified: 2022-12-13-09:01:57
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace Dgmjr.Identity;

public class PasswordValidator : PasswordValidator<User>
{
    public PasswordValidator(DavidsErrorDescriber errors) : base(errors)
    {
    }
}
