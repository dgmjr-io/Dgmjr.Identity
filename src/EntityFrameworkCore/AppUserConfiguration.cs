namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

using Telegram.Bot.Types;

public class AppUserConfiguration<
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
> : IEntityTypeConfiguration<TUser>
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
    public void Configure(EntityTypeBuilder<TUser> builder)
    {
        builder.ToTable(
            TableNames.User,
            IdentitySchema.ShortName,
            tb =>
            {
                // tb.HasCheckConstraint(
                //     CK_ + nameof(AppUser.EmailAddress),
                //     $"[data].{ufn_ + nameof(IdentityDbContext.IsValidEmailAddress)}([{nameof(AppUser.TelegramUsername)}]) = 1)"
                // );
                // tb.HasCheckConstraint(
                //     CK_ + nameof(AppUser.PhoneNumber),
                //     $"[{nameof(AppUser.PhoneNumber)}] IS NULL OR [{nameof(AppUser.PhoneNumber)}] LIKE '+%'"
                // );
                // tb.HasCheckConstraint(
                //     CK_ + nameof(AppUser.TelegramUsername),
                //     $"""
                //     [{nameof(AppUser.TelegramUsername)}] IS NULL
                //     OR (
                //             len([{nameof(AppUser.TelegramUsername)}]) >= {Account.UsernameMinLength}
                //             AND len([{nameof(AppUser.TelegramUsername)}]) <= ({Account.UsernameMaxLength} + 1)
                //             AND [{nameof(AppUser.TelegramUsername)}] LIKE '@%'
                //         )
                //     """
                // );
                // tb.HasCheckConstraint(
                //     CK_ + nameof(AppUser.Gender),
                //     $"{ufn_ + nameof(IdentityDbContext.IsValidGender)}({nameof(AppUser.Gender)}) = 1"
                // );
                tb.IsTemporal();
            }
        );
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.HasKey(e => e.Id).HasName(pk_ + TableNames.User);
        builder.EmailAddressProperty(e => e.EmailAddress);
        builder.PhoneNumberProperty(e => e.PhoneNumber);
        builder
            .Property(e => e.IsLockedOut)
            .HasComputedColumnSql(
                $"cast(CASE WHEN {nameof(AppUser.LockoutEnd)} IS NOT NULL AND {nameof(AppUser.LockoutEnd)} > GetUtcDate() THEN 1 ELSE 0 END as bit)"
            );
        builder
            .HasIndex(e => e.EmailAddress)
            .HasDatabaseName(ix_ + TableNames.User + IdentityConstants.User.Columns.EmailAddress);
        builder
            .HasIndex(e => e.Username)
            .HasDatabaseName(ix_ + TableNames.User + IdentityConstants.User.Columns.Username);
        builder
            .HasIndex(e => e.TelegramUsername)
            .HasDatabaseName(
                ix_ + TableNames.User + IdentityConstants.User.Columns.TelegramUsername
            );
        builder
            .Property(e => e.TelegramUsername)
            .HasMaxLength(Account.UsernameMaxLength)
            .IsUnicode(false);
        builder
            .HasIndex(e => e.NormalizedEmailAddress)
            .HasDatabaseName(ix_ + TableNames.User + nameof(AppUser.NormalizedEmailAddress));
        builder
            .HasIndex(e => e.NormalizedUsername)
            .HasDatabaseName(
                ix_ + TableNames.User + IdentityConstants.User.Columns.NormalizedUsername
            );
        builder
            .Property<byte[]>(IdentityConstants.User.Columns.ConcurrencyStamp)
            .HasColumnType(RowVersion.ShortName)
            .IsRowVersion();
        builder
            .HasMany(e => e.Roles)
            .WithMany(e => e.Users)
            .UsingEntity<TUserRole>(
                ur =>
                    ur.HasOne(ur => ur.Role)
                        .WithMany(e => e.UserRoles)
                        .HasForeignKey(ur => ur.RoleId)
                        .HasPrincipalKey(r => r.Id),
                ur =>
                    ur.HasOne(ur => ur.User)
                        .WithMany(e => e.UserRoles)
                        .HasForeignKey(ur => ur.UserId)
                        .HasPrincipalKey(u => u.Id),
                ur => ur.HasKey(ur => ur.Id)
            );
        builder.Property(e => e.IsTwoFactorEnabled).HasDefaultValueSql("0");
        builder.Property(e => e.IsLockoutEnabled).HasDefaultValueSql("1");
        builder.Property(e => e.IsEmailConfirmed).HasDefaultValueSql("0");
        builder.Property(e => e.IsPhoneNumberConfirmed).HasDefaultValueSql("0");
        builder.GenderProperty(e => e.Gender);
        builder.Property(e => e.LockoutEnd).HasDefaultValueSql($"'{AppUser.DefaultLockoutEnd}'");
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
    }
}

public class AppUserConfiguration
    : AppUserConfiguration<
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
