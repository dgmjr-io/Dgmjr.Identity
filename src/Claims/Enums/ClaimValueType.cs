// /* 
//  * ClaimValueType.cs
//  * 
//  *   Created: 2023-03-29-01:25:48
//  *   Modified: 2023-03-29-01:25:48
//  * 
//  *   Author: David G. Moore, Jr. <david@dgmjr.io>
//  *   
//  *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */

// namespace Dgmjr.Identity.Claims.Enums;

// [GenerateEnumerationClass("ClaimValueType", "Dgmjr.Identity")]
// public enum ClaimValueType
// {
//     /// <summary>A URI for representing a claim value types</summary>
//     /// <value><c>urn:identity:claim:value</c></value>
//     [Display(Name = ClaimValueTypeUris.BaseUri, ShortName = nameof(BaseUri))]
//     [Uri(ClaimValueTypeUris.BaseUri)]
//     BaseUri,

//     /// <summary>A URI pattern for representing a generic claim type</summary>
//     /// <value><c><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="NS.Generic" />:{0} </c></value>
//     [Display(Name = ClaimValueTypeUris.GenericClaimTypePattern, ShortName = nameof(GenericClaimTypePattern))]
//     [Uri(ClaimValueTypeUris.GenericClaimTypePattern)]
//     GenericClaimTypePattern,

//     /// <summary>The base URI for the w3c, <inheritdoc cref="W3CBaseUri" path="/value/node()"/></summary>
//     /// <value><c>https://www.w3.org/</c></value>
//     [Display(Name = ClaimValueTypeUris.W3CBaseUri, ShortName = nameof(W3CBaseUri))]
//     [Uri(ClaimValueTypeUris.W3CBaseUri)]
//     W3CBaseUri,
//     /// <summary>The base URI for the XML schema version 11-2, <inheritdoc cref="XmlSchema11_2Uri" path="/value"/></summary>
//     /// <value><inheritdoc cref="W3CBaseUri" path="/value" /><inheritdoc cref="NS.TR" path="/value" /><inheritdoc cref="NS.XmlSchema11_2" path="/value" /></value>
//     [Display(Name = ClaimValueTypeUris.XmlSchema11_2Uri, ShortName = nameof(XmlSchema11_2Uri))]
//     [Uri(ClaimValueTypeUris.XmlSchema11_2Uri)]
//     XmlSchema11_2Uri,
//     /// <summary>
//     /// A URI for representing URI claim value types, <inheritdoc cref="AnyUri" path="/value/node()" />
//     /// </summary>
//     /// <value><inheritdoc cref="XmlSchema11_2Uri" path="/value/node()" /><inheritdoc cref="NS.AnyUriAnchor" path="/value/node()" /></value>
//     [Display(Name = ClaimValueTypeUris.AnyUri, ShortName = nameof(AnyUri))]
//     [Uri(ClaimValueTypeUris.AnyUri)]
//     AnyUri,
//     /// <summary>A URI for representing a phone number</summary>
//     /// <value><inheritdoc cref="DgmjrCt.IdentityClaimBaseUri" path="/value" /><inheritdoc cref="NS.Schema" path="/value" /><inheritdoc cref="NS.PhoneNumber" path="/value" /></value>
//     [Display(Name = ClaimValueTypeUris.Json, ShortName = nameof(Json))]
//     [Uri(ClaimValueTypeUris.Json)]
//     Json,
//     /// <summary>A URI for representing a phone number</summary>
//     /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="NS.PhoneNumber" path="/value" /></value>
//     [Display(Name = ClaimValueTypeUris.PhoneNumber, ShortName = nameof(PhoneNumber))]
//     [Uri(ClaimValueTypeUris.PhoneNumber)]
//     PhoneNumber,

