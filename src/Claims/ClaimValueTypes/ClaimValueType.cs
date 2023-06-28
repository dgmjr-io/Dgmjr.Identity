using Microsoft.VisualBasic;
using System.Security.Cryptography;
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

namespace Dgmjr.Identity.ClaimValueTypes;
using Dgmjr.Identity.Claims.Abstractions;
using System;
using Abstractions;

public abstract class ClaimValueType<TValue> : IClaimValueType
{
    public virtual uri Uri => LongUri;
    public virtual uri ShortUri => ((IClaimTypeOrValue)this).ShortUriString;
    public virtual uri LongUri => ((IClaimTypeOrValue)this).LongUriString;
    public virtual string Description => $"A claimtype for the {((IClaimTypeOrValue)this).Name} defined in the {((IClaimTypeOrValue)this).LongUriString} ({((IClaimTypeOrValue)this).ShortUriString}) namespace.";

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
    public static bool operator ==(ClaimValueType? left, ClaimValueType? right) => left is null ? right is null : left.Equals(right);
    public static bool operator !=(ClaimValueType? left, ClaimValueType? right) => !(left == right);
    public override string ToString() => Uri.ToString();
    public static implicit operator uri(ClaimValueType? claimValueType) => claimValueType?.Uri ?? uri.Empty;

    public const string LongUriPrefx = Constants.DefaultLongUriPrefix;
    public const string ShortUriPrefix = Constants.DefaultShortUriPrefix;
    public const string LongUriSeparator = Constants.DefaultLongUriSeparator;
    public const string ShortUriSeparator = Constants.DefaultShortUriSeparator;
    public const string Name = Constants.value;
    public const string LongUriString = $"{LongUriPrefx}{LongUriSeparator}{Name}";
    public const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";


    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefx;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    type IClaimTypeOrValue.UnderlyingType => typeof(void);

    public virtual object? Value { get; set; }
    public virtual TValue? Value { get; set; }
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
