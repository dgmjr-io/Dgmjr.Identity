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
using System.Collections;
using static ClaimValueType;

using Dgmjr.Primitives;

using SSCXmlKeyInfo = System.Security.Cryptography.Xml.KeyInfo;

// the schema needs to be checked for all these types to ensure they allowed

/// <summary>A claim value for a(n) Base64Binary</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Base64Binary : ClaimValueType<byte[]>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Base64Binary();

    private Base64Binary() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />base64Binary</value>
    public new const string UriString = XmlSchemaNamespace + "base64Binary";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:base64Binary</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":base64Binary";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Base64Binary value) => value.Value.ToBase64String();

    public static implicit operator Base64Binary(string value) =>
        (Instance as Base64Binary) with
        {
            Value = value.FromBase64String()
        };
}

/// <summary>A claim value for a(n) Boolean</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Boolean : ClaimValueType<bool>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Boolean();

    private Boolean() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />boolean</value>
    public new const string UriString = XmlSchemaNamespace + "boolean";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:boolean</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":boolean";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator bool(Boolean value) => value.Value;

    public static implicit operator Boolean(bool value) =>
        (Instance as Boolean) with
        {
            Value = value
        };

    public static implicit operator string(Boolean value) => value.Value.ToString().ToLower();

    public static implicit operator Boolean(string value) =>
        (Instance as Boolean) with
        {
            Value = value.Equals(bool.TrueString, InvariantCultureIgnoreCase)
        };
}

/// <summary>A claim value for a(n) Date</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Date : ClaimValueType<date>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Date();

    private Date() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />date</value>
    public new const string UriString = XmlSchemaNamespace + "date";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:date</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":date";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator date(Date value) => value.Value;

    public static implicit operator Date(date value) => (Instance as Date) with { Value = value };

    public static implicit operator string(Date value) => value.Value.ToShortDateString();

    public static implicit operator Date(string value) =>
        (Instance as Date) with
        {
            Value = date.Parse(value, CultureInfo.InvariantCulture)
        };
}

/// <summary>A claim value for a(n) _DateTime</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class _DateTime : ClaimValueType<datetime>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new _DateTime();

    private _DateTime() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />dateTime</value>
    public new const string UriString = XmlSchemaNamespace + "dateTime";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:dateTime</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":dateTime";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator datetime(_DateTime value) => value.Value;

    public static implicit operator _DateTime(datetime value) =>
        (Instance as _DateTime) with
        {
            Value = value
        };

    public static implicit operator string(_DateTime value) => value.Value.ToLongDateString();

    public static implicit operator _DateTime(string value) =>
        (Instance as _DateTime) with
        {
            Value = datetime.Parse(value, CultureInfo.InvariantCulture)
        };

    public static implicit operator long(_DateTime value) => value.Value.Ticks;

    public static implicit operator _DateTime(long value) =>
        (Instance as _DateTime) with
        {
            Value = new datetime(value)
        };
}

/// <summary>A claim value for a(n) Double</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Double : ClaimValueType<double>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Double();

    private Double() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />double</value>
    public new const string UriString = XmlSchemaNamespace + "double";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:double</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":double";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator double(Double value) => value.Value;

    public static implicit operator Double(double value) =>
        (Instance as Double) with
        {
            Value = value
        };
}

/// <summary>A claim value for a(n) Fqbn</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Fqbn : ClaimValueType<string>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Fqbn();

    private Fqbn() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />fqbn</value>
    public new const string UriString = XmlSchemaNamespace + "fqbn";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value" />:fqbn</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":fqbn";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Fqbn value) => value.Value;

    public static implicit operator Fqbn(string value) => (Instance as Fqbn) with { Value = value };
}

/// <summary>A claim value for a(n) HexBinary</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class HexBinary : ClaimValueType<byte[]>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new HexBinary();

    private HexBinary() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />hexBinary</value>
    public new const string UriString = XmlSchemaNamespace + "hexBinary";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:hexBinary</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":hexBinary";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator byte[](HexBinary value) => value.Value;

    public static implicit operator HexBinary(byte[] value) =>
        (Instance as HexBinary) with
        {
            Value = value
        };

    public static implicit operator string(HexBinary value) => value.Value.ToHexString();

    public static implicit operator HexBinary(string value) =>
        (Instance as HexBinary) with
        {
            Value = value.FromHexString()
        };
}

