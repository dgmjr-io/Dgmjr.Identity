/*
 * ApplicationRole.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-04:59:07
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Models;

using System;
using System.Collections.ObjectModel;
using Dgmjr.Abstractions;
using Dgmjr.Identity.Abstractions;

using Microsoft.AspNetCore;
using static System.Guid;

[DebuggerDisplay("ApplicationRole ({Id} - {Name} {Uri})")]
[Comment("A role is a collection of claims that can be assigned to a user.")]
public partial class ApplicationRole<TKey>
    : ApplicationIdentityEntity<TKey>,
        IIdentityRole<
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            TKey,
            ApplicationUserClaim<TKey>,
            ApplicationUserRole<TKey>,
            ApplicationUserLogin<TKey>,
            ApplicationRoleClaim<TKey>,
            ApplicationUserToken<TKey>
        >,
        IIdentityRole<TKey, ApplicationUser<TKey>, ApplicationRole<TKey>>
    where TKey : IEquatable<TKey>, IComparable
{
    public const string RoleUriDefaultFormatString = "urn:role:{0}";

    object IIdentifiable.Id
    {
        get => Id;
    }

    public virtual string? ConcurrencyStamp { get; set; } = NewGuid().ToString();

    public virtual string Name { get; set; }

    public virtual string NormalizedName
    {
        get => Name.Normalize(NormalizationForm.FormKD);
        set
        {
            /* no op */
        }
    }

    Uri IHaveAUri.Uri
    {
        get => Uri;
    }

    public string Description { get; set; } = string.Empty;

    public virtual uri Uri { get; set; }

    public virtual ICollection<ApplicationUser<TKey>> Users { get; set; } =
        new Collection<ApplicationUser<TKey>>();
    public virtual ICollection<ApplicationUserRole<TKey>> UserRoles { get; set; } =
        new Collection<ApplicationUserRole<TKey>>();

    // public virtual ICollection<ApplicationClaimType<TKey>> ClaimTypes { get; set; } =
    //     new Collection<ApplicationClaimType<TKey>>();
    public virtual ICollection<ApplicationRoleClaim<TKey>> RoleClaims { get; set; } =
        new Collection<ApplicationRoleClaim<TKey>>();
}

public class ApplicationRole : ApplicationRole<long> { }

public record struct RoleInsertDto(string Name, uri Uri, string Description)
{
    public RoleInsertDto()
        : this(string.Empty, uri.Empty, string.Empty) { }
}
