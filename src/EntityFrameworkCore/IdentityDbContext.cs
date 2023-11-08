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

public class IdentityDbContext<TUser, TRole> : DbContext, IDbContext {
  public IdentityDbContext(
      DbContextOptions<IdentityDbContext<TUser, TRole>> options)
      : base(options) {}

  public IdentityDbContext(DbContextOptions options) : base(options) {}
}

// [GenerateInterface]
public class IdentityDbContext<TUser, TRole, TKey, TUserClaim, TUserRole,
                               TUserLogin, TRoleClaim, TUserToken, TClaimType,
                               TClaimValueType>
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
                       IIdentityUserClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserRole : class,
                      IIdentityUserRole<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserLogin : class,
                       IIdentityUserLogin<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TRoleClaim : class,
                       IIdentityRoleClaim<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TUserToken : class,
                       IIdentityUserToken<TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken>
    where TClaimType : class,
                       IIdentityClaimType<TKey, TUser, TRole, TClaimType, TClaimValueType>,
                       IHaveAName
    where TClaimValueType : class,
                            IIdentityClaimValueType<TKey, TUser, TRole, TClaimType, TClaimValueType> {
  public IdentityDbContext(DbContextOptions options) : base(options) {}

  public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
      : base(options) {}

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

  protected override void
  OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    optionsBuilder.EnableSensitiveDataLogging()
        .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
        .EnableDetailedErrors()
        .ConfigureWarnings(
            _ => {})
        .UseSqlServer(options => {
          options.MigrationsAssembly(
              typeof(IdentityDbContext).Assembly.FullName);
          options.EnableRetryOnFailure();
        });
    base.OnConfiguring(optionsBuilder);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfiguration<AppUserConfiguration, AppUser>();
    modelBuilder.ApplyConfiguration<AppRoleConfiguration, AppRole>();
    modelBuilder.ApplyConfiguration<AppUserClaimConfiguration, AppUserClaim>();
    modelBuilder.ApplyConfiguration<AppUserLoginConfiguration, AppUserLogin>();
    modelBuilder.ApplyConfiguration<AppRoleClaimConfiguration, AppRoleClaim>();
    modelBuilder.ApplyConfiguration<AppUserTokenConfiguration, AppUserToken>();
    modelBuilder.ApplyConfiguration<AppClaimTypeConfiguration, AppClaimType>();
    modelBuilder.ApplyConfiguration<AppClaimValueTypeConfiguration,
                                    AppClaimValueType>();
    modelBuilder.ApplyConfiguration<AppUserRoleConfiguration, AppUserRole>();
    // builder.Entity<Bot>(builder
    // {
    //     builder.Property(e => e.Id).ValueGeneratedOnAdd();
    //     builder.Property(e =>
    //     e.ApiToken).HasConversion<BotApiToken.EfCoreValueConverter>();
    //     builder.Property(e =>
    //     e.SendPulseId).HasConversion<ObjectId.EfCoreValueConverter>();
    // });
    // builder.Entity<UserContactId>(builder =>
    // {
    //     builder.Property(e =>
    //     e.ContactId).HasConversion<ObjectId.EfCoreValueConverter>();
    // });
    // builder.HasMany(e => e.Users).WithMany(u =>
    // u.ClaimTypes).UsingEntity<AppUserClaim>(
    //     uc => uc.HasOne(uc => uc.User).WithMany().HasForeignKey(uc =>
    //     uc.UserId).HasPrincipalKey(u => u.Id), uc =>
    //     uc.HasOne<IdentityClaimType>("ClaimType").WithMany().HasForeignKey<int>("ClaimTypeId").HasPrincipalKey(ct
    //     => ct.Id uc => uc.HasKey(uc => new { uc.UserId, uc.ClaimTypeId })
    // );
    // builder.HasMany(e => e.Roles).WithMany().UsingEntity<RoleClaim>();
  }

  [DbFunction(ufn_ + nameof(IsBot), Schema = IdentitySchema.ShortName)]
  public virtual bool IsBot(long userId) => !GetBotToken(userId).IsEmpty;

  public virtual BotApiToken
  GetBotToken(long userId) => BotApiToken.TryParse(ufn_GetBotToken(userId),
                                                   out var botToken)
                                  ? botToken.Value
                                  : default!;

  [DbFunction(nameof(ufn_GetBotToken), Schema = DataSchema.ShortName)]
  public virtual string ufn_GetBotToken(
      long userId) => UserClaims
                          .FirstOrDefault(
                              u => u.Type.Equals(Telegram.Identity.ClaimTypes
                                                     .BotApiToken.UriString) &&
                                   u.UserId.Equals(userId.ToString()))
                          ?.Value
                      ?? string.Empty;

  [DbFunction(nameof(ufn_GetBotToken), Schema = DataSchema.ShortName)]
  public virtual bool
  IsValidBotToken(string token) => BotApiToken.TryParse(token, out _);

  [DbFunction(ufn_ + nameof(IsValidEmailAddress),
              Schema = IdentitySchema.ShortName)]
  public virtual bool
  IsValidEmailAddress(string email) => EmailAddress.TryParse(email, out _);

  [DbFunction(ufn_ + nameof(IsValidPhoneNumber),
              Schema = IdentitySchema.ShortName)]
  public virtual bool
  IsValidPhoneNumber(string phoneNumber) => PhoneNumber.TryParse(phoneNumber,
                                                                 out _);

  [DbFunction(ufn_ + nameof(IsValidGender), Schema = IdentitySchema.ShortName)]
  public virtual bool IsValidGender(string gender) => Gender.TryParse(gender,
                                                                      out _);

  [DbFunction(ufn_ + nameof(IsUri), Schema = IdentitySchema.ShortName)]
  public virtual bool IsUri(string uri) => System.uri.TryParse(uri, out _);

  [DbFunction(ufn_ + nameof(IsUrn), Schema = IdentitySchema.ShortName)]
  public virtual bool IsUrn(string urn) => System.urn.TryParse(urn, out _);

  [DbFunction(ufn_ + nameof(IsUrl), Schema = IdentitySchema.ShortName)]
  public virtual bool IsUrl(string url) => System.url.TryParse(url, out _);

  [DbFunction(ufn_ + nameof(IsValidObjectId),
              Schema = IdentitySchema.ShortName)]
  public virtual bool
  IsValidObjectId(string objectId) => ObjectId.TryParse(objectId, out _);
}

public class IdentityDbContext
    : IdentityDbContext<AppUser, AppRole, long, AppUserClaim, AppUserRole,
                        AppUserLogin, AppRoleClaim, AppUserToken, AppClaimType,
                        AppClaimValueType> {
  public IdentityDbContext(DbContextOptions options) : base(options) {}
}
