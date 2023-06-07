/*
 * ClaimType.cs
 *
 *   Created: 2023-03-30-12:44:53
 *   Modified: 2023-03-30-12:44:53
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;
using System;
using Dgmjr.Tuples;

public partial class ClaimValueType : IEquatable<ClaimValueType>
{
    public virtual bool Equals(ClaimValueType? other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return Uri == other.Uri;
    }

    public override int GetHashCode() => Uri.GetHashCode();

    /// <summary>
    /// This function compares the <see cref="ClaimValueType.Uri"/> property of two <see cref="ClaimValueType"/> objects and returns an integer
    /// indicating their relative order.
    /// </summary>
    /// <param name="other">other is a nullable <see cref="ClaimValueType" /> object that is being compared to the current
    /// instance of the <see cref="ClaimValueType" /> class.</param>
    /// <returns>
    /// The method is returning an integer value that represents the result of the comparison between the
    /// current instance of the <see cref="ClaimValueType" />  class and the specified <see cref="ClaimValueType" />  object. If the
    /// specified object is null, the method returns 1. If the specified object is the same as the current
    /// instance, the method returns 0. Otherwise, the method compares the <see cref="ClaimValueType.Uri"/> property of the current
    /// instance with the <see cref="ClaimValueType.Uri"/> property of the specified
    /// </returns>
    public int CompareTo(ClaimValueType? other)
    {
        if (other is null)
            return 1;
        if (ReferenceEquals(this, other))
            return 0;
        return Uri.CompareTo(other.Uri);
    }
}

// public class ClaimType : UriDescriptionTuple
// {
//     public virtual ClaimValueType ValueType { get; }

//     public ClaimType(@uri? uri, string? description = null, uri? claimValueType = null) : base(uri, description)
//         => ValueType = claimValueType != null ? new ClaimValueType(claimValueType, null as string/*, null as IValidator<C>*/) : new ClaimValueType(DgmjrCvt.String);
//     public ClaimType(string? uri, string? description = null, string? claimValueType = null) : this(uri.ToUri(), description, claimValueType?.ToUri()!) { }

//     public override string ToString() => Uri.ToString();

//     public static implicit operator string(ClaimType claimType) => claimType.Uri.ToString();
//     public static implicit operator uri?(ClaimType claimType) => claimType.Uri;
//     //public static implicit operator ClaimType((Uri, string) tuple) => new ClaimType(tuple.Item1, tuple.Item2, null as Uri);
// #if NETSTANDARD2_0_OR_GREATER
//     public static implicit operator ClaimType((string, string) tuple) => new(tuple.Item1, tuple.Item2, null as string);
//     public static implicit operator ClaimType((uri, string) tuple) => new (tuple.Item1, tuple.Item2, null as uri);
//     public static implicit operator ClaimType((string, string, string) tuple) => new (tuple.Item1, tuple.Item2, tuple.Item3);
//     public static implicit operator ClaimType((uri, string, ClaimValueType) tuple) => new (tuple.Item1, tuple.Item2, tuple.Item3);
// #endif
// }
