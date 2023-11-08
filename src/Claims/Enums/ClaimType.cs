// /*
//  * ClaimType.cs
//  *
//  *   Created: 2023-03-29-11:42:22
//  *   Modified: 2023-05-20-03:57:29
//  *
//  *   Author: David G. Moore, Jr. <david@dgmjr.io>
//  *
//  *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */

// namespace Dgmjr.Identity.Claims.Enums;
// using ClaimTypeUris = Dgmjr.Identity.ClaimTypeUris;

// /// <summary>
// /// A enumeration representing the built-in claim types in the <see
// cref="System.Security.Claims.ClaimTypes" /> class.
// /// </summary>
// [GenerateEnumerationClass("ClaimType", "Dgmjr.Identity")]
// public enum ClaimType
// {
//     /// <inheritdoc cref="ClaimTypeUris.UnknownLoginProvider" />
//     [Display(Name = ClaimTypeUris.UnknownLoginProvider, ShortName =
//     nameof(UnknownLoginProvider))] [Uri(ClaimTypeUris.UnknownLoginProvider)]
//     UnknownLoginProvider,

//     /// <inheritdoc cref="ClaimTypeUris.SecurityStamp" />
//     [Display(Name = ClaimTypeUris.SecurityStamp, ShortName =
//     nameof(SecurityStamp))] [Uri(ClaimTypeUris.SecurityStamp)] SecurityStamp,

//     /// <inheritdoc cref="ClaimTypeUris.BaseUri" />
//     [Display(Name = ClaimTypeUris.BaseUri, ShortName = nameof(BaseUri))]
//     [Uri(ClaimTypeUris.BaseUri)]
//     BaseUri,

//     /// <inheritdoc cref="ClaimTypeUris.Identity" />
//     [Display(Name = ClaimTypeUris.Identity, ShortName = nameof(Identity))]
//     [Uri(ClaimTypeUris.Identity)]
//     Identity,

//     /// <inheritdoc cref="ClaimTypeUris.Actor" path="/summary/node()" />
//     [Display(Name = ClaimTypeUris.Actor, ShortName = nameof(Actor))]
//     [Uri(ClaimTypeUris.Actor)]
//     Actor,

//     /// <inheritdoc cref="ClaimTypeUris.Anonymous" >
//     [Display(Name = ClaimTypeUris.Anonymous, ShortName = nameof(Anonymous))]
//     [Uri(ClaimTypeUris.Anonymous)]
//     Anonymous,

//     /// <inheritdoc cref="ClaimTypeUris.Authentication" />
//     [Display(Name = ClaimTypeUris.Authentication, ShortName =
//     nameof(Authentication))] [Uri(ClaimTypeUris.Authentication)]
//     Authentication,

//     /// <inheritdoc cref="ClaimTypeUris.AuthenticationInstant" />
//     [Display(Name = ClaimTypeUris.AuthenticationInstant, ShortName =
//     nameof(AuthenticationInstant))]
//     [Uri(ClaimTypeUris.AuthenticationInstant)]
//     AuthenticationInstant,

//     /// <inheritdoc cref="ClaimTypeUris.AuthenticationMethod" />
//     [Display(Name = ClaimTypeUris.AuthenticationMethod, ShortName =
//     nameof(AuthenticationMethod))] [Uri(ClaimTypeUris.AuthenticationMethod)]
//     AuthenticationMethod,

//     /// <inheritdoc cref="ClaimTypeUris.AuthorizationDecision" />
//     [Display(Name = ClaimTypeUris.AuthorizationDecision, ShortName =
//     nameof(AuthorizationDecision))]
//     [Uri(ClaimTypeUris.AuthorizationDecision)]
//     AuthorizationDecision,

//     /// <inheritdoc cref="ClaimTypeUris.CookiePath" />
//     [Display(Name = ClaimTypeUris.CookiePath, ShortName =
//     nameof(CookiePath))] [Uri(ClaimTypeUris.CookiePath)] CookiePath,

//     /// <inheritdoc cref="ClaimTypeUris.Country" />

//     [Display(Name = ClaimTypeUris.Country, ShortName = nameof(Country))]
//     [Uri(ClaimTypeUris.Country)]
//     Country,

//     /// <inheritdoc cref="ClaimTypeUris.DateOfBirth" />

