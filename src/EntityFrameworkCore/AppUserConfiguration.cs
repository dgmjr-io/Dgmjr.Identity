namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using static Dgmjr.Identity.EntityFrameworkCore.Constants;
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
        builder.Property(e => e.SecurityStamp).HasDefaultValueSql("NewId()");
        builder.Property(e => e.ConcurrencyStamp).HasDefaultValueSql("NewId()");
        builder.Property(e => e.IsTwoFactorEnabled).HasDefaultValueSql("0");
        builder.Property(e => e.IsLockoutEnabled).HasDefaultValueSql("1");
        builder.Property(e => e.IsEmailConfirmed).HasDefaultValueSql("0");
        builder.Property(e => e.IsPhoneNumberConfirmed).HasDefaultValueSql("0");
        builder
            .Property(e => e.LockoutEnd)
            .HasDefaultValueSql(AppUser.DefaultLockoutEnd.ToString());
        builder.Ignore(e => e.EmailAddress);
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
