namespace Dgmjr.Identity.ClaimValueTypes;

using System.Globalization;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using Dgmjr.Primitives;

using SSCXmlKeyInfo = System.Security.Cryptography.Xml.KeyInfo;

// the schema needs to be checked for all these types to ensure they allowed

public record class Base64Binary : ClaimValueType<byte[]>, IClaimValueType
{
    public static IClaimValueType Instance => new Base64Binary();

    private Base64Binary() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#base64Binary</value>
    public const string UriString = XmlSchemaNamespace + "#base64Binary";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:base64Binary</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":base64Binary";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Base64Binary value) => value.Value.ToBase64String();

    public static implicit operator Base64Binary(string value) => (Instance as Base64Binary) with { Value = value.FromBase64String() };
}
public record class Base64Octet : ClaimValueType<byte[]>, IClaimValueType
{
    public static IClaimValueType Instance => new Base64Octet();

    private Base64Octet() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#base64Octet</value>
    public const string UriString = XmlSchemaNamespace + "#base64Octet";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value" />:base64Octet</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":#base64Octet";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Base64Octet value) => value.Value.ToHexString();
    public static implicit operator Base64Octet(string value) => (Instance as Base64Octet) with { Value = value.FromHexString() };
    public static implicit operator byte[](Base64Octet value) => value.Value;
    public static implicit operator Base64Octet(byte[] value) => (Instance as Base64Octet) with { Value = value };
}
public record class Boolean : ClaimValueType<bool>, IClaimValueType
{
    public static IClaimValueType Instance => new Boolean();

    private Boolean() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#boolean</value>
    public const string UriString = XmlSchemaNamespace + "#boolean";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:boolean</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":boolean";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator bool(Boolean value) => value.Value;
    public static implicit operator Boolean(bool value) => (Instance as Boolean) with { Value = value };
    public static implicit operator string(Boolean value) => value.Value.ToString().ToLower();
    public static implicit operator Boolean(string value) => (Instance as Boolean) with { Value = value.Equals(bool.TrueString, InvariantCultureIgnoreCase) };
}
public record class Date : ClaimValueType<DateOnly>, IClaimValueType
{
    public static IClaimValueType Instance => new Date();

    private Date() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#date</value>
    public const string UriString = XmlSchemaNamespace + "#date";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:date</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":date";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator DateOnly(Date value) => value.Value;
    public static implicit operator Date(DateOnly value) => (Instance as Date) with { Value = value };
    public static implicit operator string(Date value) => value.Value.ToShortDateString();
    public static implicit operator Date(string value) => (Instance as Date) with { Value = DateOnly.Parse(value, CultureInfo.InvariantCulture) };
}
public record class DateTime : ClaimValueType<System.DateTime>, IClaimValueType
{
    public static IClaimValueType Instance => new DateTime();

    private DateTime() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#dateTime</value>
    public const string UriString = XmlSchemaNamespace + "#dateTime";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:dateTime</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":dateTime";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator System.DateTime(DateTime value) => value.Value;
    public static implicit operator DateTime(System.DateTime value) => (Instance as DateTime) with { Value = value };
    public static implicit operator string(DateTime value) => value.Value.ToLongDateString();
    public static implicit operator DateTime(string value) => (Instance as DateTime) with { Value = datetime.Parse(value, CultureInfo.InvariantCulture) };
    public static implicit operator long(DateTime value) => value.Value.Ticks;
    public static implicit operator DateTime(long value) => (Instance as DateTime) with { Value = new datetime(value) };
}
public record class Double : ClaimValueType<double>, IClaimValueType
{
    public static IClaimValueType Instance => new Double();

    private Double() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#double</value>
    public const string UriString = XmlSchemaNamespace + "#double";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:double</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":double";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator double(Double value) => value.Value;
    public static implicit operator Double(double value) => (Instance as Double) with { Value = value };
}
public record class Fqbn : ClaimValueType<string>, IClaimValueType
{
    public static IClaimValueType Instance => new Fqbn();

    private Fqbn() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#fqbn</value>
    public const string UriString = XmlSchemaNamespace + "#fqbn";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value" />:fqbn</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":fqbn";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Fqbn value) => value.Value;
    public static implicit operator Fqbn(string value) => (Instance as Fqbn) with { Value = value };
}
public record class HexBinary : ClaimValueType<byte[]>, IClaimValueType
{
    public static IClaimValueType Instance => new HexBinary();