//     [Display(Name = ClaimTypeUris.DateOfBirth, ShortName =
//     nameof(DateOfBirth))] [Uri(ClaimTypeUris.DateOfBirth)] DateOfBirth,

//     /// <inheritdoc cref="ClaimTypeUris.DenyOnlyPrimaryGroupSid" />

//     [Display(
//         Name = ClaimTypeUris.DenyOnlyPrimaryGroupSid,
//         ShortName = nameof(DenyOnlyPrimaryGroupSid)
//     )]
//     [Uri(ClaimTypeUris.DenyOnlyPrimaryGroupSid)]
//     DenyOnlyPrimaryGroupSid,

//     /// <inheritdoc cref="ClaimTypeUris.DenyOnlyPrimarySid" />

//     [Display(Name = ClaimTypeUris.DenyOnlyPrimarySid, ShortName =
//     nameof(DenyOnlyPrimarySid))] [Uri(ClaimTypeUris.DenyOnlyPrimarySid)]
//     DenyOnlyPrimarySid,

//     /// <inheritdoc cref="ClaimTypeUris.DenyOnlySid" />

//     [Display(Name = ClaimTypeUris.DenyOnlySid, ShortName =
//     nameof(DenyOnlySid))] [Uri(ClaimTypeUris.DenyOnlySid)] DenyOnlySid,

//     /// <inheritdoc cref="ClaimTypeUris.DenyOnlyWindowsDeviceGroup" />

//     [Display(
//         Name = ClaimTypeUris.DenyOnlyWindowsDeviceGroup,
//         ShortName = nameof(DenyOnlyWindowsDeviceGroup)
//     )]
//     [Uri(ClaimTypeUris.DenyOnlyWindowsDeviceGroup)]
//     DenyOnlyWindowsDeviceGroup,

//     /// <inheritdoc cref="ClaimTypeUris.Dns" />

//     [Display(Name = ClaimTypeUris.Dns, ShortName = nameof(Dns))]
//     [Uri(ClaimTypeUris.Dns)]
//     Dns,

//     /// <inheritdoc cref="ClaimTypeUris.Dsa" />

//     [Display(Name = ClaimTypeUris.Dsa, ShortName = nameof(Dsa))]
//     [Uri(ClaimTypeUris.Dsa)]
//     Dsa,

//     /// <inheritdoc cref="ClaimTypeUris.Email" />

//     [Display(Name = ClaimTypeUris.Email, ShortName = nameof(Email))]
//     [Uri(ClaimTypeUris.Email)]
//     Email,

//     /// <inheritdoc cref="ClaimTypeUris.Expiration" />

//     [Display(Name = ClaimTypeUris.Expiration, ShortName =
//     nameof(Expiration))] [Uri(ClaimTypeUris.Expiration)] Expiration,

//     /// <inheritdoc cref="ClaimTypeUris.Expired" />
//     [Display(Name = ClaimTypeUris.Expired, ShortName = nameof(Expired))]
//     [Uri(ClaimTypeUris.Expired)]
//     Expired,

//     /// <inheritdoc cref="ClaimTypeUris.Gender" />

//     [Display(Name = ClaimTypeUris.Gender, ShortName = nameof(Gender))]
//     [Uri(ClaimTypeUris.Gender)]
//     Gender,

//     /// <inheritdoc cref="ClaimTypeUris.GivenName" />

//     [Display(Name = ClaimTypeUris.GivenName, ShortName = nameof(GivenName))]
//     [Uri(ClaimTypeUris.GivenName)]
//     GivenName,

//     /// <inheritdoc cref="ClaimTypeUris.GroupSid" />

//     [Display(Name = ClaimTypeUris.GroupSid, ShortName = nameof(GroupSid))]
//     [Uri(ClaimTypeUris.GroupSid)]
//     GroupSid,

//     /// <inheritdoc cref="ClaimTypeUris.Hash" />

//     [Display(Name = ClaimTypeUris.Hash, ShortName = nameof(Hash))]
//     [Uri(ClaimTypeUris.Hash)]
//     Hash,

//     /// <inheritdoc cref="ClaimTypeUris.HomePhone" />

//     [Display(Name = ClaimTypeUris.HomePhone, ShortName = nameof(HomePhone))]
//     [Uri(ClaimTypeUris.HomePhone)]
//     HomePhone,

//     /// <inheritdoc cref="ClaimTypeUris.IsPersistent" />