/// <summary>A claim value for a(n) Integer</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Integer : ClaimValueType<int>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Integer();

    private Integer() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />integer</value>
    public new const string UriString = XmlSchemaNamespace + "integer";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:integer</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":integer";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator int(Integer value) => value.Value;

    public static implicit operator Integer(int value) =>
        (Instance as Integer) with
        {
            Value = value
        };

    public static implicit operator string(Integer value) => value.Value.ToString();

    public static implicit operator Integer(string value) =>
        (Instance as Integer) with
        {
            Value = int.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
        };
}

/// <summary>A claim value for a(n) Integer32</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Integer32 : ClaimValueType<int>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Integer32();

    private Integer32() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />integer32</value>
    public new const string UriString = XmlSchemaNamespace + "integer32";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:integer32</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":integer32";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator int(Integer32 value) => value.Value;

    public static implicit operator Integer32(int value) =>
        (Instance as Integer32) with
        {
            Value = value
        };

    public static implicit operator string(Integer32 value) => value.Value.ToString();

    public static implicit operator Integer32(string value) =>
        (Instance as Integer32) with
        {
            Value = int.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
        };
}

/// <summary>A claim value for a(n) UnixTimestamp</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class UnixTimestamp : Integer64, IClaimValueType
{
    public static new readonly IClaimValueType Instance = new UnixTimestamp();

    private UnixTimestamp() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />unixTimestamp</value>
    public new const string UriString = XmlSchemaNamespace + "unixTimestamp";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:unixTimestamp</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":unixTimestamp";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator long(UnixTimestamp value) => value.Value;

    public static implicit operator datetime(UnixTimestamp value) =>
        datetime.FromFileTime(value.Value);

    public static implicit operator UnixTimestamp(long value) =>
        (Instance as UnixTimestamp) with
        {
            Value = value
        };

    public static implicit operator string(UnixTimestamp value) =>
        value.Value.ToString(
            CultureInfo.InvariantCulture.DateTimeFormat.UniversalSortableDateTimePattern
        );

    public static implicit operator UnixTimestamp(string value) =>
        (Instance as UnixTimestamp) with
        {
            Value = datetime.Parse(value, CultureInfo.InvariantCulture).ToFileTime()
        };
}

/// <summary>A claim value for a(n) Integer64</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Integer64 : ClaimValueType<long>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Integer64();

    protected Integer64() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />integer64</value>
    public new const string UriString = XmlSchemaNamespace + "integer64";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:integer64</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":integer64";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator long(Integer64 value) => value.Value;

    public static implicit operator Integer64(long value) =>
        (Instance as Integer64) with
        {
            Value = value
        };

    public static implicit operator string(Integer64 value) => value.Value.ToString();

    public static implicit operator Integer64(string value) =>
        (Instance as Integer64) with
        {
            Value = long.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
        };
}

/// <summary>A claim value for a(n) Integer64</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Enum<T> : ClaimValueType<T>, IClaimValueType
    where T : System.Enum
{
    public static readonly IClaimValueType Instance = new Enum<T>();

    protected Enum() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />integer32(of-T)</value>
    public new static readonly string UriString =
        XmlSchemaNamespace + $"integer32({typeof(T).Name})";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:integer32(of-T)</value>
    public new static readonly string ShortUriString =
        ShortXmlSchemaNamespace + $"integer32({typeof(T).Name})";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator int(Enum<T> value) => (int)(object)value.Value;

    public static implicit operator T?(Enum<T> value) => value.Value;

    public static implicit operator Enum<T>(long value) =>
        (Instance as Enum<T>) with
        {
            Value = (T)Enum.ToObject(typeof(T), value)
        };

    public static implicit operator string(Enum<T> value) => value.Value.ToString();

    public static implicit operator Enum<T>(string value) =>
        (Instance as Enum<T>) with
        {
            Value = (T)Enum.Parse(typeof(T), value, true)
        };
}

#if WINDOWS
/// <summary>A claim value for a(n) Sid</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Sid
    : ClaimValueType<System.Security.Principal.SecurityIdentifier>,
        IClaimValueType
{
    public static readonly IClaimValueType Instance = new Sid();

    private Sid() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />sid</value>
    public new const string UriString = XmlSchemaNamespace + "sid";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:sid</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":sid";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

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

    public static implicit operator Sid(byte[] value) =>
        (Instance as Sid) with
        {
            Value = new(value, 0)
        };

    public static implicit operator string(Sid value) => value.Value.ToString();

    public static implicit operator Sid(string value) =>
        (Instance as Sid) with
        {
            Value = new System.Security.Principal.SecurityIdentifier(value)
        };
}
#endif

