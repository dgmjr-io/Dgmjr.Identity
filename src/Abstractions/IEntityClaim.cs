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

namespace Dgmjr.Identity.Abstractions;

public interface IEntityClaim<TSelf, TEntity, TKey> : IIdentityEntity<TKey>
    where TSelf : IEntityClaim<TSelf, TEntity, TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    [Hashids]
    TKey EntityId { get; set; }

    TEntity Entity { get; set; }

    string? Value { get; set; }

    [StringLength(UriMaxLength, MinimumLength = 1)]
    [Required]
    [Url] [DefaultValue(DgmjrCt.DgmjrClaims.UriString)] uri Type { get; set; }

    [StringLength(UriMaxLength, MinimumLength = 1)]
    [Required]
    [Url]
    [DefaultValue(ClaimValueTypes.String.UriString)]
    uri ValueType
    {
        get;
        set;
    }

    [StringLength(UriMaxLength, MinimumLength = 1)]
    [Required]
    [Url] [DefaultValue(DgmjrCt.DgmjrClaims.BaseUri)] uri Issuer { get; set; }

    [StringLength(UriMaxLength, MinimumLength = 1)]
    [Required]
    [Url]
    [DefaultValue(DgmjrCt.DgmjrClaims.BaseUri)]
    uri OriginalIssuer
    {
        get;
        set;
    }

    [DefaultValue("{}")] IStringDictionary Properties { get; set; }

    C ToClaim();
    void InitializeFromClaim(C? claim);
}
