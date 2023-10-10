/*
 * IUserAssociatedEntity.cs
 *
 *   Created: 2022-12-01-04:51:41
 *   Modified: 2022-12-03-01:45:05
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IUserAssociatedEntity<TKey> : IIdentityEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    TKey UserId { get; set; }
}
