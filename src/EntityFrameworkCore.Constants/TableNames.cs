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
        private const string tbl_ = nameof(tbl_);
        public const string TblBot = tbl_ + "Bot";
        public const string TblUser = tbl_ + "User";
        public const string TblUserLogin = tbl_ + "UserLogin";
        public const string TblRole = tbl_ + "Role";
        public const string TblUserRole = tbl_ + "UserRole";
        public const string TblUserClaim = tbl_ + "UserClaim";
        public const string TblRoleClaim = tbl_ + "RoleClaim";
        public const string TblUserToken = tbl_ + "UserToken";
        public const string TblLoginProvider = tbl_ + "LoginProvider";
        public const string TblClaimType = tbl_ + "ClaimType";
        public const string TblClaimValueType = tbl_ + "ClaimValueType";
    }
}
