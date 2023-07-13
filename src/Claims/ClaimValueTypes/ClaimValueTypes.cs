namespace Dgmjr.Identity.Claims.ClaimValueTypes;

using Cvt = Dgmjr.Identity.Claims.ClaimValueTypes;

public static class ClaimValueTypes
{
    public static readonly Cvt.Rsa Rsa = Cvt.Rsa.Instance;
    public static readonly Cvt.DsaKeyValue Dsa = Cvt.DsaKeyValue.Instance;
    public static readonly Cvt.X509Certificate X509Certificate = Cvt.X509Certificate.Instance;
    public static readonly Cvt.EmailAddresss EmailAddress = Cvt.EmailAddresss.Instance;
    public static readonly Cvt.DnsName DnsName = Cvt.DnsName.Instance;
    public static readonly Cvt.IpAddress IpAddress = Cvt.IpAddress.Instance;
    public static readonly Cvt.Rfc822Name Rfc822Name = Cvt.Rfc822Name.Instance;
    public static readonly Cvt.AnyUri AnyUri = Cvt.AnyUri.Instance;
    public static readonly Cvt.HexBinary HexBinary = Cvt.HexBinary.Instance;
    public static readonly Cvt.Base64Binary Base64Binary = Cvt.Base64Binary.Instance;
    public static readonly Cvt.Base64Octet Base64Octet = Cvt.Base64Octet.Instance;
    public static readonly Cvt.String String = Cvt.String.Instance;
    public static readonly Cvt.Boolean Boolean = Cvt.Boolean.Instance;
    public static readonly Cvt.Integer Integer = Cvt.Integer.Instance;
    public static readonly Cvt.Long Long = Cvt.Long.Instance;
    public static readonly Cvt.Double Double = Cvt.Double.Instance;
    public static readonly Cvt.Decimal Decimal = Cvt.Decimal.Instance;
    public static readonly Cvt.DateTime DateTime = Cvt.DateTime.Instance;
    public static readonly Cvt.Duration Duration = Cvt.Duration.Instance;
    public static readonly Cvt.Time Time = Cvt.Time.Instance;
    public static readonly Cvt.Date Date = Cvt.Date.Instance;
    public static readonly Cvt.Language Language = Cvt.Language.Instance;
}
