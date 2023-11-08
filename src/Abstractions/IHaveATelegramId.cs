/*
 * IHaveATelegramId.cs
 *
 *   Created: 2023-03-19-03:04:18
 *   Modified: 2023-10-10-09:29:30
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Text.RegularExpressions;

namespace Dgmjr.Identity.Abstractions;

public interface IHaveATelegramId
{
    long TelegramId {
        get;
    }
}
