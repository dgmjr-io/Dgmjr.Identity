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
namespace Dgmjr.Identity.ClaimTypes;

/// <summary>The URI for a claim that specifies the actor</summary>
/// <value><inheritdoc cref="Actor.UriString" path="/value" /></value>
public record class Actor
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Actor();

    private Actor() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2009" path="/value" />/actor</value>
    public const string UriString = Namespace2009 + "/actor";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2009" path="/value" />:actor</value>
    public const string ShortUriString = ShortNamespace2009 + ":" + "actor";

    /// <value>Actor</value>
    public const string Name = nameof(Actor);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the anonymous user.</summary>
/// <value><inheritdoc cref="Anonymous.UriString" path="/value" /></value>
public record class Anonymous
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Anonymous();

    private Anonymous() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/anonymous</value>
    public const string UriString = Namespace2005 + "/anonymous";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:authenticated</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "anonymous";

    /// <value>Anonymous</value>
    public const string Name = nameof(Anonymous);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies details about whether an identity is authenticated</summary>
/// <value><inheritdoc cref="Authenticated.UriString" path="/value" /></value>
public record class Authenticated
    : ClaimType<DgmjrId.ClaimValueTypes.Boolean>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Authenticated();

    private Authenticated() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/authenticated</value>
    public const string UriString = Namespace2005 + "/authenticated";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:authenticated</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "authenticated";

    /// <value>Authenticated</value>
    public const string Name = nameof(Authenticated);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the instant at which an entity was authenticated; </summary>
/// <value><inheritdoc cref="AuthenticationInstant.UriString" path="/value" /></value>
public record class AuthenticationInstant
    : ClaimType<DgmjrId.ClaimValueTypes._DateTime>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new AuthenticationInstant();

    private AuthenticationInstant() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/authenticationinstant</value>
    public const string UriString = Namespace2008 + "/authenticationinstant";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:authenticationinstant</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "authenticationinstant";

    /// <value>AuthenticationInstant</value>
    public const string Name = nameof(AuthenticationInstant);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the method with which an entity was authenticated; </summary>
/// <value><inheritdoc cref="AuthenticationMethod.UriString" path="/value" /></value>
public record class AuthenticationMethod
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new AuthenticationMethod();

    private AuthenticationMethod() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/authenticationmethod</value>
    public const string UriString = Namespace2008 + "/authenticationmethod";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:authenticationmethod</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "authenticationmethod";

    /// <value>AuthenticationMethod	</value>
    public const string Name = nameof(AuthenticationMethod);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies an authorization decision on an entity; </summary>
/// <value><inheritdoc cref="AuthorizationDecision.UriString" path="/value" /></value>
public record class AuthorizationDecision
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new AuthorizationDecision();

    private AuthorizationDecision() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/authorizationdecision</value>
    public const string UriString = Namespace2005 + "/authorizationdecision";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:authorizationdecision</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "authorizationdecision";

    /// <value>AuthorizationDecision</value>
    public const string Name = nameof(AuthorizationDecision);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the cookie path; </summary>
/// <value><inheritdoc cref="CookiePath.UriString" path="/value" /></value>
public record class CookiePath
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new CookiePath();

    private CookiePath() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/cookiepath</value>
    public const string UriString = Namespace2008 + "/cookiepath";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:cookiepath</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "cookiepath";

    /// <value>CookiePath</value>
    public const string Name = nameof(CookiePath);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the common name of the user; </summary>
