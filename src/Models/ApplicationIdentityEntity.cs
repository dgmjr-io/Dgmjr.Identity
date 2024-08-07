using System.ComponentModel;
/*
 * ApplicationIdentityEntity.cs
 *
 *   Created: 2023-55-29T23:55:16-04:00
 *   Modified: 2023-55-29T23:55:16-04:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;

using Dgmjr.Identity.Abstractions;

namespace Dgmjr.Identity.Models;

public abstract class ApplicationIdentityEntity<TKey> : IIdentityEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    [Key, DbGen(DbGen.Identity), Column(nameof(Id), TypeName = BigInt.ShortName), Required]
    public TKey Id { get; set; } = default!;

    object IIdentifiable.Id => Id;

    public override int GetHashCode() => HashCode.Combine(GetType(), Id);

    public override bool Equals(object? obj) => obj is IEntity<TKey> entity && Equals(entity);

    public virtual bool Equals(IEntity<TKey>? other) =>
        ((other?.GetType().IsInstanceOfType(this) == true) || GetType().IsInstanceOfType(other))
        && Id.Equals(other.Id);

    public virtual DateTimeOffset Created { get; } = DateTimeOffset.Now;
    public virtual DateTimeOffset? Deleted { get; set; }

    [Projectable]
    public virtual bool IsDeleted => Deleted < DateTimeOffset.Now;
}
