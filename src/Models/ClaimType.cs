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
namespace Dgmjr.Identity.Models;

public class ClaimType : IIdentifiable<long>
{
    public long Id { get; set; }

    public System.uri? Uri { get; set; }

    public virtual Collection<User> Users { get; set; } = new Collection<User>();
    public virtual Collection<ApplicationRole> Roles { get; set; } =
        new Collection<ApplicationRole>();
}