/// <summary>A claim value for a(n) String</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class String : ClaimValueType<string>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new String();

    private String() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />string</value>
    public new const string UriString = XmlSchemaNamespace + "string";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:string</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":string";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(String value) => value.Value;

    public static implicit operator String(string value) =>
        (Instance as String) with
        {
            Value = value
        };
}

/// <summary>A claim value for a(n) Time</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Time : ClaimValueType<time>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Time();

    private Time() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />time</value>
    public new const string UriString = XmlSchemaNamespace + "time";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:time</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":time";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator time(Time value) => value.Value;

    public static implicit operator Time(time value) => (Instance as Time) with { Value = value };

    public static implicit operator string(Time value) => value.Value.ToLongTimeString();

    public static implicit operator Time(string value) =>
        (Instance as Time) with
        {
            Value = time.Parse(value, CultureInfo.InvariantCulture)
        };

    public static implicit operator long(Time value) => value.Value.Ticks;

    public static implicit operator Time(long value) =>
        (Instance as Time) with
        {
            Value = new time(value)
        };
}

/// <summary>A claim value for a(n) UInteger32</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class UInteger32 : ClaimValueType<uint>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new UInteger32();

    private UInteger32() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />uinteger32</value>
    public new const string UriString = XmlSchemaNamespace + "uinteger32";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:uinteger32</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":uinteger32";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator uint(UInteger32 value) => value.Value;

    public static implicit operator UInteger32(uint value) =>
        (Instance as UInteger32) with
        {
            Value = value
        };

    public static implicit operator string(UInteger32 value) => value.Value.ToString();

    public static implicit operator UInteger32(string value) =>
        (Instance as UInteger32) with
        {
            Value = uint.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
        };
}

/// <summary>A claim value for a(n) UInteger64</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class UInteger64 : ClaimValueType<ulong>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new UInteger64();

    private UInteger64() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />uinteger64</value>
    public new const string UriString = XmlSchemaNamespace + "uinteger64";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:uinteger64</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":uinteger64";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator ulong(UInteger64 value) => value.Value;

    public static implicit operator UInteger64(ulong value) =>
        (Instance as UInteger64) with
        {
            Value = value
        };

    public static implicit operator string(UInteger64 value) => value.Value.ToString();

    public static implicit operator UInteger64(string value) =>
        (Instance as UInteger64) with
        {
            Value = ulong.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture)
        };
}

/// <summary>A claim value for a(n) DnsName</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class DnsName : ClaimValueType<string>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new DnsName();

    private DnsName() { }

    /// <value><inheritdoc cref="SoapNamespace" path="/value" />/dns</value>
    public new const string UriString = SoapNamespace + "/dns";

    /// <value><inheritdoc cref="ShortSoapSchemaNamespace" path="/value"/>:dns</value>
    public new const string ShortUriString = ShortSoapSchemaNamespace + ":dns";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(DnsName value) => value.Value;

    public static implicit operator DnsName(string value) =>
        (Instance as DnsName) with
        {
            Value = value
        };
}

/// <summary>A claim value for a(n) Email</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Email : ClaimValueType<EmailAddress>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Email();

    private Email() { }

    /// <value><inheritdoc cref="Soap2005Namespace" path="/value" />/emailaddress</value>
    public new const string UriString = Soap2005Namespace + "/emailaddress";

    /// <value><inheritdoc cref="ShortSoapSchemaNamespace" path="/value"/>:emailaddress</value>
    public new const string ShortUriString = ShortSoapSchemaNamespace + ":emailaddress";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string?(Email value) => value.Value;

    public static implicit operator Email(string value) =>
        (Instance as Email) with
        {
            Value = EmailAddress.From(value)
        };
}

/// <summary>A claim value for a(n) Rsa</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Rsa : ClaimValueType<RSA>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Rsa();

    private Rsa() { }

    /// <value><inheritdoc cref="Soap2005Namespace" path="/value" />/rsa</value>
    public new const string UriString = Soap2005Namespace + "/rsa";

    /// <value><inheritdoc cref="ShortSoapSchemaNamespace" path="/value" />:rsa</value>
    public new const string ShortUriString = ShortSoapSchemaNamespace + ":rsa";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

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

