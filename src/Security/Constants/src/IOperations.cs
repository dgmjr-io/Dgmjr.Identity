/*
 * IOperation.cs
 *
 *   Created: 2023-01-03-12:33:03
 *   Modified: 2023-01-03-12:33:04
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Security;
using Dgmjr.Enumerations.Abstractions;
using Dgmjr.Abstractions;

public interface IOperations : IEnumeration<IOperations, byte, Enums.Operations>
{
    // Enums.Operations Value { get; }
    // byte Id { get; }
    // Enums.Operations Value { get; }
    // string Name { get; }
    // string DisplayName { get; }

    // bool Equals(IOperations? other);

    // int CompareTo(IOperations? other);
    // int GetHashCode();
}
