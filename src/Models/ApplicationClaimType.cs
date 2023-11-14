/*
 * ClaimType.cs
 *
 *   Created: 2022-12-03-01:10:00
 *   Modified: 2022-12-03-01:10:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

using Telegram.Identity.ClaimTypes;

namespace Dgmjr.Identity.Models;

public class ApplicationClaimType<TKey>
    : ApplicationIdentityEntity<TKey>,
        IIdentityClaimType<
            TKey,
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            ApplicationClaimType<TKey>,
            ApplicationClaimValueType<TKey>
        >,
        IIdentifiable<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    public virtual string? Example { get; set; }

    public virtual string? Default => throw new NotImplementedException();

    public virtual ICollection<ApplicationClaimType<TKey>> ClaimTypes { get; } =
        new Collection<ApplicationClaimType<TKey>>();

    public virtual required uri Uri { get; set; }

public virtual required string Name { get; set; }

public virtual required uri ValueTypeUri { get; set; }
public ApplicationClaimValueType<TKey> ValueType { get; set; } = default!;

public virtual string Description { get; set; }

    // public ICollection<ApplicationUser<TKey>> Users { get; } =
    //     new Collection<ApplicationUser<TKey>>();

    // public ICollection<ApplicationRole<TKey>> Roles { get; } =
    //     new Collection<ApplicationRole<TKey>>();
}
