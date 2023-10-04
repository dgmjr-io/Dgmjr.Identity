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

public interface IEntityClaim<TEntityClaimType>
    where TEntityClaimType : IEntityClaim<TEntityClaimType>
{
    long EntityId { get; set; }
    string? ClaimValue { get; set; }
    string? ClaimType { get; set; }
    uri? Type { get; set; }
    uri? ValueType { get; set; }
    uri? Issuer { get; set; }
    uri? OriginalIssuer { get; set; }
    IStringDictionary Properties { get; set; }

    C ToClaim();
}
