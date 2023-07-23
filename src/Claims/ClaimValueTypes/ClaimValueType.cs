/* 
 * ClaimValueType.cs
 * 
 *   Created: 2023-06-07-06:56:39
 *   Modified: 2023-07-10-05:31:03
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 * 
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Claims.ClamValueTypes;
using Dgmjr.Identity.Claims.Abstractions;
using Dgmjr.Identity.Claims.ClaimValueTypes;
using System;

public abstract partial class ClaimValueType<TSelf, TUnderlyingValue> : ClaimValueOrTypeBase
{
    public override uri Uri => LongUri;
    public override uri ShortUri => this.ShortUriString;
    public override uri LongUri => this.LongUriString;

    public virtual bool Equals(IClaimValueType? other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return Uri == other.Uri;
    }

    public override int GetHashCode() => Uri.GetHashCode();
    public override bool Equals(object? obj) => Equals(obj as IClaimValueType);
    // public static bool operator ==(ClaimValueType<TSelf, TUnderlyingValue>? left, IClaimValueType? right) => left is null ? right is null : left.Uri.Equals(right.Uri);
    // public static bool operator !=(ClaimValueType<TSelf, TUnderlyingValue>? left, IClaimValueType? right) => left is null && right is not null || left is not null && right is null || !left.Uri.Equals(right.Uri);

#if NET7_0_OR_GREATER
    static type IClaimValueType.UnderlyingType => typeof(TValue);
#else
#endif
}

public class ClaimValueType : ClaimValueType<ClaimValueType, string>
{
    public new virtual uri Uri { get => LongUri; set => LongUri = value; }
    public new virtual uri LongUri { get => LongUriString; set => LongUriString = value; }
    public new virtual uri ShortUri { get => ShortUriString; set => ShortUriString = value; }
    public new virtual string Description { get; set; }
    public new virtual string LongUriString { get; set; }
    public new virtual string ShortUriString { get; set; }
    public override string ShortUriSeparator => ShortUriString.Contains(":") ? ":" : LongUriSeparator;
    public override string LongUriSeparator => LongUriString.Contains("#") ? "#" : "/";
    public override string Name => ShortUriString.Split(ShortUriSeparator.First()).Last();
}

// public class ClaimType : UriDescriptionTuple
// {
//     public virtual ClaimValueType ValueType _{_ get; }

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
