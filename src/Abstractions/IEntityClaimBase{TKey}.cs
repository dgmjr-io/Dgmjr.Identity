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

public interface IEntityClaimBase<TKey> : IIdentityEntity<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    [Hashids]
    TKey EntityId { get; set; }
    string? Value { get; set; }

    [StringLength(
        Dgmjr.EntityFrameworkCore.Constants.UriMaxLengthConstant.UriMaxLength,
        MinimumLength = 1
    )]
    [Required]
    [Url]
    [DefaultValue(DgmjrCt.DgmjrClaims.UriString)]
    uri Type { get; set; }

    [StringLength(
        Dgmjr.EntityFrameworkCore.Constants.UriMaxLengthConstant.UriMaxLength,
        MinimumLength = 1
    )]
    [Required]
    [Url]
    [DefaultValue(DgmjrCt.DgmjrClaims.UriString)]
    uri ValueType { get; set; }

    [StringLength(
        Dgmjr.EntityFrameworkCore.Constants.UriMaxLengthConstant.UriMaxLength,
        MinimumLength = 1
    )]
    [Required]
    [Url]
    [DefaultValue(DgmjrCt.DgmjrClaims.UriString)]
    uri Issuer { get; set; }

    [StringLength(
        Dgmjr.EntityFrameworkCore.Constants.UriMaxLengthConstant.UriMaxLength,
        MinimumLength = 1
    )]
    [Required]
    [Url]
    [DefaultValue(DgmjrCt.DgmjrClaims.UriString)]
    uri OriginalIssuer { get; set; }

    [DefaultValue("{}")]
    IStringDictionary Properties { get; set; }

    void InitializeFromClaim(C? claim);
    C ToClaim();
}
