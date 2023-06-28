namespace Dgmjr.Identity.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;

public static class JwtClaimMap
{
    private static readonly IDictionary<string, string> JwtClaimTypeToLongTypeMappping = new Dictionary<string, string>
    {
        { JwtRegisteredClaimNames.Actort, ClaimTypes.Actor },
        { JwtRegisteredClaimNames.Birthdate, ClaimTypes.DateOfBirth },
        { JwtRegisteredClaimNames.Email, ClaimTypes.Email },
        { JwtRegisteredClaimNames.FamilyName, ClaimTypes.Surname },
        { JwtRegisteredClaimNames.Gender, ClaimTypes.Gender },
        { JwtRegisteredClaimNames.GivenName, ClaimTypes.GivenName },
        { JwtRegisteredClaimNames.NameId, ClaimTypes.NameIdentifier },
        { JwtRegisteredClaimNames.Sub, ClaimTypes.NameIdentifier },
        { JwtRegisteredClaimNames.Website, ClaimTypes.Webpage },
        { JwtRegisteredClaimNames.UniqueName, ClaimTypes.Name },
        { "oid", "http://schemas.microsoft.com/identity/claims/objectidentifier" },
        { "scp", "http://schemas.microsoft.com/identity/claims/scope" },
        { "tid", "http://schemas.microsoft.com/identity/claims/tenantid" },
        { "acr", "http://schemas.microsoft.com/claims/authnclassreference" },
        { "adfs1email", "http://schemas.xmlsoap.org/claims/EmailAddress" },
        { "adfs1upn", "http://schemas.xmlsoap.org/claims/UPN" },
        { "amr", "http://schemas.microsoft.com/claims/authnmethodsreferences" },
        { "authmethod", ClaimTypes.AuthenticationMethod },
        { "certapppolicy", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/applicationpolicy" },
        { "certauthoritykeyidentifier", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/authoritykeyidentifier" },
        { "certbasicconstraints", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/basicconstraints" },
        { "certeku", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/eku" },
        { "certissuer", "http://schemas.microsoft.com/2012/12/certificatecontext/field/issuer" },
        { "certissuername", "http://schemas.microsoft.com/2012/12/certificatecontext/field/issuername" },
        { "certkeyusage", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/keyusage" },
        { "certnotafter", "http://schemas.microsoft.com/2012/12/certificatecontext/field/notafter" },
        { "certnotbefore", "http://schemas.microsoft.com/2012/12/certificatecontext/field/notbefore" },
        { "certpolicy", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/certificatepolicy" },
        { "certpublickey", ClaimTypes.Rsa },
        { "certrawdata", "http://schemas.microsoft.com/2012/12/certificatecontext/field/rawdata" },
        { "certserialnumber", ClaimTypes.SerialNumber },
        { "certsignaturealgorithm", "http://schemas.microsoft.com/2012/12/certificatecontext/field/signaturealgorithm" },
        { "certsubject", "http://schemas.microsoft.com/2012/12/certificatecontext/field/subject" },
        { "certsubjectaltname", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/san" },
        { "certsubjectkeyidentifier", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/subjectkeyidentifier" },
        { "certsubjectname", "http://schemas.microsoft.com/2012/12/certificatecontext/field/subjectname" },
        { "certtemplateinformation", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/certificatetemplateinformation" },
        { "certtemplatename", "http://schemas.microsoft.com/2012/12/certificatecontext/extension/certificatetemplatename" },
        { "certthumbprint", ClaimTypes.Thumbprint },
        { "certx509version", "http://schemas.microsoft.com/2012/12/certificatecontext/field/x509version" },
        { "clientapplication", "http://schemas.microsoft.com/2012/01/requestcontext/claims/x-ms-client-application" },
        { "clientip", "http://schemas.microsoft.com/2012/01/requestcontext/claims/x-ms-client-ip" },
        { "clientuseragent", "http://schemas.microsoft.com/2012/01/requestcontext/claims/x-ms-client-user-agent" },
        { "commonname", "http://schemas.xmlsoap.org/claims/CommonName" },
        { "denyonlyprimarygroupsid", ClaimTypes.DenyOnlyPrimaryGroupSid },
        { "denyonlyprimarysid", ClaimTypes.DenyOnlyPrimarySid },
        { "denyonlysid", ClaimTypes.DenyOnlySid },
        { "devicedispname", "http://schemas.microsoft.com/2012/01/devicecontext/claims/displayname" },
        { "deviceid", "http://schemas.microsoft.com/2012/01/devicecontext/claims/identifier" },
        { "deviceismanaged", "http://schemas.microsoft.com/2012/01/devicecontext/claims/ismanaged" },
        { "deviceostype", "http://schemas.microsoft.com/2012/01/devicecontext/claims/ostype" },
        { "deviceosver", "http://schemas.microsoft.com/2012/01/devicecontext/claims/osversion" },
        { "deviceowner", "http://schemas.microsoft.com/2012/01/devicecontext/claims/userowner" },
        { "deviceregid", "http://schemas.microsoft.com/2012/01/devicecontext/claims/registrationid" },
        { "endpointpath", "http://schemas.microsoft.com/2012/01/requestcontext/claims/x-ms-endpoint-absolute-path" },
        { "forwardedclientip", "http://schemas.microsoft.com/2012/01/requestcontext/claims/x-ms-forwarded-client-ip" },
        { "group", "http://schemas.xmlsoap.org/claims/Group" },
        { "groupsid", ClaimTypes.GroupSid },
        { "idp", "http://schemas.microsoft.com/identity/claims/identityprovider" },
        { "insidecorporatenetwork", "http://schemas.microsoft.com/ws/2012/01/insidecorporatenetwork" },
        { "isregistereduser", "http://schemas.microsoft.com/2012/01/devicecontext/claims/isregistereduser" },
        { "ppid", "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/privatepersonalidentifier" },
        { "primarygroupsid", ClaimTypes.PrimaryGroupSid },
        { "primarysid", ClaimTypes.PrimarySid },
        { "proxy", "http://schemas.microsoft.com/2012/01/requestcontext/claims/x-ms-proxy" },
        { "pwdchgurl", "http://schemas.microsoft.com/ws/2012/01/passwordchangeurl" },
        { "pwdexpdays", "http://schemas.microsoft.com/ws/2012/01/passwordexpirationdays" },
        { "pwdexptime", "http://schemas.microsoft.com/ws/2012/01/passwordexpirationtime" },
        { "relyingpartytrustid", "http://schemas.microsoft.com/2012/01/requestcontext/claims/relyingpartytrustid" },
        { "role", ClaimTypes.Role },
        { "roles", ClaimTypes.Role },
        { "upn", ClaimTypes.Upn },
        { "winaccountname", ClaimTypes.WindowsAccountName }
    };

    public static readonly IDictionary<string, string> LongClaimTypeToShortJwtMapping =
        JwtClaimTypeToLongTypeMappping.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

    public static string? ToShortClaimType(this string? jwtClaimType)
        => LongClaimTypeToShortJwtMapping.TryGetValue(jwtClaimType, out var shortClaimType) ? shortClaimType : jwtClaimType;

    public static string? ToLongClaimType(this string? jwtClaimType)
        => JwtClaimTypeToLongTypeMappping.TryGetValue(jwtClaimType, out var longClaimType) ? longClaimType : jwtClaimType;

}
