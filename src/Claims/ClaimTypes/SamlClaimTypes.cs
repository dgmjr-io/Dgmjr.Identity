namespace Dgmjr.Identity.ClaimTypes.SamlClaimTypes;

/// <summary>The user's access token</summary>
/// <value><inheritdoc cref="UriString"/></value>
public record class Actort : ClaimType<Dgmjr.Identity.ClaimValueTypes.String>, IClaimType
{
    public static readonly IClaimType Instance = new Actort();

    private Actort() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + Colon + Name;

    /// <value>actort</value>
    public const string Name = "actort";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The user's access token</summary>
/// <value><inheritdoc cref="UriString"/></value>
public record class AccessToken
    : ClaimType<Dgmjr.Identity.ClaimValueTypes.Array<Dgmjr.Identity.ClaimValueTypes.String>>,
        IClaimType
{
    public static readonly IClaimType Instance = new AccessToken();

    private AccessToken() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + Colon + Name;

    /// <value>access_token</value>
    public const string Name = "access_token";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>JSON array of strings</summary>
/// <remarks>Indicates the Auth Context IDs of the operations that the bearer is eligible to perform. Auth Context IDs can be used to trigger a demand for step-up authentication from within your application and services. Often used along with the xms_cc claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Acrs
    : ClaimType<Dgmjr.Identity.ClaimValueTypes.Array<Dgmjr.Identity.ClaimValueTypes.String>>,
        IClaimType
{
    public static readonly IClaimType Instance = new Acrs();

    private Acrs() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + Colon + Name;

    /// <value>aud</value>
    public const string Name = "aud";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String, an App ID GUID</summary>
/// <remarks>Identifies the intended recipient of the token. In id_tokens, the audience is your app's Application ID, assigned to your app in the Azure portal. This value should be validated. The token should be rejected if it fails to match your app's Application ID.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Aud
    : ClaimType<Dgmjr.Identity.ClaimValueTypes.OneOf<
        Dgmjr.Identity.ClaimValueTypes.AnyUri,
        Dgmjr.Identity.ClaimValueTypes.Guid
    >>,
        IClaimType
{
    public static readonly IClaimType Instance = new Aud();

    private Aud() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>aud</value>
    public const string Name = "aud";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String, an issuer URI</summary>
/// <remarks>Identifies the issuer, or "authorization server" that constructs and returns the token. It also identifies the tenant for which the user was authenticated. If the token was issued by the v2.0 endpoint, the URI ends in /v2.0. The GUID that indicates that the user is a consumer user from a Microsoft account is 9188040d-6c67-4c5b-b112-36a304b66dad. Your app should use the GUID portion of the claim to restrict the set of tenants that can sign in to the app, if applicable.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Iss : ClaimType<DgmjrCvt.AnyUri>, IClaimType
{
    public static readonly IClaimType Instance = new Iss();

    private Iss() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>iss</value>
    public const string Name = "iss";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>int, a Unix timestamp</summary>
/// <remarks>Indicates when the authentication for the token occurred.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Iat : ClaimType<DgmjrCvt.Integer32>, IClaimType
{
    public static readonly IClaimType Instance = new Iat();

    private Iat() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>iat</value>
    public const string Name = "iat";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String, usually an STS URI</summary>
/// <remarks>Records the identity provider that authenticated the subject of the token. This value is identical to the value of the issuer claim unless the user account isn't in the same tenant as the issuer - guests, for instance. If the claim isn't present, it means that the value of iss can be used instead. For personal accounts being used in an organizational context (for instance, a personal account invited to a tenant), the idp claim may be 'live.com' or an STS URI containing the Microsoft account tenant 9188040d-6c67-4c5b-b112-36a304b66dad.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Idp : ClaimType<DgmjrCvt.AnyUri>, IClaimType
{
    public static readonly IClaimType Instance = new Idp();

    private Idp() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>idp</value>
    public const string Name = "idp";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>int, a Unix timestamp</summary>
/// <remarks>Identifies the time before which the JWT can't be accepted for processing.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Nbf : ClaimType<DgmjrCvt.Integer32>, IClaimType
{
    public static readonly IClaimType Instance = new Nbf();

    private Nbf() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>nbf</value>
    public const string Name = "nbf";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>int, a Unix timestamp</summary>
/// <remarks>Identifies the expiration time on or after which the JWT can't be accepted for processing. In certain circumstances, a resource may reject the token before this time. For example, if a change in authentication is required or a token revocation has been detected.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Exp : ClaimType<DgmjrCvt.Integer32>, IClaimType
{
    public static readonly IClaimType Instance = new Exp();

    private Exp() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>exp</value>
    public const string Name = "exp";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The application ID of the client using the token. The application can act as itself or on behalf of a user. The application ID typically represents an application object, but it can also represent a service principal object in Microsoft Entra ID.	</summary>
/// <remarks>appid may be used in authorization decisions.</remarks>
/// <value>String, a GUID, only present in v1.0 tokens</value>
public record class AppId : ClaimType<DgmjrCvt.Guid>, IClaimType
{
    public static readonly IClaimType Instance = new AppId();

    private AppId() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>exp</value>
    public const string Name = "appid";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>A replacement for appid. The application ID of the client using the token. The application can act as itself or on behalf of a user. The application ID typically represents an application object, but it can also represent a service principal object in Microsoft Entra ID.</summary>
/// <remarks>azp may be used in authorization decisions.</remarks>
/// <value>String, a GUID, only present in v2.0 tokens</value>
public record class Azp : ClaimType<DgmjrCvt.Guid>, IClaimType
{
    public static readonly IClaimType Instance = new Azp();

    private Azp() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>exp</value>
    public const string Name = "azp";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The code hash is included in ID tokens only when the ID token is issued with an OAuth 2.0 authorization code. It can be used to validate the authenticity of an authorization code. To understand how to do this validation, see the OpenID Connect specification. This claim isn't returned on ID tokens from the /token endpoint.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class CHash : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new CHash();

    private CHash() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>c_hash</value>
    public const string Name = "c_hash";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The access token hash is included in ID tokens only when the ID token is issued from the /authorize endpoint with an OAuth 2.0 access token. It can be used to validate the authenticity of an access token. To understand how to do this validation, see the OpenID Connect specification. This claim isn't returned on ID tokens from the /token endpoint.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class AtHash : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new AtHash();

    private AtHash() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>at_hash</value>
    public const string Name = "at_hash";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Opaque String</summary>
/// <remarks>An internal claim that's used to record data for token reuse. Should be ignored.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Aio : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new Aio();

    private Aio() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>aio</value>
    public const string Name = "aio";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The primary username that represents the user. It could be an email address, phone number, or a generic username without a specified format. Its value is mutable and might change over time. Since it's mutable, this value can't be used to make authorization decisions. It can be used for username hints and in human-readable UI as a username. The profile scope is required to receive this claim. Present only in v2.0 tokens.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class PreferredUsername : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new PreferredUsername();

    private PreferredUsername() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>preferred_username</value>
    public const string Name = "preferred_username";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Present by default for guest accounts that have an email address. Your app can request the email claim for managed users (from the same tenant as the resource) using the email optional claim. This value isn't guaranteed to be correct and is mutable over time. Never use it for authorization or to save data for a user. If you require an addressable email address in your app, request this data from the user directly by using this claim as a suggestion or prefill in your UX. On the v2.0 endpoint, your app can also request the email OpenID Connect scope - you don't need to request both the optional claim and the scope to get the claim.</summary>
/// <remarks>This value is included by default if the user is a guest in the tenant. For managed users (the users inside the tenant), it must be requested through this optional claim or, on v2.0 only, with the OpenID scope. This value isn't guaranteed to be correct, and is mutable over time - never use it for authorization or to save data for a user. For more information, see Validate the user has permission to access this data. If you're using the email claim for authorization, we recommend performing a migration to move to a more secure claim. If you require an addressable email address in your app, request this data from the user directly, using this claim as a suggestion or prefill in your UX.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Email : ClaimType<DgmjrCvt.Email>, IClaimType
{
    public static readonly IClaimType Instance = new Email();

    private Email() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>email</value>
    public const string Name = "email";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The name claim provides a human-readable value that identifies the subject of the token. The value isn't guaranteed to be unique, it can be changed, and should be used only for display purposes. The profile scope is required to receive this claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class _Name : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new _Name();

    private _Name() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>name</value>
    public const string Name = "name";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The name claim provides a human-readable value that identifies the subject of the token. The value isn't guaranteed to be unique, it can be changed, and should be used only for display purposes. The profile scope is required to receive this claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class GivenName : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new GivenName();

    private GivenName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>givenname</value>
    public const string Name = "givenname";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The name claim provides a human-readable value that identifies the subject of the token. The value isn't guaranteed to be unique, it can be changed, and should be used only for display purposes. The profile scope is required to receive this claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class FamilyName : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new FamilyName();

    private FamilyName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>familyname</value>
    public const string Name = "familyname";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The name claim provides a human-readable value that identifies the subject of the token. The value isn't guaranteed to be unique, it can be changed, and should be used only for display purposes. The profile scope is required to receive this claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class NameId : ClaimType<DgmjrCvt.Integer64>, IClaimType
{
    public static readonly IClaimType Instance = new NameId();

    private NameId() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>nameid</value>
    public const string Name = "nameid";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The name claim provides a human-readable value that identifies the subject of the token. The value isn't guaranteed to be unique, it can be changed, and should be used only for display purposes. The profile scope is required to receive this claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Website : ClaimType<DgmjrCvt.AnyUri>, IClaimType
{
    public static readonly IClaimType Instance = new Website();

    private Website() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>website</value>
    public const string Name = "website";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The name claim provides a human-readable value that identifies the subject of the token. The value isn't guaranteed to be unique, it can be changed, and should be used only for display purposes. The profile scope is required to receive this claim.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Birthdate : ClaimType<DgmjrCvt.Date>, IClaimType
{
    public static readonly IClaimType Instance = new Birthdate();

    private Birthdate() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value>
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value>
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>birthdate</value>
    public const string Name = "birthdate";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The nonce matches the parameter included in the original authorize request to the IDP. If it doesn't match, your application should reject the token.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Nonce : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new Nonce();

    private Nonce() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>nonce</value>
    public const string Name = "nonce";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String, a GUID</summary>
/// <remarks>The immutable identifier for the requestor, which is the verified identity of the user or service principal. This ID uniquely identifies the requestor across applications. Two different applications signing in the same user receive the same value in the oid claim. The oid can be used when making queries to Microsoft online services, such as the Microsoft Graph. The Microsoft Graph returns this ID as the id property for a given user account. Because the oid allows multiple applications to correlate principals, to receive this claim for users use the profile scope. If a single user exists in multiple tenants, the user contains a different object ID in each tenant. Even though the user logs into each account with the same credentials, the accounts are different.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Oid : ClaimType<DgmjrCvt.Guid>, IClaimType
{
    public static readonly IClaimType Instance = new Oid();

    private Oid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>oid</value>
    public const string Name = "oid";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Array of strings</summary>
/// <remarks>The set of roles that were assigned to the user who is logging in.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Roles : ClaimType<DgmjrCvt.Array<DgmjrCvt.AnyUri>>, IClaimType
{
    public static readonly IClaimType Instance = new Roles();

    private Roles() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>roles</value>
    public const string Name = "roles";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>The subject of the information in the token. For example, the user of an app. This value is immutable and can't be reassigned or reused. The subject is a pairwise identifier and is unique to an application ID. If a single user signs into two different apps using two different client IDs, those apps receive two different values for the subject claim. You may or may not want two values depending on your architecture and privacy requirements.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Sub : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new Sub();

    private Sub() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>sub</value>
    public const string Name = "sub";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Represents the tenant that the user is signing in to. For work and school accounts, the GUID is the immutable tenant ID of the organization that the user is signing in to. For sign-ins to the personal Microsoft account tenant (services like Xbox, Teams for Life, or Outlook), the value is 9188040d-6c67-4c5b-b112-36a304b66dad. To receive this claim, the application must request the profile scope.</summary>
/// <remarks>This value should be considered in combination with other claims in authorization decisions.</remarks>
/// <value>	String, a GUID</value>
public record class Tid : ClaimType<DgmjrCvt.Guid>, IClaimType
{
    public static readonly IClaimType Instance = new Tid();

    private Tid() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>tid</value>
    public const string Name = "tid";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>Only present in v1.0 tokens. Provides a human readable value that identifies the subject of the token. This value isn't guaranteed to be unique within a tenant and should be used only for display purposes.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class UniqueName : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new UniqueName();

    private UniqueName() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>unique_name</value>
    public const string Name = "unique_name";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String</summary>
/// <remarks>Token identifier claim, equivalent to jti in the JWT specification. Unique, per-token identifier that is case-sensitive.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Uti : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new Uti();

    private Uti() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>uti</value>
    public const string Name = "uti";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>String, either 1.0 or 2.0</summary>
/// <remarks>Indicates the version of the ID token.</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class Ver : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new Ver();

    private Ver() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>ver</value>
    public const string Name = "ver";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Boolean</summary>
/// <remarks>If present, always true, denoting the user is in at least one group. Used in place of the groups claim for JWTs in implicit grant flows when the full groups claim extends the URI fragment beyond the URL length limits (currently six or more groups). Indicates that the client should use the Microsoft Graph API to determine the user's groups (https://graph.microsoft.com/v1.0/users/{userID}/getMemberObjects).</remarks>
/// <value><inheritdoc cref="UriString"/></value>
public record class HasGroups : ClaimType<DgmjrCvt.Boolean>, IClaimType
{
    public static readonly IClaimType Instance = new HasGroups();

    private HasGroups() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>hasgroups</value>
    public const string Name = "hasgroups";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>JSON object</summary>
/// <remarks>For token requests that aren't limited in length (see <seealso cref="HasGroups" />) but still too large for the token, a link to the full groups list for the user is included. For JWTs as a distributed claim, for SAML as a new claim in place of the groups claim.</remarks>
/** <example><code>"groups":"src1"
"_claim_sources: "src1" : { "endpoint" : "https://graph.microsoft.com/v1.0/users/{userID}/getMemberObjects" }</code></example> */
/// <value><inheritdoc cref="UriString"/></value>
public record class GroupsSrc1 : ClaimType<DgmjrCvt.Json>, IClaimType
{
    public static readonly IClaimType Instance = new GroupsSrc1();

    private GroupsSrc1() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>groups:src1</value>
    public const string Name = "groups:src1";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>A value of 0 for the "Authentication context class" claim indicates the end-user authentication didn't meet the requirements of ISO/IEC 29115.	</summary>
public record class Acr : ClaimType<DgmjrCvt.Integer32>, IClaimType
{
    public static readonly IClaimType Instance = new Acr();

    private Acr() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>acr</value>
    public const string Name = "acr";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Identifies the authentication method of the subject of the token.</summary>
public record class Amr : ClaimType<DgmjrCvt.Array<DgmjrCvt.String>>, IClaimType
{
    public static readonly IClaimType Instance = new Amr();

    private Amr() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>amr</value>
    public const string Name = "amr";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>A replacement for appidacr. Indicates the authentication method of the client. For a public client, the value is 0. When you use the client ID and client secret, the value is 1. When you use a client certificate for authentication, the value is 2.	</summary>
public record class AzpAcr : ClaimType<DgmjrCvt.Integer32>, IClaimType
{
    public const int PublicClient = 0;
    public const int ClientIdAndSecret = 1;
    public const int ClientCertificate = 2;

    public static readonly IClaimType Instance = new AzpAcr();

    private AzpAcr() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>azpacr</value>
    public const string Name = "azpacr";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Indicates authentication method of the client. For a public client, the value is 0. When you use the client ID and client secret, the value is 1. When you use a client certificate for authentication, the value is 2.</summary>
public record class AppIdAcr : ClaimType<DgmjrCvt.Integer32>, IClaimType
{
    public const int PublicClient = 0;
    public const int ClientIdAndSecret = 1;
    public const int ClientCertificate = 2;

    public static readonly IClaimType Instance = new AppIdAcr();

    private AppIdAcr() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>appidacr</value>
    public const string Name = "appidacr";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Denotes the tenant-wide roles assigned to this user, from the section of roles present in Microsoft Entra built-in roles. The groupMembershipClaims property of the application manifest configures this claim on a per-application basis. Set the claim to All or DirectoryRole. May not be present in tokens obtained through the implicit flow due to token length concerns.</summary>
/// <value>Array of RoleTemplateID GUIDs</value>
public record class Wids : ClaimType<DgmjrCvt.Array<DgmjrCvt.Guid>>, IClaimType
{
    public static readonly IClaimType Instance = new Wids();

    private Wids() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>wids</value>
    public const string Name = "wids";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>The set of scopes exposed by the application for which the client application has requested (and received) consent. Only included for user tokens.	</summary>
/// <value>String, a space separated list of scopes	</value>
public record class Scp : ClaimType<DgmjrCvt.String>, IClaimType
{
    public static readonly IClaimType Instance = new Scp();

    private Scp() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + Slash + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>scp</value>
    public const string Name = "scp";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}

/// <summary>Provides object IDs that represent the group memberships of the subject. The groupMembershipClaims property of the application manifest configures the groups claim on a per-application basis. A value of null excludes all groups, a value of SecurityGroup includes only Active Directory Security Group memberships, and a value of All includes both Security Groups and Microsoft 365 Distribution Lists.
/// See the <seealso cref="HasGroups" /> claim for details on using the groups claim with the implicit grant. For other flows, if the number of groups the user is in goes over 150 for SAML and 200 for JWT, then Microsoft Entra ID adds an overage claim to the claim sources. The claim sources point to the Microsoft Graph endpoint that contains the list of groups for the user.		</summary>
/// <value>JSON array of GUIDs		</value>
/// <remarks>These values can be used for managing access, such as enforcing authorization to access a resource.  If the number of groups the user is in goes over a limit (150 for SAML, 200 for JWT) then an overage claim will be added the claim sources pointing at the Graph endpoint containing the list of groups for the user.</remarks>
public record class Groups : ClaimType<DgmjrCvt.Array<DgmjrCvt.Guid>>, IClaimType
{
    public static readonly IClaimType Instance = new Groups();

    private Groups() { }

    /// <value><inheritdoc cref="ClaimType.Namespace2008" path="/value" />/<inheritdoc cref="Name" path="/value" /></value
    public new const string UriString = Namespace2008 + "/" + Name;

    /// <value><inheritdoc cref="ClaimType.ShortSamlNamespace" path="/value" />:<inheritdoc cref="Name" path="/value" /></value
    public const string ShortUriString = ShortSamlNamespace + ":" + Name;

    /// <value>groups</value>
    public const string Name = "groups";

    /// <value><inheritdoc cref="Name" path="/value" /></value>
    string IHaveAName.Name => Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
}
