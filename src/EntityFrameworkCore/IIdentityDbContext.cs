/*
 * IIdentityDbContext.cs
 *
 *   Created: 2022-12-30-11:37:53
 *   Modified: 2022-12-30-11:37:54
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

using Microsoft.EntityFrameworkCore.Abstractions;
using Telegram.Bot.Types;
using System;

// [GenerateInterface(typeof(IdentityDbContext<,,,,,,,,,>))]
public partial interface IIdentityDbContext : IDbContext<IIdentityDbContext>
{
    BotApiToken GetBotToken(long userId);
    ObjectId GetSendPulseId(long userId);
    bool IsBot(long userId);
    bool IsUri(string uri);
    bool IsUrl(string url);
    bool IsUrn(string urn);
    bool IsValidBotToken(string token);
    bool IsValidEmailAddress(string email);
    bool IsValidGender(string gender);
    bool IsValidObjectId(string objectId);
    bool IsValidPhoneNumber(string phoneNumber);
}

// [GenerateInterface(typeof(IdentityDbContext<,,,,,,,,,>))]
public partial interface IIdentityDbContext<TUser, TRole>
    : IDbContext<IIdentityDbContext<TUser, TRole>>
    where TUser : class, IIdentityUserBase
    where TRole : class, IIdentityRoleBase
{
    DbSet<TUser> Users { get; set; }
    DbSet<TRole> Roles { get; set; }
}
