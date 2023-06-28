namespace Dgmjr.Claims.ClaimValueTypes;
using Dgmjr.Identity.ClaimValueTypes.Abstractions;
using Cvt = Dgmjr.Identity.ClaimValueTypes;

public static class ClaimValueTypes
{
    public static readonly IClaimValueType Rsa = Cvt.Rsa.Instance;
    public static readonly IClaimValueType Dsa = Cvt.Dsa.Instance;
    public static readonly IClaimValueType X509Certificate = Cvt.X509Certificate.Instance;
    public static readonly IClaimValueType EmailAddress = Cvt.EmailAddress.Instance;
    public static readonly IClaimValueType DnsName = Cvt.DnsName.Instance;
    public static readonly IClaimValueType IpAddress = Cvt.IpAddress.Instance;
    public static readonly IClaimValueType Rfc822Name = Cvt.Rfc822Name.Instance;
    public static readonly IClaimValueType AnyUri = Cvt.AnyUri.Instance;
    public static readonly IClaimValueType HexBinary = Cvt.HexBinary.Instance;
    public static readonly IClaimValueType Base64Binary = Cvt.Base64Binary.Instance;
    public static readonly IClaimValueType Base64Octet = Cvt.Base64Octet.Instance;
    public static readonly IClaimValueType String = Cvt.String.Instance;
    public static readonly IClaimValueType Boolean = Cvt.Boolean.Instance;
    public static readonly IClaimValueType Integer = Cvt.Integer.Instance;
    public static readonly IClaimValueType Long = Cvt.Long.Instance;
    public static readonly IClaimValueType Double = Cvt.Double.Instance;
    public static readonly IClaimValueType Decimal = Cvt.Decimal.Instance;
    public static readonly IClaimValueType DateTime = Cvt.DateTime.Instance;
    public static readonly IClaimValueType DateTimeOffset = Cvt.DateTimeOffset.Instance;
    public static readonly IClaimValueType Duration = Cvt.Duration.Instance;
    public static readonly IClaimValueType Time = Cvt.Time.Instance;
    public static readonly IClaimValueType Date = Cvt.Date.Instance;
    public static readonly IClaimValueType Language = Cvt.Language.Instance;
}
