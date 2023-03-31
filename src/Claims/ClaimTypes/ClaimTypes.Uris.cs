/*
 * ClaimTypeUris.cs
 *
 *   Created: 2022-11-23-08:41:50
 *   Modified: 2022-11-23-08:41:51
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org" licenses" MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity;
using System;

public static partial class ClaimTypeUris
{

    /// <inheritdoc cref="ClaimTypeUris" />
    public static class Uris
    {
        /// <inheritdoc cref="ClaimTypeUris.UnknownLoginProvider" />
        public static readonly uri UnknownLoginProvider = uri.From(ClaimTypeUris.UnknownLoginProvider);

        /// <inheritdoc cref="ClaimTypeUris.SecurityStamp" />
        public static readonly uri SecurityStamp = uri.From(ClaimTypeUris.SecurityStamp);

        /// <inheritdoc cref="ClaimTypeUris.BaseUri" />
        public static readonly uri DgmjrBaseUri = uri.From(ClaimTypeUris.BaseUri);

        /// <inheritdoc cref="ClaimTypeUris.Identity" />
        public static readonly uri Identity = uri.From(ClaimTypeUris.Identity);

        /// <inheritdoc cref="ClaimTypeUris.Actor" path="/summary/node()" />
        public static readonly uri Actor = uri.From(ClaimTypeUris.Actor);

        /// <inheritdoc cref="ClaimTypeUris.Anonymous" >
        public static readonly uri Anonymous = uri.From(ClaimTypeUris.Anonymous);

        /// <inheritdoc cref="ClaimTypeUris.Authentication" />
        public static readonly uri Authentication = uri.From(ClaimTypeUris.Authentication);

        /// <inheritdoc cref="ClaimTypeUris.AuthenticationInstant" />
        public static readonly uri AuthenticationInstant = uri.From(ClaimTypeUris.AuthenticationInstant);

        /// <inheritdoc cref="ClaimTypeUris.AuthenticationMethod" />
        public static readonly uri AuthenticationMethod = uri.From(ClaimTypeUris.AuthenticationMethod);

        /// <inheritdoc cref="ClaimTypeUris.AuthorizationDecision" />
        public static readonly uri AuthorizationDecision = uri.From(ClaimTypeUris.AuthorizationDecision);

        /// <inheritdoc cref="ClaimTypeUris.CookiePath" />
        public static readonly uri CookiePath = uri.From(ClaimTypeUris.CookiePath);
        /// <inheritdoc cref="ClaimTypeUris.Country" />

        public static readonly uri Country = uri.From(ClaimTypeUris.Country);
        /// <inheritdoc cref="ClaimTypeUris.DateOfBirth" />

        public static readonly uri DateOfBirth = uri.From(ClaimTypeUris.DateOfBirth);
        /// <inheritdoc cref="ClaimTypeUris.DenyOnlyPrimaryGroupSid" />

        public static readonly uri DenyOnlyPrimaryGroupSid = uri.From(ClaimTypeUris.DenyOnlyPrimaryGroupSid);
        /// <inheritdoc cref="ClaimTypeUris.DenyOnlyPrimarySid" />

        public static readonly uri DenyOnlyPrimarySid = uri.From(ClaimTypeUris.DenyOnlyPrimarySid);
        /// <inheritdoc cref="ClaimTypeUris.DenyOnlySid" />

        public static readonly uri DenyOnlySid = uri.From(ClaimTypeUris.DenyOnlySid);
        /// <inheritdoc cref="ClaimTypeUris.DenyOnlyWindowsDeviceGroup" />

        public static readonly uri DenyOnlyWindowsDeviceGroup = uri.From(ClaimTypeUris.DenyOnlyWindowsDeviceGroup);
        /// <inheritdoc cref="ClaimTypeUris.Dns" />

        public static readonly uri Dns = uri.From(ClaimTypeUris.Dns);
        /// <inheritdoc cref="ClaimTypeUris.Dsa" />

        public static readonly uri Dsa = uri.From(ClaimTypeUris.Dsa);
        /// <inheritdoc cref="ClaimTypeUris.Email" />

        public static readonly uri Email = uri.From(ClaimTypeUris.Email);
        /// <inheritdoc cref="ClaimTypeUris.Expiration" />

        public static readonly uri Expiration = uri.From(ClaimTypeUris.Expiration);
        /// <inheritdoc cref="ClaimTypeUris.Expired" />
        public static readonly uri Expired = uri.From(ClaimTypeUris.Expired);
        /// <inheritdoc cref="ClaimTypeUris.Gender" />

        public static readonly uri Gender = uri.From(ClaimTypeUris.Gender);
        /// <inheritdoc cref="ClaimTypeUris.GivenName" />

        public static readonly uri GivenName = uri.From(ClaimTypeUris.GivenName);
        /// <inheritdoc cref="ClaimTypeUris.GroupSid" />

        public static readonly uri GroupSid = uri.From(ClaimTypeUris.GroupSid);
        /// <inheritdoc cref="ClaimTypeUris.Hash" />

        public static readonly uri Hash = uri.From(ClaimTypeUris.Hash);
        /// <inheritdoc cref="ClaimTypeUris.HomePhone" />

        public static readonly uri HomePhone = uri.From(ClaimTypeUris.HomePhone);
        /// <inheritdoc cref="ClaimTypeUris.IsPersistent" />

        public static readonly uri IsPersistent = uri.From(ClaimTypeUris.IsPersistent);
        /// <inheritdoc cref="ClaimTypeUris.Locality" />

        public static readonly uri Locality = uri.From(ClaimTypeUris.Locality);
        /// <inheritdoc cref="ClaimTypeUris.MobilePhone" />

        public static readonly uri MobilePhone = uri.From(ClaimTypeUris.MobilePhone);
        /// <inheritdoc cref="ClaimTypeUris.Name" />

        public static readonly uri Name = uri.From(ClaimTypeUris.Name);
        /// <inheritdoc cref="ClaimTypeUris.NameIdentifier" />

        public static readonly uri NameIdentifier = uri.From(ClaimTypeUris.NameIdentifier);
        /// <inheritdoc cref="ClaimTypeUris.OtherPhone" />

        public static readonly uri OtherPhone = uri.From(ClaimTypeUris.OtherPhone);
        /// <inheritdoc cref="ClaimTypeUris.PostalCode" />

        public static readonly uri PostalCode = uri.From(ClaimTypeUris.PostalCode);
        /// <inheritdoc cref="ClaimTypeUris.PrimaryGroupSid" />

        public static readonly uri PrimaryGroupSid = uri.From(ClaimTypeUris.PrimaryGroupSid);
        /// <inheritdoc cref="ClaimTypeUris.PrimarySid" />

        public static readonly uri PrimarySid = uri.From(ClaimTypeUris.PrimarySid);
        /// <inheritdoc cref="ClaimTypeUris.Role" />

        public static readonly uri Role = uri.From(ClaimTypeUris.Role);
        /// <inheritdoc cref="ClaimTypeUris.Rsa" />

        public static readonly uri Rsa = uri.From(ClaimTypeUris.Rsa);
        /// <inheritdoc cref="ClaimTypeUris.SerialNumber" />

        public static readonly uri SerialNumber = uri.From(ClaimTypeUris.SerialNumber);
        /// <inheritdoc cref="ClaimTypeUris.Sid" />

        public static readonly uri Sid = uri.From(ClaimTypeUris.Sid);
        /// <inheritdoc cref="ClaimTypeUris.Spn" />

        public static readonly uri Spn = uri.From(ClaimTypeUris.Spn);
        /// <inheritdoc cref="ClaimTypeUris.StateOrProvince" />

        public static readonly uri StateOrProvince = uri.From(ClaimTypeUris.StateOrProvince);
        /// <inheritdoc cref="ClaimTypeUris.StreetAddress" />

        public static readonly uri StreetAddress = uri.From(ClaimTypeUris.StreetAddress);
        /// <inheritdoc cref="ClaimTypeUris.Surname" />

        public static readonly uri Surname = uri.From(ClaimTypeUris.Surname);
        /// <inheritdoc cref="ClaimTypeUris.System" />

        public static readonly uri System = uri.From(ClaimTypeUris.System);
        /// <inheritdoc cref="ClaimTypeUris.Thumbprint" />

        public static readonly uri Thumbprint = uri.From(ClaimTypeUris.Thumbprint);
        /// <inheritdoc cref="ClaimTypeUris.Upn" />

        public static readonly uri Upn = uri.From(ClaimTypeUris.Upn);
        /// <inheritdoc cref="ClaimTypeUris.uri" />

        public static readonly uri uri = uri.From(ClaimTypeUris.Uri);
        /// <inheritdoc cref="ClaimTypeUris.UserData" />

        public static readonly uri UserData = uri.From(ClaimTypeUris.UserData);
        /// <inheritdoc cref="ClaimTypeUris.Version" />

        public static readonly uri Version = uri.From(ClaimTypeUris.Version);
        /// <inheritdoc cref="ClaimTypeUris.Webpage" />

        public static readonly uri Webpage = uri.From(ClaimTypeUris.Webpage);
        /// <inheritdoc cref="ClaimTypeUris.WindowsAccountName" />

        public static readonly uri WindowsAccountName = uri.From(ClaimTypeUris.WindowsAccountName);
        /// <inheritdoc cref="ClaimTypeUris.WindowsDeviceClaim" />

        public static readonly uri WindowsDeviceClaim = uri.From(ClaimTypeUris.WindowsDeviceClaim);
        /// <inheritdoc cref="ClaimTypeUris.WindowsDeviceGroup" />

        public static readonly uri WindowsDeviceGroup = uri.From(ClaimTypeUris.WindowsDeviceGroup);
        /// <inheritdoc cref="ClaimTypeUris.WindowsFqbnVersion" />

        public static readonly uri WindowsFqbnVersion = uri.From(ClaimTypeUris.WindowsFqbnVersion);
        /// <inheritdoc cref="ClaimTypeUris.WindowsSubAuthority" />

        public static readonly uri WindowsSubAuthority = uri.From(ClaimTypeUris.WindowsSubAuthority);
        /// <inheritdoc cref="ClaimTypeUris.WindowsUserClaim" />

        public static readonly uri WindowsUserClaim = uri.From(ClaimTypeUris.WindowsUserClaim);
        /// <inheritdoc cref="ClaimTypeUris.X500DistinguishedName" />

        public static readonly uri X500DistinguishedName = uri.From(ClaimTypeUris.X500DistinguishedName);
    }
}
