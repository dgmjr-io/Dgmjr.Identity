/*
 * ClaimTypeUris.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity;
using NS = Dgmjr.Identity.ClaimTypeUris.Namespaces;

// [GenerateEnumerationClass("Dgmjr.Identity.ClaimTypes", "ClaimTypes")]
public static partial class ClaimTypeUris
{
    public const string IdentityClaimBaseUri = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/";

    /// <summary>The URI for a claim that specifies the actor</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor.</value>
    public const string Actor = "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor/";
    /// <summary>The URI for a claim that specifies the anonymous user</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous.</value>
    public const string Anonymous = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous/";
    /// <summary>The URI for a claim that specifies details about whether an identity is authenticated</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated.</value>
    public const string Authentication = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated/";
    /// <summary>The URI for a claim that specifies the instant at which an entity was authenticated</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant.</value>
    public const string AuthenticationInstant = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant/";
    /// <summary>The URI for a claim that specifies the method with which an entity was authenticated</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod.</value>
    public const string AuthenticationMethod = "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod/";
    /// <summary>The URI for a claim that specifies an authorization decision on an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision.</value>
    public const string AuthorizationDecision = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision/";
    /// <summary>The URI for a claim that specifies the cookie path</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath.</value>
    public const string CookiePath = "http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath/";
    // /// <summary>The URI for a claim that specifies the country/region in which an entity resides</summary>
    // /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country.</value>
    // public const string Country = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country/";

    /// <summary>The URI for a claim that specifies the "common name" of an entity, <inheritdoc cref="CommonName" path="/value" /></summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/commonname.</value>
    public static string CommonName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/commonname/";

    public const string Country = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country/";
    /// <summary>The URI for a claim that specifies the date of birth of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth.</value>
    public const string DateOfBirth = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth/";
    /// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. A deny-only SID denies the specified entity to a securable object.</value>
    public const string DenyOnlyPrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid. A deny-only SID denies the specified entity to a securable object";
    /// <summary>The URI for a claim that specifies the deny-only primary SID on an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. A deny-only SID denies the specified entity to a securable object.</value>
    public const string DenyOnlyPrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid. A deny-only SID denies the specified entity to a securable object";
    /// <summary>The URI for a claim that specifies a deny-only security identifier (SID) for an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denies the specified entity to a securable object.</value>
    public const string DenyOnlySid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid. A deny-only SID denies the specified entity to a securable object";
    /// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup.</value>
    public const string DenyOnlyWindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup/";
    /// <summary>The URI for a claim that specifies the DNS name associated with the computer name or with the alternative name of either the subject or issuer of an X.509 certificate</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns.</value>
    public const string Dns = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa.</value>
    public const string Dsa = "http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa/";
    /// <summary>The URI for a claim that specifies the email address of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress.</value>
    public const string Email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration.</value>
    public const string Expiration = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired.</value>
    public const string Expired = "http://schemas.microsoft.com/ws/2008/06/identity/claims/expired/";
    /// <summary>The URI for a claim that specifies the gender of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender.</value>
    public const string Gender = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender/";
    /// <summary>The URI for a claim that specifies the given name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname.</value>
    public const string GivenName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname/";
    /// <summary>The URI for a claim that specifies the SID for the group of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid.</value>
    public const string GroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid/";
    /// <summary>The URI for a claim that specifies a hash value</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash.</value>
    public const string Hash = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash/";
    /// <summary>The URI for a claim that specifies the home phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone.</value>
    public const string HomePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent.</value>
    public const string IsPersistent = "http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent/";
    /// <summary>The URI for a claim that specifies the locale in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality.</value>
    public const string Locality = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality/";
    /// <summary>The URI for a claim that specifies the mobile phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone.</value>
    public const string MobilePhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone/";
    /// <summary>The URI for a claim that specifies the name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name.</value>
    public const string Name = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name/";
    /// <summary>The URI for a claim that specifies the name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier.</value>
    public const string NameIdentifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier/";
    /// <summary>The URI for a claim that specifies the alternative phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone.</value>
    public const string OtherPhone = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone/";
    /// <summary>The URI for a claim that specifies the postal code of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode.</value>
    public const string PostalCode = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode/";
    /// <summary>The URI for a claim that specifies the primary group SID of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid.</value>
    public const string PrimaryGroupSid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid/";
    /// <summary>The URI for a claim that specifies the primary SID of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid.</value>
    public const string PrimarySid = "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid/";
    /// <summary>The URI for a claim that specifies the role of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/role.</value>
    public const string Role = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role/";
    /// <summary>The URI for a claim that specifies an RSA key</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa.</value>
    public const string Rsa = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa/";
    /// <summary>The URI for a claim that specifies a serial number</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber.</value>
    public const string SerialNumber = "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber/";
    /// <summary>The URI for a claim that specifies a security identifier (SID)</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid.</value>
    public const string Sid = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid/";
    /// <summary>The URI for a claim that specifies a service principal name (SPN) claim</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn.</value>
    public const string Spn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn/";
    /// <summary>The URI for a claim that specifies the state or province in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince.</value>
    public const string StateOrProvince = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince/";
    /// <summary>The URI for a claim that specifies the street address of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress.</value>
    public const string StreetAddress = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress/";
    /// <summary>The URI for a claim that specifies the surname of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname.</value>
    public const string Surname = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname/";
    /// <summary>The URI for a claim that identifies the system entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system.</value>
    public const string System = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system/";
    /// <summary>The URI for a claim that specifies a thumbprint</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate.</value>
    public const string Thumbprint = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate/";
    /// <summary>The URI for a claim that specifies a user principal name (UPN)</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn.</value>
    public const string Upn = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn/";
    /// <summary>The URI for a claim that specifies a URI</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri.</value>
    public const string Uri = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri/";
    /// <summary>The URI for a claim that specifies the user data</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata.</value>
    public const string UserData = "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata/";
    /// <summary>The URI for a claim that specifies the version</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/version.</value>
    public const string Version = "http://schemas.microsoft.com/ws/2008/06/identity/claims/version/";
    /// <summary>The URI for a claim that specifies the webpage of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage.</value>
    public const string Webpage = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage/";
    /// <summary>The URI for a claim that specifies the Windows domain account name of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname.</value>
    public const string WindowsAccountName = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</value>
    public const string WindowsDeviceClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim/";
    /// <summary>The URI for a claim that specifies the Windows group SID of the device</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup.</value>
    public const string WindowsDeviceGroup = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion.</value>
    public const string WindowsFqbnVersion = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority.</value>
    public const string WindowsSubAuthority = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority/";
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim.</value>
    public const string WindowsUserClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim/";
    /// <summary>The URI for an X.500 distinguished name claim</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname.</value>
    public const string X500DistinguishedName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname/";
}
