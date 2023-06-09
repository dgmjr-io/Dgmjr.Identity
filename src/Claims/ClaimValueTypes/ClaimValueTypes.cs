#pragma warning disable
namespace Dgmjr.Identity;
using Dgmjr.Identity;
using static Dgmjr.Identity.ClaimTypeUris;
using static Dgmjr.Identity.ClaimValueTypeUris;

using NS = Dgmjr.Identity.ClaimValueTypeUris.Namespaces;

using SysSecCvt = System.Security.Claims.ClaimValueTypes;


/// <summary>Defines claim value types according to the type URIs defined by W3C and OASIS. This class cannot be inherited.</summary>
public static partial class ClaimValueTypeUris
{
    /// <summary>A URI for representing a claim value types</summary>
    /// <value><c>urn:identity:claim:value</c></value>
    public const string BaseUri = "urn:identity:claim:value";

    /// <summary>A URI pattern for representing a generic claim type</summary>
    /// <value><c><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="NS.Generic" />:{0} </c></value>
    public const string GenericClaimTypePattern = BaseUri + ":" + Namespaces.Generic + ":{0}";

    /// <summary>The base URI for the w3c, <inheritdoc cref="W3CBaseUri" path="/value/node()"/></summary>
    /// <value><c>https://www.w3.org/</c></value>
    public const string W3CBaseUri = "https://www.w3.org/";
    /// <summary>The base URI for the XML schema version 11-2, <inheritdoc cref="XmlSchema11_2Uri" path="/value/node()"/></summary>
    /// <value><inheritdoc cref="W3CBaseUri"/><inheritdoc cref="NS.TR"/><inheritdoc cref="NS.XmlSchema11_2"/></value>
    public const string XmlSchema11_2Uri = $"{W3CBaseUri}{NS.TR}{NS.XmlSchema11_2}";
    /// <summary>
    /// A URI for representing URI claim value types, <inheritdoc cref="AnyUri" path="/value/node()" />
    /// </summary>
    /// <value><inheritdoc cref="XmlSchema11_2Uri" path="/value/node()" /><inheritdoc cref="NS.AnyUriAnchor" path="/value/node()" /></value>
    public const string AnyUri = "urn:";
    /// <summary>A URI for representing a phone number</summary>
    /// <value><inheritdoc cref="DgmjrCt.IdentityClaimBaseUri" path="/value" /><inheritdoc cref="NS.Schema" path="/value" /><inheritdoc cref="NS.PhoneNumber" path="/value" /></value>
    public const string Json = $"{DgmjrCt.IdentityClaimBaseUri}{NS.Schema}{NS.Json}";
    /// <summary>A URI for representing a phone number</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="NS.PhoneNumber" path="/value" /></value>
    public const string PhoneNumber = $"{BaseUri}:{NS.PhoneNumber}";

    public const string xs = nameof(xs);

