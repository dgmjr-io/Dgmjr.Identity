#pragma warning disable
namespace Dgmjr.Identity.Claims.ClaimValueTypes;
using System.Security.AccessControl;
using System.Diagnostics.Contracts;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;
using System.Collections.ObjectModel;
using static XsdClaimValueType;
using static Constants;
using System.Globalization;

file static class XsdClaimValueType
{
    /// <summary>The short prefix for types in the "<inheritdoc cref="_ShortUriPrefix" path="/value" />" namespace</summary>
    /// <value>xs</value>
    public new const string _ShortUriPrefix = "xs";
    /// <summary>The long URI prefix for types in the "<inheritdoc cref="_Name" path="/value" />" namespace</summary>
    /// <value>http://www.w3.org/2001/XMLSchema</value>
    public new const string _LongUriPrefix = $"http://www.w3.org/2001/XMLSchema";

    /// <summary>The name of the claim value type "<inheritdoc cref="Constants.@default" path="/value" />"</summary>
    /// <value>default</value>
    public new const string _Name = Constants.@default;

    /// <value>#</value>
    public new const string _LongUriSeparator = "#";
    /// <inheritdoc cref="DefaultShortUriSeparator" />
    public new const string _ShortUriSeparator = DefaultShortUriSeparator;

    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <value>A claim value type that represents a(n) <inheritdoc cref="_Name" path="/value" /> in the <inheritdoc cref="_LongUriPrefix" path="/value" /> (<inheritdoc cref="_ShortUriPrefix" path="/value" />) namespace</value>
    public new const string _Description = $"A claim value type that represents a(n) \"{_Name}\" in the _{_LongUriPrefix} (_{_ShortUriPrefix}) namespace";
}

/// <summary>A URI pattern for representing a claim type in the  <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="ShortUriPrefix" path="/value" />) namespace</summary>
public abstract class XsdClaimValueType<TSelf, TValue> : ClaimValueType<TSelf, TValue>
    where TSelf : XsdClaimValueType<TSelf, TValue>
    where TValue : notnull
{
    public override string StringValue { get => Convert.ToString(Value, CultureInfo.CurrentCulture.GetFormat(typeof(TValue))); set => Value.ToString(); }
}


/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class String : XsdClaimValueType<String, string>
{
    const string plainliteral = nameof(plainliteral);
    static readonly string[] _synonyms = new[] { $"{RdfsClaimValueType._LongUriPrefix}{RdfsClaimValueType._LongUriSeparator}{plainliteral}", $"{RdfsClaimValueType._ShortUriPrefix}{RdfsClaimValueType._ShortUriSeparator}{plainliteral}" };

    public static String Instance => new String();

    public String() { }

    /// <value>string</value>
    public new const string _Name = "string";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public override string[] Synonyms { get => base.Synonyms.Concat(_synonyms).Distinct().ToArray(); init => base.Synonyms = value; }
}
/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class Uri : AnyUri { }
/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class Double : XsdClaimValueType<Double, double>
{
    public static Double Instance => new Double();

    public Double() { }

    /// <value>double</value>
    public new const string _Name = "double";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}


/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class Decimal : XsdClaimValueType<Decimal, decimal>
{
    public static Decimal Instance => new Decimal();
    public Decimal() { }

    /// <value>decimal</value>
    public new const string _Name = "decimal";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}

public class Boolean : XsdClaimValueType<Boolean, bool>
{
    public static Boolean Instance => new Boolean();

    public Boolean() { }

    public new const string _Name = "boolean";
    public new const string _LongUriString = $"{XsdClaimValueType<Boolean, bool>._LongUriPrefix}{XsdClaimValueType<Boolean, bool>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<Boolean, bool>._ShortUriPrefix}{XsdClaimValueType<Boolean, bool>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}

public class DateTime : XsdClaimValueType<DateTime, System.DateTime>
{
    public static DateTime Instance => new DateTime();

    public DateTime() { }

    public new const string _Name = "dateTime";
    public new const string _LongUriString = $"{XsdClaimValueType<DateTime, System.DateTime>._LongUriPrefix}{XsdClaimValueType<DateTime, System.DateTime>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<DateTime, System.DateTime>._ShortUriPrefix}{XsdClaimValueType<DateTime, System.DateTime>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}
public class Date : XsdClaimValueType<Date, System.DateOnly>
{
    public static Date Instance => new Date();

    public Date() { }
    public Date(System.DateOnly date) => Value = date;
    public Date(System.DateTime date) : this(System.DateOnly.Parse(date.ToShortDateString())) { }
    public Date(string date) : this(System.DateTime.TryParse(date, out var dt) ? dt : throw new InvalidCastException($"The string \"{date}\" was not recognized as a valid date.")) { }

