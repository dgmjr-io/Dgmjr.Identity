using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dgmjr.Identity.Abstractions;

public interface IIdentityRoleClaim<TKey> : IEntityClaim<IIdentityRoleClaim<TKey>, TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    TKey RoleId { get; set; }
}