/// <summary>A claim value for a(n) UpnName</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class UpnName : ClaimValueType<EmailAddress>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new UpnName();

    private UpnName() { }

    /// <value><inheritdoc cref="SoapNamespace" path="/value" />UPN</value>
    public new const string UriString = SoapNamespace + "UPN";

    /// <value><inheritdoc cref="ShortSoapSchemaNamespace" path="/value"/>:UPN"</value>
    public new const string ShortUriString = ShortSoapSchemaNamespace + ":UPN";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string?(UpnName value) => value.Value;

    public static implicit operator UpnName(string value) =>
        (Instance as UpnName) with
        {
            Value = EmailAddress.From(value)
        };
};

/// <summary>A claim value for a(n) DsaKeyValue</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class DsaKeyValue : ClaimValueType<XE>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new DsaKeyValue();

    private DsaKeyValue() { }

    /// <value><inheritdoc cref="XmlSignatureConstantsNamespace" path="/value" />DSAKeyValue</value>
    public new const string UriString = XmlSignatureConstantsNamespace + "DSAKeyValue";

    /// <value><inheritdoc cref="ShortXmlSignatureConstantsNamespace" path="/value" />:DSAKeyValue</value>
    public new const string ShortUriString = ShortXmlSignatureConstantsNamespace + ":DSAKeyValue";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(DsaKeyValue value) => value.Value.ToString();

    public static implicit operator DsaKeyValue(string value) =>
        (Instance as DsaKeyValue) with
        {
            Value = value.ToXElement()
        };

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

/// <summary>A claim value for a(n) KeyInfo</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class KeyInfo : ClaimValueType<SSCXmlKeyInfo>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new KeyInfo();

    private KeyInfo() { }

    /// <value><inheritdoc cref="XmlSignatureConstantsNamespace" path="/value" />KeyInfo</value>
    public new const string UriString = XmlSignatureConstantsNamespace + "KeyInfo";

    /// <value><inheritdoc cref="ShortXmlSignatureConstantsNamespace" path="/value" />:KeyInfo</value>
    public new const string ShortUriString = ShortXmlSignatureConstantsNamespace + ":KeyInfo";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(KeyInfo value) => value.Value.ToString();

    public static implicit operator KeyInfo(string value)
    {
        var keyInfo = new SSCXmlKeyInfo();
        var xDoc = new XmlDocument();
        xDoc.LoadXml(value);
        keyInfo.LoadXml(xDoc.DocumentElement);
        return (Instance as KeyInfo) with { Value = keyInfo };
    }

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
        var xElement = value.GetXml();
        instance.Value = new SSCXmlKeyInfo();
        instance.Value.LoadXml(xElement);
        return instance;
    }
}

/// <summary>A claim value for a(n) RsaKeyValue</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class RsaKeyValue : ClaimValueType<XE>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new RsaKeyValue();

    private RsaKeyValue() { }

    /// <value><inheritdoc cref="XmlSignatureConstantsNamespace" path="/value" />RSAKeyValue</value>
    public new const string UriString = XmlSignatureConstantsNamespace + "RSAKeyValue";

    /// <value><inheritdoc cref="ShortXmlSignatureConstantsNamespace" path="/value" />:RSAKeyValue</value>
    public new const string ShortUriString = ShortXmlSignatureConstantsNamespace + ":RSAKeyValue";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(RsaKeyValue value) => value.Value.ToString();

    public static implicit operator RsaKeyValue(string value) =>
        (Instance as RsaKeyValue) with
        {
            Value = value.ToXElement()
        };

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

/// <summary>A claim value for a(n) DaytimeDuration</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class DaytimeDuration : ClaimValueType<DayTimeDuration>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new DaytimeDuration();

    private DaytimeDuration() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />dayTimeDuration</value>
    public new const string UriString = XmlSchemaNamespace + "dayTimeDuration";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:dayTimeDuration</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":dayTimeDuration";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(DaytimeDuration value) => value.Value;

    public static implicit operator DaytimeDuration(string value) =>
        (Instance as DaytimeDuration) with
        {
            Value = DayTimeDuration.Parse(value)
        };
}

