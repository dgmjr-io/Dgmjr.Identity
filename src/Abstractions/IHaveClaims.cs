/*
 * IHaveClaims.cs
 *
 *   Created: 2023-03-19-03:04:18
 *   Modified: 2023-10-10-09:28:42
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IHaveClaims<TKey> : IHaveClaims { }

public interface IHaveClaims : IIdentityEntity
{
    /// <summary>Gets or sets the claims associated with the entity.</summary>
    /// <value>The claims associated with the entity.</value>
    [NotMapped]
    ICollection<C> Claims { get; }
}
