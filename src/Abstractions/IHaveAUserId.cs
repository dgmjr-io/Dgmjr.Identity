/*
 * IHaveAUserId.cs
 *
 *   Created: 2023-10-06-12:47:38
 *   Modified: 2023-10-06-12:47:38
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IHaveAUserId
{
    string UserId { get; }
}
