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
[JSerializable(typeof(ApplicationRole))]
public partial class ApplicationRole : IIdentityRole<long>
{
    public const string RoleUriDefaultFormatString = "urn:role:{0}";

    public virtual long Id { get; set; }

    public virtual string? ConcurrencyStamp { get; set; } = NewGuid().ToString();

    public virtual string? Name { get; set; }

    public virtual string? NormalizedName
    {
        get => Name.Normalize(NormalizationForm.FormKD);
        set
        {
            /* no op */
        }
    }

    public string? Description { get; set; } = string.Empty;

    public virtual uri Uri { get; set; }

    public virtual ICollection<ApplicationUser> Users { get; set; } =
        new Collection<ApplicationUser>();
    public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } =
        new Collection<ApplicationUserRole>();
}

public record struct RoleInsertDto(string Name, uri Uri, string Description)
{
    public RoleInsertDto()
        : this(string.Empty, uri.Empty, string.Empty) { }
}
