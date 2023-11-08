/*
 * IHaveAUsername.cs
 *
 *   Created: 2023-10-06-12:48:00
 *   Modified: 2023-10-06-12:48:17
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Abstractions;

public interface IHaveAUsername
{
    string Username { get; }
}