/// <summary>A claim value for a(n) YearMonthDuration</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class YearMonthDuration
    : ClaimValueType<Primitives.YearMonthDuration>,
        IClaimValueType
{
    public static readonly IClaimValueType Instance = new YearMonthDuration();

    private YearMonthDuration() { }

    /// <value><inheritdoc cref="XmlSchemaNamespace" path="/value" />yearMonthDuration</value>
    public new const string UriString = XmlSchemaNamespace + "yearMonthDuration";

    /// <value><inheritdoc cref="ShortXmlSchemaNamespace" path="/value"/>:yearMonthDuration</value>
    public new const string ShortUriString = ShortXmlSchemaNamespace + ":yearMonthDuration";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(YearMonthDuration value) => value.Value;

    public static implicit operator YearMonthDuration(string value) =>
        (Instance as YearMonthDuration) with
        {
            Value = Dgmjr.Primitives.YearMonthDuration.Parse(value)
        };
}

/// <summary>A claim value for a(n) Rfc822Name</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Rfc822Name : ClaimValueType<EmailAddress>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Rfc822Name();

    private Rfc822Name() { }

    /// <value><inheritdoc cref="Xacml10Namespace" path="/value" />:data-type:rfc822Name</value>
    public new const string UriString = Xacml10Namespace + ":data-type:rfc822Name";

    /// <value><inheritdoc cref="ShortXacml10Namespace" path="/value"/>:rfc822Name</value>
    public new const string ShortUriString = ShortXacml10Namespace + ":rfc822Name";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public override string ExampleStringValue => System.Net.Mail.EmailAddress.ExampleValueString;
    public override string DefaultStringValue => System.Net.Mail.EmailAddress.EmptyValueString;

    public static implicit operator string?(Rfc822Name value) => value.Value;

    public static implicit operator Rfc822Name(string value) =>
        (Instance as Rfc822Name) with
        {
            Value = EmailAddress.From(value)
        };
}

/// <summary>A claim value for a(n) PhoneNumber</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class PhoneNumber : ClaimValueType<System.Domain.PhoneNumber>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new PhoneNumber();

    private PhoneNumber() { }

    /// <value><inheritdoc cref="PhoneNumberUri" path="/value" /></value>
    public new const string UriString = PhoneNumberUri;

    /// <value><inheritdoc cref="PhoneNumberShortUri" path="/value"/></value>
    public new const string ShortUriString = PhoneNumberShortUri;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;
    public override string ExampleStringValue => System.Domain.PhoneNumber.ExampleString;
    public override string DefaultStringValue => System.Domain.PhoneNumber.EmptyString;

    public static implicit operator string?(PhoneNumber value) => value.Value;

    public static implicit operator PhoneNumber(string value) =>
        (Instance as PhoneNumber) with
        {
            Value = System.Domain.PhoneNumber.From(value)
        };
}

/// <summary>A claim value for a(n) X500Name</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class X500Name : ClaimValueType<X500DistinguishedName>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new X500Name();

    private X500Name() { }

    /// <value><inheritdoc cref="Xacml10Namespace" path="/value" />:data-type:x500Name</value>
    public new const string UriString = Xacml10Namespace + ":data-type:x500Name";

    /// <value><inheritdoc cref="ShortXacml10Namespace" path="/value"/>:x500Name</value>
    public new const string ShortUriString = ShortXacml10Namespace + ":x500Name";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string?(X500Name value) => value.Value.Name;

    public static implicit operator X500Name(string value) =>
        (Instance as X500Name) with
        {
            Value = new X500DistinguishedName(value)
        };
}

/// <summary>A claim value for a(n) XacmlDnsName</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class XacmlDnsName : ClaimValueType<string>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new XacmlDnsName();

    private XacmlDnsName() { }

    /// <value><inheritdoc cref="Xacml20Namespace" path="/value" />:data-type:dnsName</value>
    public new const string UriString = Xacml20Namespace + ":data-type:dnsName";

    /// <value><inheritdoc cref="ShortXacml20Namespace" path="/value"/>:dnsName</value>
    public new const string ShortUriString = ShortXacml20Namespace + ":dnsName";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(XacmlDnsName value) => value.Value;

    public static implicit operator XacmlDnsName(string value) =>
        (Instance as XacmlDnsName) with
        {
            Value = value
        };
}

