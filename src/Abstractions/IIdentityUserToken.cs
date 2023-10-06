namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserToken<TKey> : IUserAssociatedEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the LoginProvider this token is from.
    /// </summary>
    string LoginProvider { get; set; }

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
