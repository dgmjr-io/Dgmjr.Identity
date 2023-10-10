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

using Newtonsoft.Json.Linq;

using Telegram.Identity.ClaimTypes;

namespace Dgmjr.Identity.Models;

public class ApplicationClaimType : IIdentifiable<long>
{
    [Key, DbGen(DbGen.Identity)]
    public virtual long Id { get; set; }
    public virtual uri? Uri { get; set; }
    public virtual string Name { get; set; }

    public virtual ICollection<ApplicationUser> Users { get; set; } =
        new Collection<ApplicationUser>();
    public virtual Collection<ApplicationRole> Roles { get; set; } =
        new Collection<ApplicationRole>();
}
