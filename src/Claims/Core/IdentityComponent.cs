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

/// <summary>A basic Identity Component</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public abstract record class IdentityComponent : IIdentityComponent
{
    public virtual bool Equals(IIdentityComponent? other) =>
        (other is not null)
        && (ReferenceEquals(this, other) || ((IIdentityComponent)this).Uri == other.Uri);

    /// <value>about:blank</value>
    public const string UriString = "about:blank";

    // public override bool Equals(object? other) => Equals(other as IIdentityComponent);

    // public override int GetHashCode() => ((IIdentityComponent)this).GetHashCode();

    /// <value>about</value>
    string IIdentityComponent.Namespace => "about";

    /// <value>about</value>
    string IIdentityComponent.ShortNamespace => "about";

    /// <value>about</value>
    string IHaveAUriString.UriString =>
        $"{((IIdentityComponent)this).Namespace}{((IHaveAUriString)this).UriString}";
    string IIdentityComponent.ShortUriString =>
        $"{((IIdentityComponent)this).Namespace}{((IIdentityComponent)this).ShortUriString}";

    /// <value>blank</value>
    string IHaveAName.Name => "blank";

    /// <inheritdoc cref="UriString" path="/value" />
    uri IHaveAuri.Uri => ((IIdentityComponent)this).UriString;

    /// <inheritdoc cref="UriString" path="/value" />
    uri IIdentityComponent.ShortUri => ((IIdentityComponent)this).ShortUriString;
}
