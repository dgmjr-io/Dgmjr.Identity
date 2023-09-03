/*
 * ClaimTypeOrValueType.cs
 *
 *   Created: 2023-08-29-09:31:57
 *   Modified: 2023-08-29-09:31:57
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity;

public abstract record class ClaimTypeOrValueType : IClaimTypeOrValueType
{
    public virtual bool Equals(IClaimTypeOrValueType? other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return ((IClaimTypeOrValueType)this).Uri == other.Uri;
    }

    // public override bool Equals(object? other) => Equals(other as IClaimTypeOrValueType);

    public override int GetHashCode() => ((IClaimTypeOrValueType)this).GetHashCode();

    string IClaimTypeOrValueType.Namespace => "about";
    string IClaimTypeOrValueType.ShortNamespace => "about";
    string IClaimTypeOrValueType.UriString => $"{((IClaimTypeOrValueType)this).Namespace}{((IClaimTypeOrValueType)this).Name}";
    string IClaimTypeOrValueType.ShortUriString => $"{((IClaimTypeOrValueType)this).Namespace}{((IClaimTypeOrValueType)this).Name}";
    string IClaimTypeOrValueType.Name => "blank";
    uri IClaimTypeOrValueType.Uri => ((IClaimTypeOrValueType)this).UriString;
    uri IClaimTypeOrValueType.ShortUri => ((IClaimTypeOrValueType)this).ShortUriString;
}
