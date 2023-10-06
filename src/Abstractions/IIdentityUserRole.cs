namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserRole<TKey> : IUserAssociatedEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the primary key of the role that is linked to the user.
    /// </summary>
    TKey RoleId { get; set; }
}
