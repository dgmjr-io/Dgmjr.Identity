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
using System.Security.Claims;

public partial interface IIdentityUser<TKey> : IHaveAWritableId<TKey>, IHaveATelegramUsername
    where TKey : IEquatable<TKey>, IComparable
{
    /// <summary>Gets or sets the primary key for this user.</summary>
    [PersonalData, Key, DbGen(DbGen.None), Column(nameof(Id))]
    new TKey Id { get; set; }

    /// <summary>Gets or sets the user's username (usually the same as the <see cref="IHaveATelegramUsername.TelegramUsername" />)</summary>
    /// <example>Dgmjr</example>
    [ProtectedPersonalData, StringLength(int.MaxValue, MinimumLength = 0)]
    string? Username { get; set; }

    /// <summary>The user's given ("first") name</summary>
    /// <example>David</example>
    [ProtectedPersonalData, StringLength(int.MaxValue, MinimumLength = 0)]
    string? GivenName { get; set; }

    /// <summary>The user's sur- ("last"/"family") name</summary>
    /// <example>Gerard</example>
    [ProtectedPersonalData, StringLength(int.MaxValue, MinimumLength = 0)]
    string? Surname { get; set; }

    /// <summary>The user's go-by name (i.e., what he "goes by")</summary>
    /// <example>David</example>
    [ProtectedPersonalData, StringLength(int.MaxValue, MinimumLength = 0)]
    string? GoByName { get; set; }

    /// <summary>Gets or sets the normalized user name for this user.</summary>
    [ProtectedPersonalData, StringLength(int.MaxValue, MinimumLength = 0)]
    [JIgnore, XIgnore]
    string? NormalizedUsername { get; set; }

    /// <summary>Gets or sets the email address for this user.</summary>
    [ProtectedPersonalData]
    [Column(nameof(EmailAddress), TypeName = DbTypeNVarChar.ShortName)]
    [StringLength(UriMaxLength, MinimumLength = 0)]
    EmailAddress EmailAddress { get; set; }

    /// <summary>Gets or sets the normalized email address for this user.</summary>
    [Column(nameof(EmailAddress), TypeName = DbTypeNVarChar.ShortName)]
    [StringLength(UriMaxLength, MinimumLength = 0)]
    [JIgnore, XIgnore]
    string? NormalizedEmailAddress { get; set; }

    /// <summary>Gets or sets a flag indicating if a user has confirmed their email address.</summary>
    /// <value>True if the email address has been confirmed, otherwise false.</value>
    [PersonalData, JIgnore, XIgnore]
    bool IsEmailConfirmed { get; set; }

    /// <summary>Gets or sets a salted and hashed representation of the password for this user.</summary>
    [Column(TypeName = DbTypeNVarCharMax.ShortName)]
    [StringLength(int.MaxValue, MinimumLength = 0)]
    [JIgnore, XIgnore]
    string? PasswordHash { get; set; }

    /// <summary>A random value that must change whenever a users credentials change (password changed, login removed)</summary>
    guid SecurityStamp { get; set; }

    /// <summary>A random value that must change whenever a user is persisted to the store</summary>
    [Timestamp]
    [Column(TypeName = DbTypeRowVersion.ShortName)]
    [DbGen(DbGen.Computed)]
    [JIgnore]
    byte[] ConcurrencyStamp { get; set; }

    /// <summary>Gets or sets a telephone number for the user.</summary>
    [ProtectedPersonalData]
    [RegularExpression(PhoneNumber.RegexString)]
    [Column(TypeName = DbTypeVarChar.ShortName), StringLength(32, MinimumLength = 0)]
    PhoneNumber PhoneNumber { get; set; }

    /// <summary>Gets or sets a flag indicating if a user has confirmed their telephone address.</summary>
    /// <value>True if the telephone number has been confirmed, otherwise false.</value>
    [PersonalData]
    bool IsPhoneNumberConfirmed { get; set; }

    /// <summary>Gets or sets a flag indicating if two factor authentication is enabled for this user.</summary>
    /// <value>True if 2fa is enabled, otherwise false.</value>
    [PersonalData]
    bool IsTwoFactorEnabled { get; set; }

    /// <summary>Gets or sets the date and time, in UTC, when any user lockout ends.</summary>
    /// <remarks>A value in the past means the user is not locked out.</remarks>
    DateTimeOffset? LockoutEnd { get; set; }

    /// <summary>Gets or sets a flag indicating if the user could be locked out.</summary>
    /// <value>True if the user could be locked out, otherwise false.</value>
    bool IsLockoutEnabled { get; set; }

    /// <summary>Gets or sets the number of failed login attempts for the current user.</summary>
    int AccessFailedCount { get; set; }

    /// <summary>Returns the username for this user.</summary>
    string ToString();
}
