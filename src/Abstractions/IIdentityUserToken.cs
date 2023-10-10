namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserToken<TKey> : IUserLoginEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the name of the token.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the token value.
    /// </summary>
    [ProtectedPersonalData]
    string? Value { get; set; }
}
