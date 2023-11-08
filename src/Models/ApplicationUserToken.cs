/*
 * UserToken.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-04-11:54:26
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity.Models;

using Dgmjr.Identity.Models.Enums;
using Dgmjr.Identity.Models.Abstractions;

using Dgmjr.Identity.Abstractions;

using Microsoft.EntityFrameworkCore.Internal;

[Table(EntityFrameworkCore.Constants.TableNames.UserToken,
       Schema = IdentitySchema.ShortName)]
[DebuggerDisplay(
    "User Token ({UserId} - {LoginProvider}, Created: {DateTimeCreated})")]
public class ApplicationUserToken<TKey>
    : ApplicationIdentityEntity<TKey>,
      IIdentityUserToken<ApplicationUser<TKey>, ApplicationRole<TKey>, TKey,
                         ApplicationUserClaim<TKey>, ApplicationUserRole<TKey>,
                         ApplicationUserLogin<TKey>, ApplicationRoleClaim<TKey>,
                         ApplicationUserToken<TKey>>
    where TKey : IEquatable<TKey>, IComparable
{
    [Column]
    public virtual TKey UserId { get; set; }

    //[ForeignKey(ColUserId)]
    public virtual ApplicationUser<TKey> User { get; set; }

    [Column]
    public virtual int ProviderId
    {
        get => ((IIdentifiable<int>)Provider).Id;
        set => Provider = ApplicationUserLoginProvider.FromId(value);
    }

    public virtual string ProviderName
    {
        get => Provider.Name;
        set
        { /* no op */
        }
    }
    public virtual string ProviderDisplayName
    {
        get => Provider.DisplayName;
        set
        { /* no op */
        }
    }

    //[ForeignKey(nameof(ProviderId)), BackingField("_provider")]
    public virtual IApplicationUserLoginProvider Provider { get; set; }

    [Column(nameof(Name)), StringLength(64)]
    public virtual string Name { get; set; }

    [Column(nameof(Value)), StringLength(256)]
    public virtual string Value { get; set; }

    [Column(nameof(Created))]
    public virtual DateTimeOffset Created { get; set; } = DateTimeOffset.Now;

    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }
}

public class ApplicationUserToken : ApplicationUserToken<long> { }

// public class TelegramUserToken : BackroomUserToken
// {
//     public override byte ProviderId { get => ProviderId =
//     (byte)TelegramLoginProvider; set => ProviderId =
//     (byte)TelegramLoginProvider; }
// }
