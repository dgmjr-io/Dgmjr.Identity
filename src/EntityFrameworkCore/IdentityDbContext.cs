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
using System.Domain;
using System.Net.Mail;
using Dgmjr.EntityFrameworkCore;
using Dgmjr.Identity.Abstractions;
using Dgmjr.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Bot.Types;
using static Dgmjr.EntityFrameworkCore.DbSchemas;
using static Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using MSID = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
> : DbContext, IDbContext, IIdentityDbContext, IDbContext<IIdentityDbContext>
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
    where TClaimType : class, IIdentityClaimType<TKey, TUser, TRole, TClaimType, TClaimValueType>
    where TClaimValueType : class,
        IIdentityClaimValueType<TKey, TUser, TRole, TClaimType, TClaimValueType>
{
    // public virtual DbSet<UserContactId> UserContactIds { get; set; }
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

    public IdentityDbContext(
        DbContextOptions<
            IdentityDbContext<
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
        > options
    )
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<TUser>(builder =>
        {
            builder.ToTable(
                TableNames.User,
                IdentitySchema.ShortName //,
            // tb =>
            //     tb.HasCheckConstraint(
            //         "CK_EmailAddress",
            //         $"{nameof(AppUser.EmailAddress)} IS NULL OR {nameof(AppUser.EmailAddress)} LIKE '{EmailAddress.RegexString}'"
            //     )
            );
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.HasKey(e => e.Id);
            builder.ConfigureEmailAddress(e => e.EmailAddress);
            builder.ConfigurePhoneNumber(e => e.PhoneNumber);
            // builder.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();
            builder.Ignore(e => e.ConcurrencyStamp);
            builder.Property(e => e.EmailAddress).HasMaxLength(256);
            builder
                .Property(e => e.IsLockedOut)
                .HasComputedColumnSql(
                    $"{nameof(AppUser.LockoutEnd)} IS NOT NULL AND {nameof(AppUser.LockoutEnd)} > GetUtcDate()"
                );
            builder.HasIndex(e => e.EmailAddress);
            builder.HasIndex(e => e.Username);
            builder.HasIndex(e => e.TelegramUsername);
            builder.HasIndex(e => e.NormalizedEmailAddress);
            builder.HasIndex(e => e.NormalizedUsername);
            builder.Property(e => e.TelegramUsername).IsUnicode(false);
            builder.Property(e => e.SecurityStamp).HasDefaultValueSql("NewId()");
            builder.Property(e => e.ConcurrencyStamp).HasDefaultValueSql("NewId()");
            builder.Property(e => e.IsTwoFactorEnabled).HasDefaultValueSql("0");
            builder.Property(e => e.IsLockoutEnabled).HasDefaultValueSql("1");
            builder.Property(e => e.IsEmailConfirmed).HasDefaultValueSql("0");
            builder.Property(e => e.IsPhoneNumberConfirmed).HasDefaultValueSql("0");
            builder
                .Property(e => e.LockoutEnd)
                .HasDefaultValueSql(
                    $"CONVERT(datetimeoffset, '{AppUser.DefaultLockoutEnd.ToString()}')"
                )
                .HasColumnType(SqlDateTimeOffset.ShortName);
            builder.Property(e => e.PhoneNumber).IsUnicode(false);
            builder.Ignore(e => e.NormalizedEmailAddress);
            builder
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .HasPrincipalKey(e => e.Id);
            builder.HasMany(
                e => e.Roles
            )
            /*.WithMany(r => r.Users)
            .UsingEntity<TUserRole>(
                ur =>
                    ur.HasOne(ur => ur.Role)
                        .WithMany()
                        .HasForeignKey(ur => ur.RoleId)
                        .HasPrincipalKey(r => r.Id),
                ur =>
                    ur.HasOne(ur => ur.User)
                        .WithMany()
                        .HasForeignKey(ur => ur.UserId)
                        .HasPrincipalKey(u => u.Id),
                ur => ur.HasKey(ur => ur.Id)
            )*/;
        });
        builder.Entity<TRole>(builder =>
        {
            builder.ToTable(
                TableNames.Role,
                IdentitySchema.ShortName /*,
                tb =>
                {
                    tb.IsMemoryOptimized();
                    tb.IsTemporal();
                    tb.HasComment("The Roles table contains the roles for the application.");
                }*/
            );
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();
            // builder.Property(e => e.Name).HasMaxLength(256);
            // builder.Property(e => e.NormalizedName).HasMaxLength(256);
            // builder.HasIndex(e => e.NormalizedName).IsUnique().HasName("RoleNameIndex").HasFilter("[NormalizedName] IS NOT NULL");
            builder.Property(e => e.Uri).HasConversion<System.uri.EfCoreValueConverter>();
            builder.HasMany(
                e => e.Users
            ) /*
                .WithMany(u => u.Roles)
                .UsingEntity<TUserRole>(
                    ur =>
                        ur.HasOne(ur => ur.User)
                            .WithMany(u => u.UserRoles)
                            .HasForeignKey(ur => ur.UserId)
                            .HasPrincipalKey(u => u.Id),
                    ur =>
                        ur.HasOne(ur => ur.Role)
                            .WithMany(r => r.UserRoles)
                            .HasForeignKey(ur => ur.RoleId)
                            .HasPrincipalKey(r => r.Id),
                    ur => ur.HasKey(ur => ur.Id)
                )*/
            ;
        });
        builder.Entity<TUserLogin>(builder =>
        {
            builder.ToTable(
                TableNames.UserLogin,
                IdentitySchema.ShortName /*, tb => IsTemporal() */
            );
            builder.HasKey(e => e.Id);
            builder
                .HasOne(e => e.User)
                .WithMany(u => u.Logins)
                .HasForeignKey(e => e.UserId)
                .HasPrincipalKey(e => e.Id);
            // builder
            //     .HasOne(e => e.Provider)
            //     .WithMany()
            //     .HasForeignKey(e => e.ProviderId)
            //     .HasPrincipalKey(e => e.Id);
        });
        builder.Entity<TRoleClaim>(builder =>
        {
            builder.ToTable(
                TableNames.RoleClaim,
                IdentitySchema.ShortName /*, tb => IsTemporal() */
            );
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder
                .Property(e => e.Properties)
                .HasConversion<JsonObjectConverter<IStringDictionary>>();
            builder.Property(e => e.Type).HasConversion<uri.EfCoreValueConverter>();
            builder.Property(e => e.Issuer).HasConversion<uri.EfCoreValueConverter>();
            builder.Property(e => e.OriginalIssuer).HasConversion<uri.EfCoreValueConverter>();
            builder.Property(e => e.ValueType).HasConversion<uri.EfCoreValueConverter>();
            builder
                .HasOne(e => e.Role)
                .WithMany()
                .HasForeignKey(e => e.RoleId)
                .HasPrincipalKey(e => e.Id);
        });
        builder.Entity<TUserToken>(builder =>
        {
            builder.ToTable(
                TableNames.UserToken,
                IdentitySchema.ShortName /*, tb => IsTemporal()*/
            );
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder
                .HasOne(e => e.User)
                .WithMany(u => u.Tokens)
                .HasForeignKey(e => e.UserId)
                .HasPrincipalKey(e => e.Id);
        });
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
        builder.Entity<TClaimType>(builder =>
        {
            builder.ToTable(
                TableNames.ClaimType,
                IdentitySchema.ShortName /*, tb => IsTemporal() */
            );
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsUnicode(false);
            builder.Property(e => e.Uri).IsUnicode(false).HasConversion<uri.EfCoreValueConverter>();
            // builder.HasMany(e => e.Users).WithMany(u => u.ClaimTypes).UsingEntity<UserClaim>(
            //     uc => uc.HasOne(uc => uc.User).WithMany().HasForeignKey(uc => uc.UserId).HasPrincipalKey(u => u.Id),
            //     uc => uc.HasOne<IdentityClaimType>("ClaimType").WithMany().HasForeignKey<int>("ClaimTypeId").HasPrincipalKey(ct => ct.Id
            //     uc => uc.HasKey(uc => new { uc.UserId, uc.ClaimTypeId })
            // );
            // builder.HasMany(e => e.Roles).WithMany().UsingEntity<RoleClaim>();
        });
        builder.Entity<TClaimValueType>(builder =>
        {
            builder.ToTable(
                TableNames.ClaimValueType,
                IdentitySchema.ShortName /*, tb => IsTemporal() */
            );
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsUnicode(false);
            builder.Property(e => e.Uri).IsUnicode(false).HasConversion<uri.EfCoreValueConverter>();
            // builder.HasMany(e => e.Users).WithMany(u => u.ClaimTypes).UsingEntity<UserClaim>(
            //     uc => uc.HasOne(uc => uc.User).WithMany().HasForeignKey(uc => uc.UserId).HasPrincipalKey(u => u.Id),
            //     uc => uc.HasOne<IdentityClaimType>("ClaimType").WithMany().HasForeignKey<int>("ClaimTypeId").HasPrincipalKey(ct => ct.Id
            //     uc => uc.HasKey(uc => new { uc.UserId, uc.ClaimTypeId })
            // );
            // builder.HasMany(e => e.Roles).WithMany().UsingEntity<RoleClaim>();
        });
    }

    // public override DbSet<TEntity> Set<TEntity>()
    // {
    //     return typeof(TEntity) switch
    //     {
    //         var t when t == typeof(UserClaim)
    //             => (
    //                 UserClaims.Include(uc => uc.ClaimType) as DbSet<TEntity>
    //                 ?? UserClaims as DbSet<TEntity>
    //             ) as DbSet<TEntity>,
    //         var t when t == typeof(User)
    //             => Users.Include(u => u.Roles).Include(u => u.Claims) as DbSet<TEntity>
    //                 ?? Users as DbSet<TEntity>,
    //         var t when t == typeof(UserRole) => UserRoles as DbSet<TEntity>,
    //         var t when t == typeof(Role) => Roles.Include(r => r.Users) as DbSet<TEntity>,
    //         var t when t == typeof(RoleClaim)
    //             => RoleClaims.Include(rc => rc.ClaimType) as DbSet<TEntity>,
    //         var t when t == typeof(UserLogin) => UserLogins as DbSet<TEntity>,
    //         var t when t == typeof(UserToken) => UserTokens as DbSet<TEntity>,
    //         // var t when t == typeof(Bot) => Bots as DbSet<TEntity>,
    //         // var t when t == typeof(UserContactId) => UserContactIds as DbSet<TEntity>,
    //         _ => base.Set<TEntity>()
    //     };
    // }
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
    public IdentityDbContext(
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
        : base(options) { }
}
