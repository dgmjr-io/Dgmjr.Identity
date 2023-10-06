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
public record class Actor : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Actor();

    private Actor() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2009Namespace" path="/value" />/actor</value>
    public const string UriString = ClaimType2009Namespace + "/actor";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2009Namespace" path="/value" />:actor</value>
    public const string ShortUriString = ShortClaimType2009Namespace + ":" + "actor";

    /// <value>Actor</value>
    public const string Name = nameof(Actor);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the anonymous user.</summary>
/// <value><inheritdoc cref="Anonymous.UriString" path="/value" /></value>
public record class Anonymous : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Anonymous();

    private Anonymous() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/anonymous</value>
    public const string UriString = ClaimType2005Namespace + "/anonymous";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:authenticated</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "anonymous";

    /// <value>Anonymous</value>
    public const string Name = nameof(Anonymous);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies details about whether an identity is authenticated</summary>
/// <value><inheritdoc cref="Authenticated.UriString" path="/value" /></value>
public record class Authenticated : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Authenticated();

    private Authenticated() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/authenticated</value>
    public const string UriString = ClaimType2005Namespace + "/authenticated";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:authenticated</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "authenticated";

    /// <value>Authenticated</value>
    public const string Name = nameof(Authenticated);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the instant at which an entity was authenticated; </summary>
/// <value><inheritdoc cref="AuthenticationInstant.UriString" path="/value" /></value>
public record class AuthenticationInstant : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new AuthenticationInstant();

    private AuthenticationInstant() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/authenticationinstant</value>
    public const string UriString = ClaimType2008Namespace + "/authenticationinstant";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:authenticationinstant</value>
    public const string ShortUriString =
        ShortClaimType2008Namespace + ":" + "authenticationinstant";

    /// <value>AuthenticationInstant</value>
    public const string Name = nameof(AuthenticationInstant);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the method with which an entity was authenticated; </summary>
/// <value><inheritdoc cref="AuthenticationMethod.UriString" path="/value" /></value>
public record class AuthenticationMethod : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new AuthenticationMethod();

    private AuthenticationMethod() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/authenticationmethod</value>
    public const string UriString = ClaimType2008Namespace + "/authenticationmethod";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:authenticationmethod</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "authenticationmethod";

    /// <value>AuthenticationMethod	</value>
    public const string Name = nameof(AuthenticationMethod);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies an authorization decision on an entity; </summary>
/// <value><inheritdoc cref="AuthorizationDecision.UriString" path="/value" /></value>
public record class AuthorizationDecision : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new AuthorizationDecision();

    private AuthorizationDecision() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/authorizationdecision</value>
    public const string UriString = ClaimType2005Namespace + "/authorizationdecision";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:authorizationdecision</value>
    public const string ShortUriString =
        ShortClaimType2005Namespace + ":" + "authorizationdecision";

    /// <value>AuthorizationDecision</value>
    public const string Name = nameof(AuthorizationDecision);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the cookie path; </summary>
/// <value><inheritdoc cref="CookiePath.UriString" path="/value" /></value>
public record class CookiePath : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new CookiePath();

    private CookiePath() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/cookiepath</value>
    public const string UriString = ClaimType2008Namespace + "/cookiepath";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:cookiepath</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "cookiepath";

    /// <value>CookiePath</value>
    public const string Name = nameof(CookiePath);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the country/region in which an entity resides, </summary>
/// <value><inheritdoc cref="Country.UriString" path="/value" /></value>
public record class Country : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Country();

    private Country() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/country</value>
    public const string UriString = ClaimType2005Namespace + "/country";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:country</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "country";

    /// <value>Country</value>
    public const string Name = nameof(Country);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the date of birth of an entity, </summary>
/// <value><inheritdoc cref="DateOfBirth.UriString" path="/value" /></value>
public record class DateOfBirth : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new DateOfBirth();

    private DateOfBirth() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/dateofbirth</value>
    public const string UriString = ClaimType2005Namespace + "/dateofbirth";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:dateofbirth</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "dateofbirth";

    /// <value>DateOfBirth</value>
    public const string Name = nameof(DateOfBirth);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the deny-only primary group SID on an entity; </summary>
