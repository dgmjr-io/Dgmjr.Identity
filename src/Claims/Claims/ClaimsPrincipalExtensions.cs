/*
 * ClaimsPrincipalExtensions.cs
 *
 *   Created: 2023-01-08-02:38:24
 *   Modified: 2023-01-08-02:38:24
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Dgmjr.Identity;

namespace System.Security.Claims;

public static class ClaimsPrincipalExtensions
{
    public static IEnumerable<string> FindAllValues(
        this ClaimsPrincipal principal,
        string claimType
    ) => principal.FindAll(c => c.Type == claimType).Select(c => c.Value);

    public static long GetUserId(this ClaimsPrincipal principal) =>
        long.Parse(
            principal.FindFirstValue(Ct.NameIdentifier)
                ?? principal.FindFirstValue(JwtCt.NameId.UriString)
        );

    public static Claim GetUserIdClaim(this ClaimsPrincipal principal) =>
        principal.FindClaim(Ct.NameIdentifier) ?? principal.FindClaim(JwtCt.NameId.UriString);

    public static string? GetName(this ClaimsPrincipal principal) =>
        principal.FindFirstValue(Ct.Name) ?? principal.FindFirstValue(JwtCt._Name.UriString) ?? principal.FindFirstValue(JwtCt._Name.Name);

    public static Claim GetNameClaim(this ClaimsPrincipal principal) =>
        principal.FindClaim(Ct.Name);

    public static string? GetEmail(this ClaimsPrincipal principal) =>
        principal.FindFirstValue(Ct.Email) ?? principal.FindFirstValue(JwtCt.Email.UriString) ?? principal.FindFirstValue(JwtCt.Email.Name);

    public static Claim GetEmailClaim(this ClaimsPrincipal principal) =>
        principal.FindClaim(Ct.Email) ?? principal.FindClaim(JwtCt.Email.UriString) ?? principal.FindClaim(JwtCt.Email.Name);

    public static Claim GetPhoneNumberClaim(this ClaimsPrincipal principal) =>
        principal.FindClaim(Ct.MobilePhone)
        ?? principal.FindClaim(Ct.HomePhone)
        ?? principal.FindClaim(Ct.OtherPhone);

    public static string? GetPhoneNumber(this ClaimsPrincipal principal) =>
        principal.FindFirstValue(Ct.MobilePhone)
        ?? principal.FindFirstValue(Ct.HomePhone)
        ?? principal.FindFirstValue(Ct.OtherPhone);

    public static IEnumerable<string> GetRoles(this ClaimsPrincipal principal) =>
        principal.FindAllValues(Ct.Role) ?? principal.FindAllValues(JwtCt.Roles.UriString) ?? principal.FindAllValues(JwtCt.Roles.Name);

    public static bool IsInRole(this ClaimsPrincipal principal, string role) =>
        principal.GetRoles().Contains(role, StringComparer.OrdinalIgnoreCase);

    public static bool IsInAnyRole(this ClaimsPrincipal principal, params string[] roles) =>
        Exists(roles, principal.IsInRole);

    public static bool IsInAllRoles(this ClaimsPrincipal principal, params string[] roles) =>
        Exists(roles, principal.IsInRole);

    // public static string GetDisplayName(this ClaimsPrincipal principal)
    // {
    //     return principal.FindFirstValue(DgmjrCt.CommonName.UriString)
    //         ?? principal.FindFirstValue(DgmjrCt.GivenName.UriString)
    //         ?? principal.FindFirstValue(DgmjrCt.Name.UriString)
    //         ?? principal.FindFirstValue(DgmjrCt.Email.UriString)
    //         ?? principal.FindFirstValue(DgmjrCt.NameIdentifier.UriString)
    //         ?? "Unknown";
    // }

    public static string? GetUsername(this ClaimsPrincipal principal) =>
        principal.FindFirstValue(DgmjrCt.Username.UriString) ??
        principal.FindFirstValue(JwtCt.PreferredUsername.UriString) ??
        principal.FindFirstValue(JwtCt.PreferredUsername.Name) ??
        principal.FindFirstValue(Ct.Name) ??
        principal.FindFirstValue(JwtCt._Name.UriString) ??
        principal.FindFirstValue(JwtCt._Name.Name) ??
        principal.FindFirstValue(Ct.Email) ??
        principal.FindFirstValue(JwtCt.Email.UriString) ??
        principal.FindFirstValue(JwtCt.Email.Name) ??
        principal.FindFirstValue(Ct.NameIdentifier) ??
        principal.FindFirstValue(DgmjrCt.Upn.UriString) ??
        principal.FindFirstValue(DgmjrCt.Upn.Name);

    public static Claim FindClaim(this ClaimsPrincipal principal, string claimType) =>
        principal.FindFirst(c => c.Type.Equals(claimType, OrdinalIgnoreCase))
        ?? throw new InvalidOperationException($"The claim type '{claimType}' was not found.");

#if !NET6_0_OR_GREATER
    public static string? FindFirstValue(this ClaimsPrincipal principal, string claimType) =>
        principal.FindFirst(c => string.Equals(c.Type, claimType, CurrentCultureIgnoreCase))?.Value;
#endif
    public static string? FindFirstValue(this ClaimsPrincipal principal, Predicate<Claim> pred) =>
        principal.FindFirst(pred)?.Value;

    public static T? FindFirstValue<T>(this ClaimsPrincipal principal, string claimType)
        where T : IClaimValueType
    {
        var value = principal.FindFirstValue(c => string.Equals(c.Type, claimType, CurrentCultureIgnoreCase));
        return (T?)(object?)value;
    }
}
