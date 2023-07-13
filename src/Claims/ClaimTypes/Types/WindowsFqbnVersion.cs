/*
 * ClaimTypeUris.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity.Claims.Abstractions;

/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion</value>
public sealed class WindowsFqbnVersion : MicrosoftSoap2008ClaimBaseType, IClaimType
{
    /// <summary>The singleton instance of the <see cref="WindowsFqbnVersion" /> class.</summary>
    /// <returns>an instance of the <see cref="WindowsFqbnVersion" /> class</returns>
    public static readonly IClaimType Instance = new WindowsFqbnVersion();
    private WindowsFqbnVersion() { }
    public const string _Name = "windowsfqbnversion";

    public override string Name => _Name;
}