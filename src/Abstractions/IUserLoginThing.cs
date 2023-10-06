using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace Dgmjr.Identity.Abstractions;

public interface IUserLoginThing<TKey> : IUserAssociatedEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    int ProviderId { get; set; }
    string ProviderName { get; set; }
}