/// <summary>A claim value for a(n) AnyUri</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class AnyUri : ClaimValueType<uri>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new AnyUri();

    private AnyUri() { }

    /// <value>https://www.w3.org/2001/XMLSchema#anyURI</value>
    public new const string UriString = "https://www.w3.org/2001/XMLSchema#anyURI";

    /// <value>xs:anyURI</value>
    public new const string ShortUriString = "xs:anyURI";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(AnyUri value) => value.Value.ToString();

    public static implicit operator AnyUri(string value) =>
        (Instance as AnyUri) with
        {
            Value = System.uri.From(value)
        };

    public static implicit operator uri(AnyUri value) => value.Value.ToString();

    public static implicit operator AnyUri(uri value) =>
        (Instance as AnyUri) with
        {
            Value = System.uri.From(value.ToString())
        };
}

/// <summary>A claim value for a(n) Array<T></summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Array<T> : ClaimValueType<T[]>, IClaimValueType, IEnumerable<T>
    where T : IClaimValueType
{
    public static readonly IClaimValueType Instance = new Array<T>();

    public virtual IEnumerator<T> GetEnumerator() => Value.OfType<T>().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private Array() { }

    /// <value>https://www.w3.org/2001/XMLSchema#sequence</value>
    public new const string UriString = "https://www.w3.org/2001/XMLSchema#list";

    /// <value>xs:list</value>
    public new const string ShortUriString = "xs:list";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Array<T> value) =>
        Serialize(value.Select(v => v.ToString()).ToArray());

    public static implicit operator Array<T>(string value) =>
        (Instance as Array<T>) with
        {
            Value = JNode.Parse(value).AsArray().Select(x => x.AsValue().GetValue<T>()).ToArray()
        };
}

/// <summary>A claim value for a(n) Json</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Json : ClaimValueType<JElem>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Json();

    private Json() { }

    /// <value>https://www.w3.org/2001/XMLSchema#json</value>
    public new const string UriString = "https://www.w3.org/2001/XMLSchema#json";

    /// <value>xs:json</value>
    public new const string ShortUriString = "xs:json";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Json value) => value.Value.ToString();

    public static implicit operator Json(string value)
    {
        var utf8Span = value.ToUTF8Bytes().AsSpan();
        var utf8Reader = new Utf8JsonReader(utf8Span);
        var elem = JElem.ParseValue(ref utf8Reader);
        return (Instance as Json) with { Value = elem };
    }
}

/// <summary>A claim value for a(n) Guid</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class Guid : ClaimValueType<guid>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new Guid();

    private Guid() { }

    /// <value>https://www.w3.org/2001/XMLSchema#uuidType</value>
    public new const string UriString = "https://www.w3.org/2001/XMLSchema#uuidType";

    /// <value>xs:uuidType</value>
    public new const string ShortUriString = "xs:uuidType";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(Guid value) => value.Value.ToString();

    public static implicit operator Guid(string value) =>
        (Instance as Guid) with
        {
            Value = guid.Parse(value)
        };
}

/// <summary>A claim value for a(n) OneOf<T,</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class OneOf<T, U>
    : ClaimValueType<AnyOf<T, U>>,
        IHaveAValue<AnyOf<T, U>>,
        IHaveAUriString,
        IIdentityComponent
    where T : class, IClaimValueType, IIdentityComponent, IHaveAUriString
    where U : class, IClaimValueType, IIdentityComponent, IHaveAUriString
{
    public static readonly IClaimValueType Instance = new OneOf<T, U>();

    private OneOf() { }

    public override AnyOf<T, U> Value { get; set; }

    /// <value><inheritdoc cref="Dgmjr.Identity.Core.Constants.DgmjrIdentity" path="/value" />/oneof/T/or/U</value>
    public new const string UriString =
        Dgmjr.Identity.Core.Constants.DgmjrIdentity + "/oneof/T/or/U";

    /// <value><inheritdoc cref="Dgmjr.Identity.Core.Constants.Dgmjr" path="/value" />:oneof-T-or-U</value>
    public new const string ShortUriString = Dgmjr.Identity.Core.Constants.Dgmjr + ":oneof-T-or-U";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString =>
        $"{DgmjrIdentity}/oneof/{Activator.CreateInstance<T>().ShortUriString}/or/{Activator.CreateInstance<U>().ShortUriString}";

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString =>
        $"dgmjr:oneof:{Activator.CreateInstance<T>().ShortUriString}:or:{Activator.CreateInstance<U>().ShortUriString}";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    public static implicit operator string(OneOf<T, U> value) => value.Value.ToString();

    public static implicit operator OneOf<T, U>(string value)
    {
        T? t = default;
        U? u = default;
        try
        {
            t = value as object as T;
            if (t is null)
            {
                throw new InvalidCastException();
            }
        }
        catch
        {
            /* it's the other type */
            try
            {
                u = value as object as U;
            }
            catch
            {
                /* it's neither type 🤷‍♂️ */
            }
        }
        return (Instance as OneOf<T, U>) with { Value = t is not null ? t : u };
    }
}

