namespace Dgmjr.Identity;

using global::System;
using global::System.Security;

public abstract record class ClaimType : IIdentityComponent, IClaimType
{
    string IIdentityComponent.Namespace => "about";
    string IIdentityComponent.Name => "blank";
    string IHaveAUriString.UriString => $"{((IIdentityComponent)this).Namespace}";
    string IIdentityComponent.ShortNamespace => "about";
    string IIdentityComponent.ShortUriString => "about:blank";
    public virtual uri Uri => ((IIdentityComponent)this).UriString;
    public virtual uri ShortUri => ((IIdentityComponent)this).ShortUriString;

    public virtual bool
        Equals(IIdentityComponent? other) => Equals(other as IClaimType);

    public virtual bool Equals(ClaimType? other) => Equals(other as IClaimType);

    public virtual bool Equals(IClaimType? other)
    {
        return other is not null && (ReferenceEquals(this, other) ||
                                     ((IClaimType)this).Uri == other.Uri);
    }

    public override int GetHashCode() => ((IClaimType)this).GetHashCode();
}

public partial record class ClaimType<TValueType> : ClaimType
    where TValueType : IEquatable<TValueType>, IClaimValueType
{
    /// <value>http://schemas.microsoft.com</value>
    public const string NamespacePrefix = "http://schemas.microsoft.com";

    /// <summary>Claim Type 2008 Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value"
    /// />/ws/2008/06/identity/claims</value>
    public const string Namespace2008 =
        NamespacePrefix + "/ws/2008/06/identity/claims";

    /// <summary>Claim Type Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value" />/claims</value>
    public const string Namespace = NamespacePrefix + "/claims";

    /// <summary>Short Claim Type Namespace</summary>
    /// <value>ws</value>
    public const string ShortNamespace = "ws";

    /// <summary>Short Claim Type 2008 Namespace</summary>
    /// <value>ws:2008</value>
    public const string ShortNamespace2008 = "ws:2009";

    /// <summary>Claim Type 2005 Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value"
    /// />/ws/2005/05/identity/claims</value>
    public const string Namespace2005 =
        NamespacePrefix + "/ws/2005/05/identity/claims";

    /// <summary>Short Claim Type 2009 Namespace</summary>
    /// <value>ws:2005</value>
    public const string ShortNamespace2005 = "ws:2005";

    /// <summary>Claim Type 2009 Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value"
    /// />/ws/2009/09/identity/claims</value>
    public const string Namespace2009 =
        NamespacePrefix + "/ws/2009/09/identity/claims";

    /// <summary>Short Claim Type 2009 Namespace</summary>
    /// <value>ws:2009</value>
    public const string ShortNamespace2009 = "ws:2009";
}
