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

public abstract partial record class Role : ClaimTypeOrValueType, IClaimTypeOrValueType, IRole
{
    protected Role() { }

    public abstract IRole Instance { get; }

    /// <value><inheritdoc cref="Roles.Names.Scheme" path="/value" /></value>
    public const string Scheme = Roles.Names.Scheme;
    /// <value>dgmjr.io/roles</value>
    public const string Namespace = "dgmjr.io/roles";
    /// <value></value>
    public const string Name = "";
    /// <value><inheritdoc cref="Scheme" path="/value" /><inheritdoc cref="DgmjrR.Namespace" path="/value" /></value>
    public const string UriString = $"{Scheme}{DgmjrR.Namespace}";

    /// <inheritdoc cref="Namespace" />
    string IClaimTypeOrValueType.Namespace => Namespace;
    /// <inheritdoc cref="Scheme" />
    string IRole.Scheme => Scheme;
    /// <inheritdoc cref="Name" />
    string IRole.Name => Name;
    /// <inheritdoc cref="UriString" />
    string IClaimTypeOrValueType.UriString => $"{Scheme}:{Namespace}:{Name}";
    /// <inheritdoc cref="UriString" />
    uri IClaimTypeOrValueType.Uri => uri.From(UriString);

    public virtual bool Equals(Role? other) => (other as IClaimTypeOrValueType)?.Uri == (this as IClaimTypeOrValueType).Uri;

    public override int GetHashCode() => UriString.GetHashCode();
}
