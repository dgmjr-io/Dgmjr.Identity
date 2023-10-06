/*
 * IUserClaim.cs
 *
 *   Created: 2022-12-23-06:21:08
 *   Modified: 2022-12-23-06:21:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

using static Dgmjr.EntityFrameworkCore.Constants.DbTypeNames;

public interface IEntityClaim<TSelf, TKey> : IIdentifiable<TKey>
    where TSelf : IEntityClaim<TSelf, TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    TKey EntityId { get; set; }
    string? Value { get; set; }

    uri? Type { get; set; }
    uri? ValueType { get; set; }
    uri? Issuer { get; set; }
    uri? OriginalIssuer { get; set; }
    IStringDictionary Properties { get; set; }

    C ToClaim();
    void InitializeFromClaim(C? claim);
}
