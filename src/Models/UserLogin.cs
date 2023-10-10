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
using Microsoft.AspNetCore.Identity;
using static Dgmjr.EntityFrameworkCore.Constants.DbTypeNames;
using static Dgmjr.EntityFrameworkCore.Constants.Schemas;

[Table(Constants.TableNames.TblUserLogin, Schema = IdSchema)]
[DebuggerDisplay("User Login (Id} - {LoginProvider}: {ProviderKey})")]
[JSerializable(typeof(ApplicationUserLogin))]
public class ApplicationUserLogin : UserLoginEntity, IIdentityUserLogin<long>
{
    [Key, DbGen(DbGen.Identity), Column(nameof(Id), TypeName = DbTypeBigInt), Required]
    public virtual long Id { get; set; }

    [NotMapped]
    public virtual string ProviderName => Provider.Name;

    public virtual string ProviderKey { get; set; }

    [NotMapped]
    public virtual string ProviderDisplayName => Provider.DisplayName;

    [JIgnore, Newtonsoft.Json.JsonIgnore]
    public virtual IApplicationUserLoginProvider Provider { get; set; }

    public virtual int ProviderId { get; set; }

    public virtual ApplicationUser User { get; set; }

    [Hashids]
    public virtual long UserId { get; set; }
    public virtual DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
}

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
