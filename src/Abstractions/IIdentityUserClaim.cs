using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dgmjr.Identity.Abstractions;

public interface IIdentityUserClaim<TKey>
    : IEntityClaim<IIdentityUserClaim<TKey>, TKey>,
        IUserAssociatedEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable { }
