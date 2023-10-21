namespace Dgmjr.Identity.Abstractions;

public interface IIdentityClaimIssuer<TKey, TUser, TRole, TUserClaim, TRoleClaim>
    : IIdentityEntity<TKey>,
        IHaveAName
    where TKey : IEquatable<TKey>, IComparable
    where TUser : IIdentityUser<TKey, TUser, TRole>
    where TRole : IIdentityRole<TKey, TUser, TRole>
    where TUserClaim : IEntityClaim<TUserClaim, TUser, TKey>
    where TRoleClaim : IEntityClaim<TRoleClaim, TRole, TKey>
{
    uri Uri { get; set; }
    ICollection<TUser> Users { get; }
    ICollection<TRole> Roles { get; }
    ICollection<TUserClaim> UserClaims { get; }
    ICollection<TRoleClaim> RoleClaims { get; }
}

public interface IIdentityClaimIssuer
    : IIdentityClaimIssuer<
        long,
        IIdentityUser,
        IIdentityRole,
        IIdentityUserClaim,
        IIdentityRoleClaim
    >
{ }
