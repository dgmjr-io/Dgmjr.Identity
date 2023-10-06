namespace Dgmjr.Identity;

using global::System;
using global::System.Security;

public partial record class ClaimType : IdentityComponent, IClaimType
{
    public override bool Equals(IIdentityComponent? other) => Equals(other as IClaimType);

    public virtual bool Equals(ClaimType? other) => Equals(other as IClaimType);

    public virtual bool Equals(IClaimType? other)
    {
        return other is not null
            && (ReferenceEquals(this, other) || ((IClaimType)this).Uri == other.Uri);
    }

    string IIdentityComponent.Namespace => "about";
    string IIdentityComponent.Name => "blank";
    string IHaveAUriString.UriString => $"{((IIdentityComponent)this).Namespace}";
    string IIdentityComponent.ShortNamespace => "about";
    string IIdentityComponent.ShortUriString => "about:blank";
    public virtual uri Uri => ((IIdentityComponent)this).UriString;
    public virtual uri ShortUri => ((IIdentityComponent)this).ShortUriString;

    public override int GetHashCode() => ((IClaimType)this).GetHashCode();

    /// <summary>Claim Type 2008 Namespace</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims</value>
    public const string ClaimType2008Namespace =
        "http://schemas.microsoft.com/ws/2008/06/identity/claims";

    /// <summary>Short Claim Type 2008 Namespace</summary>
    /// <value>ws:2008</value>
    public const string ShortClaimType2008Namespace = "ws:2009";

    /// <summary>Claim Type 2005 Namespace</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims</value>
    public const string ClaimType2005Namespace =
        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";

    /// <summary>Short Claim Type 2009 Namespace</summary>
    /// <value>ws:2005</value>
    public const string ShortClaimType2005Namespace = "ws:2005";

    /// <summary>Claim Type 2009 Namespace</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims</value>
    public const string ClaimType2009Namespace =
        "http://schemas.xmlsoap.org/ws/2009/09/identity/claims";

    /// <summary>Short Claim Type 2009 Namespace</summary>
    /// <value>ws:2009</value>
    public const string ShortClaimType2009Namespace = "ws:2009";
}
