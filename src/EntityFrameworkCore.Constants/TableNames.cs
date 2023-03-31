/*
 * TableNames.cs
 *
 *   Created: 2022-12-01-05:14:16
 *   Modified: 2022-12-01-05:14:17
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.EntityFrameworkCore;

public static partial class Constants
{
    public static partial class TableNames
    {
        public const string tbl_ = nameof(tbl_);
        public const string Bot = tbl_ + nameof(Bot);
        public const string User = tbl_ + nameof(User);
        public const string UserLogin = tbl_ + nameof(UserLogin);
        public const string Role = tbl_ + nameof(Role);
        public const string UserRole = tbl_ + nameof(UserRole);
        public const string UserClaim = tbl_ + nameof(UserClaim);
        public const string RoleClaim = tbl_ + nameof(RoleClaim);
        public const string UserToken = tbl_ + nameof(UserToken);
        public const string LoginProvider = tbl_ + nameof(LoginProvider);
        public const string ClaimType = tbl_ + nameof(ClaimType);
    }
}
