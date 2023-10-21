/*
 * IIDentityRole.cs
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

public partial interface IIdentityRole<TKey, TUser, TRole> : IIdentityEntity<TKey>
    where TUser : IIdentityUser<TKey, TUser, TRole>
    where TRole : IIdentityRole<TKey, TUser, TRole>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the name for this role.
    /// </summary>
    string? Name { get; set; }

    /// <summary>
    /// Gets or sets the normalized name for this role.
    /// </summary>
    string? NormalizedName { get; set; }

    /// <summary>
    /// Gets or sets the description for this role.
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// A random value that should change whenever a role is persisted to the store
    /// </summary>
    string? ConcurrencyStamp { get; set; }

    /// <summary>
    /// The <see cref="uri" /> of the role
    /// </summary>
    uri Uri { get; set; }

    /// <summary>
    /// Returns the name of the role.
    /// </summary>
    /// <returns>The name of the role.</returns>
    string ToString();

    ICollection<TUser> Users { get; set; }
}

public partial interface IIdentityRole<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
> : IIdentityRole<TKey, TUser, TRole>
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
    ICollection<TUserRole> UserRoles { get; set; }
}

public interface IIdentityRole
    : IIdentityRole<
        Dgmjr.Identity.Abstractions.IIdentityUser,
        Dgmjr.Identity.Abstractions.IIdentityRole,
        long,
        Dgmjr.Identity.Abstractions.IIdentityUserClaim,
        Dgmjr.Identity.Abstractions.IIdentityUserRole,
        Dgmjr.Identity.Abstractions.IIdentityUserLogin,
        Dgmjr.Identity.Abstractions.IIdentityRoleClaim,
        Dgmjr.Identity.Abstractions.IIdentityUserToken
    > { }
