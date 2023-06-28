namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity.Claims.Abstractions;

public static class ClaimTypes
{
    /// <summary>The URI for a claim that specifies the actor</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor</value>
    public static readonly IClaimType Actor = DgmjrClaims.Actor.Instance;

    /// <summary>The URI for a claim that specifies the anonymous user</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous</value>
    public static readonly IClaimType Anonymous = DgmjrClaims.Anonymous.Instance;

    /// <summary>The URI for a claim that specifies details about whether an identity is authenticated</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated</value>
    public static readonly IClaimType Authentication = DgmjrClaims.Authentication.Instance;

    /// <summary>The URI for a claim that specifies the instant at which an entity was authenticated</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant</value>
    public static readonly IClaimType AuthenticationInstant = DgmjrClaims.AuthenticationInstant.Instance;

    /// <summary>The URI for a claim that specifies the method with which an entity was authenticated</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod</value>
    public static readonly IClaimType AuthenticationMethod = DgmjrClaims.AuthenticationMethod.Instance;

    /// <summary>The URI for a claim that specifies an authorization decision on an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision</value>
    public static readonly IClaimType AuthorizationDecision = DgmjrClaims.AuthorizationDecision.Instance;
    /// <summary>The URI for a claim that specifies the cookie path</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath</value>
    public static readonly IClaimType CookiePath = DgmjrClaims.CookiePath.Instance;

    /// <summary>The URI for a claim that specifies the "common name" of an entity, <inheritdoc cref="CommonName" path="/value" /></summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/commonname</value>
    public static readonly IClaimType CommonName = DgmjrClaims.CommonName.Instance;
    /// <summary>The URI for a claim that specifies the country/region in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country</value>
    public static readonly IClaimType Country = DgmjrClaims.Country.Instance;

    /// <summary>The URI for a claim that specifies the date of birth of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth</value>
    public static readonly IClaimType DateOfBirth = DgmjrClaims.DateOfBirth.Instance;

    /// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid</value>
    public static readonly IClaimType DenyOnlyPrimaryGroupSid = DgmjrClaims.DenyOnlyPrimaryGroupSid.Instance;

    /// <summary>The URI for a claim that specifies the deny-only primary SID on an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid</value>
    public static readonly IClaimType DenyOnlyPrimarySid = DgmjrClaims.DenyOnlyPrimarySid.Instance;
    /// <summary>The URI for a claim that specifies a deny-only security identifier (SID) for an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid</value>
    public static readonly IClaimType DenyOnlySid = DgmjrClaims.DenyOnlySid.Instance;

    /// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup</value>
    public static readonly IClaimType DenyOnlyWindowsDeviceGroup = DgmjrClaims.DenyOnlyWindowsDeviceGroup.Instance;
    /// <summary>The URI for a claim that specifies the DNS name associated with the computer name or with the alternative name of either the subject or issuer of an X.509 certificate</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns</value>
    public static readonly IClaimType Dns = DgmjrClaims.Dns.Instance;

    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa</value>
    public static readonly IClaimType Dsa = DgmjrClaims.Dsa.Instance;

