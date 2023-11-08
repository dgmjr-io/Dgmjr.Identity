/*
 * IIdentityUser.cs
 *
 *   Created: 2023-04-01-11:21:04
 *   Modified: 2023-04-01-11:21:04
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.AspNetCore.Identity.Abstractions
{
    [GenerateInterface(typeof(IdentityUser<TKey>))]
    public partial interface IIdentityUser<TKey>
        where TKey : IEquatable<TKey>, IComparable
    {
    }
}
