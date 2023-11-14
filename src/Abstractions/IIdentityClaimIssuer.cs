namespace Dgmjr.Identity.Abstractions;

public interface IIdentityClaimsIssuer<TKey, TUserClaim, TRoleClaim>
    : IIdentityEntity<TKey>,
        IHaveAName,
        IHaveADescription
    where TKey : IEquatable<TKey>, IComparable
    where TUserClaim : IEntityClaimBase<TKey>
    where TRoleClaim : IEntityClaimBase<TKey>
{
    uri Uri { get; set; }
    ICollection<TUserClaim> UserClaims { get; }
    ICollection<TRoleClaim> RoleClaims { get; }
}

public interface IIdentityClaimIssuer
    : IIdentityClaimsIssuer<long, IIdentityUserClaim, IIdentityRoleClaim> { }
