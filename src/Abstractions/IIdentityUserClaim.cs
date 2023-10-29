/*
 * IIdentityUserClaim.cs
 *
 *   Created: 2023-10-06-05:37:28
 *   Modified: 2023-10-10-09:29:07
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserClaim<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
>
    : IEntityClaim<TUserClaim, TUser, TKey>,
        IUserAssociatedEntity<
            TUser,
            TRole,
            TKey,
            TUserClaim,
            TUserRole,
            TUserLogin,
            TRoleClaim,
            TUserToken
        >
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
{ }

public interface IIdentityUserClaim
    : IIdentityUserClaim<
        IIdentityUser,
        IIdentityRole,
        long,
        IIdentityUserClaim,
        IIdentityUserRole,
        IIdentityUserLogin,
        IIdentityRoleClaim,
        IIdentityUserToken
    >
{ }
