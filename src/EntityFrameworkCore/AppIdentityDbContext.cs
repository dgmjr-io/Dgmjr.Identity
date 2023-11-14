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

using System;
using System.Data;
using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

using Dgmjr.EntityFrameworkCore;
using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.Abstractions;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using Dgmjr.Identity.Models;

using MSID = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Telegram.Bot.Types;

public class AppIdentityDbContext(DbContextOptions options)
    : IdentityDbContext<
        AppUser,
        AppRole,
        long,
        AppUserClaim,
        AppUserRole,
        AppUserLogin,
        AppRoleClaim,
        AppUserToken,
        AppClaimType,
        AppClaimValueType
    >(options)
{
    public AppIdentityDbContext(
        DbContextOptions<
            IdentityDbContext<
                AppUser,
                AppRole,
                long,
                AppUserClaim,
                AppUserRole,
                AppUserLogin,
                AppRoleClaim,
                AppUserToken,
                AppClaimType,
                AppClaimValueType
            >
        > options
    )
        : this(options as DbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration<AppUserConfiguration, AppUser>();
        modelBuilder.ApplyConfiguration<AppRoleConfiguration, AppRole>();
        modelBuilder.ApplyConfiguration<AppUserClaimConfiguration, AppUserClaim>();
        modelBuilder.ApplyConfiguration<AppUserLoginConfiguration, AppUserLogin>();
        modelBuilder.ApplyConfiguration<AppRoleClaimConfiguration, AppRoleClaim>();
        modelBuilder.ApplyConfiguration<AppUserTokenConfiguration, AppUserToken>();
        modelBuilder.ApplyConfiguration<AppClaimTypeConfiguration, AppClaimType>();
        modelBuilder.ApplyConfiguration<AppClaimValueTypeConfiguration, AppClaimValueType>();
        modelBuilder.ApplyConfiguration<AppUserRoleConfiguration, AppUserRole>();

        var claimValueTypesByUri = new Dictionary<string, AppClaimValueType>();
        long id = 1;
        modelBuilder
            .Entity<AppClaimValueTypeConfiguration>()
            .HasData(
                Dgmjr.Identity.ClaimValueType
                    .GetAll()
                    .OrderBy(cvt => ((IHaveAUriString)cvt).UriString)
                    .Select(cvt =>
                    {
                        claimValueTypesByUri[((IHaveAUriString)cvt).UriString] =
                            new AppClaimValueType
                            {
                                Id = id++,
                                Name = ((IIdentityComponent)cvt).Name,
                                Uri = cvt.Uri,
                                Example = cvt.ExampleStringValue,
                                Default = cvt.DefaultStringValue
                            };
                        return claimValueTypesByUri[((IHaveAUriString)cvt).UriString];
                    })
            );

        modelBuilder
            .Entity<AppClaimType>()
            .HasData(
                Dgmjr.Identity.ClaimType
                    .GetAll()
                    .OrderBy(ct => ((IHaveAUriString)ct).UriString)
                    .Select(ct =>
                    {
                        var claimValueType = claimValueTypesByUri[ct.ClaimTypeUri];
                        return new AppClaimType
                        {
                            Id = ((IIdentifiable<long>)ct).Id,
                            Name = ((IHaveAName)ct).Name,
                            Uri = ((IHaveAUriString)ct).UriString,
                            ValueTypeUri = ((IHaveAuri)claimValueType).Uri,
                            ValueType = claimValueType
                        };
                    })
            );

        // builder.Entity<Bot>(builder
        // {
        //     builder.Property(e => e.Id).ValueGeneratedOnAdd();
        //     builder.Property(e => e.ApiToken).HasConversion<BotApiToken.EfCoreValueConverter>();
        //     builder.Property(e => e.SendPulseId).HasConversion<ObjectId.EfCoreValueConverter>();
        // });
        // builder.Entity<UserContactId>(builder =>
        // {
        //     builder.Property(e => e.ContactId).HasConversion<ObjectId.EfCoreValueConverter>();
        // });
        // builder.HasMany(e => e.Users).WithMany(u => u.ClaimTypes).UsingEntity<AppUserClaim>(
        //     uc => uc.HasOne(uc => uc.User).WithMany().HasForeignKey(uc => uc.UserId).HasPrincipalKey(u => u.Id),
        //     uc => uc.HasOne<IdentityClaimType>("ClaimType").WithMany().HasForeignKey<int>("ClaimTypeId").HasPrincipalKey(ct => ct.Id
        //     uc => uc.HasKey(uc => new { uc.UserId, uc.ClaimTypeId })
        // );
        // builder.HasMany(e => e.Roles).WithMany().UsingEntity<RoleClaim>();
    }

    [DbFunction(ufn_ + nameof(GetBotToken), Schema = DataSchema.ShortName)]
    public virtual BotApiToken GetBotToken(long userId) =>
        BotApiToken.From(
            UserClaims
                .FirstOrDefault(
                    u =>
                        u.Type.Equals(Telegram.Identity.ClaimTypes.BotApiToken.UriString)
                        && u.UserId.Equals(userId.ToString())
                )
                ?.Value ?? string.Empty
        );

    [DbFunction(ufn_ + nameof(GetSendPulseId), Schema = DataSchema.ShortName)]
    public virtual ObjectId GetSendPulseId(long userId) =>
        ObjectId.From(
            UserClaims
                .FirstOrDefault(
                    u => u.Type.Equals(SpId.ObjectId) && u.UserId.Equals(userId.ToString())
                )
                ?.Value ?? ObjectId.EmptyValue
        );
}
