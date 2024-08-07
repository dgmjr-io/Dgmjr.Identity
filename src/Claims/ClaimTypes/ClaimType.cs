namespace Dgmjr.Identity;

using global::System;
using global::System.Security;

public abstract record sealed class ClaimType : IClaimType, IEquatable<ClaimType>
{
    /// <summary>The forward slash ("<inheritdoc cref="Slash" path="/value" />") character</summary>
    /// <value>/</value>
    public const string Slash = "/";

    /// <summary>The colon ("<inheritdoc cref="Colon" path="/value" />") character</summary>
    /// <value>:</value>
    public const string Colon = ":";

    /// <value>https://jwt.io</value>
    public const string JwtNamespace = "https://jwt.io";

    /// <value>jwt</value>
    public const string ShortJwtNamespace = "jwt";

    /// <value>http://schemas.microsoft.com</value>
    public const string NamespacePrefix = "http://schemas.microsoft.com";

    /// <value>http://schemas.xmlsoap.org</value>
    public const string SoapNamespacePrefix = "http://schemas.xmlsoap.org";

    /// <summary>Claim Type 2008 Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value" />/ws/2008/06/identity/claims</value>
    public const string Namespace2008 = NamespacePrefix + "/ws/2008/06/identity/claims";

    /// <summary>Claim Type 2012 Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value" />/ws/2012/01</value>
    public const string Namespace2012 = NamespacePrefix + "/ws/2012/01";

    /// <summary>Claim Type Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value" />/identity/claims</value>
    public const string Namespace = NamespacePrefix + "/identity/claims";

    /// <summary>Claim Type Namespace</summary>
    /// <value><inheritdoc cref="NamespacePrefix" path="/value" />/claims</value>
    public const string MicrosoftNamespace = NamespacePrefix + "/claims";

    /// <summary>Short Claim Type Namespace</summary>
    /// <value>ws</value>
    public const string ShortNamespace = "ws";

    /// <summary>Short Claim Type 2008 Namespace</summary>
    /// <value>ws:2008</value>
    public const string ShortNamespace2008 = "ws:2009";

    /// <summary>Short SAML Namespace</summary>
    /// <value>saml</value>
    public const string ShortSamlNamespace = "saml";

    /// <summary>Short Claim Type 2012 Namespace</summary>
    /// <value>saml:2012</value>
    public const string ShortNamespace2012 = "saml:2012";

    /// <summary>Claim Type 2005 Namespace</summary>
    /// <value><inheritdoc cref="SoapNamespacePrefix" path="/value" />/ws/2005/05/identity/claims</value>
    public const string Namespace2005 = SoapNamespacePrefix + "/ws/2005/05/identity/claims";

    /// <summary>Short Claim Type 2009 Namespace</summary>
    /// <value>ws:2005</value>
    public const string ShortNamespace2005 = "ws:2005";

    /// <summary>Claim Type 2009 Namespace</summary>
    /// <value><inheritdoc cref="SoapNamespacePrefix" path="/value" />/ws/2009/09/identity/claims</value>
    public const string Namespace2009 = SoapNamespacePrefix + "/ws/2009/09/identity/claims";

    /// <summary>Short Claim Type 2009 Namespace</summary>
    /// <value>ws:2009</value>
    public const string ShortNamespace2009 = "ws:2009";

    /// <value><inheritdoc cref="_Namespace" path="/value" />:<inheritdoc cref="_Name" path="/value" /></value>
    public const string UriString = $"{_Namespace}:{_Name}";

    /// <value>blank</value>
    private const string _Name = "blank";

    /// <value>about</value>
    private const string _Namespace = "about";

    /// <value><inheritdoc cref="_Namespace" path="/value" /></value>
    string IIdentityComponent.Namespace => _Namespace;

    /// <value><inheritdoc cref="_Name" path="/value" /></value>
    string IHaveAName.Name => _Name;

    /// <value><inheritdoc cref="UriString" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="_Namespace" path="/value" /></value>
    string IIdentityComponent.ShortNamespace => _Namespace;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public virtual uri Uri => ((IIdentityComponent)this).UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public virtual uri ShortUri => ((IIdentityComponent)this).ShortUriString;

    public virtual bool Equals(IIdentityComponent? other) => Equals(other as IClaimType);

    public virtual bool Equals(ClaimType? other) => Equals(other as IClaimType);

    public virtual bool Equals(IClaimType? other)
    {
        return other is not null
            && (ReferenceEquals(this, other) || ((IClaimType)this).Uri == other.Uri);
    }

    /// <summary>The URI of the claim value type</summary>
    public abstract uri? ClaimValueTypeUri { get; }

    public override int GetHashCode() => Uri.GetHashCode();

    public static ClaimType FromUri(uri uri) => GetAll().First(ct => ct.Uri == uri);

    public static ClaimType Parse(string s) => GetAll().First(ct => ct.Uri == s);

    public static ClaimType[] GetAll() =>
        CurrentDomain
            .GetAssemblies()
            .SelectMany(
                asm =>
                    asm.GetExportedTypes()
                        .Where(
                            t =>
                                !t.ContainsGenericParameters
                                && typeof(ClaimType).IsAssignableFrom(t)
                        )
            )
            .Select(
                t =>
                    t.GetRuntimeField("Instance")?.GetValue(null)
                    ?? (t.GetRuntimeProperty("Instance")?.GetValue(null))
            )
            .OfType<ClaimType>()
            .WhereNotNull()
            .ToArray();
}

public partial record class ClaimType<TValueType> : ClaimType, IClaimType<TValueType>
    where TValueType : IEquatable<TValueType>, IClaimValueType
{
    public override uri? ClaimValueTypeUri =>
        (
            (
                typeof(TValueType).GetRuntimeField("Instance")?.GetValue(null)
                ?? (typeof(TValueType).GetRuntimeProperty("Instance")?.GetValue(null))
            ) as IClaimValueType
        )?.Uri;
}
