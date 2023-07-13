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

/// <summary>The URI for a claim that specifies the Windows group SID of the device</summary>
/// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup</value>
public sealed class WindowsDeviceGroup : MicrosoftSoap2008ClaimBaseType<WindowsDeviceGroup, string>
{
    /// <summary>The singleton instance of the <see cref="WindowsDeviceGroup" /> class.</summary>
    /// <returns>an instance of the <see cref="WindowsDeviceGroup" /> class</returns>
    public static readonly IClaimType Instance = new WindowsDeviceGroup();

    /// <value>windowsdevicegroup</value>
    public const string _Name = "windowsdevicegroup";

    public override string Name => _Name;
}
