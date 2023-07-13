using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
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
/// <summary>The URI for an X.500 distinguished name claim</summary>
/// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname</value>
public sealed class X500DistinguishedName : Soap2005ClaimBaseType<X500DistinguishedName, global::System.Security.Cryptography.X509Certificates.X509Certificate>, IClaimType
{
    public static readonly IClaimType Instance = new X500DistinguishedName();

    /// <summary>The singleton instance of the <see cref="X500DistinguishedName" /> class.</summary>
    /// <returns>an instance of the <see cref="X500DistinguishedName" /> class</returns>    public static readonly IClaimType Instance = new X500DistinguishedName();
    private X500DistinguishedName() { }
    public const string _Name = "x500distinguishedname";

    public override string Name => _Name;
}
