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

public abstract partial record class Role : IdentityComponent, IRole
{
    protected Role() { }

    /// <value><inheritdoc cref="Roles.Names.Scheme" path="/value" /></value>
    public const string Scheme = Roles.Names.Scheme;

    /// <value>dgmjr.io/roles</value>
    public const string Namespace = "dgmjr.io/roles";

    /// <value>role</value>
    public const string Name = "";

    /// <value><inheritdoc cref="Scheme" path="/value" /><inheritdoc cref="Namespace" path="/value" />/<inheritdoc cref="Name" path="/value" /></value>
    public const string UriString = $"{Scheme}{Namespace}/{Name}";

    /// <inheritdoc cref="Namespace" />
    string IIdentityComponent.Namespace => Namespace;

    /// <inheritdoc cref="Scheme" />
    string IRole.Scheme => Scheme;

    /// <inheritdoc cref="Name" />
    string IIdentityComponent.Name => Name;

    /// <inheritdoc cref="UriString" />
    string IIdentityComponent.UriString => $"{Scheme}{Namespace}/{Name}";

    /// <inheritdoc cref="UriString" />
    uri IIdentityComponent.Uri => uri.From(UriString);

    public virtual bool Equals(Role? other) =>
        (other as IIdentityComponent)?.Uri == (this as IIdentityComponent).Uri;

    public override int GetHashCode() => UriString.GetHashCode();
}