    /// <summary>A URI that represents the base64Binary XML data type.</summary>
    /// <value>xs:base64Binary</value>
    public const string Base64Binary = SysSecCvt.Base64Binary;
    /// <summary>A URI that represents the base64Octet XML data type.</summary>
    /// <value>xs:base64Octet</value>
    public const string Base64Octet = SysSecCvt.Base64octet;
    /// <summary>A URI that represents the boolean XML data type.</summary>
    /// <value>xs:boolean</value>
    public const string Boolean = SysSecCvt.Boolean;
    /// <summary>A URI that represents the date XML data type.</summary>
    /// <value>xs:date</value>
    public const string Date = SysSecCvt.Date;
    /// <summary>A URI that represents the dateTime XML data type.</summary>
    /// <value>xs:dateTime</value>
    public const string DateTime = SysSecCvt.Datetime;
    /// <summary>A URI that represents the daytimeDuration XQuery data type.</summary>
    /// <value>http://www.w3.org/TR/2002/WD-xquery-operators-20020816#dayTimeDuration</value>
    public const string DaytimeDuration = SysSecCvt.Daytimeduration;
    /// <summary>A URI that represents the dns SOAP data type.</summary>
    /// <value>http://schemas.xmlsoap.org/claims/dns</value>
    public const string DnsName = SysSecCvt.Dnsname;
    /// <summary>A URI that represents the double XML data type.</summary>
    /// <value>xs:double</value>
    public const string Double = SysSecCvt.Double;
    /// <summary>A URI that represents the DSAKeyValue XML Signature data type.</summary>
    /// <value>http://www.w3.org/2000/09/xmldsig#DSAKeyValue</value>
    /// <summary>A URI that represents the emailaddress SOAP data type.</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress</value>
    /// <summary>A URI that represents the fqbn XML data type.</summary>
    /// <value>xs:fqbn</value>
    public const string Fqbn = SysSecCvt.Fqbn;
    /// <summary>A URI that represents the hexBinary XML data type.</summary>
    /// <value>xs:hexBinary</value>
    public const string HexBinary = SysSecCvt.Hexbinary;
    /// <summary>A URI that represents the integer XML data type.</summary>
    /// <value>xs:integer</value>
    public const string Integer = SysSecCvt.Integer;
    /// <summary>A URI that represents the integer32 XML data type.</summary>
    /// <value>xs:integer32</value>
    public const string Integer32 = SysSecCvt.Integer32;
    /// <summary>A URI that represents the integer64 XML data type.</summary>
    /// <value>xs:integer64</value>
    public const string Integer64 = SysSecCvt.Integer64;
    /// <summary>A URI that represents the KeyInfo XML Signature data type.</summary>
    /// <value>http://www.w3.org/2000/09/xmldsig#KeyInfo</value>
    public const string KeyInfo = SysSecCvt.KeyInfo;//"http://www.w3.org/2000/09/xmldsig#KeyInfo";
    /// <summary>A URI that represents the rfc822Name XACML 1.0 data type.</summary>
    /// <value>urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name</value>
    public const string Rfc822Name = SysSecCvt.Rfc822name;
    /// <summary>A URI that represents the rsa SOAP data type.</summary>
    /// <value><http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa/value>
    public const string Rsa = SysSecCvt.Rsa;
    /// <summary>A URI that represents the RSAKeyValue XML Signature data type.</summary>
    /// <value>http://www.w3.org/2000/09/xmldsig#RSAKeyValue</value>
    public const string RsaKeyValue = SysSecCvt.Rsakeyvalue;
    /// <summary>A URI that represents the sid XML data type.</summary>
    /// <value>xs:sid</value>
    public const string Sid = SysSecCvt.Sid;
    /// <summary>A URI that represents the string XML data type.</summary>
    /// <value>xs:string</value>
    public const string String = SysSecCvt.String;
    /// <summary>A URI that represents the time XML data type.</summary>
    /// <value>xs:time</value>
    public const string Time = SysSecCvt.Time;
    /// <summary>A URI that represents the uinteger32 XML data type.</summary>
    /// <value>xs:uinteger32</value>
    public const string UInteger32 = SysSecCvt.Uinteger32;
    /// <summary>A URI that represents the uinteger64 XML data type.</summary>
    /// <value>xs:uinteger64</value>
    public const string UInteger64 = SysSecCvt.Uinteger64;
    /// <summary>A URI that represents the UPN SOAP data type.</summary>
    /// <value>http://schemas.xmlsoap.org/claims/UPN</value>
    public const string UpnName = SysSecCvt.Upnname;
    /// <summary>A URI that represents the x500Name XACML 1.0 data type.</summary>
    /// <value>urn:oasis:names:tc:xacml:1.0:data-type:x500Name</value>
    public const string X500Name = SysSecCvt.X500name;
    /// <summary>A URI that represents the yearMonthDuration XQuery data type.</summary>
    /// <value>http://www.w3.org/TR/2002/WD-xquery-operators-20020816#yearMonthDuration</value>
    public const string YearMonthDuration = SysSecCvt.Yearmonthduration;

    /// <summary>A URI that represents an unknown claim value type</summary>
    /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="NS.Unknown" path="/value" /></value>
    public const string Unknown = $"{BaseUri}:{NS.Unknown}";
}

// public static class ClaimValueTypeUris
// {
//     /// <inheritdoc cref="ClaimValueTypes.W3CBaseUri" path="//node()" />
//     public static readonly @uri W3CBaseUri = uri.From(ClaimValueTypes.W3CBaseUri);
//     /// <inheritdoc cref="ClaimValueTypes.XmlSchema11_2Uri" path="/node()" />
//     public static readonly @uri XmlSchema11_2Uri = uri.From(ClaimValueTypes.XmlSchema11_2Uri);
//     /// <inheritdoc cref="ClaimValueTypes.AnyUri" path="/node()" />
//     public static readonly @uri AnyUriClaimValueType = uri.From(ClaimValueTypes.AnyUri);
// }

// /// <summary>A URI that represents a null claim value type</summary>
// /// <value><c>null</c></value>
// public static readonly ClaimValueType NullClaimValueType = (null as Uri)!;

