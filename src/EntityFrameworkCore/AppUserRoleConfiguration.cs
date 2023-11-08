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

public class AppUserRoleConfiguration<
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
    > : IEntityTypeConfiguration<TUserRole>
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
    public void Configure(EntityTypeBuilder<TUserRole> builder)
    {
        builder.ToTable(UserRole, IdentitySchema.ShortName, tb => tb.IsTemporal());
        builder.HasKey(e => e.Id).HasName(pk_ + UserRole);
        // builder
        //     .HasOne(e => e.User)
        //     .WithMany(e => e.Roles)
        //     .HasForeignKey(e => e.UserId)
        //     .HasPrincipalKey(e => e.Id);
        // builder
        //     .HasOne(e => e.Role)
        //     .WithMany(e => e.Users)
        //     .HasForeignKey(e => e.RoleId)
        //     .HasPrincipalKey(e => e.Id);
    }
}

public class AppUserRoleConfiguration
    : AppUserRoleConfiguration<
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
