using System.Net.Mime;
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

public class ApplicationClaimType<TKey> : IIdentifiable<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    [Key, DbGen(DbGen.Identity)]
    public virtual TKey Id { get; set; }
    public virtual uri? Uri { get; set; }
    public virtual string Name { get; set; }

    public virtual ICollection<ApplicationUser<TKey>> Users { get; set; } =
        new Collection<ApplicationUser<TKey>>();
    public virtual Collection<ApplicationRole<TKey>> Roles { get; set; } =
        new Collection<ApplicationRole<TKey>>();
}

public class ApplicationClaimType : ApplicationClaimType<long> { }
