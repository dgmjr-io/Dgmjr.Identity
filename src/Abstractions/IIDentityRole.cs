/*
 * IIdentityRole.cs
 *
 *   Created: 2023-03-25-03:40:20
 *   Modified: 2023-03-25-03:40:20
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

using System.Security.Principal;

using Microsoft.AspNetCore.Identity;

public partial interface IIdentityRole<TKey, TUser, TRole>
    : IIdentityRoleBase, IIdentityEntity<TKey>
    where TUser : IIdentityUser<TKey, TUser, TRole>
    where TRole : IIdentityRole<TKey, TUser, TRole>
    where TKey : IEquatable<TKey>, IComparable {
  ICollection<TUser> Users { get; set; }
}

public partial
    interface IIdentityRole<TUser, TRole, TKey, TUserClaim, TUserRole,
                            TUserLogin, TRoleClaim, TUserToken>
    : IIdentityRole<TKey, TUser, TRole>
    where TUser : IIdentityUser<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRole : IIdentityRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TKey : IEquatable<TKey>, IComparable
    where TUserClaim : IIdentityUserClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserRole : IIdentityUserRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserLogin : IIdentityUserLogin<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRoleClaim : IIdentityRoleClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserToken : IIdentityUserToken<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken> {
  ICollection<TUserRole> UserRoles { get; set; }
}

public partial interface IIdentityRole<TUser, TRole, TKey, TUserClaim,
                                       TUserRole, TUserLogin, TRoleClaim,
                                       TUserToken, TClaimType, TClaimValueType>
    : IIdentityRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin,
                    TRoleClaim, TUserToken>
    where TUser : IIdentityUser<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRole : IIdentityRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken, TClaimType, TClaimValueType>
    where TKey : IEquatable<TKey>, IComparable
    where TUserClaim : IIdentityUserClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserRole : IIdentityUserRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserLogin : IIdentityUserLogin<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRoleClaim : IIdentityRoleClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserToken : IIdentityUserToken<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TClaimType : IIdentityClaimType<TKey, TUser, TRole, TClaimType, TClaimValueType>
    where TClaimValueType : IIdentityClaimValueType<TKey, TUser, TRole, TClaimType, TClaimValueType> {
  ICollection<TClaimType> ClaimTypes { get; }
}

public interface IIdentityRole
    : IIdentityRole<IIdentityUser, IIdentityRole, long, IIdentityUserClaim,
                    IIdentityUserRole, IIdentityUserLogin, IIdentityRoleClaim,
                    IIdentityUserToken, IIdentityClaimType,
                    IIdentityClaimValueType> {}
