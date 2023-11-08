/*
 * IBackroomUser.cs
 *
 *   Created: 2022-12-01-04:51:41
 *   Modified: 2022-12-03-01:45:50
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

using System.Domain;
using System.Net.Mail;
using System.Security.Claims;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Telegram.Constants.Account;

using Dgmjr.Abstractions;

public partial interface IIdentityUser<TKey, TUser, TRole>
    : IIdentityUserBase,
      IIdentityEntity<TKey>
      where TKey : IEquatable<TKey>, IComparable
      where TRole : IIdentityRole<TKey, TUser, TRole>
      where TUser : IIdentityUser<TKey, TUser, TRole>
{
    /// <summary>Gets or sets the primary key for this user.</summary>
    [PersonalData, Key, DbGen(DbGen.None), Hashids]
    new TKey Id {
        get;
        set;
    }
    ICollection<TRole> Roles {
        get;
    }
}

public partial interface IIdentityUser<
    TUser,
    TRole,
    TKey,
    TUserClaim,
    TUserRole,
    TUserLogin,
    TRoleClaim,
    TUserToken
    > : IIdentityUser<TKey, TUser, TRole>
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
    ICollection<TUserLogin> Logins {
        get;
    }
    ICollection<TUserToken> Tokens {
        get;
    }
    ICollection<TUserRole> UserRoles {
        get;
    }
}

public interface IIdentityUser
    : IIdentityUser<
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
