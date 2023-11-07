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
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;

using Dgmjr.EntityFrameworkCore;
using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.Abstractions;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using Dgmjr.Identity.Models;

using MSID = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Telegram.Bot.Types;

public class IdentityDbContext<TUser, TRole> : DbContext, IDbContext
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext<TUser, TRole>> options)
        : base(options) { }

    public IdentityDbContext(DbContextOptions options)
        : base(options) { }
}

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
>
    : IdentityDbContext<TUser, TRole>,
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
        IIdentityClaimValueType<TKey, TUser, TRole, TClaimType, TClaimValueType>
{
    public IdentityDbContext(DbContextOptions options)
        : base(options) { }

    public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
        : base(options) { }

    public virtual DbSet<TUser> Users { get; set; }
    public virtual DbSet<TRole> Roles { get; set; }
    public virtual DbSet<TUserClaim> UserClaims { get; set; }
    public virtual DbSet<TUserRole> UserRoles { get; set; }
    public virtual DbSet<TUserLogin> UserLogins { get; set; }
    public virtual DbSet<TRoleClaim> RoleClaims { get; set; }
    public virtual DbSet<TUserToken> UserTokens { get; set; }
    public virtual DbSet<TClaimType> ClaimTypes { get; set; }
    public virtual DbSet<TClaimValueType> ClaimValueTypes { get; set; }

    static string DefaultConnectionStringConfigurationKey => "IdentityDb";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .EnableSensitiveDataLogging()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
            .EnableDetailedErrors()
            .ConfigureWarnings(_ => { })
            .UseSqlServer(options =>
            {
                options.MigrationsAssembly(typeof(IdentityDbContext).Assembly.FullName);
                options.EnableRetryOnFailure();
            });
        base.OnConfiguring(optionsBuilder);
    }

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

        modelBuilder.HasDbFunction(
            typeof(IdentityDbContext).GetMethod(nameof(GetBotToken)),
            builder =>
            {
                builder.HasName(ufn_ + nameof(GetBotToken));
                builder.HasSchema(IdentitySchema.ShortName);
                builder.HasParameter("userId");
                builder.HasStoreType($"char({BotApiToken.Length})");
                builder
                    .GetInfrastructure()
                    .HasTypeMapping(
                        new StringTypeMapping(DbTypeNames.NVarCharMax.ShortName, DbType.String)
                    );
                //         builder
                //             .GetInfrastructure()
                //             .HasTranslation(
                //                 args =>
                //                     args[0] is SqlConstantExpression sqlConstantExpression
                //                         ? new SqlFragmentExpression(
                //                             $"""
                //                             SELECT TOP 1[{ IdentityConstants.UserClaim.Columns.Value }]
                //                             FROM[{ IdentitySchema.ShortName}].[{ UserClaim}]
                //                             WHERE[{ IdentityConstants.UserClaim.Columns.UserId}] = { sqlConstantExpression.Value}
                // AND[{ IdentityConstants.UserClaim.Columns.Type}] = '{Telegram.Identity.BotApiToken.UriString}'
                //                             """
                //                         )
                //                         : throw new InvalidOperationException(
                //                             "The argument must be a constant expression."
                //                         )
                //             );
            }
        );

        modelBuilder.HasDbFunction(
            typeof(IdentityDbContext).GetMethod(nameof(IsValidEmailAddress)),
            builder =>
            {
                builder.HasName(ufn_ + nameof(IsValidEmailAddress));
                builder.HasSchema(DataSchema.ShortName);
                builder.HasParameter("email");
                builder.HasStoreType($"char({BotApiToken.Length})");
                builder
                    .GetInfrastructure()
                    .HasTypeMapping(
                        new StringTypeMapping(DbTypeNames.NVarCharMax.ShortName, DbType.String)
                    );
                // builder.HasTranslation(
                //     args =>
                //         args[0] is SqlConstantExpression sqlConstantExpression
                //             ? new SqlFragmentExpression(
                //                 $$$"""
                //                 DECLARE @bitEmailVal as Bit
                //                 DECLARE @EmailText nvarchar(MAX) = '{{{sqlConstantExpression.Value}}}'

                //                 SET @EmailText = ltrim(rtrim(isnull(@EMAIL, '')))

                //                 SET @bitEmailVal = case when @EmailText = '' then 0
                //                                         when @EmailText like '% %' then 0
                //                                         when @EmailText like ('%["(),:;<>\]%') then 0
                //                                         when substring(@EmailText, charindex('@', @EmailText),len(@EmailText)) like('%[!#$%&*+/=?^`_{|]%') then 0
                //                                         when(left(@EmailText,1) like('[-_.+]') or right(@EmailText,1) like('[-_.+]')) then 0
                //                                         when(@EmailText like '%[%' or @EmailText like '%]%') then 0
                //                                         when @EmailText LIKE '%@%@%' then 0
                //                                         when @EmailText NOT LIKE '_%@_%._%' then 0
                //                                         else 1
                //                                     end
                //                 RETURN @bitEmailVal
                //                 """
                //             )
                //             : throw new InvalidOperationException(
                //                 "The argument must be a constant expression."
                //             )
                // );
            }
        );
    }

    public static bool IsBot(long userId) => !GetBotToken(userId).IsEmpty;

    [DbFunction(ufn_ + nameof(GetBotToken), Schema = DataSchema.ShortName)]
    public static BotApiToken GetBotToken(long userId) => default!;

    [DbFunction(ufn_ + nameof(IsValidEmailAddress), Schema = IdentitySchema.ShortName)]
    public static bool IsValidEmailAddress(string email) => default!;

    [DbFunction(ufn_ + nameof(IsValidPhoneNumber), Schema = IdentitySchema.ShortName)]
    public static bool IsValidPhoneNumber(string phoneNumber) => default!;

    [DbFunction(ufn_ + nameof(IsValidGender), Schema = IdentitySchema.ShortName)]
    public static bool IsValidGender(string gender) => default!;

    [DbFunction(ufn_ + nameof(IsValidUri), Schema = IdentitySchema.ShortName)]
    public static bool IsValidUri(string uri) => default!;

    [DbFunction(ufn_ + nameof(IsValidUrn), Schema = IdentitySchema.ShortName)]
    public static bool IsValidUrn(string urn) => default!;

    [DbFunction(ufn_ + nameof(IsValidUrl), Schema = IdentitySchema.ShortName)]
    public static bool IsValidUrl(string url) => default!;

    [DbFunction(ufn_ + nameof(IsValidObjectId), Schema = IdentitySchema.ShortName)]
    public static bool IsValidObjectId(string objectId) => default!;
}

public class IdentityDbContext
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
    >
{
    public IdentityDbContext(DbContextOptions options)
        : base(options) { }
}
