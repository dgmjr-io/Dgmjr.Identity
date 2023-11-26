/*
 * DgmjrClaims.cs
 *
 *   Created: 2023-08-29-06:29:17
 *   Modified: 2023-09-04-01:31:02
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.ClaimTypes;

public abstract record class DgmjrClaims : ClaimType<DgmjrId.ClaimValueTypes.String>, IClaimType
{
    /// <inheritdoc cref="DgmjrIdentity" />
    public new const string UriString = DgmjrIdentity;

    /// <value>DGMJR-IO Identity</value>
    public const string Name = "DGMJR-IO Identity";

    string IHaveAUriString.UriString => UriString;

    public override uri Uri => ((IIdentityComponent)this).UriString;

    /// <summary>The base URI for claims in the <inheritdoc cref="BaseUri" path="/value" /> namespace</summary>
    /// <value>https://dgmjr.io</value>
    public const string BaseUri = "https://dgmjr.io";

    /// <value>/identity</value>
    public const string Identity = "/identity";

    /// <summary>The base URI for claims in the <inheritdoc cref="Identity" /> namespace</summary>
    /// <value><inheritdoc cref="BaseUri" /><inheritdoc cref="Identity" /></value>
    public const string DgmjrIdentity = BaseUri + Identity;
}

public record class UnknownClaimType : ClaimType<DgmjrId.ClaimValueTypes.String>, IClaimType
{
    /// <value><inheritdoc cref="DgmjrClaims.DgmjrIdentity" />/unknown</value>
    public new const string UriString = $"{DgmjrClaims.DgmjrIdentity}/unknown";

    /// <value>Unknown</value>
    public const string Name = "Unknown";

    /// <value><inheritdoc cref="DgmjrClaims.DgmjrIdentity" />/unknown</value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="DgmjrClaims.DgmjrIdentity" />/unknown</value>
    public override uri Uri => ((IIdentityComponent)this).UriString;

    public static readonly IClaimType Instance = new UnknownClaimType();
}
