/*
 * IHaveUserClaims.cs
 *
 *   Created: 2023-10-10-09:28:28
 *   Modified: 2023-10-10-09:28:30
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IHaveUserClaims<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    > : IIdentityEntity<TKey>
    where TUser : IIdentityUser<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
    where TRole : IIdentityRole<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
    where TKey : IEquatable<TKey>, IComparable
    where TUserClaim : IIdentityUserClaim<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
    where TUserRole : IIdentityUserRole<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
    where TUserLogin : IIdentityUserLogin<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
    where TRoleClaim : IIdentityRoleClaim<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
    where TUserToken : IIdentityUserToken<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    >
{
    ICollection<TUserClaim> Claims {
        get;
    }
}
