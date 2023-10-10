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
        public const string TblBot = tbl_ + nameof(TblBot);
        public const string TblUser = tbl_ + nameof(TblUser);
        public const string TblUserLogin = tbl_ + nameof(TblUserLogin);
        public const string TblRole = tbl_ + nameof(TblRole);
        public const string TblUserRole = tbl_ + nameof(TblUserRole);
        public const string TblUserClaim = tbl_ + nameof(TblUserClaim);
        public const string TblRoleClaim = tbl_ + nameof(TblRoleClaim);
        public const string TblUserToken = tbl_ + nameof(TblUserToken);
        public const string TblLoginProvider = tbl_ + nameof(TblLoginProvider);
        public const string TblClaimType = tbl_ + nameof(TblClaimType);
    }
}