/// <value><inheritdoc cref="CommonName.UriString" path="/value" /></value>
public record class CommonName
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName,
        IIdentifiable<long>
{
    long IIdentifiable<long>.Id => 0;

    public static readonly IClaimType Instance = new CommonName();

    private CommonName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace" path="/value" />/<inheritdoc cref="Name" path="/value" /></value>
    public const string UriString = Namespace + "/" + Name;

    /// <value><inheritdoc cref="ClaimType.ShortNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortNamespace + ":" + Name;

    /// <value>CommonName</value>
    public const string Name = nameof(CommonName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the country/region in which an entity resides, </summary>
/// <value><inheritdoc cref="Country.UriString" path="/value" /></value>
public record class Country
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Country();

    private Country() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/country</value>
    public const string UriString = Namespace2005 + "/country";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:country</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "country";

    /// <value>Country</value>
    public const string Name = nameof(Country);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the date of birth of an entity, </summary>
/// <value><inheritdoc cref="DateOfBirth.UriString" path="/value" /></value>
public record class DateOfBirth
    : ClaimType<DgmjrId.ClaimValueTypes._DateTime>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new DateOfBirth();

    private DateOfBirth() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/dateofbirth</value>
    public const string UriString = Namespace2005 + "/dateofbirth";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:dateofbirth</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "dateofbirth";

    /// <value>DateOfBirth</value>
    public const string Name = nameof(DateOfBirth);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity; </summary>
/// <value><inheritdoc cref="DenyOnlyPrimaryGroupSid.UriString" path="/value" /></value>
public record class DenyOnlyPrimaryGroupSid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new DenyOnlyPrimaryGroupSid();

    private DenyOnlyPrimaryGroupSid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/denyonlyprimarygroupsid</value>
    public const string UriString = Namespace2008 + "/denyonlyprimarygroupsid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:denyonlyprimarygroupsid</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "denyonlyprimarygroupsid";

    /// <value>DenyOnlyPrimaryGroupSid</value>
    public const string Name = nameof(DenyOnlyPrimaryGroupSid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the deny-only primary SID on an entity; A deny-only SID denies the specified entity to a securable object </summary>
/// <value><inheritdoc cref="DenyOnlyPrimarySid.UriString" path="/value" /></value>
public record class DenyOnlyPrimarySid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new DenyOnlyPrimarySid();

    private DenyOnlyPrimarySid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/denyonlyprimarysid</value>
    public const string UriString = Namespace2008 + "/denyonlyprimarysid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:denyonlyprimarysid</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "denyonlyprimarysid";

    /// <value>DenyOnlyPrimarySid</value>
    public const string Name = nameof(DenyOnlyPrimarySid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a deny-only security identifier (SID) for an entity, </summary>
/// <value><inheritdoc cref="DenyOnlySid.UriString" path="/value" /></value>
public record class DenyOnlySid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new DenyOnlySid();

    private DenyOnlySid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/denyonlysid</value>
    public const string UriString = Namespace2005 + "/denyonlysid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:denyonlysid</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "denyonlysid";

    /// <value>DenyOnlySid</value>
    public const string Name = nameof(DenyOnlySid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device, </summary>
/// <value><inheritdoc cref="DenyOnlyWindowsDeviceGroup.UriString" path="/value" /></value>
public record class DenyOnlyWindowsDeviceGroup
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new DenyOnlyWindowsDeviceGroup();

    private DenyOnlyWindowsDeviceGroup() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/denyonlywindowsdevicegroup</value>
    public const string UriString = Namespace2008 + "/denyonlywindowsdevicegroup";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:denyonlywindowsdevicegroup</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "denyonlywindowsdevicegroup";

    /// <value>DenyOnlyWindowsDeviceGroup</value>
    public const string Name = nameof(DenyOnlyWindowsDeviceGroup);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device, </summary>
/// <value><inheritdoc cref="DisplayName.UriString" path="/value" /></value>
public record class DisplayName
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new DisplayName();

    private DisplayName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/displayname</value>
    public const string UriString = Namespace2008 + "/displayname";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:displayname</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "displayname";

    /// <value>DisplayName</value>
    public const string Name = nameof(DisplayName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the DNS name associated with the computer name or with the alternative name of either the subject or issuer of an X.509 certificate, </summary>
/// <value><inheritdoc cref="Dns.UriString" path="/value" /></value>
public record class Dns
    : ClaimType<DgmjrId.ClaimValueTypes.DnsName>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Dns();

    private Dns() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/dns</value>
    public const string UriString = Namespace2005 + "/dns";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:dns</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "dns";

    /// <value>Dns</value>
    public const string Name = nameof(Dns);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="Dsa.UriString" path="/value" /></value>
public record class Dsa
    : ClaimType<DgmjrId.ClaimValueTypes.DsaKeyValue>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Dsa();

    private Dsa() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/dsa</value>
    public const string UriString = Namespace2008 + "/dsa";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:dsa</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "dsa";

    /// <value>Dsa</value>
    public const string Name = nameof(Dsa);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the email address of an entity, </summary>
/// <value><inheritdoc cref="Email2005.UriString" path="/value" /></value>
public record class Email2005
    : ClaimType<DgmjrId.ClaimValueTypes.Rfc822Name>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Email2005();

    private Email2005() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/emailaddress</value>
    public const string UriString = Namespace2005 + "/emailaddress";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:emailaddress</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "emailaddress";

    /// <value>Email2005</value>
    public const string Name = nameof(Email2005);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the email address of an entity, </summary>
/// <value><inheritdoc cref="Email.UriString" path="/value" /></value>
public record class Email
    : ClaimType<DgmjrId.ClaimValueTypes.Rfc822Name>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Email();

    private Email() { }

    /// <value><inheritdoc cref="ClaimType.Namespace" path="/value" />/emailaddress</value>
    public const string UriString = Namespace + "/emailaddress";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace" path="/value" />:emailaddress</value>
    public const string ShortUriString = ShortNamespace + ":" + "emailaddress";

    /// <value>Email</value>
    public const string Name = nameof(Email);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration</summary>
/// <value><inheritdoc cref="Expiration.UriString" path="/value" /></value>
public record class Expiration
    : ClaimType<DgmjrId.ClaimValueTypes._DateTime>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Expiration();

    private Expiration() { }

    /// <value><inheritdoc cref="ClaimType.Namespace" path="/value" />/expiration</value>
    public const string UriString = Namespace2008 + "/expiration";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:expiration</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "expiration";

    /// <value>Expiration</value>
    public const string Name = nameof(Expiration);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="Expired.UriString" path="/value" /></value>
public record class Expired
    : ClaimType<DgmjrId.ClaimValueTypes.Boolean>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Expired();

    private Expired() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/expired</value>
    public const string UriString = Namespace2008 + "/expired";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:expired</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "expired";

    /// <value>Expired</value>
    public const string Name = nameof(Expired);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the gender of an entity, </summary>
/// <value><inheritdoc cref="Gender.UriString" path="/value" /></value>
public record class Gender
    : ClaimType<DgmjrId.ClaimValueTypes.AnyUri>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Gender();

    private Gender() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/gender</value>
    public const string UriString = Namespace2005 + "/gender";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:gender</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "gender";

    /// <value>Gender</value>
    public const string Name = nameof(Gender);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the given name of an entity, </summary>
/// <value><inheritdoc cref="GivenName.UriString" path="/value" /></value>
public record class GivenName
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new GivenName();

    private GivenName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/givenname</value>
    public const string UriString = Namespace2005 + "/givenname";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:givenname</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "givenname";

    /// <value>GivenName</value>
    public const string Name = nameof(GivenName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the SID for the group of an entity, </summary>
/// <value><inheritdoc cref="GroupSid.UriString" path="/value" /></value>
public record class GroupSid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new GroupSid();

    private GroupSid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/groupsid</value>
    public const string UriString = Namespace2008 + "/groupsid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:groupsid</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "groupsid";

    /// <value>GroupSid</value>
    public const string Name = nameof(GroupSid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a hash value, </summary>
/// <value><inheritdoc cref="Hash.UriString" path="/value" /></value>
public record class Hash
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Hash();

    private Hash() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/hash</value>
    public const string UriString = Namespace2005 + "/hash";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:hash</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "hash";

    /// <value>Hash</value>
    public const string Name = nameof(Hash);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the home phone number of an entity, </summary>
/// <value><inheritdoc cref="HomePhone.UriString" path="/value" /></value>
public record class HomePhone
    : ClaimType<DgmjrId.ClaimValueTypes.PhoneNumber>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new HomePhone();

    private HomePhone() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/homephone</value>
    public const string UriString = Namespace2005 + "/homephone";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:homephone</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "homephone";

    /// <value>HomePhone</value>
    public const string Name = nameof(HomePhone);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="IsPersistent.UriString" path="/value" /></value>
public record class IsPersistent
    : ClaimType<DgmjrId.ClaimValueTypes.Boolean>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new IsPersistent();

    private IsPersistent() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/ispersistent</value>
    public const string UriString = Namespace2008 + "/ispersistent";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:ispersistent</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "ispersistent";

    /// <value>IsPersistent</value>
    public const string Name = nameof(IsPersistent);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the locale in which an entity resides, </summary>
/// <value><inheritdoc cref="Locality.UriString" path="/value" /></value>
public record class Locality
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Locality();

    private Locality() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/locality</value>
    public const string UriString = Namespace2005 + "/locality";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:locality</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "locality";

    /// <value>Locality</value>
    public const string Name = nameof(Locality);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the mobile phone number of an entity, </summary>
/// <value><inheritdoc cref="MobilePhone.UriString" path="/value" /></value>
public record class MobilePhone
    : ClaimType<DgmjrId.ClaimValueTypes.PhoneNumber>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new MobilePhone();

    private MobilePhone() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/mobilephone</value>
    public const string UriString = Namespace2005 + "/mobilephone";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:mobilephone</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "mobilephone";

    /// <value>MobilePhone	</value>
    public const string Name = "MobilePhone	";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the name of an entity, </summary>
/// <value><inheritdoc cref="Name.UriString" path="/value" /></value>
public record class Name
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Name();

    private Name() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/name</value>
    public const string UriString = Namespace2005 + "/name";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:name</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "name";
    public const string _Name = "Name";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => _Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the name of an entity, </summary>
/// <value><inheritdoc cref="NameIdentifier.UriString" path="/value" /></value>
public record class NameIdentifier
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new NameIdentifier();

    private NameIdentifier() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/nameidentifier</value>
    public const string UriString = Namespace2005 + "/nameidentifier";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:nameidentifier</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "nameidentifier";

    /// <value>NameIdentifier</value>
    public const string Name = nameof(NameIdentifier);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the alternative phone number of an entity, </summary>
/// <value><inheritdoc cref="OtherPhone.UriString" path="/value" /></value>
public record class OtherPhone
    : ClaimType<DgmjrId.ClaimValueTypes.PhoneNumber>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new OtherPhone();

    private OtherPhone() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/otherphone</value>
    public const string UriString = Namespace2005 + "/otherphone";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:otherphone</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "otherphone";

    /// <value>OtherPhone</value>
    public const string Name = nameof(OtherPhone);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the postal code of an entity, </summary>
/// <value><inheritdoc cref="PostalCode.UriString" path="/value" /></value>
public record class PostalCode
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new PostalCode();

    private PostalCode() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/postalcode</value>
    public const string UriString = Namespace2005 + "/postalcode";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:postalcode</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "postalcode";

    /// <value>PostalCode</value>
    public const string Name = nameof(PostalCode);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the primary group SID of an entity, </summary>
/// <value><inheritdoc cref="PrimaryGroupSid.UriString" path="/value" /></value>
public record class PrimaryGroupSid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new PrimaryGroupSid();

    private PrimaryGroupSid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/primarygroupsid</value>
    public const string UriString = Namespace2008 + "/primarygroupsid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:primarygroupsid</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "primarygroupsid";

    /// <value>PrimaryGroupSid</value>
    public const string Name = nameof(PrimaryGroupSid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the primary SID of an entity, </summary>
/// <value><inheritdoc cref="PrimarySid.UriString" path="/value" /></value>
public record class PrimarySid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new PrimarySid();

    private PrimarySid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/primarysid</value>
    public const string UriString = Namespace2008 + "/primarysid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:primarysid</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "primarysid";

    /// <value>PrimarySid</value>
    public const string Name = nameof(PrimarySid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the role of an entity, </summary>
/// <value><inheritdoc cref="Role.UriString" path="/value" /></value>
public record class Role
    : ClaimType<DgmjrId.ClaimValueTypes.AnyUri>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Role();

    private Role() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/role</value>
    public const string UriString = Namespace2008 + "/role";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:role</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "role";

    /// <value>Role</value>
    public const string Name = nameof(Role);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies an RSA key, </summary>
/// <value><inheritdoc cref="Rsa.UriString" path="/value" /></value>
public record class Rsa
    : ClaimType<DgmjrId.ClaimValueTypes.RsaKeyValue>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Rsa();

    private Rsa() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/rsa</value>
    public const string UriString = Namespace2005 + "/rsa";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:rsa</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "rsa";

    /// <value>Rsa</value>
    public const string Name = nameof(Rsa);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a serial number, </summary>
/// <value><inheritdoc cref="SerialNumber.UriString" path="/value" /></value>
public record class SerialNumber
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new SerialNumber();

    private SerialNumber() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/serialnumber</value>
    public const string UriString = Namespace2008 + "/serialnumber";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:serialnumber</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "serialnumber";

    /// <value>SerialNumber</value>
    public const string Name = nameof(SerialNumber);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a security identifier (SID), </summary>
/// <value><inheritdoc cref="Sid.UriString" path="/value" /></value>
public record class Sid
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Sid();

    private Sid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/sid</value>
    public const string UriString = Namespace2005 + "/sid";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:sid</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "sid";

    /// <value>Sid</value>
    public const string Name = nameof(Sid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a service principal name (SPN) claim, </summary>
/// <value><inheritdoc cref="Spn.UriString" path="/value" /></value>
public record class Spn
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Spn();

    private Spn() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/spn</value>
    public const string UriString = Namespace2005 + "/spn";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:spn</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "spn";

    /// <value>Spn</value>
    public const string Name = nameof(Spn);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the state or province in which an entity resides, </summary>
/// <value><inheritdoc cref="StateOrProvince.UriString" path="/value" /></value>
public record class StateOrProvince
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new StateOrProvince();

    private StateOrProvince() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/stateorprovince</value>
    public const string UriString = Namespace2005 + "/stateorprovince";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:stateorprovince</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "stateorprovince";

    /// <value>StateOrProvince</value>
    public const string Name = nameof(StateOrProvince);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the street address of an entity, </summary>
/// <value><inheritdoc cref="StreetAddress.UriString" path="/value" /></value>
public record class StreetAddress
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new StreetAddress();

    private StreetAddress() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/streetaddress</value>
    public const string UriString = Namespace2005 + "/streetaddress";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:streetaddress</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "streetaddress";

    /// <value>StreetAddress</value>
    public const string Name = nameof(StreetAddress);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the surname of an entity, </summary>
/// <value><inheritdoc cref="Surname.UriString" path="/value" /></value>
public record class Surname
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Surname();

    private Surname() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/surname</value>
    public const string UriString = Namespace2005 + "/surname";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:surname</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "surname";

    /// <value>Surname</value>
    public const string Name = nameof(Surname);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that identifies the system entity, </summary>
/// <value><inheritdoc cref="System.UriString" path="/value" /></value>
public record class System
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new System();

    private System() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/system</value>
    public const string UriString = Namespace2005 + "/system";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:system</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "system";

    /// <value>System</value>
    public const string Name = nameof(System);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a thumbprint.  A thumbprint is a globally unique SHA-1 hash of an X.509 certificate</summary>
/// <value><inheritdoc cref="Thumbprint.UriString" path="/value" /></value>
public record class Thumbprint
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName,
        IHaveADescription
{
    public static readonly IClaimType Instance = new Thumbprint();

    private Thumbprint() { }

    public const string Description = "A thumbprint is a globally unique SHA-1 hash of an X.509 certificate";

    string IHaveADescription.Description => Description;

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/thumbprint</value>
    public const string UriString =
        Namespace2005
        + "/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:thumbprint</value>
    public const string ShortUriString =
        ShortNamespace2005
        + ":"
        + "thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate";

    /// <value>Thumbprint</value>
    public const string Name = nameof(Thumbprint);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a user principal name (UPN), </summary>
/// <value><inheritdoc cref="Upn.UriString" path="/value" /></value>
public record class Upn
    : ClaimType<DgmjrId.ClaimValueTypes.UpnName>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Upn();

    private Upn() { }

    /// <value><inheritdoc cref="ClaimType.Namespace" path="/value" />/upn</value>
    public const string UriString = Namespace + "/upn";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace" path="/value" />:upn</value>
    public const string ShortUriString = ShortNamespace + ":" + "upn";

    /// <value>Upn	</value>
    public const string Name = nameof(Upn);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a user principal name (UPN), </summary>
/// <value><inheritdoc cref="Upn2005.UriString" path="/value" /></value>
public record class Upn2005
    : ClaimType<DgmjrId.ClaimValueTypes.UpnName>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Upn2005();

    private Upn2005() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/upn</value>
    public const string UriString = Namespace2005 + "/upn";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:upn</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "upn";

    /// <value>Upn2005</value>
    public const string Name = nameof(Upn2005);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a URI, </summary>
/// <value><inheritdoc cref="_Uri.UriString" path="/value" /></value>
public record class _Uri
    : ClaimType<DgmjrId.ClaimValueTypes.AnyUri>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new _Uri();

    private _Uri() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/uri</value>
    public const string UriString = Namespace2005 + "/uri";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:uri</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "uri";

    /// <value>Uri</value>
    public const string Name = nameof(Uri);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the user data, </summary>
/// <value><inheritdoc cref="UserData.UriString" path="/value" /></value>
public record class UserData
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new UserData();

    private UserData() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/userdata</value>
    public const string UriString = Namespace2008 + "/userdata";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:userdata</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "userdata";

    /// <value>UserData</value>
    public const string Name = nameof(UserData);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the version, </summary>
/// <value><inheritdoc cref="Version.UriString" path="/value" /></value>
public record class Version
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Version();

    private Version() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/version</value>
    public const string UriString = Namespace2008 + "/version";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:version</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "version";

    /// <value>Version</value>
    public const string Name = nameof(Version);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the webpage of an entity, </summary>
/// <value><inheritdoc cref="Webpage.UriString" path="/value" /></value>
public record class Webpage
    : ClaimType<DgmjrId.ClaimValueTypes.AnyUri>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new Webpage();

    private Webpage() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/webpage</value>
    public const string UriString = Namespace2005 + "/webpage";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:webpage</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "webpage";

    /// <value>Webpage</value>
    public const string Name = nameof(Webpage);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows domain account name of an entity, </summary>
/// <value><inheritdoc cref="WindowsAccountName.UriString" path="/value" /></value>
public record class WindowsAccountName
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new WindowsAccountName();

    private WindowsAccountName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/windowsaccountname</value>
    public const string UriString = Namespace2008 + "/windowsaccountname";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:windowsaccountname</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "windowsaccountname";

    /// <value>WindowsAccountName</value>
    public const string Name = nameof(WindowsAccountName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</summary>
/// <value><inheritdoc cref="WindowsDeviceClaim.UriString" path="/value" /></value>
public record class WindowsDeviceClaim
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new WindowsDeviceClaim();

    private WindowsDeviceClaim() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/windowsdeviceclaim</value>
    public const string UriString = Namespace2008 + "/windowsdeviceclaim";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:windowsdeviceclaim</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "windowsdeviceclaim";

    /// <value>WindowsDeviceClaim</value>
    public const string Name = nameof(WindowsDeviceClaim);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows group SID of the device, </summary>
/// <value><inheritdoc cref="WindowsDeviceGroup.UriString" path="/value" /></value>
public record class WindowsDeviceGroup
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new WindowsDeviceGroup();

    private WindowsDeviceGroup() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/windowsdevicegroup</value>
    public const string UriString = Namespace2008 + "/windowsdevicegroup";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:windowsdevicegroup</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "windowsdevicegroup";

    /// <value>WindowsDeviceGroup</value>
    public const string Name = nameof(WindowsDeviceGroup);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>windowsfqbnversion.</summary>
/// <value><inheritdoc cref="WindowsFqbnVersion.UriString" path="/value" /></value>
public record class WindowsFqbnVersion
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new WindowsFqbnVersion();

    private WindowsFqbnVersion() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/windowsfqbnversion</value>
    public const string UriString = Namespace2008 + "/windowsfqbnversion";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:windowsfqbnversion</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "windowsfqbnversion";

    /// <value>WindowsFqbnVersion</value>
    public const string Name = nameof(WindowsFqbnVersion);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="WindowsSubAuthority.UriString" path="/value" /></value>
public record class WindowsSubAuthority
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new WindowsSubAuthority();

    private WindowsSubAuthority() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/windowssubauthority</value>
    public const string UriString = Namespace2008 + "/windowssubauthority";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:windowssubauthority</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "windowssubauthority";

    /// <value>WindowsSubAuthority</value>
    public const string Name = nameof(WindowsSubAuthority);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="WindowsUserClaim.UriString" path="/value" /></value>
public record class WindowsUserClaim
    : ClaimType<DgmjrId.ClaimValueTypes.String>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new WindowsUserClaim();

    private WindowsUserClaim() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/windowsuserclaim</value>
    public const string UriString = Namespace2008 + "/windowsuserclaim";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2008" path="/value" />:windowsuserclaim</value>
    public const string ShortUriString = ShortNamespace2008 + ":" + "windowsuserclaim";

    /// <value>WindowsUserClaim</value>
    public const string Name = nameof(WindowsUserClaim);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for an X.500 distinguished name claim, such as the subject of an X.509 Public Key Certificate or an entry identifier in a directory services Directory Information Tree; </summary>
/// <value><inheritdoc cref="X500DistinguishedName.UriString" path="/value" /></value>
public record class X500DistinguishedName
    : ClaimType<DgmjrId.ClaimValueTypes.X500Name>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new X500DistinguishedName();

    private X500DistinguishedName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2005" path="/value" />/x500distinguishedname</value>
    public const string UriString = Namespace2005 + "/x500distinguishedname";

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2005" path="/value" />:x500distinguishedname</value>
    public const string ShortUriString = ShortNamespace2005 + ":" + "x500distinguishedname";

    /// <value>X500DistinguishedName</value>
    public const string Name = nameof(X500DistinguishedName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

public record class PasswordExpirationDays
    : ClaimType<DgmjrId.ClaimValueTypes.Integer32>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new PasswordExpirationDays();

    private PasswordExpirationDays() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2012" path="/value" /><inheritdoc cref="ClaimType.Slash" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public const string UriString = Namespace2012 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2012" path="/value" /><inheritdoc cref="ClaimType.Colon" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortNamespace2012 + Colon + Name;

    /// <value>passwordexpirationtime</value>
    public const string Name = "passwordexpirationdays";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

public record class PasswordExpirationTime
    : ClaimType<DgmjrId.ClaimValueTypes.Integer32>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new PasswordExpirationTime();

    private PasswordExpirationTime() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2012" path="/value" /><inheritdoc cref="ClaimType.Slash" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public const string UriString = Namespace2012 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2012" path="/value" /><inheritdoc cref="ClaimType.Colon" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortNamespace2012 + Colon + Name;

    /// <value>passwordexpirationtime</value>
    public const string Name = "passwordexpirationtime";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

public record class PasswordChangeUrl
    : ClaimType<DgmjrId.ClaimValueTypes.AnyUri>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new PasswordChangeUrl();

    private PasswordChangeUrl() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2012" path="/value" /><inheritdoc cref="ClaimType.Slash" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public const string UriString = Namespace2012 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortNamespace2012" path="/value" /><inheritdoc cref="ClaimType.Colon" path="/value" /><inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortNamespace2012 + Colon + Name;

    /// <value>passwordchangeurl</value>
    public const string Name = "passwordchangeurl";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

public record class ObjectId
    : ClaimType<DgmjrId.ClaimValueTypes.ObjectId>,
        IClaimType,
        IIdentityComponent,
        IHaveAuri,
        IHaveAUriString,
        IHaveAName
{
    public static readonly IClaimType Instance = new ObjectId();

    private ObjectId() { }

    /// <value>https://www.mongodb.com/docs/manual/reference/method/ObjectId</value>
    public const string UriString = "https://www.mongodb.com/docs/manual/reference/method/ObjectId";

    /// <value>mongodb:objectid</value>
    public const string ShortUriString = "mongodb:objectid";

    /// <value>objectid</value>
    public const string Name = "objectid";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}
