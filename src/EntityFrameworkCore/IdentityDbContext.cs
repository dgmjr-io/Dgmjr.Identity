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

using System.Net.Mail;
using Dgmjr.EntityFrameworkCore;
using Dgmjr.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Bot.Types;
using static Dgmjr.EntityFrameworkCore.Constants.Schemas;
using static Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using IdentityClaimType = Dgmjr.Identity.Models.ClaimType;
using MSID = Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RoleModel = Dgmjr.Identity.Models.Role;
using UserModel = Dgmjr.Identity.Models.User;
using User = Dgmjr.Identity.Models.User;

public class IdentityDbContext : MSID.IdentityDbContext<User, RoleModel, long, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, IIdentityDbContext, IDbContext<IIdentityDbContext>
{
    // public virtual DbSet<UserContactId> UserContactIds { get; set; }
    public virtual DbSet<Dgmjr.Identity.Models.User> Users { get; set; }
    public virtual DbSet<RoleModel> Roles { get; set; }
    public virtual DbSet<Dgmjr.Identity.Models.UserClaim> UserClaims { get; set; }
    public virtual DbSet<Dgmjr.Identity.Models.UserRole> UserRoles { get; set; }
    public virtual DbSet<Dgmjr.Identity.Models.UserLogin> UserLogins { get; set; }
    public virtual DbSet<Dgmjr.Identity.Models.RoleClaim> RoleClaims { get; set; }
    public virtual DbSet<Dgmjr.Identity.Models.UserToken> UserTokens { get; set; }

