/*
 * RoleClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-05:35:10
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Models;

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Dgmjr.Abstractions;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;

[DebuggerDisplay("Role Claim ({Id} Role ID: {RoleId}, {Type}: {Value})")]
// [JSerializable(typeof(ApplicationRoleClaim<TSelf, TKey>))]
public class ApplicationRoleClaim : EntityClaim<ApplicationRoleClaim, long>
{
    public static implicit operator ApplicationRoleClaim(C claim) => FromClaim(claim);

    public virtual long RoleId
    {
        get => EntityId;
        set => EntityId = value;
    }
}

public record struct ApplicationRoleClaimInsertDto
{
    public ApplicationRoleClaimInsertDto() => Properties = new StringDictionary();

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0)]
    public Uri Type { get; set; }

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0)]
    public Uri ValueType { get; set; }

    [StringLength(int.MaxValue, MinimumLength = 0)]
    public string? Value { get; set; }

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0)]
    public Uri Issuer { get; set; }

    [Required, Url, StringLength(UriMaxLength, MinimumLength = 0)]
    public Uri OriginalIssuer { get; set; }

    [Required]
    public StringDictionary Properties { get; set; } = new StringDictionary();
}
