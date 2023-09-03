namespace Dgmjr.Identity;
using global::System;
using global::System.Security;

public partial class ClaimType : ClaimTypeOrValueType, IClaimType
{
    public override bool Equals(IClaimTypeOrValueType? other)
        => Equals(other as IClaimType);

    public virtual bool Equals(ClaimType? other)
        => Equals(other as IClaimType);

    public virtual bool Equals(IClaimType? other)
    {
        return other is not null && (ReferenceEquals(this, other) || ((IClaimType)this).Uri == other.Uri);
    }

    string IClaimTypeOrValueType.Namespace => "about";
    string IClaimTypeOrValueType.Name => "blank";
    string IClaimTypeOrValueType.UriString => $"{((IClaimTypeOrValueType)this).Namespace}";
    string IClaimTypeOrValueType.ShortNamespace => "about";
    string IClaimTypeOrValueType.ShortUriString => "about:blank";
    public virtual uri Uri => ((IClaimTypeOrValueType)this).UriString;
    public virtual uri ShortUri => ((IClaimTypeOrValueType)this).ShortUriString;

    public override bool Equals(object? other) => Equals(other as ClaimType);

    public override int GetHashCode() => ((IClaimType)this).GetHashCode();

    /// <summary>ClaimTypeNamespace</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims</value>
    public const string ClaimTypeNamespace = "http://schemas.microsoft.com/ws/2008/06/identity/claims";

    /// <summary>ShortClaimTypeNamespace</summary>
    /// <value>ws</value>
    public const string ShortClaimTypeNamespace = "ws";

    /// <summary>Claim Type 2005 Namespace</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims</value>
    public const string ClaimType2005Namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";


    /// <summary>ShortClaimTypeNamespace</summary>
    /// <value>ws:2005</value>
    public const string ShortClaimType2005Namespace = "ws:2005";

    /// <summary>Claim Type 2009 Namespace</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims</value>
    public const string ClaimType2009Namespace = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims";

    /// <summary>ShortClaimTypeNamespace</summary>
    /// <value>w:2009</value>
    public const string ShortClaimType2009Namespace = "ws:2009";
}
