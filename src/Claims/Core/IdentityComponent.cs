/*
 * IdentityComponent.cs
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

public abstract record class IdentityComponent : IIdentityComponent
{
    public virtual bool Equals(IIdentityComponent? other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return ((IIdentityComponent)this).Uri == other.Uri;
    }

    // public override bool Equals(object? other) => Equals(other as IIdentityComponent);

    public override int GetHashCode() => ((IIdentityComponent)this).GetHashCode();

    /// <value>about</value>
    string IIdentityComponent.Namespace => "about";

    /// <value>about</value>
    string IIdentityComponent.ShortNamespace => "about";

    /// <value>about</value>
    string IHaveAUriString.UriString =>
        $"{((IIdentityComponent)this).Namespace}{((IIdentityComponent)this).UriString}";
    string IIdentityComponent.ShortUriString =>
        $"{((IIdentityComponent)this).Namespace}{((IIdentityComponent)this).ShortUriString}";

    /// <value>blank</value>
    string IIdentityComponent.Name => "blank";
    uri IIdentityComponent.Uri => ((IIdentityComponent)this).UriString;
    uri IIdentityComponent.ShortUri => ((IIdentityComponent)this).ShortUriString;
}