    /// <summary>The URI for a claim that specifies the email address of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress</value>
    public static readonly IClaimType Email = DgmjrClaims.Email.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration</value>
    public static readonly IClaimType Expiration = DgmjrClaims.Expiration.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/expired</value>
    public static readonly IClaimType Expired = DgmjrClaims.Expired.Instance;
    /// <summary>The URI for a claim that specifies the gender of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender</value>
    public static readonly IClaimType Gender = DgmjrClaims.Gender.Instance;
    /// <summary>The URI for a claim that specifies the given name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname</value>
    public static readonly IClaimType GivenName = DgmjrClaims.GivenName.Instance;
    /// <summary>The URI for a claim that specifies the SID for the group of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid</value>
    public static readonly IClaimType GroupSid = DgmjrClaims.GroupSid.Instance;
    /// <summary>The URI for a claim that specifies a hash value</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash</value>
    public static readonly IClaimType Hash = DgmjrClaims.Hash.Instance;
    /// <summary>The URI for a claim that specifies the home phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone</value>
    public static readonly IClaimType HomePhone = DgmjrClaims.HomePhone.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent</value>
    public static readonly IClaimType IsPersistent = DgmjrClaims.IsPersistent.Instance;
    /// <summary>The URI for a claim that specifies the locale in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality</value>
    public static readonly IClaimType Locality = DgmjrClaims.Locality.Instance;
    /// <summary>The URI for a claim that specifies the mobile phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone</value>
    public static readonly IClaimType MobilePhone = DgmjrClaims.MobilePhone.Instance;
    /// <summary>The URI for a claim that specifies the name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name</value>
    public static readonly IClaimType Name = DgmjrClaims.Name.Instance;
    /// <summary>The URI for a claim that specifies the name of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier</value>
    public static readonly IClaimType NameIdentifier = DgmjrClaims.NameIdentifier.Instance;
    /// <summary>The URI for a claim that specifies the alternative phone number of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone</value>
    public static readonly IClaimType OtherPhone = DgmjrClaims.OtherPhone.Instance;
    /// <summary>The URI for a claim that specifies the postal code of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode</value>
    public static readonly IClaimType PostalCode = DgmjrClaims.PostalCode.Instance;
    /// <summary>The URI for a claim that specifies the primary group SID of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid</value>
    public static readonly IClaimType PrimaryGroupSid = DgmjrClaims.PrimaryGroupSid.Instance;
    /// <summary>The URI for a claim that specifies the primary SID of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid</value>
    public static readonly IClaimType PrimarySid = DgmjrClaims.PrimarySid.Instance;
    /// <summary>The URI for a claim that specifies the role of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/role</value>
    public static readonly IClaimType Role = DgmjrClaims.Role.Instance;
    /// <summary>The URI for a claim that specifies an RSA key</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa</value>
    public static readonly IClaimType Rsa = DgmjrClaims.Rsa.Instance;
    /// <summary>The URI for a claim that specifies a serial number</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber</value>
    public static readonly IClaimType SerialNumber = DgmjrClaims.SerialNumber.Instance;
    /// <summary>The URI for a claim that specifies a security identifier (SID)</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid</value>
    public static readonly IClaimType Sid = DgmjrClaims.Sid.Instance;
    /// <summary>The URI for a claim that specifies a service principal name (SPN) claim</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn</value>
    public static readonly IClaimType Spn = DgmjrClaims.Spn.Instance;
    /// <summary>The URI for a claim that specifies the state or province in which an entity resides</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince</value>
    public static readonly IClaimType StateOrProvince = DgmjrClaims.StateOrProvince.Instance;
    /// <summary>The URI for a claim that specifies the street address of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress</value>
    public static readonly IClaimType StreetAddress = DgmjrClaims.StreetAddress.Instance;
    /// <summary>The URI for a claim that specifies the surname of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname</value>
    public static readonly IClaimType Surname = DgmjrClaims.Surname.Instance;
    /// <summary>The URI for a claim that identifies the system entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system</value>
    public static readonly IClaimType System = DgmjrClaims.System.Instance;
    /// <summary>The URI for a claim that specifies a thumbprint</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate</value>
    public static readonly IClaimType Thumbprint = DgmjrClaims.Thumbprint.Instance;
    /// <summary>The URI for a claim that specifies a user principal name (UPN)</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn</value>
    public static readonly IClaimType Upn = DgmjrClaims.Upn.Instance;
    /// <summary>The URI for a claim that specifies a URI</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri</value>
    public static readonly IClaimType Uri = DgmjrClaims.Uri.Instance;
    /// <summary>The URI for a claim that specifies the user data</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata</value>
    public static readonly IClaimType UserData = DgmjrClaims.UserData.Instance;
    /// <summary>The URI for a claim that specifies the version</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/version</value>
    public static readonly IClaimType Version = DgmjrClaims.Version.Instance;
    /// <summary>The URI for a claim that specifies the webpage of an entity</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage</value>
    public static readonly IClaimType Webpage = DgmjrClaims.Webpage.Instance;
    /// <summary>The URI for a claim that specifies the Windows domain account name of an entity</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname</value>
    public static readonly IClaimType WindowsAccountName = DgmjrClaims.WindowsAccountName.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim</value>
    public static readonly IClaimType WindowsDeviceClaim = DgmjrClaims.WindowsDeviceClaim.Instance;
    /// <summary>The URI for a claim that specifies the Windows group SID of the device</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup</value>
    public static readonly IClaimType WindowsDeviceGroup = DgmjrClaims.WindowsDeviceGroup.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion</value>
    public static readonly IClaimType WindowsFqbnVersion = DgmjrClaims.WindowsFqbnVersion.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority</value>
    public static readonly IClaimType WindowsSubAuthority = DgmjrClaims.WindowsSubAuthority.Instance;
    /// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim</summary>
    /// <value>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim</value>
    public static readonly IClaimType WindowsUserClaim = DgmjrClaims.WindowsUserClaim.Instance;
    /// <summary>The URI for an X.500 distinguished name claim</summary>
    /// <value>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname</value>
    public static readonly IClaimType X500DistinguishedName = DgmjrClaims.X500DistinguishedName.Instance;
}
