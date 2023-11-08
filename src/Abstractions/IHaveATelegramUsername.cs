/*
 * IHaveATelegramUsername.cs
 *
 *   Created: 2023-10-06-08:17:14
 *   Modified: 2023-10-10-09:29:24
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

/// <summary>
/// Marker interface for a type that has a property called <see cref="TelegramUsername" />.
/// </summary>
public interface IHaveATelegramUsername
{
    /// <summary>Gets or sets the user's unique Telegram username</summary>
    /// <example>@IAmTheAntitwink</example>
    [RegularExpression(Account.UsernameRegex)]
    [Column(nameof(TelegramUsername), TypeName = VarChar.ShortName)]
    string TelegramUsername {
        get;
        set;
    }
}
