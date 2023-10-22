namespace Dgmjr.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Dgmjr.EntityFrameworkCore;
using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.Abstractions;
using static Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using Dgmjr.Identity.Models;

public class AppRoleConfiguration<
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
> : IEntityTypeConfiguration<TRole>
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
    public virtual void Configure(EntityTypeBuilder<TRole> builder)
    {
        builder.ToTable(
            Dgmjr.Identity.Constants.Tables.Role,
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
    }
}

public class AppRoleConfiguration
    : AppRoleConfiguration<
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
{ }
