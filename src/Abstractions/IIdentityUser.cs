using System.ComponentModel.DataAnnotations;

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

using Microsoft.AspNetCore.Identity;

using System.Domain;
using System.Net.Mail;
using Dgmjr.Abstractions;

public partial interface IIdentityUser<TKey> : IHaveAWritableId<TKey>
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>
    /// Gets or sets the primary key for this user.
    /// </summary>
    [PersonalData]
    new TKey Id { get; set; }

    /// <summary>
    /// Gets or sets the user name for this user.
    /// </summary>
    [ProtectedPersonalData]
    string? UserName { get; set; }

    /// <summary>
    /// Gets or sets the normalized user name for this user.
    /// </summary>
    string? NormalizedUserName { get; set; }

    /// <summary>
    /// Gets or sets the email address for this user.
    /// </summary>
    [ProtectedPersonalData]
    EmailAddress Email { get; set; }

    /// <summary>
    /// Gets or sets the normalized email address for this user.
    /// </summary>
    string? NormalizedEmail { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating if a user has confirmed their email address.
    /// </summary>
    /// <value>True if the email address has been confirmed, otherwise false.</value>
    [PersonalData]
    bool IsEmailConfirmed { get; set; }

    /// <summary>
    /// Gets or sets a salted and hashed representation of the password for this user.
    /// </summary>
    string? PasswordHash { get; set; }

    /// <summary>
    /// A random value that must change whenever a users credentials change (password changed, login removed)
    /// </summary>
    string? SecurityStamp { get; set; }

    /// <summary>
    /// A random value that must change whenever a user is persisted to the store
    /// </summary>
    string? ConcurrencyStamp { get; set; }

    /// <summary>
    /// Gets or sets a telephone number for the user.
    /// </summary>
    [ProtectedPersonalData]
    PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating if a user has confirmed their telephone address.
    /// </summary>
    /// <value>True if the telephone number has been confirmed, otherwise false.</value>
    [PersonalData]
    bool IsPhoneNumberConfirmed { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating if two factor authentication is enabled for this user.
    /// </summary>
    /// <value>True if 2fa is enabled, otherwise false.</value>
    [PersonalData]
    bool IsTwoFactorEnabled { get; set; }

    /// <summary>
    /// Gets or sets the date and time, in UTC, when any user lockout ends.
    /// </summary>
    /// <remarks>
    /// A value in the past means the user is not locked out.
    /// </remarks>
    DateTimeOffset? LockoutEnd { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating if the user could be locked out.
    /// </summary>
    /// <value>True if the user could be locked out, otherwise false.</value>
    bool LockoutEnabled { get; set; }

    /// <summary>
    /// Gets or sets the number of failed login attempts for the current user.
    /// </summary>
    int AccessFailedCount { get; set; }

    /// <summary>
    /// Returns the username for this user.
    /// </summary>
    string ToString();
}
