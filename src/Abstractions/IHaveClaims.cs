/*
 * IBackroomUser.cs
 *
 *   Created: 2022-12-01-04:51:41
 *   Modified: 2022-12-03-01:45:50
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IHaveClaims<TKey> : IIdentityEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>Gets or sets the claims associated with the user.</summary>
    /// <value>The claims associated with the user.</value>
    ICollection<C> Claims { get; set; }
}

public interface IHaveUserClaims<TKey> : IIdentifiable<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    ICollection<IIdentityUserClaim<TKey>> Claims { get; set; }
}
