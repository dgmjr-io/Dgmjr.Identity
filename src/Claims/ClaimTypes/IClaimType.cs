/*
 * IClaimType.cs
 *
 *   Created: 2023-08-29-06:47:36
 *   Modified: 2023-08-29-06:47:36
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

public interface IClaimType : IClaimTypeOrValueType, IEquatable<IClaimType>
{
}
