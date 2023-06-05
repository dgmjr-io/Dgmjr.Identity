/* 
 * DgmjrClaims.cs
 * 
 *   Created: 2023-03-19-03:04:51
 *   Modified: 2023-03-25-01:55:21
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

/*
 * DgmjrClaims.cs
 *
 *   Created: 2022-12-17-06:58:00
 *   Modified: 2022-12-17-06:58:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;
using NS = Dgmjr.Identity.ClaimTypeUris.Namespaces;

public static partial class ClaimTypeUris
{
    /// <summary>The base URI for claims in the <inheritdoc cref="BaseUri" path="/value" /> namespace</summary>
    /// <value>https://dgmjr.io/</value>
    public const string BaseUri = "https://dgmjr.io/";

    /// <summary>The base URI for claims in the <inheritdoc cref="Identity" /> namespace</summary>
    /// <value><inheritdoc cref="BaseUri" /><inheritdoc cref="NS.Identity" /></value>
    public const string Identity = BaseUri + NS.Identity;
}
