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

namespace System.Security.Extensions;

using Dgmjr.Identity;
using Dgmjr.Identity.Abstractions;
using System.Security.Claims;

using ClaimsIdentity = ClaimsIdentity;
using ClaimsPrincipal = ClaimsPrincipal;

public static class ClaimsPrincipalExtensions
{
    public static ClaimsPrincipal ToClaimsPrincipal(this IHaveClaims user)
    {
        return new ClaimsPrincipal(new ClaimsIdentity(user.Claims));
    }

    public static ClaimsIdentity ToClaimsIdentity(this IHaveClaims user)
    {
        return new ClaimsIdentity(user.Claims);
    }

    public static ClaimsPrincipal AddClaims(this ClaimsPrincipal principal, params Claim[] claims)
    {
        principal.AddIdentity(new ClaimsIdentity(claims));
        return principal;
    }

    public static ClaimsPrincipal AddClaim(this ClaimsPrincipal principal, Claim claim)
    {
        principal.AddIdentity(new ClaimsIdentity([claim]));
        return principal;
    }

    public static ClaimsPrincipal AddAppRoles(this ClaimsPrincipal principal, IEnumerable<Guid> roles)
    {
        var claims = roles.Select(role => new Claim(Ct.Role, role.ToString())).ToArray();
        ForEach(claims, claim => principal.AddClaim(claim));
        return principal;
    }
}
