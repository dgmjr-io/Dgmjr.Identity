/*
 * AoplicationClaimValueType.cs
 *
 *   Created: 2023-10-10-09:32:09
 *   Modified: 2023-10-10-09:32:36
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

#pragma warning disable
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

using Telegram.Identity.ClaimTypes;

namespace Dgmjr.Identity.Models;

[Comment("A claim value type is a type of value that a claim can have.")]
public class ApplicationClaimValueType<TKey>
    : ApplicationIdentityEntity<TKey>,
        IIdentityClaimValueType<
            TKey,
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            ApplicationClaimType<TKey>,
            ApplicationClaimValueType<TKey>
        >,
        IIdentifiable<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    // [SetsRequiredMembers]
    public ApplicationClaimValueType() { }

    [Key, DbGen(DbGen.Identity)]
    public virtual TKey Id { get; set; }

    public virtual string? Example { get; set; }

    public virtual string? Default { get; set; }

    public virtual uri Uri { get; set; }

    public virtual string Name { get; set; }

    public virtual string Description { get; set; }

    public virtual ICollection<ApplicationClaimType<TKey>> ClaimTypes { get; } =
        new Collection<ApplicationClaimType<TKey>>();
}
