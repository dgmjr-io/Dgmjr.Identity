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

namespace Dgmjr.Identity.EntityFrameworkCore.Constants;

public static partial class TableNames {
  private const string tbl_ = nameof(tbl_);
  public const string Bot = tbl_ + "Bot";
  public const string User = tbl_ + "User";
  public const string UserLogin = tbl_ + "UserLogin";
  public const string Role = tbl_ + "Role";
  public const string UserRole = tbl_ + "UserRole";
  public const string UserClaim = tbl_ + "UserClaim";
  public const string RoleClaim = tbl_ + "RoleClaim";
  public const string UserToken = tbl_ + "UserToken";
  public const string LoginProvider = tbl_ + "LoginProvider";
  public const string ClaimType = tbl_ + "ClaimType";
  public const string ClaimValueType = tbl_ + "ClaimValueType";
}