    static string DefaultConnectionStringConfigurationKey => "IdentityDb";

    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>(entity =>
        {
            entity.ToTable(TableNames.User, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasKey(e => e.Id);
            // entity.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();
            entity.Ignore(e => e.ConcurrencyStamp);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Ignore(e => e.EmailAddress);
            entity.Ignore(e => e.NormalizedEmailAddress);
            // entity.Property(e => e.Phone).HasConversion<System.Domain.PhoneNumber.EfCoreValueConverter>();
            // entity.HasMany(u => u.Bots).WithMany(b => b.Contacts).UsingEntity<UserContactId>(
            //     uc => uc.HasOne(uc => uc.Bot).WithMany(bot => bot.ContactIds).HasForeignKey(uc => uc.BotId),
            //     uc => uc.HasOne(uc => uc.User).WithMany(user => user.ContactIds).HasForeignKey(uc => uc.UserId),
            //     uc => uc.HasKey(uc => new { uc.UserId, uc.BotId })
            // );
            // // entity.Property(e => e.SendPulseId).HasConversion<SendPulse.Data.ValueObjects.SendPulseIdConverter>();
            // entity.HasIndex(e => e.NormalizedEmail)/*.HasName("EmailIndex")*/;
            // entity.HasIndex(e => e.NormalizedUserName).IsUnique()/*.HasName("UserNameIndex").HasFilter("[NormalizedUserName] IS NOT NULL")*/;
        });
        builder.Entity<RoleModel>(entity =>
        {
            entity.ToTable(TableNames.Role, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ConcurrencyStamp).IsConcurrencyToken();
            // entity.Property(e => e.Name).HasMaxLength(256);
            // entity.Property(e => e.NormalizedName).HasMaxLength(256);
            // entity.HasIndex(e => e.NormalizedName).IsUnique().HasName("RoleNameIndex").HasFilter("[NormalizedName] IS NOT NULL");
            entity.Property(e => e.Uri).HasConversion<System.uri.EfCoreValueConverter>();
            entity.HasMany(e => e.Users).WithMany(u => u.Roles).UsingEntity<UserRole>(
                ur => ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId).HasPrincipalKey(u => u.Id),
                ur => ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId).HasPrincipalKey(r => r.Id),
                ur => ur.HasKey(ur => new { ur.UserId, ur.RoleId })
            );
        });
        builder.Entity<UserRole>(entity =>
        {
            entity.ToTable(TableNames.UserRole, IdSchema);
            entity.HasKey(e => new { e.UserId, e.RoleId });
            entity.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<UserClaim>(entity =>
        {
            entity.ToTable(TableNames.UserClaim, IdSchema,
                tb =>
                {
                    // (tb as TableBuilder).HasTrigger("SomeTrigger");
                });
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Properties).HasConversion<JsonObjectConverter<IStringDictionary>>();
            entity.Property(e => e.Type).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.Issuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.OriginalIssuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.ValueType).HasConversion<uri.EfCoreValueConverter>();
            entity.HasOne(e => e.User).WithMany(u => u.Claims).HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<UserLogin>(entity =>
        {
            entity.ToTable(TableNames.UserLogin, IdSchema);
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.ProviderDisplayName });
            entity.HasOne(e => e.User).WithMany(u => u.Logins).HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
            entity.HasOne(e => e.Provider).WithMany().HasForeignKey(e => e.ProviderId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<RoleClaim>(entity =>
        {
            entity.ToTable(TableNames.RoleClaim, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Properties).HasConversion<JsonObjectConverter<IStringDictionary>>();
            entity.Property(e => e.Type).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.Issuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.OriginalIssuer).HasConversion<uri.EfCoreValueConverter>();
            entity.Property(e => e.ValueType).HasConversion<uri.EfCoreValueConverter>();
            entity.HasOne(e => e.Role).WithMany().HasForeignKey(e => e.RoleId).HasPrincipalKey(e => e.Id);
        });
        builder.Entity<UserToken>(entity =>
        {
            entity.ToTable(TableNames.UserToken, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasOne(e => e.User).WithMany(u => u.Tokens).HasForeignKey(e => e.UserId).HasPrincipalKey(e => e.Id);
        });
        // builder.Entity<Bot>(entity =>
        // {
        //     entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //     entity.Property(e => e.ApiToken).HasConversion<BotApiToken.EfCoreValueConverter>();
        //     entity.Property(e => e.SendPulseId).HasConversion<ObjectId.EfCoreValueConverter>();
        // });
        // builder.Entity<UserContactId>(entity =>
        // {
        //     entity.Property(e => e.ContactId).HasConversion<ObjectId.EfCoreValueConverter>();
        // });
        builder.Entity<IdentityClaimType>(entity =>
        {
            entity.ToTable(TableNames.ClaimType, IdSchema);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Uri).HasConversion<uri.EfCoreValueConverter>();
            // entity.HasMany(e => e.Users).WithMany(u => u.ClaimTypes).UsingEntity<UserClaim>(
            //     uc => uc.HasOne(uc => uc.User).WithMany().HasForeignKey(uc => uc.UserId).HasPrincipalKey(u => u.Id),
            //     uc => uc.HasOne<IdentityClaimType>("ClaimType").WithMany().HasForeignKey<int>("ClaimTypeId").HasPrincipalKey(ct => ct.Id
            //     uc => uc.HasKey(uc => new { uc.UserId, uc.ClaimTypeId })
            // );
            // entity.HasMany(e => e.Roles).WithMany().UsingEntity<RoleClaim>();
        });
    }

    public override DbSet<TEntity> Set<TEntity>()
    {
        return typeof(TEntity) switch
        {
            var t when t == typeof(UserClaim) => (UserClaims.Include(uc => uc.ClaimType) as DbSet<TEntity> ?? UserClaims as DbSet<TEntity>) as DbSet<TEntity>,
            var t when t == typeof(User) => Users.Include(u => u.Roles).Include(u => u.Claims) as DbSet<TEntity> ?? Users as DbSet<TEntity>,
            var t when t == typeof(UserRole) => UserRoles as DbSet<TEntity>,
            var t when t == typeof(Role) => Roles.Include(r => r.Users) as DbSet<TEntity>,
            var t when t == typeof(RoleClaim) => RoleClaims.Include(rc => rc.ClaimType) as DbSet<TEntity>,
            var t when t == typeof(UserLogin) => UserLogins as DbSet<TEntity>,
            var t when t == typeof(UserToken) => UserTokens as DbSet<TEntity>,
            // var t when t == typeof(Bot) => Bots as DbSet<TEntity>,
            // var t when t == typeof(UserContactId) => UserContactIds as DbSet<TEntity>,
            _ => base.Set<TEntity>()
        };
    }
}