    private HexBinary() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#hexBinary</value>
    public const string UriString = XmlSchemaNamespace + "#hexBinary";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:hexBinary</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":hexBinary";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator byte[](HexBinary value) => value.Value;
    public static implicit operator HexBinary(byte[] value) => (Instance as HexBinary) with { Value = value };
    public static implicit operator string(HexBinary value) => value.Value.ToHexString();
    public static implicit operator HexBinary(string value) => (Instance as HexBinary) with { Value = value.FromHexString() };
}
public record class Integer : ClaimValueType<int>, IClaimValueType
{
    public static IClaimValueType Instance => new Integer();

    private Integer() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#integer</value>
    public const string UriString = XmlSchemaNamespace + "#integer";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:integer</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":integer";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator int(Integer value) => value.Value;
    public static implicit operator Integer(int value) => (Instance as Integer) with { Value = value };
    public static implicit operator string(Integer value) => value.Value.ToString();
    public static implicit operator Integer(string value) => (Instance as Integer) with { Value = int.Parse(value) };
}
public record class Integer32 : ClaimValueType<int>, IClaimValueType
{
    public static IClaimValueType Instance => new Integer32();

    private Integer32() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#integer32</value>
    public const string UriString = XmlSchemaNamespace + "#integer32";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:integer32</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":integer32";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator int(Integer32 value) => value.Value;
    public static implicit operator Integer32(int value) => (Instance as Integer32) with { Value = value };
    public static implicit operator string(Integer32 value) => value.Value.ToString();
    public static implicit operator Integer32(string value) => (Instance as Integer32) with { Value = int.Parse(value) };
}
public record class Integer64 : ClaimValueType<long>, IClaimValueType
{
    public static IClaimValueType Instance => new Integer64();

    private Integer64() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#integer64</value>
    public const string UriString = XmlSchemaNamespace + "#integer64";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:integer64</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":integer64";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator long(Integer64 value) => value.Value;
    public static implicit operator Integer64(long value) => (Instance as Integer64) with { Value = value };
    public static implicit operator string(Integer64 value) => value.Value.ToString();
    public static implicit operator Integer64(string value) => (Instance as Integer64) with { Value = long.Parse(value) };
}
public record class Sid : ClaimValueType<System.Security.Principal.SecurityIdentifier>, IClaimValueType
{
    public static IClaimValueType Instance => new Sid();

    private Sid() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#sid</value>
    public const string UriString = XmlSchemaNamespace + "#sid";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:sid</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":sid";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator byte[](Sid value)
    {
        var buff = new byte[value.Value.BinaryLength];
        value.Value.GetBinaryForm(buff, 0);
        return buff;
    }
    public static implicit operator Sid(byte[] value) => (Instance as Sid) with { Value = new(value, 0) };
    public static implicit operator string(Sid value) => value.Value.ToString();
    public static implicit operator Sid(string value) => (Instance as Sid) with { Value = new System.Security.Principal.SecurityIdentifier(value) };
}
public record class String : ClaimValueType<string>, IClaimValueType
{
    public static IClaimValueType Instance => new String();

    private String() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#string</value>
    public const string UriString = XmlSchemaNamespace + "#string";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:string</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":string";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator string(String value) => value.Value;
    public static implicit operator String(string value) => (Instance as String) with { Value = value };

}
public record class Time : ClaimValueType<TimeOnly>, IClaimValueType
{
    public static IClaimValueType Instance => new Time();

    private Time() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#time</value>
    public const string UriString = XmlSchemaNamespace + "#time";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:time</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":time";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator TimeOnly(Time value) => value.Value;
    public static implicit operator Time(TimeOnly value) => (Instance as Time) with { Value = value };
    public static implicit operator string(Time value) => value.Value.ToLongTimeString();
    public static implicit operator Time(string value) => (Instance as Time) with { Value = TimeOnly.Parse(value, CultureInfo.InvariantCulture) };
    public static implicit operator long(Time value) => value.Value.Ticks;
    public static implicit operator Time(long value) => (Instance as Time) with { Value = new TimeOnly(value) };
}
public record class UInteger32 : ClaimValueType<uint>, IClaimValueType
{
    public static IClaimValueType Instance => new UInteger32();

    private UInteger32() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#uinteger32</value>
    public const string UriString = XmlSchemaNamespace + "#uinteger32";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:uinteger32</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":uinteger32";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator uint(UInteger32 value) => value.Value;