/// <summary>A claim value for a(n) ObjectId</summary>
/// <value><inheritdoc cref="UriString" path="/value" /></value>
public record class ObjectId : ClaimValueType<System.ObjectId>, IClaimValueType
{
    public static readonly IClaimValueType Instance = new ObjectId();

    private ObjectId() { }

    /// <value>https://www.mongodb.com/docs/manual/reference/method/ObjectId</value>
    public new const string UriString =
        "https://www.mongodb.com/docs/manual/reference/method/ObjectId";

    /// <value>mongodb:objectid</value>
    public new const string ShortUriString = "mongodb:objectid";

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    public override uri Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    public override uri ShortUri => ShortUriString;

    /// <value><inheritdoc cref="System.ObjectId.ExampleValueString" /></value>
    public override string ExampleStringValue => System.ObjectId.ExampleValueString;

    /// <value><inheritdoc cref="System.ObjectId.EmptyValue" /></value>
    public override string DefaultStringValue => System.ObjectId.EmptyValue;

    public static implicit operator string(ObjectId value) => value.Value.ToString();

    public static implicit operator ObjectId(string value) =>
        (Instance as ObjectId) with
        {
            Value = System.ObjectId.From(value)
        };
}

[RegexDto(
    @"(?<Address:string>((^\s*((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))\s*$)|(^\s*((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?\s*$)))",
    typeof(ClaimValueType<System.Net.IPAddress>)
)]
public partial record class IpAddress : IClaimValueType<System.Net.IPAddress>
{
    public static readonly IClaimValueType Instance = new IpAddress();

    // private IpAddress() { }

    System.Net.IPAddress IClaimValueType<System.Net.IPAddress>.Value =>
        System.Net.IPAddress.Parse(Address);
    object IClaimValueType.Value => Value;

    /// <value><inheritdoc cref="Xacml30Namespace" path="/value" /></value>
    public const string Namespace = Xacml30Namespace;

    /// <value>ipAddress</value>
    public const string Name = "ipAddress";

    /// <value><inheritdoc cref="Xacml30Namespace" path="/value" />:data-type:<inheritdoc cref="Name" path="/value" /></value>
    public new const string UriString = Xacml30Namespace + ":data-type:" + Name;

    /// <value><inheritdoc cref="ShortXacml30Namespace" path="/value"/>:ipAddress</value>
    public new const string ShortUriString = ShortXacml30Namespace + ":" + Name;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    string IHaveAUriString.UriString => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IIdentityComponent.ShortUriString => ShortUriString;

    /// <value><inheritdoc cref="ShortXacml30Namespace" path="/value"/>:ipAddress</value>
    string IIdentityComponent.Namespace => Namespace;

    /// <value><inheritdoc cref="UriString" path="/value" /></value>
    uri IHaveAuri.Uri => UriString;

    /// <value><inheritdoc cref="ShortUriString" path="/value" /></value>
    string IHaveAName.Name => Name;
    uri IIdentityComponent.ShortUri => ShortUriString;

    public override bool Equals(IIdentityComponent? other) => UriString == other.UriString;
    // public static implicit operator string(IpAddress value) => value.ToString();

    // public static implicit operator IpAddress(string value) => (Instance as IpAddress) with { Value = System.Net.IPAddress.Parse(value) };

    // public static implicit operator byte[](IpAddress value) => value.GetAddressBytes();

    // public static implicit operator IpAddress(byte[] value) => (Instance as IpAddress) with { Value = new System.Net.IPAddress(value) };

    // public static implicit operator System.Net.IPAddresss(IpAddress value) => value.Value;

    // public static implicit operator IpAddress(System.Net.IPAddresss value) => (Instance as IpAddress) with { Value = value };
}
