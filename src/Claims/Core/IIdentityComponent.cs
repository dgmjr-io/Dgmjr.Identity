/*
 * IIdentityComponent.cs
 *
 *   Created: 2023-08-29-09:32:39
 *   Modified: 2023-08-29-09:32:39
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

public interface IIdentityComponent : IEquatable<IIdentityComponent>, IHaveAUriString
{
    bool Equals(object other);

    string Namespace { get; }
    string Name { get; }
    string ShortUriString { get; }
    string ShortNamespace { get; }
    uri Uri { get; }
    uri ShortUri { get; }
    int GetHashCode();
}
