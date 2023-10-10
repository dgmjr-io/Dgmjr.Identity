using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Dgmjr.Identity.Abstractions;

public interface IUserLoginEntity<TKey> : IUserAssociatedEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the login provider ID
    /// </summary>
    int ProviderId { get; set; }
    string ProviderName { get; }
    string ProviderDisplayName { get; }
}
