/*
 * UserClaimExtensions.cs
 *
 *   Created: 2022-12-19-09:02:25
 *   Modified: 2022-12-19-09:02:26
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity.Models;

namespace Dgmjr.Identity;

public static class UserClaimExtensions
{
    public static UserClaim ToUserClaim(this C c)
    {
        var uc = new UserClaim();
        uc.InitializeFromClaim(c);
        return uc;
    }

    public static RoleClaim ToRoleClaim(this C c)
    {
        var rc = new RoleClaim();
        rc.InitializeFromClaim(c);
        return rc;
    }
}
