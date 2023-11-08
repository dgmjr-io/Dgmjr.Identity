/*
 * IIdentityUserRole.cs
 *
 *   Created: 2023-10-06-04:47:15
 *   Modified: 2023-10-10-09:28:56
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserRole<TUser, TRole, TKey, TUserClaim, TUserRole,
                                   TUserLogin, TRoleClaim, TUserToken>
    : IUserAssociatedEntity<TUser, TRole, TKey, TUserClaim, TUserRole,
                            TUserLogin, TRoleClaim, TUserToken>
    where TUser : IIdentityUser<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRole : IIdentityRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TKey : IEquatable<TKey>, IComparable
    where TUserClaim : IIdentityUserClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserRole : IIdentityUserRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserLogin : IIdentityUserLogin<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRoleClaim : IIdentityRoleClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserToken : IIdentityUserToken<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken> {
  /// <summary>
  /// Gets or sets the primary key of the role that is linked to the user.
  /// </summary>
  [Hashids]
  TKey RoleId { get; set; }

  TRole Role { get; set; }
}

public interface IIdentityUserRole
    : IIdentityUserRole<IIdentityUser, IIdentityRole, long, IIdentityUserClaim,
                        IIdentityUserRole, IIdentityUserLogin,
                        IIdentityRoleClaim, IIdentityUserToken> {}