//     [Display(Name = ClaimTypeUris.IsPersistent, ShortName =
//     nameof(IsPersistent))] [Uri(ClaimTypeUris.IsPersistent)] IsPersistent,

//     /// <inheritdoc cref="ClaimTypeUris.Locality" />

//     [Display(Name = ClaimTypeUris.Locality, ShortName = nameof(Locality))]
//     [Uri(ClaimTypeUris.Locality)]
//     Locality,

//     /// <inheritdoc cref="ClaimTypeUris.MobilePhone" />

//     [Display(Name = ClaimTypeUris.MobilePhone, ShortName =
//     nameof(MobilePhone))] [Uri(ClaimTypeUris.MobilePhone)] MobilePhone,

//     /// <inheritdoc cref="ClaimTypeUris.Name" />

//     [Display(Name = ClaimTypeUris.Name, ShortName =
//     nameof(ClaimTypeUris.Name))] [Uri(ClaimTypeUris.Name)] NameClaim,

//     /// <inheritdoc cref="ClaimTypeUris.NameIdentifier" />

//     [Display(Name = ClaimTypeUris.NameIdentifier, ShortName =
//     nameof(NameIdentifier))] [Uri(ClaimTypeUris.NameIdentifier)]
//     NameIdentifier,

//     /// <inheritdoc cref="ClaimTypeUris.OtherPhone" />

//     [Display(Name = ClaimTypeUris.OtherPhone, ShortName =
//     nameof(OtherPhone))] [Uri(ClaimTypeUris.OtherPhone)] OtherPhone,

//     /// <inheritdoc cref="ClaimTypeUris.PostalCode" />

//     [Display(Name = ClaimTypeUris.PostalCode, ShortName =
//     nameof(PostalCode))] [Uri(ClaimTypeUris.PostalCode)] PostalCode,

//     /// <inheritdoc cref="ClaimTypeUris.PrimaryGroupSid" />

//     [Display(Name = ClaimTypeUris.PrimaryGroupSid, ShortName =
//     nameof(PrimaryGroupSid))] [Uri(ClaimTypeUris.PrimaryGroupSid)]
//     PrimaryGroupSid,

//     /// <inheritdoc cref="ClaimTypeUris.PrimarySid" />

//     [Display(Name = ClaimTypeUris.PrimarySid, ShortName =
//     nameof(PrimarySid))] [Uri(ClaimTypeUris.PrimarySid)] PrimarySid,

//     /// <inheritdoc cref="ClaimTypeUris.Role" />

//     [Display(Name = ClaimTypeUris.Role, ShortName = nameof(Role))]
//     [Uri(ClaimTypeUris.Role)]
//     Role,

//     /// <inheritdoc cref="ClaimTypeUris.Rsa" />

//     [Display(Name = ClaimTypeUris.Rsa, ShortName = nameof(Rsa))]
//     [Uri(ClaimTypeUris.Rsa)]
//     Rsa,

//     /// <inheritdoc cref="ClaimTypeUris.SerialNumber" />

//     [Display(Name = ClaimTypeUris.SerialNumber, ShortName =
//     nameof(SerialNumber))] [Uri(ClaimTypeUris.SerialNumber)] SerialNumber,

//     /// <inheritdoc cref="ClaimTypeUris.Sid" />

//     [Display(Name = ClaimTypeUris.Sid, ShortName = nameof(Sid))]
//     [Uri(ClaimTypeUris.Sid)]
//     Sid,

//     /// <inheritdoc cref="ClaimTypeUris.Spn" />

//     [Display(Name = ClaimTypeUris.Spn, ShortName = nameof(Spn))]
//     [Uri(ClaimTypeUris.Spn)]
//     Spn,

//     /// <inheritdoc cref="ClaimTypeUris.StateOrProvince" />

//     [Display(Name = ClaimTypeUris.StateOrProvince, ShortName =
//     nameof(StateOrProvince))] [Uri(ClaimTypeUris.StateOrProvince)]
//     StateOrProvince,

//     /// <inheritdoc cref="ClaimTypeUris.StreetAddress" />

//     [Display(Name = ClaimTypeUris.StreetAddress, ShortName =
//     nameof(StreetAddress))] [Uri(ClaimTypeUris.StreetAddress)] StreetAddress,

