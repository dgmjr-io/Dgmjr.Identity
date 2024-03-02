/*
 * IEntityClaim.cs
 *
 *   Created: 2023-03-19-03:04:18
 *   Modified: 2023-10-10-09:29:37
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Collections.Generic;

namespace Dgmjr.Identity.Abstractions;

public interface IEntityClaim<TSelf, TEntity, TKey, TClaimType, TClaimValueType>
    : IEntityClaim<TSelf, TEntity, TKey>
    where TSelf : IEntityClaim<TSelf, TEntity, TKey, TClaimType, TClaimValueType>
    where TKey : IEquatable<TKey>, IComparable
{
    TClaimType ClaimType { get; set; }

    TClaimValueType ClaimValueType { get; set; }
}

public interface IEntityClaim<TSelf, TEntity, TKey> : IIdentityEntity<TKey>, IEntityClaimBase<TKey>
    where TSelf : IEntityClaim<TSelf, TEntity, TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    TEntity Entity { get; set; }
}
