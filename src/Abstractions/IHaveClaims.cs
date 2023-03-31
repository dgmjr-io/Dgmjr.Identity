/*
 * IBackroomUser.cs
 *
 *   Created: 2022-12-01-04:51:41
 *   Modified: 2022-12-03-01:45:50
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IHaveClaims : IIdentifiable<long>
{
    /// <summary>Gets or sets the claims associated with the user.</summary>
    /// <value>The claims associated with the user.</value>
    ICollection<C> Claims { get; set; }
}

public interface IHaveUserClaims : IIdentifiable<long>
{
    ICollection<IUserClaim> Claims { get; set; }
}