    public new const string _Name = "date";
    public new const string _LongUriString = $"{XsdClaimValueType<Date, System.DateOnly>._LongUriPrefix}{XsdClaimValueType<Date, System.DateOnly>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<Date, System.DateOnly>._ShortUriPrefix}{XsdClaimValueType<Date, System.DateOnly>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Date(System.DateTime date) => new Date(date);
    public static implicit operator Date(string date) => new Date(System.DateTime.Parse(System.DateTime.Parse(date).ToShortDateString()));
    public static implicit operator Date(DateOnly date) => new Date(date);
    public static implicit operator string(Date date) => date.Value.ToShortDateString();
}

public class Time : XsdClaimValueType<Time, System.TimeOnly>
{
    public static Time Instance => new Time();

    public Time() { }
    public Time(double milisecons) : this(global::System.DateTime.FromFileTimeUtc((long)milisecons)) { }
    public Time(TimeOnly date) => Value = date;
    public Time(System.DateTime date) : this(TimeOnly.Parse(date.ToShortTimeString())) { }
    public Time(string date) : this(System.DateTime.TryParse(date, out var dt) ? dt : throw new InvalidCastException($"The string \"{date}\" was not recognized as a valid date.")) { }

    public new const string _Name = "time";
    public new const string _LongUriString = $"{XsdClaimValueType<Time, System.TimeOnly>._LongUriPrefix}{XsdClaimValueType<Time, System.TimeOnly>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<Time, System.TimeOnly>._ShortUriPrefix}{XsdClaimValueType<Time, System.TimeOnly>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}

public class Duration : XsdClaimValueType<Duration, System.TimeSpan>
{
    public static Duration Instance => new Duration();

    public Duration() { }
    public Duration(System.TimeSpan timeSpan) => Value = timeSpan;
    public Duration(double timeSpan) : this(System.TimeSpan.FromMilliseconds(timeSpan)) { }

