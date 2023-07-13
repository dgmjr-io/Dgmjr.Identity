namespace Dgmjr.Identity;

public static class Constants
{
    /// <summary>A constant representing the long URI prefix for items in the <inheritdoc cref="Dgmjr_IO" path="/value" /> namespace.</summary>
    /// <value>https://dgmjr.io</value>
    public const string Dgmjr_IO = "https://dgmjr.io";

    /// <summary>A constant representing the long URI prefix for items in the <inheritdoc cref="DgmjrIoIdentity" path="/value" /> namespace.</summary>
    /// <value><inheritdoc cref="Dgmjr_IO" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="identity" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="claims" path="/value" /></value>
    public const string DgmjrIoIdentity = Dgmjr_IO + DefaultLongUriSeparator + identity + DefaultLongUriSeparator + claims;

    /// <summary>A constant representing thhe short URI prefix for items in the <inheritdoc cref="Dgmjr" path="/value" /> namespace.</summary>
    /// <value>dgmjr</value>
    public const string Dgmjr = "dgmjr";

    /// <summary>A constant representing the default long URI prefix (<inheritdoc cref="Dgmjr_IO" path="/value" />).</summary>
    /// <value><inheritdoc cref="Dgmjr_IO" path="/value" /></value>
    public const string DefaultLongUriPrefix = DgmjrIoIdentity;
    /// <summary>A constant representing the default short URI prefix (<inheritdoc cref="Dgmjr" path="/value" />).</summary>
    /// <value><inheritdoc cref="Dgmjr" path="/value" /></value>
    public const string DefaultShortUriPrefix = Dgmjr;

    /// <summary>A constant representing thhe default claim name.</summary>
    /// <value>claims</value>
    public const string DefaultClaimName = "claims";

    /// <summary>A constant representing thhe default identity name.</summary>
    /// <value>identity</value>
    public const string identity = nameof(identity);
    /// <summary>A constant representing thhe default value name.</summary>
    /// <value>value</value>
    public const string value = nameof(value);
    /// <summary>A constant representing the default claim name.</summary>
    /// <value>claim</value>
    public const string claim = nameof(claim);
    /// <summary>A constant representing the default long URI separator.</summary>
    /// <value>/</value>
    public const string DefaultLongUriSeparator = "/";
    /// <summary>A constant representing the default short URI separator.</summary>
    /// <value>:</value>
    public const string DefaultShortUriSeparator = ":";

    /// <summary>A constant representing the short <inheritdoc cref="ws" path="/value" /> prefix.</summary>
    /// <value>ws</value>
    public const string ws = nameof(ws);

    /// <summary>A constant containing the value "<inheritdoc cref="claims" path="/value" />".</summary>
    /// <value>claims</value>
    public const string claims = nameof(claims);

    /// <summary>A constant representing the short <inheritdoc cref="soap" path="/value" /> prefix.</summary>
    /// <value>ws</value>
    public const string soap = ws;
    /// <summary>A constant containing the value "<inheritdoc cref="role" path="/value" />".</summary>
    /// <value>role</value>
    public const string role = nameof(role);

    /// <summary>A constant containing the value "<inheritdoc cref="Ldap" path="/value" />".</summary>
    /// <value>ldap://</value>
    public const string Ldap = "ldap://";

    /// <summary>A constant containing the value "<inheritdoc cref="ldap" path="/value" />".</summary>
    /// <value>ldap</value>
    public const string ldap = "ldap";

    /// <summary>A constant containing the value "default."</summary>
    /// <value>default</value>
    public const string @default = nameof(@default);

    /// <summary>A constant containing the value "<inheritdoc cref="users" path="/value" />".</summary>
    /// <value>users</value>
    public const string users = nameof(users);
    /// <summary>A constant containing the value "<inheritdoc cref="identity_provider" path="/value" />".</summary>
    /// <value>identity_provider</value>
    public const string identity_provider = nameof(identity_provider);

    /// <summary>A constant containing the value "<inheritdoc cref="XmlSoapOrg" path="/value" />" namespace.</summary>
    /// <value>http://schemas.xmlsoap.org</value>
    public const string XmlSoapOrg = "http://schemas.xmlsoap.org";

    /// <summary>A constant string representing the <inheritdoc cref="Soap" path="/value" /> long URI prefix.</summary> 
    /// <value><inheritdoc cref="XmlSoapOrg" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="claims" path="/value" /></value>
    public const string Soap = XmlSoapOrg + DefaultLongUriSeparator + claims;


    /// <summary>A constant string representing the <inheritdoc cref="Soap2005" path="/value" /> namespace.</summary> 
    /// <value><inheritdoc cref="XmlSoapOrg" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="ws" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" />2005/05</value>
    public const string Soap2005 = XmlSoapOrg + DefaultLongUriSeparator + ws + "/2005/05";

    /// <summary>A constant string representing the <inheritdoc cref="Soap2009" path="/value" /> namespace.</summary> 
    /// <value><inheritdoc cref="XmlSoapOrg" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="ws" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" />2009/09</value>
    public const string Soap2009 = XmlSoapOrg + DefaultLongUriSeparator + ws + "/2009/09";

    /// <summary>A constant string representing the <inheritdoc cref="Microsoft2008" path="/value" /> namespace</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06</value>
    public const string Microsoft2008 = "http://schemas.microsoft.com/ws/2008/06";

    /// <summary>A constant string representing the <inheritdoc cref="Soap2005Identity" path="/value" /> namespace</summary>
    /// <value><inheritdoc cref="XmlSoapOrg" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="ws" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" />2005/05/identity/claims</value>
    public const string Soap2005Identity = Soap2005 + DefaultLongUriSeparator + identity + DefaultLongUriSeparator + claims;

    /// <summary>A constant string representing the <inheritdoc cref="Soap2009Identity" path="/value" /> namespace</summary>
    /// <value><inheritdoc cref="XmlSoapOrg" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" /><inheritdoc cref="ws" path="/value" /><inheritdoc cref="DefaultLongUriSeparator" path="/value" />2009/09/identity/claims</value>
    public const string Soap2009Identity = Soap2009 + DefaultLongUriSeparator + identity + DefaultLongUriSeparator + claims;

    /// <summary>A constant string representing the <inheritdoc cref="Microsoft2008Identity" path="/value" /> namespace</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims</value>
    public const string Microsoft2008Identity = "http://schemas.microsoft.com/ws/2008/06/identity/claims";
}
