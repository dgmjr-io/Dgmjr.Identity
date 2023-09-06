/*
 * Roles.cs
 *
 *   Created: 2023-03-19-05:02:09
 *   Modified: 2023-03-19-05:02:09
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace Dgmjr.Identity;

public interface IRole
{
    string Scheme { get; }
    string Name { get; }

    bool Equals(DgmjrR other);
    bool Equals(object obj);
    bool Equals(ClaimTypeOrValueType? other);
    int GetHashCode();
    string ToString();
    IRole Instance { get; }
}
