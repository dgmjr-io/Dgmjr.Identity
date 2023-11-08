/*
 * IClaimValueType.cs
 *
 *   Created: 2023-08-29-04:38:27
 *   Modified: 2023-08-29-04:38:43
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

using Dgmjr.Abstractions;

public interface IClaimValueType<TValue> : IClaimValueType,
                                           IHaveAValue<TValue> {
  new TValue Value { get;
}
}

public interface IClaimValueType : IIdentityComponent,
                                   IEquatable<IClaimValueType> {
  object Value { get; }
}