    public static implicit operator UInteger32(uint value) => (Instance as UInteger32) with { Value = value };

    public static implicit operator string(UInteger32 value) => value.Value.ToString();

    public static implicit operator UInteger32(string value) => (Instance as UInteger32) with { Value = uint.Parse(value) };
}
public record class UInteger64 : ClaimValueType<ulong>, IClaimValueType
{
    public static IClaimValueType Instance => new UInteger64();

    private UInteger64() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#uinteger64</value>
    public const string UriString = XmlSchemaNamespace + "#uinteger64";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:uinteger64</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":uinteger64";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator ulong(UInteger64 value) => value.Value;

    public static implicit operator UInteger64(ulong value) => (Instance as UInteger64) with { Value = value };

    public static implicit operator string(UInteger64 value) => value.Value.ToString();

    public static implicit operator UInteger64(string value) => (Instance as UInteger64) with { Value = ulong.Parse(value) };
}

public record class DnsName : ClaimValueType<string>, IClaimValueType
{
    public static IClaimValueType Instance => new DnsName();

    private DnsName() { }

    /// <value><inheritdoc cref="ClaimValueType.SoapSchemaNamespace" path="/value" />claims/dns</value>
    public const string UriString = SoapSchemaNamespace + "claims/dns";
    /// <value><inheritdoc cref="ClaimValueType.ShortSoapSchemaNamespace" path="/value"/>:dns</value>
    public const string ShortUriString = ShortSoapSchemaNamespace + ":dns";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(DnsName value) => value.Value;

    public static implicit operator DnsName(string value) => (Instance as DnsName) with { Value = value };
}
public record class Email : ClaimValueType<EmailAddress>, IClaimValueType
{
    public static IClaimValueType Instance => new Email();

    private Email() { }

    /// <value><inheritdoc cref="ClaimValueType.SoapSchemaNamespace" path="/value" />ws/2005/05/identity/claims/emailaddress</value>
    public const string UriString = SoapSchemaNamespace + "ws/2005/05/identity/claims/emailaddress";
    /// <value><inheritdoc cref="ClaimValueType.ShortSoapSchemaNamespace" path="/value"/>:emailaddress</value>
    public const string ShortUriString = ShortSoapSchemaNamespace + ":emailaddress";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator string?(Email value) => value.Value;

    public static implicit operator Email(string value) => (Instance as Email) with { Value = EmailAddress.From(value) };
}
public record class Rsa : ClaimValueType<RSA>, IClaimValueType
{
    public static IClaimValueType Instance => new Rsa();

    private Rsa() { }

    /// <value><inheritdoc cref="ClaimValueType.SoapSchemaNamespace" path="/value" />ws/2005/05/identity/claims/rsa</value>
    public const string UriString = SoapSchemaNamespace + "ws/2005/05/identity/claims/rsa";
    /// <value><inheritdoc cref="ClaimValueType.ShortSoapSchemaNamespace" path="/value" />:rsa</value>
    public const string ShortUriString = ShortSoapSchemaNamespace + ":rsa";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator Rsa(string value)
    {
        var instance = Instance as Rsa;
        instance.Value = RSA.Create();
        instance.Value.FromXmlString(value);
        return instance;
    }
    public static implicit operator string(Rsa value) => value.Value.ToXmlString(false);
}
public record class UpnName : ClaimValueType<EmailAddress>, IClaimValueType
{
    public static IClaimValueType Instance => new UpnName();

    private UpnName() { }

    /// <value><inheritdoc cref="ClaimValueType.SoapSchemaNamespace" path="/value" />claims/UPN</value>
    public const string UriString = SoapSchemaNamespace + "claims/UPN";
    /// <value><inheritdoc cref="ClaimValueType.ShortSoapSchemaNamespace" path="/value"/>:UPN"</value>
    public const string ShortUriString = ShortSoapSchemaNamespace + ":UPN";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string?(UpnName value) => value.Value;

    public static implicit operator UpnName(string value) => (Instance as UpnName) with { Value = EmailAddress.From(value) };
}

;

public record class DsaKeyValue : ClaimValueType<XE>, IClaimValueType
{
    public static IClaimValueType Instance => new DsaKeyValue();