// /// <summary>
// /// A URI that represents the boolean XML data type.
// /// </summary>
// /// <value>xs:boolean</value>
// public static readonly ClaimValueType BooleanClaimValueType = new(SysSecVt.Boolean, "A URI that represents the boolean XML data type.", v => v.RuleFor(c => c.Value).Must(v => bool.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the emailaddress SOAP data type.
// /// </summary>
// /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress</value>
// public static readonly ClaimValueType EmailClaimValueType = new(SysSecVt.Email, "A URI that represents the emailaddress SOAP data type.", v => v.RuleFor(c => c.Value).EmailAddress());
// /// <summary>
// /// A URI that represents the string XML data type.
// /// </summary>
// /// <value>xs:string</value>
// public static readonly ClaimValueType StringClaimValueType = new(SysSecVt.String, "A URI that represents the string XML data type.", v => v.RuleFor(c => c.Value));
// /// <summary>
// /// A URI that represents the sid XML data type.  xs:sid
// /// </summary>
// /// <value>xs:sid</value>
// public static readonly ClaimValueType SidClaimValueType = new(SysSecVt.Sid, "A URI that represents the sid XML data type.", v => v.RuleFor(c => c.Value));
// /// <summary>
// /// A URI that represents the date XML data type.  xs:date
// /// </summary>
// /// <value>xs:date</value>
// public static readonly ClaimValueType DateClaimValueType = new(SysSecVt.Date, "A URI that represents the date XML data type.", v => v.RuleFor(c => c.Value).Must(v => System.DateTime.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the date XML data type.  xs:dateTime
// /// </summary>
// /// <value>xs:dateTime</value>
// public static readonly ClaimValueType DateTimeClaimValueType = new(SysSecVt.DateTime, "A URI that represents the date XML data type.", v => v.RuleFor(c => c.Value).Must(v => System.DateTime.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the integer32 XML data type.  xs:integer32
// /// </summary>
// /// <value>xs:integer32</value>
// public static readonly ClaimValueType Integer64ClaimValueType = new(SysSecVt.Integer64, "A URI that represents the integer64 XML data type.", v => v.RuleFor(c => c.Value).Must(v => long.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the integer32 XML data type.  xs:integer32"
// /// </summary>
// /// <value>xs:integer32</value>
// public static readonly ClaimValueType Integer32ClaimValueType = new(SysSecVt.Integer32, "A URI that represents the integer32 XML data type.", v => v.RuleFor(c => c.Value).Must(v => int.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the unsigned integer64 XML data type.  xs:uinteger64
// /// </summary>
// // <value>xs:uinteger64</value>
// public static readonly ClaimValueType UnsignedInteger64ClaimValueType = new(SysSecVt.UInteger64, "A URI that represents the integer64 XML data type.", v => v.RuleFor(c => c.Value).Must(v => long.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the unsigned integer32 XML data type.  xs:uinteger32"
// /// </summary>
// /// <value>xs:uinteger32</value>
// public static readonly ClaimValueType UnsignedInteger32ClaimValueType = new(SysSecVt.UInteger32, "A URI that represents the integer32 XML data type.", v => v.RuleFor(c => c.Value).Must(v => int.TryParse(v, out var result)));
// /// <summary>
// /// A URI that represents the base64Binary XML data type.  xs:base64Binary
// /// </summary>
// // <value>xs:base64Binary</value>
// public static readonly ClaimValueType Base64BinaryClaimValueType = new(SysSecVt.Base64Binary, "A URI that represents the base64Binary XML data type.", v => v.RuleFor(c => c.Value).Must(c => true));

// /// <summary>
// /// A URI that represents the URI data type. <inheritdoc cref="UriStrings.AnyUri" />
// /// </summary>
// /// <value><inheritdoc cref="UriStrings.AnyUri"/></value>
// public const string UriClaimValueTypeString = UriStrings.AnyUri;
// /// <summary>
// /// <inheritdoc cref="UriClaimValueTypeString"/>
// /// </summary>
// public static readonly ClaimValueType UriClaimValueType = new(UriClaimValueTypeString, "A URI that represents the URI data type.", v => v.RuleFor(c => c.Value).Must(v => System.Uri.TryCreate(v, RelativeOrAbsolute, out Uri? result)));
// /// <summary>
// /// A URI that represents the phone number XML data type.  See <inheritdoc cref="UriStrings.PhoneNumber"/>
// /// </summary>
// public const string PhoneNumberClaimValueTypeString = UriStrings.PhoneNumber;
// /// <summary>
// /// A URI that represents the phone number XML data type.
// /// </summary>
// public static readonly ClaimValueType PhoneNumberClaimValueType = new(PhoneNumberClaimValueTypeString, "A URI that represents the phone number XML data type.", v => v.RuleFor(c => c.Value).Must(c => true));
// /// <summary>
// /// A URI that represents a JSON data type.  <inheritdoc cref="UriStrings.Json"/>schema#JSON
// /// </summary>
// public const string JsonClaimValueTypeString = UriStrings.Json;
// /// <summary>
// /// <inheritdoc cref="UriStrings.Json"/>
// /// </summary>
// public static readonly ClaimValueType JsonClaimValueType = new(JsonClaimValueTypeString, "A URI that represents the JSON data type.", v => v.RuleFor(c => c.Value).Must(claim =>
// {
//     try { var deserializedResult = Deserialize<JElem>(claim); return true; }
//     catch { return false; }
// }));
