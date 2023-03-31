/*
 * ClaimsPrincipalExtensions.cs
 *
 *   Created: 2023-01-06-06:07:12
 *   Modified: 2023-01-06-06:07:13
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Extensions.Security;

using Dgmjr.Identity;
using Dgmjr.Identity.Abstractions;

public static class ClaimsPrincipalExtensions
{
    public static ClaimsPrincipal ToClaimsPrincipal(this IHaveClaims user)
    {
        return new ClaimsPrincipal(user);
    }

    public static ClaimsIdentity ToClaimsIdentity(this IHaveClaims user)
    {
        return new ClaimsIdentity(user);
    }
}