    private DsaKeyValue() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSignatureConstantsNamespace" path="/value" />DSAKeyValue</value>
    public const string UriString = XmlSignatureConstantsNamespace + "DSAKeyValue";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSignatureConstantsNamespace" path="/value" />:DSAKeyValue</value>
    public const string ShortUriString = ShortXmlSignatureConstantsNamespace + ":DSAKeyValue";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator string(DsaKeyValue value) => value.Value.ToString();

    public static implicit operator DsaKeyValue(string value) => (Instance as DsaKeyValue) with { Value = value.ToXElement() };
    public static implicit operator DSAKeyValue(DsaKeyValue value)
    {
        var xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(value.ToString());
        var rsa = new DSAKeyValue();
        rsa.LoadXml(xmlDoc.DocumentElement);
        return rsa;
    }

    public static implicit operator DsaKeyValue(DSAKeyValue value)
    {
        var instance = Instance as DsaKeyValue;
        using var sw = new StringWriter();
        using var xmlw = new XmlTextWriter(sw);
        value.GetXml().WriteTo(xmlw);
        xmlw.Flush();
        instance.Value = sw.ToString().ToXElement();
        return instance;
    }
}
public record class KeyInfo : ClaimValueType, IClaimValueType
{
    public static IClaimValueType Instance => new KeyInfo();

    private KeyInfo() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSignatureConstantsNamespace" path="/value" />KeyInfo</value>
    public const string UriString = XmlSignatureConstantsNamespace + "KeyInfo";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSignatureConstantsNamespace" path="/value" />:KeyInfo</value>
    public const string ShortUriString = ShortXmlSignatureConstantsNamespace + ":KeyInfo";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator string(KeyInfo value) => value.Value.ToString();

    public static implicit operator KeyInfo(string value) => (Instance as KeyInfo) with { Value = value.ToXElement() };

    public static implicit operator SSCXmlKeyInfo(KeyInfo value)
    {
        var xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(value.ToString());
        var keyInfo = new SSCXmlKeyInfo();
        keyInfo.LoadXml(xmlDoc.DocumentElement);
        return keyInfo;
    }

    public static implicit operator KeyInfo(SSCXmlKeyInfo value)
    {
        var instance = Instance as KeyInfo;
        using var sw = new StringWriter();
        using var xmlw = new XmlTextWriter(sw);
        value.GetXml().WriteTo(xmlw);
        xmlw.Flush();
        instance.Value = sw.ToString().ToXElement();
        return instance;
    }
}
public record class RsaKeyValue : ClaimValueType<XE>, IClaimValueType
{
    public static IClaimValueType Instance => new RsaKeyValue();

    private RsaKeyValue() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSignatureConstantsNamespace" path="/value" />RSAKeyValue</value>
    public const string UriString = XmlSignatureConstantsNamespace + "RSAKeyValue";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSignatureConstantsNamespace" path="/value" />:RSAKeyValue</value>
    public const string ShortUriString = ShortXmlSignatureConstantsNamespace + ":RSAKeyValue";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;


    public static implicit operator string(RsaKeyValue value) => value.Value.ToString();

    public static implicit operator RsaKeyValue(string value) => (Instance as RsaKeyValue) with { Value = value.ToXElement() };
    public static implicit operator RSAKeyValue(RsaKeyValue value)
    {
        var xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(value.ToString());
        var rsa = new RSAKeyValue();
        rsa.LoadXml(xmlDoc.DocumentElement);
        return rsa;
    }

    public static implicit operator RsaKeyValue(RSAKeyValue value)
    {
        var instance = Instance as RsaKeyValue;
        using var sw = new StringWriter();
        using var xmlw = new XmlTextWriter(sw);
        value.GetXml().WriteTo(xmlw);
        xmlw.Flush();
        instance.Value = sw.ToString().ToXElement();
        return instance;
    }
}

public record class DaytimeDuration : ClaimValueType<DayTimeDuration>, IClaimValueType
{
    public static IClaimValueType Instance => new DaytimeDuration();

    private DaytimeDuration() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#dayTimeDuration</value>
    public const string UriString = XmlSchemaNamespace + "#dayTimeDuration";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:dayTimeDuration</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":dayTimeDuration";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;


    public static implicit operator string(DaytimeDuration value) => value.Value;

    public static implicit operator DaytimeDuration(string value) => (Instance as DaytimeDuration) with { Value = DayTimeDuration.Parse(value) };

}
public record class YearMonthDuration : ClaimValueType<Primitives.YearMonthDuration>, IClaimValueType
{
    public static IClaimValueType Instance => new YearMonthDuration();

    private YearMonthDuration() { }