//     /// <inheritdoc cref="ClaimTypeUris.Surname" />

//     [Display(Name = ClaimTypeUris.Surname, ShortName = nameof(Surname))]
//     [Uri(ClaimTypeUris.Surname)]
//     Surname,

//     /// <inheritdoc cref="ClaimTypeUris.System" />

//     [Display(Name = ClaimTypeUris.System, ShortName = nameof(System))]
//     [Uri(ClaimTypeUris.System)]
//     SystemClaim,

//     /// <inheritdoc cref="ClaimTypeUris.Thumbprint" />

//     [Display(Name = ClaimTypeUris.Thumbprint, ShortName =
//     nameof(Thumbprint))] [Uri(ClaimTypeUris.Thumbprint)] Thumbprint,

//     /// <inheritdoc cref="ClaimTypeUris.Upn" />

//     [Display(Name = ClaimTypeUris.Upn, ShortName = nameof(Upn))]
//     [Uri(ClaimTypeUris.Upn)]
//     Upn,

//     /// <inheritdoc cref="ClaimTypeUris.uri" />

//     [Display(Name = ClaimTypeUris.Uri, ShortName =
//     nameof(ClaimTypeUris.Uri))] [Uri(ClaimTypeUris.Uri)] UriClaim,

//     /// <inheritdoc cref="ClaimTypeUris.UserData" />

//     [Display(Name = ClaimTypeUris.UserData, ShortName = nameof(UserData))]
//     [Uri(ClaimTypeUris.UserData)]
//     UserData,

//     /// <inheritdoc cref="ClaimTypeUris.Version" />

//     [Display(Name = ClaimTypeUris.Version, ShortName = nameof(Version))]
//     [Uri(ClaimTypeUris.Version)]
//     Version,

//     /// <inheritdoc cref="ClaimTypeUris.Webpage" />

//     [Display(Name = ClaimTypeUris.Webpage, ShortName = nameof(Webpage))]
//     [Uri(ClaimTypeUris.Webpage)]
//     Webpage,

//     /// <inheritdoc cref="ClaimTypeUris.WindowsAccountName" />

//     [Display(Name = ClaimTypeUris.WindowsAccountName, ShortName =
//     nameof(WindowsAccountName))] [Uri(ClaimTypeUris.WindowsAccountName)]
//     WindowsAccountName,

//     /// <inheritdoc cref="ClaimTypeUris.WindowsDeviceClaim" />

//     [Display(Name = ClaimTypeUris.WindowsDeviceClaim, ShortName =
//     nameof(WindowsDeviceClaim))] [Uri(ClaimTypeUris.WindowsDeviceClaim)]
//     WindowsDeviceClaim,

//     /// <inheritdoc cref="ClaimTypeUris.WindowsDeviceGroup" />

//     [Display(Name = ClaimTypeUris.WindowsDeviceGroup, ShortName =
//     nameof(WindowsDeviceGroup))] [Uri(ClaimTypeUris.WindowsDeviceGroup)]
//     WindowsDeviceGroup,

//     /// <inheritdoc cref="ClaimTypeUris.WindowsFqbnVersion" />

//     [Display(Name = ClaimTypeUris.WindowsFqbnVersion, ShortName =
//     nameof(WindowsFqbnVersion))] [Uri(ClaimTypeUris.WindowsFqbnVersion)]
//     WindowsFqbnVersion,

//     /// <inheritdoc cref="ClaimTypeUris.WindowsSubAuthority" />

//     [Display(Name = ClaimTypeUris.WindowsSubAuthority, ShortName =
//     nameof(WindowsSubAuthority))] [Uri(ClaimTypeUris.WindowsSubAuthority)]
//     WindowsSubAuthority,

//     /// <inheritdoc cref="ClaimTypeUris.WindowsUserClaim" />

//     [Display(Name = ClaimTypeUris.WindowsUserClaim, ShortName =
//     nameof(WindowsUserClaim))] [Uri(ClaimTypeUris.WindowsUserClaim)]
//     WindowsUserClaim,

//     /// <inheritdoc cref="ClaimTypeUris.X500DistinguishedName" />

//     [Display(Name = ClaimTypeUris.X500DistinguishedName, ShortName =
//     nameof(X500DistinguishedName))]
//     [Uri(ClaimTypeUris.X500DistinguishedName)]
//     X500DistinguishedName,
// }