    public new const string _Name = "timeSpan";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Duration(System.TimeSpan timeSpan) => new Duration(timeSpan);
    public static implicit operator Duration(string timeSpan) => new Duration(System.TimeSpan.TryParse(timeSpan, out var ts) ? ts : throw new InvalidCastException($"The string \"{timeSpan}\" was not recognized as a valid timeSpan."));
    public static implicit operator Duration(double timeSpan) => new Duration(timeSpan);
    public static implicit operator Duration(int timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(long timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(float timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(decimal timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(uint timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(ulong timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(short timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(ushort timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(byte timeSpan) => new Duration((double)timeSpan);
    public static implicit operator Duration(sbyte timeSpan) => new Duration((double)timeSpan);
    public static implicit operator System.TimeSpan(Duration duration) => duration.Value;
    public static implicit operator string(Duration duration) => duration.Value.ToString();
    public static implicit operator double(Duration duration) => duration.Value.TotalMilliseconds;
    public static implicit operator int(Duration duration) => (int)duration.Value.TotalMilliseconds;
    public static implicit operator long(Duration duration) => (long)duration.Value.TotalMilliseconds;
    public static implicit operator float(Duration duration) => (float)duration.Value.TotalMilliseconds;
    public static implicit operator decimal(Duration duration) => (decimal)duration.Value.TotalMilliseconds;
    public static implicit operator uint(Duration duration) => (uint)duration.Value.TotalMilliseconds;
    public static implicit operator ulong(Duration duration) => (ulong)duration.Value.TotalMilliseconds;
    public static implicit operator short(Duration duration) => (short)duration.Value.TotalMilliseconds;
    public static implicit operator ushort(Duration duration) => (ushort)duration.Value.TotalMilliseconds;
    public static implicit operator byte(Duration duration) => (byte)duration.Value.TotalMilliseconds;
    public static implicit operator sbyte(Duration duration) => (sbyte)duration.Value.TotalMilliseconds;
}

public class AnyUri : XsdClaimValueType<AnyUri, uri>
{
    public static AnyUri Instance => new AnyUri();

    public AnyUri() { }
    public AnyUri(uri uri) => Value = uri;

    public new const string _Name = "anyURI";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator AnyUri(uri uri) => new AnyUri(uri);
    public static implicit operator AnyUri(string uri) => new AnyUri(uri);
    public static implicit operator uri(AnyUri uri) => uri.Value;
    public static implicit operator string(AnyUri uri) => uri.Value.ToString();
}



public class Base64Binary : XsdClaimValueType<Base64Binary, string>
{
    public static Base64Binary Instance => new Base64Binary();

    public Base64Binary() { }
    public Base64Binary(string base64Binary) => Value = base64Binary;
    public Base64Binary(byte[] bytes) : this(Convert.ToBase64String(bytes)) { }

    public new const string _Name = "base64Binary";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Base64Binary(string base64Binary) => new Base64Binary(base64Binary);
    public static implicit operator Base64Binary(byte[] bytes) => new Base64Binary(bytes);
    public static implicit operator string(Base64Binary base64Binary) => base64Binary.Value;
    public static implicit operator byte[](Base64Binary base64Binary) => Convert.FromBase64String(base64Binary.Value);
}


public class Base64Octet : Base64Binary
{
    public static Base64Octet Instance => new Base64Octet();

    public Base64Octet() : base() { }
    public Base64Octet(string base64Binary) : base(base64Binary) { }
    public Base64Octet(byte[] bytes) : base(bytes) { }

    public new const string _Name = "base64Octet";
    public new const string _LongUriString = $"{Base64Binary._LongUriPrefix}{Base64Binary._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{Base64Binary._ShortUriPrefix}{Base64Binary._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Base64Octet(string base64Binary) => new Base64Octet(base64Binary);
    public static implicit operator Base64Octet(byte[] bytes) => new Base64Octet(bytes);
    public static implicit operator string(Base64Octet base64Binary) => base64Binary.Value;
    public static implicit operator byte[](Base64Octet base64Binary) => global::System.Convert.FromBase64String(base64Binary.Value);
}


public class HexBinary : XsdClaimValueType<HexBinary, string>
{
    public static HexBinary Instance => new HexBinary();

    public HexBinary() { }
    public HexBinary(string hexBinary) => Value = new RegexGuardedString(hexBinary, HexChars);
    private const string HexChars = "^[0123456789ABCDEFabcdef]*$";

    public new const string _Name = "hexBinary";
    public new const string _LongUriString = $"{XsdClaimValueType<HexBinary, string>._LongUriPrefix}{XsdClaimValueType<HexBinary, string>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<HexBinary, string>._ShortUriPrefix}{XsdClaimValueType<HexBinary, string>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator HexBinary(string hexBinary) => new HexBinary(hexBinary);
    public static implicit operator string(HexBinary hexBinary) => hexBinary.Value;
}

public class Sid : XsdClaimValueType<Sid, SSPSId>
{
    public static Sid Instance => new Sid();

    public Sid() { }
    public Sid(SSPSId sid) => Value = sid;

    public new const string _Name = "sid";
    public new const string _LongUriString = $"{XsdClaimValueType<Sid, SSPSId>._LongUriPrefix}{XsdClaimValueType<Sid, SSPSId>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<Sid, SSPSId>._ShortUriPrefix}{XsdClaimValueType<Sid, SSPSId>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}


public class Integer : XsdClaimValueType<Integer, int>
{
    public static Integer Instance => new Integer();

    public Integer() { }

    public new const string _Name = "integer";
    public new const string _LongUriString = $"{XsdClaimValueType<Integer, int>._LongUriPrefix}{XsdClaimValueType<Integer, int>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<Integer, int>._ShortUriPrefix}{XsdClaimValueType<Integer, int>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}
public class Long : XsdClaimValueType<Long, long>
{
    public static Long Instance => new Long();

    public Long() { }
    public Long(long value) => Value = value;

    public new const string _Name = "long";
    public new const string _LongUriString = $"{XsdClaimValueType<Long, long>._LongUriPrefix}{XsdClaimValueType<Long, long>._LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{XsdClaimValueType<Long, long>._ShortUriPrefix}{XsdClaimValueType<Long, long>._ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Long(long value) => new Long(value);
    public static implicit operator long(Long value) => value.Value;
}


public class Integer32 : XsdClaimValueType<Integer32, int>
{
    public static Integer32 Instance => new Integer32();

    public Integer32() { }
    public Integer32(int value) => Value = value;

    public new const string _Name = "integer32";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Integer32(int value) => new Integer32(value);
    public static implicit operator Integer32(string value) => new Integer32(int.Parse(value));
    public static implicit operator int(Integer32 value) => value.Value;
}

public class UInteger32 : XsdClaimValueType<UInteger32, uint>
{
    public static UInteger32 Instance => new UInteger32();

    public UInteger32() { }
    public UInteger32(uint value) => Value = value;

    public new const string _Name = "uinteger32";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator UInteger32(uint value) => new UInteger32(value);
    public static implicit operator UInteger32(string value) => new UInteger32(uint.Parse(value));
    public static implicit operator uint(UInteger32 value) => value.Value;
}

public class Integer64 : XsdClaimValueType<Integer64, long>
{
    public static Integer64 Instance => new Integer64();

    public Integer64() { }
    public Integer64(long value) => Value = value;

    public new const string _Name = "integer64";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;

    public static implicit operator Integer64(long value) => new Integer64(value);
    public static implicit operator Integer64(string value) => new Integer64(long.Parse(value));
    public static implicit operator long(Integer64 value) => value.Value;
}
public class UInteger64 : XsdClaimValueType<UInteger64, ulong>
{
    const string nonnegativeinteger = nameof(nonnegativeinteger);
    static readonly string[] _synonyms = new[] { $"{_LongUriPrefix}{_LongUriSeparator}{nonnegativeinteger}", $"{_ShortUriPrefix}{_ShortUriSeparator}{nonnegativeinteger}" }

    public static UInteger64 Instance => new UInteger64();

    public UInteger64() { }
    public UInteger64(ulong value) => Value = value;

    public new const string _Name = "uinteger64";
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" path="/value" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" path="/value" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" path="/value" />
    public override string ShortUriString => _ShortUriString;



    public static implicit operator UInteger64(ulong value) => new UInteger64(value);
    public static implicit operator UInteger64(string value) => new UInteger64(ulong.Parse(value));
    public static implicit operator ulong(UInteger64 value) => value.Value;
    public static implicit operator string(UInteger64 value) => value.StringValue;
}
