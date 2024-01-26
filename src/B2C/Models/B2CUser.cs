using System.Net.Mail;
using System.Security.Claims;
using System.Security.Principal;

using Dgmjr.Abstractions;

using Microsoft.IdentityModel.Tokens.Saml;

namespace Dgmjr.Identity.B2C.Models;

public class B2CUser(ClaimsPrincipal principal)
    : ClaimsPrincipal(principal.Identities),
        IIdentifiable<long>
{
    public new ClaimsIdentity Identity => (ClaimsIdentity)base.Identity;

    protected virtual Claim ReplaceClaim(
        Claim claim,
        string newClaimValue,
        uri? type = null,
        uri? valueType = null,
        uri? issuer = null
    )
    {
        if (claim != null)
        {
            Identity.RemoveClaim(claim);
        }
        var newClaim = new Claim(
            type ?? claim?.Type,
            newClaimValue,
            valueType ?? claim?.ValueType,
            issuer ?? claim?.Issuer ?? Issuer
        );
        Identity.AddClaim(newClaim);
        return newClaim;
    }

    protected Claim? DisplayNameClaim => this.FindClaim(DgmjrCt.DisplayName.UriString);
    protected Claim? EmailVerifiedClaim => this.FindClaim(JwtCt.EmailVerified.UriString);
    protected Claim? ExpirationClaim => this.FindClaim(JwtCt.Exp.UriString);
    protected Claim GivenNameClaim => this.FindClaim(DgmjrCt.GivenName.UriString);
    protected Claim SurnameClaim => this.FindClaim(DgmjrCt.Surname.UriString);
    protected Claim EmailClaim => this.FindClaim(DgmjrCt.Email.UriString);
    protected Claim IdClaim => this.FindClaim(DgmjrCt.NameIdentifier.UriString);
    protected Claim TenantIdClaim => this.FindClaim(SamlCt.TenantId.UriString);

    public string? Acr => this.FindFirstValue("acr");
    public string? Aio => this.FindFirstValue("aio");
    public DgmjrCvt.Array<DgmjrCvt.Enum<DgmjrCvt.Enums.authnmethodsreferences>>? AuthenticationMethods =>
        this.FindFirstValue<DgmjrCvt.Array<DgmjrCvt.Enum<DgmjrCvt.Enums.authnmethodsreferences>>>(
            SamlCt.AuthenticationMethod.UriString
        );
    public string? Audience
    {
        get => this.FindFirstValue(JwtCt.Aud.UriString);
        set => ReplaceClaim(this.FindClaim(JwtCt.Aud.UriString), value);
    }
    public string? AppId => this.FindFirstValue("appid");
    public string? Appidacr => this.FindFirstValue("appidacr");
    public string? Amr => this.FindFirstValue("amr");
    public string? Azp => this.FindFirstValue("azp");
    public DateTimeOffset Expiration
    {
        get => this.FindFirstValue<DgmjrCvt.UnixTimestamp>(JwtCt.Exp.UriString);
        set => ReplaceClaim(ExpirationClaim, value.ToUnixTimeSeconds().ToString());
    }
    public EmailAddress Email
    {
        get => EmailAddress.From(EmailClaim.Value);
        set => ReplaceClaim(EmailClaim, value);
    }
    public string FirstName
    {
        get => GivenNameClaim.Value;
        set => ReplaceClaim(GivenNameClaim, value);
    }
    public long Id
    {
        get => long.Parse(IdClaim.Value);
        set => ReplaceClaim(IdClaim, value.ToString());
    }
    public DateTimeOffset IssuedAt
    {
        get => this.FindFirstValue<DgmjrCvt.UnixTimestamp>(JwtCt.Iat.UriString);
        set =>
            ReplaceClaim(this.FindClaim(JwtCt.Iat.UriString), value.ToUnixTimeSeconds().ToString());
    }
    public uri? Issuer
    {
        get => this.FindFirstValue(JwtCt.Iss.UriString);
        set => ReplaceClaim(this.FindClaim(JwtCt.Iss.UriString), value);
    }
    public string? IdentityProvider
    {
        get => this.FindFirstValue(SamlCt.IdentityProvider.UriString);
        set => ReplaceClaim(this.FindClaim(SamlCt.IdentityProvider.UriString), value);
    }
    public bool IsEmailVerified
    {
        get => bool.Parse(EmailVerifiedClaim.Value);
        set => ReplaceClaim(EmailVerifiedClaim, value.ToString());
    }
    public DgmjrCvt.Array<DgmjrCvt.String>? Roles =>
        this.FindFirstValue<DgmjrCvt.Array<DgmjrCvt.String>>(DgmjrCt.Role.UriString);
    public string? Scope => this.FindFirstValue(SamlCt.Scope.UriString);
    public string? Subject
    {
        get => this.FindFirstValue(JwtCt.Sub.UriString);
        set => ReplaceClaim(this.FindClaim(JwtCt.Sub.UriString), value);
    }
}