    /// <value><inheritdoc cref="ClaimValueType.XmlSchemaNamespace" path="/value" />#yearMonthDuration</value>
    public const string UriString = XmlSchemaNamespace + "#yearMonthDuration";
    /// <value><inheritdoc cref="ClaimValueType.ShortXmlSchemaNamespace" path="/value"/>:yearMonthDuration</value>
    public const string ShortUriString = ShortXmlSchemaNamespace + ":yearMonthDuration";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(YearMonthDuration value) => value.Value;

    public static implicit operator YearMonthDuration(string value) => (Instance as YearMonthDuration) with { Value = Dgmjr.Primitives.YearMonthDuration.Parse(value) };

}


public record class Rfc822Name : ClaimValueType<EmailAddress>, IClaimValueType
{
    public static IClaimValueType Instance => new Rfc822Name();

    private Rfc822Name() { }

    /// <value><inheritdoc cref="ClaimValueType.Xacml10Namespace" path="/value" />:data-type:rfc822Name</value>
    public const string UriString = Xacml10Namespace + ":data-type:rfc822Name";
    /// <value><inheritdoc cref="ClaimValueType.ShortXacml10Namespace" path="/value"/>:rfc822Name</value>
    public const string ShortUriString = ShortXacml10Namespace + ":rfc822Name";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator string?(Rfc822Name value) => value.Value;

    public static implicit operator Rfc822Name(string value) => (Instance as Rfc822Name) with { Value = EmailAddress.From(value) };
}

public record class X500Name : ClaimValueType<X500DistinguishedName>, IClaimValueType
{
    public static IClaimValueType Instance => new X500Name();

    private X500Name() { }

    /// <value><inheritdoc cref="ClaimValueType.Xacml10Namespace" path="/value" />:data-type:x500Name</value>
    public const string UriString = Xacml10Namespace + ":data-type:x500Name";
    /// <value><inheritdoc cref="ClaimValueType.ShortXacml10Namespace" path="/value"/>:x500Name</value>
    public const string ShortUriString = ShortXacml10Namespace + ":x500Name";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public static implicit operator string?(X500Name value) => value.Value.Name;

    public static implicit operator X500Name(string value) => (Instance as X500Name) with { Value = new X500DistinguishedName(value) };
}

public record class XacmlDnsName : ClaimValueType<string>, IClaimValueType
{
    public static IClaimValueType Instance => new XacmlDnsName();

    private XacmlDnsName() { }

    /// <value><inheritdoc cref="ClaimValueType.Xacml20Namespace" path="/value" />:data-type:dnsName</value>
    public const string UriString = Xacml20Namespace + ":data-type:dnsName";
    /// <value><inheritdoc cref="ClaimValueType.ShortXacml20Namespace" path="/value"/>:dnsName</value>
    public const string ShortUriString = ShortXacml20Namespace + ":dnsName";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;


    public static implicit operator string(XacmlDnsName value) => value.Value;

    public static implicit operator XacmlDnsName(string value) => (Instance as XacmlDnsName) with { Value = value };
}

[RegexDto(@"((^\s*((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))\s*$)|(^\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*$))", baseType: typeof(ClaimValueType<string>))]
public partial record class IpAddress : IClaimValueType
{
    public static IClaimValueType Instance => new IpAddress();

    // private IpAddress() { }

    /// <value><inheritdoc cref="ClaimValueType.Xacml30Namespace" path="/value" />:data-type:ipAddress</value>
    public const string UriString = Xacml30Namespace + ":data-type:ipAddress";
    /// <value><inheritdoc cref="ClaimValueType.ShortXacml30Namespace" path="/value"/>:ipAddress</value>
    public const string ShortUriString = ShortXacml30Namespace + ":ipAddress";
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IIdentityComponent.UriString => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;
    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;
    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    // public static implicit operator string(IpAddress value) => value.ToString();

    // public static implicit operator IpAddress(string value) => (Instance as IpAddress) with { Value = System.Net.IPAddress.Parse(value) };

    // public static implicit operator byte[](IpAddress value) => value.GetAddressBytes();

    // public static implicit operator IpAddress(byte[] value) => (Instance as IpAddress) with { Value = new System.Net.IPAddress(value) };

    // public static implicit operator System.Net.IPAddresss(IpAddress value) => value.Value;

    // public static implicit operator IpAddress(System.Net.IPAddresss value) => (Instance as IpAddress) with { Value = value };

}

