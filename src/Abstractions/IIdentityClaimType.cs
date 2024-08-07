namespace Dgmjr.Identity.Abstractions;

public interface IIdentityClaimType<TKey, TUser, TRole, TClaimType, TClaimValue>
    : IIdentityEntity<TKey>,
        IHaveAName,
        IHaveADescription
    where TKey : IEquatable<TKey>, IComparable
    where TClaimType : IIdentityClaimType<TKey, TUser, TRole, TClaimType, TClaimValue>
    where TClaimValue : IIdentityClaimValueType<TKey, TUser, TRole, TClaimType, TClaimValue>
    where TUser : IIdentityUser<TKey, TUser, TRole>
    where TRole : IIdentityRole<TKey, TUser, TRole>
{
    uri Uri { get; }
    string? Example { get; }
    string? Default { get; }
    uri ValueTypeUri { get; set; }
    TClaimValue ValueType { get; set; }
}

public interface IIdentityClaimType
    : IIdentityClaimType<
        long,
        IIdentityUser,
        IIdentityRole,
        IIdentityClaimType,
        IIdentityClaimValueType
    >
{ }