/// <value><inheritdoc cref="DenyOnlyPrimaryGroupSid.UriString" path="/value" /></value>
public record class DenyOnlyPrimaryGroupSid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new DenyOnlyPrimaryGroupSid();

    private DenyOnlyPrimaryGroupSid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/denyonlyprimarygroupsid</value>
    public const string UriString = ClaimType2008Namespace + "/denyonlyprimarygroupsid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:denyonlyprimarygroupsid</value>
    public const string ShortUriString =
        ShortClaimType2008Namespace + ":" + "denyonlyprimarygroupsid";

    /// <value>DenyOnlyPrimaryGroupSid</value>
    public const string Name = nameof(DenyOnlyPrimaryGroupSid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the deny-only primary SID on an entity; A deny-only SID denies the specified entity to a securable object </summary>
/// <value><inheritdoc cref="DenyOnlyPrimarySid.UriString" path="/value" /></value>
public record class DenyOnlyPrimarySid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new DenyOnlyPrimarySid();

    private DenyOnlyPrimarySid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/denyonlyprimarysid</value>
    public const string UriString = ClaimType2008Namespace + "/denyonlyprimarysid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:denyonlyprimarysid</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "denyonlyprimarysid";

    /// <value>DenyOnlyPrimarySid</value>
    public const string Name = nameof(DenyOnlyPrimarySid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a deny-only security identifier (SID) for an entity, </summary>
/// <value><inheritdoc cref="DenyOnlySid.UriString" path="/value" /></value>
public record class DenyOnlySid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new DenyOnlySid();

    private DenyOnlySid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/denyonlysid</value>
    public const string UriString = ClaimType2005Namespace + "/denyonlysid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:denyonlysid</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "denyonlysid";

    /// <value>DenyOnlySid</value>
    public const string Name = nameof(DenyOnlySid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows deny-only group SID of the device, </summary>
/// <value><inheritdoc cref="DenyOnlyWindowsDeviceGroup.UriString" path="/value" /></value>
public record class DenyOnlyWindowsDeviceGroup : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new DenyOnlyWindowsDeviceGroup();

    private DenyOnlyWindowsDeviceGroup() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/denyonlywindowsdevicegroup</value>
    public const string UriString = ClaimType2008Namespace + "/denyonlywindowsdevicegroup";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:denyonlywindowsdevicegroup</value>
    public const string ShortUriString =
        ShortClaimType2008Namespace + ":" + "denyonlywindowsdevicegroup";

    /// <value>DenyOnlyWindowsDeviceGroup</value>
    public const string Name = nameof(DenyOnlyWindowsDeviceGroup);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the DNS name associated with the computer name or with the alternative name of either the subject or issuer of an X.509 certificate, </summary>
/// <value><inheritdoc cref="Dns.UriString" path="/value" /></value>
public record class Dns : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Dns();

    private Dns() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/dns</value>
    public const string UriString = ClaimType2005Namespace + "/dns";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:dns</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "dns";

    /// <value>Dns</value>
    public const string Name = nameof(Dns);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="Dsa.UriString" path="/value" /></value>
public record class Dsa : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Dsa();

    private Dsa() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/dsa</value>
    public const string UriString = ClaimType2008Namespace + "/dsa";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:dsa</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "dsa";

    /// <value>Dsa</value>
    public const string Name = nameof(Dsa);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the email address of an entity, </summary>
/// <value><inheritdoc cref="Email.UriString" path="/value" /></value>
public record class Email : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Email();

    private Email() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/emailaddress</value>
    public const string UriString = ClaimType2005Namespace + "/emailaddress";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:emailaddress</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "emailaddress";

    /// <value>Email</value>
    public const string Name = nameof(Email);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration</summary>
/// <value><inheritdoc cref="Expiration.UriString" path="/value" /></value>
public record class Expiration : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Expiration();

    private Expiration() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/expiration</value>
    public const string UriString = ClaimType2008Namespace + "/expiration";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:expiration</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "expiration";

    /// <value>Expiration</value>
    public const string Name = nameof(Expiration);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="Expired.UriString" path="/value" /></value>
public record class Expired : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Expired();

    private Expired() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/expired</value>
    public const string UriString = ClaimType2008Namespace + "/expired";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:expired</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "expired";

    /// <value>Expired</value>
    public const string Name = nameof(Expired);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the gender of an entity, </summary>
/// <value><inheritdoc cref="Gender.UriString" path="/value" /></value>
public record class Gender : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Gender();

    private Gender() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/gender</value>
    public const string UriString = ClaimType2005Namespace + "/gender";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:gender</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "gender";

    /// <value>Gender</value>
    public const string Name = nameof(Gender);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the given name of an entity, </summary>
/// <value><inheritdoc cref="GivenName.UriString" path="/value" /></value>
public record class GivenName : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new GivenName();

    private GivenName() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/givenname</value>
    public const string UriString = ClaimType2005Namespace + "/givenname";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:givenname</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "givenname";

    /// <value>GivenName</value>
    public const string Name = nameof(GivenName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the SID for the group of an entity, </summary>
/// <value><inheritdoc cref="GroupSid.UriString" path="/value" /></value>
public record class GroupSid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new GroupSid();

    private GroupSid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/groupsid</value>
    public const string UriString = ClaimType2008Namespace + "/groupsid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:groupsid</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "groupsid";

    /// <value>GroupSid</value>
    public const string Name = nameof(GroupSid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a hash value, </summary>
/// <value><inheritdoc cref="Hash.UriString" path="/value" /></value>
public record class Hash : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Hash();

    private Hash() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/hash</value>
    public const string UriString = ClaimType2005Namespace + "/hash";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:hash</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "hash";

    /// <value>Hash</value>
    public const string Name = nameof(Hash);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the home phone number of an entity, </summary>
/// <value><inheritdoc cref="HomePhone.UriString" path="/value" /></value>
public record class HomePhone : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new HomePhone();

    private HomePhone() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/homephone</value>
    public const string UriString = ClaimType2005Namespace + "/homephone";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:homephone</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "homephone";

    /// <value>HomePhone</value>
    public const string Name = nameof(HomePhone);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="IsPersistent.UriString" path="/value" /></value>
public record class IsPersistent : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new IsPersistent();

    private IsPersistent() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/ispersistent</value>
    public const string UriString = ClaimType2008Namespace + "/ispersistent";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:ispersistent</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "ispersistent";

    /// <value>IsPersistent</value>
    public const string Name = nameof(IsPersistent);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the locale in which an entity resides, </summary>
/// <value><inheritdoc cref="Locality.UriString" path="/value" /></value>
public record class Locality : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Locality();

    private Locality() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/locality</value>
    public const string UriString = ClaimType2005Namespace + "/locality";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:locality</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "locality";

    /// <value>Locality</value>
    public const string Name = nameof(Locality);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the mobile phone number of an entity, </summary>
/// <value><inheritdoc cref="MobilePhone.UriString" path="/value" /></value>
public record class MobilePhone : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new MobilePhone();

    private MobilePhone() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/mobilephone</value>
    public const string UriString = ClaimType2005Namespace + "/mobilephone";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:mobilephone</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "mobilephone";

    /// <value>MobilePhone	</value>
    public const string Name = "MobilePhone	";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the name of an entity, </summary>
/// <value><inheritdoc cref="Name.UriString" path="/value" /></value>
public record class Name : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Name();

    private Name() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/name</value>
    public const string UriString = ClaimType2005Namespace + "/name";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:name</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "name";
    public const string _Name = "Name";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => _Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the name of an entity, </summary>
/// <value><inheritdoc cref="NameIdentifier.UriString" path="/value" /></value>
public record class NameIdentifier : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new NameIdentifier();

    private NameIdentifier() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/nameidentifier</value>
    public const string UriString = ClaimType2005Namespace + "/nameidentifier";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:nameidentifier</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "nameidentifier";

    /// <value>NameIdentifier</value>
    public const string Name = nameof(NameIdentifier);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the alternative phone number of an entity, </summary>
/// <value><inheritdoc cref="OtherPhone.UriString" path="/value" /></value>
public record class OtherPhone : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new OtherPhone();

    private OtherPhone() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/otherphone</value>
    public const string UriString = ClaimType2005Namespace + "/otherphone";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:otherphone</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "otherphone";

    /// <value>OtherPhone</value>
    public const string Name = nameof(OtherPhone);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the postal code of an entity, </summary>
/// <value><inheritdoc cref="PostalCode.UriString" path="/value" /></value>
public record class PostalCode : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new PostalCode();

    private PostalCode() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/postalcode</value>
    public const string UriString = ClaimType2005Namespace + "/postalcode";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:postalcode</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "postalcode";

    /// <value>PostalCode</value>
    public const string Name = nameof(PostalCode);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the primary group SID of an entity, </summary>
/// <value><inheritdoc cref="PrimaryGroupSid.UriString" path="/value" /></value>
public record class PrimaryGroupSid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new PrimaryGroupSid();

    private PrimaryGroupSid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/primarygroupsid</value>
    public const string UriString = ClaimType2008Namespace + "/primarygroupsid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:primarygroupsid</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "primarygroupsid";

    /// <value>PrimaryGroupSid</value>
    public const string Name = nameof(PrimaryGroupSid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the primary SID of an entity, </summary>
/// <value><inheritdoc cref="PrimarySid.UriString" path="/value" /></value>
public record class PrimarySid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new PrimarySid();

    private PrimarySid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/primarysid</value>
    public const string UriString = ClaimType2008Namespace + "/primarysid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:primarysid</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "primarysid";

    /// <value>PrimarySid</value>
    public const string Name = nameof(PrimarySid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the role of an entity, </summary>
/// <value><inheritdoc cref="Role.UriString" path="/value" /></value>
public record class Role : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Role();

    private Role() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/role</value>
    public const string UriString = ClaimType2008Namespace + "/role";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:role</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "role";

    /// <value>Role</value>
    public const string Name = nameof(Role);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies an RSA key, </summary>
/// <value><inheritdoc cref="Rsa.UriString" path="/value" /></value>
public record class Rsa : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Rsa();

    private Rsa() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/rsa</value>
    public const string UriString = ClaimType2005Namespace + "/rsa";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:rsa</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "rsa";

    /// <value>Rsa</value>
    public const string Name = nameof(Rsa);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a serial number, </summary>
/// <value><inheritdoc cref="SerialNumber.UriString" path="/value" /></value>
public record class SerialNumber : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new SerialNumber();

    private SerialNumber() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/serialnumber</value>
    public const string UriString = ClaimType2008Namespace + "/serialnumber";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:serialnumber</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "serialnumber";

    /// <value>SerialNumber</value>
    public const string Name = nameof(SerialNumber);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a security identifier (SID), </summary>
/// <value><inheritdoc cref="Sid.UriString" path="/value" /></value>
public record class Sid : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Sid();

    private Sid() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/sid</value>
    public const string UriString = ClaimType2005Namespace + "/sid";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:sid</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "sid";

    /// <value>Sid</value>
    public const string Name = nameof(Sid);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a service principal name (SPN) claim, </summary>
/// <value><inheritdoc cref="Spn.UriString" path="/value" /></value>
public record class Spn : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Spn();

    private Spn() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/spn</value>
    public const string UriString = ClaimType2005Namespace + "/spn";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:spn</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "spn";

    /// <value>Spn</value>
    public const string Name = nameof(Spn);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the state or province in which an entity resides, </summary>
/// <value><inheritdoc cref="StateOrProvince.UriString" path="/value" /></value>
public record class StateOrProvince : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new StateOrProvince();

    private StateOrProvince() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/stateorprovince</value>
    public const string UriString = ClaimType2005Namespace + "/stateorprovince";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:stateorprovince</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "stateorprovince";

    /// <value>StateOrProvince</value>
    public const string Name = nameof(StateOrProvince);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the street address of an entity, </summary>
/// <value><inheritdoc cref="StreetAddress.UriString" path="/value" /></value>
public record class StreetAddress : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new StreetAddress();

    private StreetAddress() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/streetaddress</value>
    public const string UriString = ClaimType2005Namespace + "/streetaddress";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:streetaddress</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "streetaddress";

    /// <value>StreetAddress</value>
    public const string Name = nameof(StreetAddress);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the surname of an entity, </summary>
/// <value><inheritdoc cref="Surname.UriString" path="/value" /></value>
public record class Surname : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Surname();

    private Surname() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/surname</value>
    public const string UriString = ClaimType2005Namespace + "/surname";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:surname</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "surname";

    /// <value>Surname</value>
    public const string Name = nameof(Surname);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that identifies the system entity, </summary>
/// <value><inheritdoc cref="System.UriString" path="/value" /></value>
public record class System : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new System();

    private System() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/system</value>
    public const string UriString = ClaimType2005Namespace + "/system";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:system</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "system";

    /// <value>System</value>
    public const string Name = nameof(System);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a thumbprint, </summary>
/// <value><inheritdoc cref="Thumbprint.UriString" path="/value" /></value>
public record class Thumbprint : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Thumbprint();

    private Thumbprint() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate</value>
    public const string UriString =
        ClaimType2005Namespace
        + "/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate</value>
    public const string ShortUriString =
        ShortClaimType2005Namespace
        + ":"
        + "thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate";

    /// <value>Thumbprint</value>
    public const string Name = nameof(Thumbprint);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a user principal name (UPN), </summary>
/// <value><inheritdoc cref="Upn.UriString" path="/value" /></value>
public record class Upn : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Upn();

    private Upn() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/upn</value>
    public const string UriString = ClaimType2005Namespace + "/upn";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:upn</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "upn";

    /// <value>Upn	</value>
    public const string Name = nameof(Upn);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies a URI, </summary>
/// <value><inheritdoc cref="_Uri.UriString" path="/value" /></value>
public record class _Uri : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new _Uri();

    private _Uri() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/uri</value>
    public const string UriString = ClaimType2005Namespace + "/uri";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:uri</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "uri";

    /// <value>Uri</value>
    public const string Name = nameof(Uri);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the user data, </summary>
/// <value><inheritdoc cref="UserData.UriString" path="/value" /></value>
public record class UserData : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new UserData();

    private UserData() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/userdata</value>
    public const string UriString = ClaimType2008Namespace + "/userdata";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:userdata</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "userdata";

    /// <value>UserData</value>
    public const string Name = nameof(UserData);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the version, </summary>
/// <value><inheritdoc cref="Version.UriString" path="/value" /></value>
public record class Version : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Version();

    private Version() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/version</value>
    public const string UriString = ClaimType2008Namespace + "/version";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:version</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "version";

    /// <value>Version</value>
    public const string Name = nameof(Version);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the webpage of an entity, </summary>
/// <value><inheritdoc cref="Webpage.UriString" path="/value" /></value>
public record class Webpage : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new Webpage();

    private Webpage() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/webpage</value>
    public const string UriString = ClaimType2005Namespace + "/webpage";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:webpage</value>
    public const string ShortUriString = ShortClaimType2005Namespace + ":" + "webpage";

    /// <value>Webpage</value>
    public const string Name = nameof(Webpage);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows domain account name of an entity, </summary>
/// <value><inheritdoc cref="WindowsAccountName.UriString" path="/value" /></value>
public record class WindowsAccountName : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new WindowsAccountName();

    private WindowsAccountName() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/windowsaccountname</value>
    public const string UriString = ClaimType2008Namespace + "/windowsaccountname";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:windowsaccountname</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "windowsaccountname";

    /// <value>WindowsAccountName</value>
    public const string Name = nameof(WindowsAccountName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim.</summary>
/// <value><inheritdoc cref="WindowsDeviceClaim.UriString" path="/value" /></value>
public record class WindowsDeviceClaim : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new WindowsDeviceClaim();

    private WindowsDeviceClaim() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/windowsdeviceclaim</value>
    public const string UriString = ClaimType2008Namespace + "/windowsdeviceclaim";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:windowsdeviceclaim</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "windowsdeviceclaim";

    /// <value>WindowsDeviceClaim</value>
    public const string Name = nameof(WindowsDeviceClaim);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for a claim that specifies the Windows group SID of the device, </summary>
/// <value><inheritdoc cref="WindowsDeviceGroup.UriString" path="/value" /></value>
public record class WindowsDeviceGroup : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new WindowsDeviceGroup();

    private WindowsDeviceGroup() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/windowsdevicegroup</value>
    public const string UriString = ClaimType2008Namespace + "/windowsdevicegroup";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:windowsdevicegroup</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "windowsdevicegroup";

    /// <value>WindowsDeviceGroup</value>
    public const string Name = nameof(WindowsDeviceGroup);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>windowsfqbnversion.</summary>
/// <value><inheritdoc cref="WindowsFqbnVersion.UriString" path="/value" /></value>
public record class WindowsFqbnVersion : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new WindowsFqbnVersion();

    private WindowsFqbnVersion() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/windowsfqbnversion</value>
    public const string UriString = ClaimType2008Namespace + "/windowsfqbnversion";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:windowsfqbnversion</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "windowsfqbnversion";

    /// <value>WindowsFqbnVersion</value>
    public const string Name = nameof(WindowsFqbnVersion);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="WindowsSubAuthority.UriString" path="/value" /></value>
public record class WindowsSubAuthority : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new WindowsSubAuthority();

    private WindowsSubAuthority() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/windowssubauthority</value>
    public const string UriString = ClaimType2008Namespace + "/windowssubauthority";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:windowssubauthority</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "windowssubauthority";

    /// <value>WindowsSubAuthority</value>
    public const string Name = nameof(WindowsSubAuthority);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary></summary>
/// <value><inheritdoc cref="WindowsUserClaim.UriString" path="/value" /></value>
public record class WindowsUserClaim : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new WindowsUserClaim();

    private WindowsUserClaim() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2008Namespace" path="/value" />/windowsuserclaim</value>
    public const string UriString = ClaimType2008Namespace + "/windowsuserclaim";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2008Namespace" path="/value" />:windowsuserclaim</value>
    public const string ShortUriString = ShortClaimType2008Namespace + ":" + "windowsuserclaim";

    /// <value>WindowsUserClaim</value>
    public const string Name = nameof(WindowsUserClaim);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The URI for an X.500 distinguished name claim, such as the subject of an X.509 Public Key Certificate or an entry identifier in a directory services Directory Information Tree; </summary>
/// <value><inheritdoc cref="X500DistinguishedName.UriString" path="/value" /></value>
public record class X500DistinguishedName : ClaimType, IClaimType, IIdentityComponent
{
    public static readonly IClaimType Instance = new X500DistinguishedName();

    private X500DistinguishedName() { }

    /// <value><inheritdoc cref="ClaimType.ClaimType2005Namespace" path="/value" />/x500distinguishedname</value>
    public const string UriString = ClaimType2005Namespace + "/x500distinguishedname";

    /// <value><inheritdoc cref="ClaimType.ShortClaimType2005Namespace" path="/value" />:x500distinguishedname</value>
    public const string ShortUriString =
        ShortClaimType2005Namespace + ":" + "x500distinguishedname";

    /// <value>X500DistinguishedName</value>
    public const string Name = nameof(X500DistinguishedName);

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IIdentityComponent.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" /></value>
    public override uri ShortUri => ShortUriString;
}
