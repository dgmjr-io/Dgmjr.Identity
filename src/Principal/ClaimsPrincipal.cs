/*
 * ClaimsPrincipal.cs
 *
 *   Created: 2023-01-03-05:39:44
 *   Modified: 2023-01-03-05:39:45
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
// #if NETSTANDARD2_0_OR_GREATER
namespace Dgmjr.Identity;

using Dgmjr.Identity.Abstractions;
using SystemClaimsIdentity = System.Security.Claims.ClaimsIdentity;
using SystemClaimsPrincipal = System.Security.Claims.ClaimsPrincipal;

public class ClaimsPrincipal : SystemClaimsPrincipal
{
    public ClaimsPrincipal(IHaveClaims user)
        : base(new ClaimsIdentity(user)) { }
}

public class ClaimsIdentity : SystemClaimsIdentity
{
    public ClaimsIdentity(IHaveClaims user)
        : base(
            user.Claims /*.Select(c => c.ToClaim())*/
        ) { }
}
// #endif
