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
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

using Newtonsoft.Json.Linq;

using Telegram.Identity.ClaimTypes;

namespace Dgmjr.Identity.Models;

public class ApplicationClaimValueType : IIdentifiable<long>
{
    [Key, DbGen(DbGen.Identity)]
    public virtual long Id { get; set; }
    public virtual uri? Uri { get; set; }
    public virtual string Name { get; set; }

    public virtual ICollection<ApplicationClaimType> Claims { get; set; } =
        new Collection<ApplicationClaimType>();
}