//     /// <summary>A URI that represents the base64Binary XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#base64Binary</value>
//     [Display(Name = ClaimValueTypeUris.Base64Binary, ShortName = nameof(Base64Binary))]
//     [Uri(ClaimValueTypeUris.Base64Binary)]
//     Base64Binary,
//     /// <summary>A URI that represents the base64Octet XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#base64Octet</value>
//     [Display(Name = ClaimValueTypeUris.Base64Octet, ShortName = nameof(Base64Octet))]
//     [Uri(ClaimValueTypeUris.Base64Octet)]
//     Base64Octet,
//     /// <summary>A URI that represents the boolean XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#boolean</value>
//     [Display(Name = ClaimValueTypeUris.Boolean, ShortName = nameof(Boolean))]
//     [Uri(ClaimValueTypeUris.Boolean)]
//     Boolean,
//     /// <summary>A URI that represents the date XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#date</value>
//     [Display(Name = ClaimValueTypeUris.Date, ShortName = nameof(Date))]
//     [Uri(ClaimValueTypeUris.Date)]
//     Date,
//     /// <summary>A URI that represents the dateTime XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#dateTime</value>
//     [Display(Name = ClaimValueTypeUris.DateTime, ShortName = nameof(ClaimValueTypeUris.DateTime))]
//     [Uri(ClaimValueTypeUris.DateTime)]
//     DateTimeValueType,
//     /// <summary>A URI that represents the daytimeDuration XQuery data type.</summary>
//     /// <value>http://www.w3.org/TR/2002/WD-xquery-operators-20020816#dayTimeDuration</value>
//     [Display(Name = ClaimValueTypeUris.DaytimeDuration, ShortName = nameof(DaytimeDuration))]
//     [Uri(ClaimValueTypeUris.DaytimeDuration)]
//     DaytimeDuration,
//     /// <summary>A URI that represents the dns SOAP data type.</summary>
//     /// <value>http://schemas.xmlsoap.org/claims/dns</value>
//     [Display(Name = ClaimValueTypeUris.DnsName, ShortName = nameof(DnsName))]
//     [Uri(ClaimValueTypeUris.DnsName)]
//     DnsName,
//     /// <summary>A URI that represents the double XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#double</value>
//     [Display(Name = ClaimValueTypeUris.Double, ShortName = nameof(Double))]
//     [Uri(ClaimValueTypeUris.Double)]
//     Double,
//     /// <summary>A URI that represents the DSAKeyValue XML Signature data type.</summary>
//     /// <value>http://www.w3.org/2000/09/xmldsig#DSAKeyValue</value>
//     [Display(Name = ClaimValueTypeUris.DsaKeyValue, ShortName = nameof(DsaKeyValue))]
//     [Uri(ClaimValueTypeUris.DsaKeyValue)]
//     DsaKeyValue,
//     /// <summary>A URI that represents the emailaddress SOAP data type.</summary>
//     /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress</value>
//     [Display(Name = ClaimValueTypeUris.EmailAddress, ShortName = nameof(EmailAddress))]
//     [Uri(ClaimValueTypeUris.EmailAddress)]
//     EmailAddress,
//     /// <summary>A URI that represents the fqbn XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#fqbn</value>
//     [Display(Name = ClaimValueTypeUris.Fqbn, ShortName = nameof(Fqbn))]
//     [Uri(ClaimValueTypeUris.Fqbn)]
//     Fqbn,
//     /// <summary>A URI that represents the hexBinary XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#hexBinary</value>
//     [Display(Name = ClaimValueTypeUris.HexBinary, ShortName = nameof(HexBinary))]
//     [Uri(ClaimValueTypeUris.HexBinary)]
//     HexBinary,
//     /// <summary>A URI that represents the integer XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#integer</value>
//     [Display(Name = ClaimValueTypeUris.Integer, ShortName = nameof(Integer))]
//     [Uri(ClaimValueTypeUris.Integer)]
//     Integer,
//     /// <summary>A URI that represents the integer32 XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#integer32</value>
//     [Display(Name = ClaimValueTypeUris.Integer32, ShortName = nameof(Integer32))]
//     [Uri(ClaimValueTypeUris.Integer32)]
//     Integer32,
//     /// <summary>A URI that represents the integer64 XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#integer64</value>
//     [Display(Name = ClaimValueTypeUris.Integer64, ShortName = nameof(Integer64))]
//     [Uri(ClaimValueTypeUris.Integer64)]
//     Integer64,
//     /// <summary>A URI that represents the KeyInfo XML Signature data type.</summary>
//     /// <value>http://www.w3.org/2000/09/xmldsig#KeyInfo</value>
//     [Display(Name = ClaimValueTypeUris.KeyInfo, ShortName = nameof(KeyInfo))]
//     [Uri(ClaimValueTypeUris.KeyInfo)]
//     KeyInfo,
//     /// <summary>A URI that represents the rfc822Name XACML 1.0 data type.</summary>
//     /// <value>urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name</value>
//     [Display(Name = ClaimValueTypeUris.Rfc822Name, ShortName = nameof(Rfc822Name))]
//     [Uri(ClaimValueTypeUris.Rfc822Name)]
//     Rfc822Name,
//     /// <summary>A URI that represents the rsa SOAP data type.</summary>
//     /// <value><http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa/value>
//     [Display(Name = ClaimValueTypeUris.Rsa, ShortName = nameof(Rsa))]
//     [Uri(ClaimValueTypeUris.Rsa)]
//     Rsa,
//     /// <summary>A URI that represents the RSAKeyValue XML Signature data type.</summary>
//     /// <value>http://www.w3.org/2000/09/xmldsig#RSAKeyValue</value>
//     [Display(Name = ClaimValueTypeUris.RsaKeyValue, ShortName = nameof(RsaKeyValue))]
//     [Uri(ClaimValueTypeUris.RsaKeyValue)]
//     RsaKeyValue,
//     /// <summary>A URI that represents the sid XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#sid</value>
//     [Display(Name = ClaimValueTypeUris.Sid, ShortName = nameof(Sid))]
//     [Uri(ClaimValueTypeUris.Sid)]
//     Sid,
//     /// <summary>A URI that represents the string XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#string</value>
//     [Display(Name = ClaimValueTypeUris.String, ShortName = nameof(ClaimValueTypeUris.String))]
//     [Uri(ClaimValueTypeUris.String)]
//     StringValueType,
//     /// <summary>A URI that represents the time XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#time</value>
//     [Display(Name = ClaimValueTypeUris.Time, ShortName = nameof(Time))]
//     [Uri(ClaimValueTypeUris.Time)]
//     Time,
//     /// <summary>A URI that represents the uinteger32 XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#uinteger32</value>
//     [Display(Name = ClaimValueTypeUris.UInteger32, ShortName = nameof(UInteger32))]
//     [Uri(ClaimValueTypeUris.UInteger32)]
//     UInteger32,
//     /// <summary>A URI that represents the uinteger64 XML data type.</summary>
//     /// <value>http://www.w3.org/2001/XMLSchema#uinteger64</value>
//     [Display(Name = ClaimValueTypeUris.UInteger64, ShortName = nameof(UInteger64))]
//     [Uri(ClaimValueTypeUris.UInteger64)]
//     UInteger64,
//     /// <summary>A URI that represents the UPN SOAP data type.</summary>
//     /// <value>http://schemas.xmlsoap.org/claims/UPN</value>
//     [Display(Name = ClaimValueTypeUris.UpnName, ShortName = nameof(UpnName))]
//     [Uri(ClaimValueTypeUris.UpnName)]
//     UpnName,
//     /// <summary>A URI that represents the x500Name XACML 1.0 data type.</summary>
//     /// <value>urn:oasis:names:tc:xacml:1.0:data-type:x500Name</value>
//     [Display(Name = ClaimValueTypeUris.X500Name, ShortName = nameof(X500Name))]
//     [Uri(ClaimValueTypeUris.X500Name)]
//     X500Name,
//     /// <summary>A URI that represents the yearMonthDuration XQuery data type.</summary>
//     /// <value>http://www.w3.org/TR/2002/WD-xquery-operators-20020816#yearMonthDuration</value>
//     [Display(Name = ClaimValueTypeUris.YearMonthDuration, ShortName = nameof(YearMonthDuration))]
//     [Uri(ClaimValueTypeUris.YearMonthDuration)]
//     YearMonthDuration,

//     /// <summary>A URI that represents an unknown claim value type</summary>
//     /// <value><inheritdoc cref="BaseUri" path="/value" />:<inheritdoc cref="NS.Unknown" path="/value" /></value>
//     [Display(Name = ClaimValueTypeUris.Unknown, ShortName = nameof(Unknown))]
//     [Uri(ClaimValueTypeUris.Unknown)]
//     Unknown,
// }
