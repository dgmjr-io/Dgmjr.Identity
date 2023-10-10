namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserLogin<TKey> : IUserLoginEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the unique provider identifier for this login.
    /// </summary>
    string ProviderKey { get; set; }
}
