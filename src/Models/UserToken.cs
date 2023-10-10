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
using UserLoginProviderEnum = Dgmjr.Identity.Models.Enums.UserLoginProvider;

using Dgmjr.Identity.Abstractions;

using Microsoft.EntityFrameworkCore.Internal;

[Table(TblUserToken, Schema = IdentitySchema.ShortName)]
[DebuggerDisplay("User Token ({UserId} - {LoginProvider}, Created: {DateTimeCreated})")]
public class ApplicationUserToken : IIdentityUserToken<long>
{
    [Key, DbGen(DbGen.Identity)]
    public virtual long Id { get; set; } //= NewId;

    [Column]
    public virtual long UserId { get; set; }

    //[ForeignKey(ColUserId)]
    public virtual ApplicationUser User { get; set; }

    [Column]
    public virtual int LoginProviderId
    {
        get => ((IIdentifiable<int>)Provider).Id;
        set => Provider = ApplicationUserLoginProvider.FromId(value);
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

// public class TelegramUserToken : BackroomUserToken
// {
//     public override byte ProviderId { get => ProviderId = (byte)TelegramLoginProvider; set => ProviderId = (byte)TelegramLoginProvider; }
// }
