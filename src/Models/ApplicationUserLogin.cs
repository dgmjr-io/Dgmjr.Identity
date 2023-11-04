/*
 * UserLogin.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-05-06:32:13
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

#pragma warning disable
namespace Dgmjr.Identity.Models;

using Abstractions;
using Dgmjr.Abstractions;
using Dgmjr.Identity.Abstractions;
using Dgmjr.Identity.Models.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query.Internal;

[Table(EntityFrameworkCore.Constants.TableNames.UserLogin, Schema = IdentitySchema.ShortName)]
[DebuggerDisplay("User Login (Id} - {LoginProvider}: {ProviderKey})")]
public class ApplicationUserLogin<TKey>
    : ApplicationIdentityEntity<TKey>,
        IUserLoginEntity<
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            TKey,
            ApplicationUserClaim<TKey>,
            ApplicationUserRole<TKey>,
            ApplicationUserLogin<TKey>,
            ApplicationRoleClaim<TKey>,
            ApplicationUserToken<TKey>
        >,
        IIdentityUserLogin<
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            TKey,
            ApplicationUserClaim<TKey>,
            ApplicationUserRole<TKey>,
            ApplicationUserLogin<TKey>,
            ApplicationRoleClaim<TKey>,
            ApplicationUserToken<TKey>
        >
    where TKey : IEquatable<TKey>, IComparable
{
    [NotMapped]
    public virtual string ProviderName => Provider.Name;

    public virtual string ProviderKey { get; set; }

    [NotMapped]
    public virtual string ProviderDisplayName => Provider.DisplayName;

    [JConverter(typeof(ApplicationUserLoginProviderJsonConverter))]
    public virtual Abstractions.IApplicationUserLoginProvider Provider { get; set; }

    public virtual int ProviderId { get; set; }

    public virtual ApplicationUser<TKey> User { get; set; }

    [Hashids]
    public virtual TKey UserId { get; set; }
    public virtual DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
}

public class ApplicationUserLogin : ApplicationUserLogin<long> { }

// public class TelegramUserLogin : BackroomUserLogin
// {
//     public override byte ProviderId { get => ProviderId = (byte)TelegramLoginProvider; set => base.ProviderId = (byte)TelegramLoginProvider; }
//     [NotMapped]
//     public long TelegramId { get => long.Parse(base.ProviderKey); set => base.ProviderKey = value.ToString(); }
// }

public struct UserLoginInsertDto
{
    public string ProviderName { get; set; }
    public string ProviderKey { get; set; }
    public string ProviderDisplayName { get; set; }
    public long UserId { get; set; }
}
