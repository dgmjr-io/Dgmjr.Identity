/*
 * IdentityDbContext.cs
 *
 *   Created: 2022-12-05-08:06:03
 *   Modified: 2022-12-05-08:06:03
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity;

using Microsoft.EntityFrameworkCore.Abstractions;

// [GenerateInterface]
public class IdentityDbContext<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken,
    TClaimType,
    TClaimValueType
>(DbContextOptions options)
    : IdentityDbContext<TUser, TRole>(options),
        IIdentityDbContext,
        IDbContext<IIdentityDbContext>,
        IIdentityDbContext<TUser, TRole>
    where TUser : class,
        IIdentityUser<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRole : class,
        IIdentityRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TKey : IEquatable<TKey>, IComparable
    where TUserClaim : class,
        IIdentityUserClaim<
            TUser,
            TRole,
            TKey,
            TUserClaim,
            TUserRole,
            TUserLogin,
            TRoleClaim,
            TUserToken
        >
    where TUserRole : class,
        IIdentityUserRole<
            TUser,
            TRole,
            TKey,
            TUserClaim,
            TUserRole,
            TUserLogin,
            TRoleClaim,
            TUserToken
        >
    where TUserLogin : class,
        IIdentityUserLogin<
            TUser,
            TRole,
            TKey,
            TUserClaim,
            TUserRole,
            TUserLogin,
            TRoleClaim,
            TUserToken
        >
    where TRoleClaim : class,
        IIdentityRoleClaim<
            TUser,
            TRole,
            TKey,
            TUserClaim,
            TUserRole,
            TUserLogin,
            TRoleClaim,
            TUserToken
        >
    where TUserToken : class,
        IIdentityUserToken<
            TUser,
            TRole,
            TKey,
            TUserClaim,
            TUserRole,
            TUserLogin,
            TRoleClaim,
            TUserToken
        >
    where TClaimType : class,
        IIdentityClaimType<TKey, TUser, TRole, TClaimType, TClaimValueType>,
        IHaveAName
    where TClaimValueType : class,
        IIdentityClaimValueType<TKey, TUser, TRole, TClaimType, TClaimValueType>,
        new()
{
    public IdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        : this(options as DbContextOptions) { }

public virtual DbSet<TUser> Users { get; set; }
public virtual DbSet<TRole> Roles { get; set; }
public virtual DbSet<TUserClaim> UserClaims { get; set; }
public virtual DbSet<TUserRole> UserRoles { get; set; }
public virtual DbSet<TUserLogin> UserLogins { get; set; }
public virtual DbSet<TRoleClaim> RoleClaims { get; set; }
public virtual DbSet<TUserToken> UserTokens { get; set; }
public virtual DbSet<TClaimType> ClaimTypes { get; set; }
public virtual DbSet<TClaimValueType> ClaimValueTypes { get; set; }
}
