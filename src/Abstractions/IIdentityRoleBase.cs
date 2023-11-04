/*
 * IIdentityRoleBase.cs
 *
 *   Created: 2023-34-29T23:34:35-04:00
 *   Modified: 2023-34-29T23:34:37-04:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IIdentityRoleBase
{
    /// <summary>
    /// Gets or sets the name for this role.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the normalized name for this role.
    /// </summary>
    string NormalizedName { get; set; }

    /// <summary>
    /// Gets or sets the description for this role.
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// A random value that should change whenever a role is persisted to the store
    /// </summary>
    [Timestamp]
    string? ConcurrencyStamp { get; set; }

    /// <summary>
    /// The <see cref="uri" /> of the role
    /// </summary>
    uri Uri { get; set; }

    /// <summary>
    /// Returns the name of the role.
    /// </summary>
    /// <returns>The name of the role.</returns>
    string ToString();
}
