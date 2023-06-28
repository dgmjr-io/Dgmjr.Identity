#pragma warning disable
namespace Dgmjr.Identity.ClaimValueTypes;
using Dgmjr.Identity.ClaimValueTypes.Abstractions;
using System.ComponentModel.DataAnnotations;
using Dgmjr.Identity;

/// <summary>A URI pattern for representing a claim type in the  <inheritdoc cref="LongUriPrefix" path="/value" /> (<inheritdoc cref="ShortUriPrefix" path="/value" />) namespace</summary>
public abstract class XsdClaimValueType : ClaimValueType, IClaimValueType, IClaimTypeOrValue
{
    /// <summary>The name of the claim value type <inheritdoc cref="Name" path="/value" /></summary>
    /// <value>xs</value>
    public new const string ShortUriPrefix = "xs";
    /// <summary>The long URI prefix of the claim value type <inheritdoc cref="Name" path="/value" /></summary>
    /// <value>http://www.w3.org/2001/XMLSchema</value>
    public new const string LongUriPrefix = $"http://www.w3.org/2001/XMLSchema";

    /// <summary>
    /// The name of the claim value type <inheritdoc cref="Name" path="/value" />
    /// </summary>
    /// <value>claim</value>
    public new const string Name = Constants.DefaultClaimName;
    public new const string LongUriSeparator = "#";
    public new const string ShortUriSeparator = ":";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";
    public new const string Description = $"A claim value type that represents a(n) {Name} in the {LongUriPrefix} ({ShortUriPrefix}) namespace";

    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.Description => Description;
}


/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class String : XsdClaimValueType, IClaimValueType, IClaimValueType<String, string>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new String();

    public String() { }

    /// <value>string</value>
    public new const string Name = "string";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.String);
}
/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class Uri : ClaimValueType, IClaimValueType<Uri, uri>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Uri();

    public Uri() { }

    /// <value>anyUri</value>
    public new const string Name = "anyUri";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(uri);
}

/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class Double : XsdClaimValueType, IClaimValueType<Double, double>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Double();

    public Double() { }

    /// <value>double</value>
    public new const string Name = "double";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(double);
}


/// <summary>
/// A URI pattern for representing a(n) <inheritdoc cref="Name" path="/value" /> claim type in the http://www.w3.org/2001/XMLSchema (xs) namespace
/// </summary>
public class Decimal : XsdClaimValueType, IClaimValueType<Decimal, decimal>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Decimal();

    public Decimal() { }

    /// <value>decimal</value>
    public new const string Name = "decimal";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(decimal);
}

public class Boolean : XsdClaimValueType, IClaimValueType<Boolean, bool>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Boolean();

    public Boolean() { }

    public new const string Name = "boolean";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(bool);
}

public class DateTime : XsdClaimValueType, IClaimValueType<DateTime, System.DateTime>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new DateTime();

    public DateTime() { }

    public new const string Name = "dateTime";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.DateTime);
}
public class Date : XsdClaimValueType,
#if NET7_0_OR_GREATER
IClaimValueType<Date, DateOnly>,
#else
IClaimType<Date, DateTime>,
#endif
IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Date();

    public Date() { }
#if NET7_0_OR_GREATER
    public Date(DateOnly date) => Value = date;
    public Date(System.DateTime date) : this(new DateOnly(date)) { }
#else
    public Date(string date) : this(System.DateTime.TryParse(date, out var dt) ? dt : throw new InvalidCastException($"The string \"{date}\" was not recognized as a valid date.")) { }
    public Date(System.DateTime date) => Value = new System.DateTime(date.ToShortDateString());
#endif

    public new const string Name = "date";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
#if NET7_0_OR_GREATER
    type IClaimValueType.UnderlyingType => typeof(System.DateOnly);
#else
    type IClaimValueType.UnderlyingType => typeof(System.DateTime);
#endif

    public static implicit operator Date(System.DateTime date) => new Date(date);
    public static implicit operator Date(string date) => new Date(date);
#if NET7_0_OR_GREATER
    public static implicit operator Date(DateOnly date) => new Date(date);
#endif
}

public class DateTimeOffset : XsdClaimValueType, IClaimValueType<DateTimeOffset>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new DateTimeOffset();

    public DateTimeOffset() { }

    public new const string Name = "dateTimeOffset";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.DateTimeOffset);
}

public class Duration : XsdClaimValueType, IClaimValueType<Duration, System.TimeSpan>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Duration();

    public Duration() { }
    public Duration(System.TimeSpan timeSpan) => Value = timeSpan;
    public Duration(double timeSpan) : this(System.TimeSpan.FromMilliseconds(timeSpan));

    public new const string Name = "timeSpan";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.TimeSpan);

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

public class AnyUri : XsdClaimValueType, IClaimValueType<AnyUri>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new AnyUri();

    public AnyUri() { }
    public AnyUri(uri uri) => Value = uri;

    public new const string Name = "anyUri";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(uri);

    public static implicit operator AnyUri(uri uri) => new AnyUri(uri);
    public static implicit operator AnyUri(string uri) => new AnyUri(uri);
    public static implicit operator uri(AnyUri uri) => uri.Value;
    public static implicit operator string(AnyUri uri) => uri.Value.ToString();
}



public class Base64Binary : XsdClaimValueType, IClaimValueType<Base64Binary, byte[]>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Base64Binary();

    public Base64Binary() { }
    public Base64Binary(string base64Binary) : this(FromBase64String(base64Binary));
    public Base64Binary(byte[] byes) => Value = bytes;

    public new const string Name = "base64Binary";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(byte[]);

    public static implicit operator Base64Binary(string base64Binary) => new Base64Binary(base64Binary);
    public static implicit operator Base64Binary(byte[] bytes) => new Base64Binary(bytes);
    public static implicit operator string(Base64Binary base64Binary) => ToBase64String(base64Binary.Value);
    public static implicit operator byte[](Base64Binary base64Binary) => base64Binary.Value;
}


public class Base64Octet : XsdClaimValueType, IClaimValueType<Base64Octet>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Base64Octet();

    public Base64Octet() { }
    public Base64Binary(string base64Binary) : this(FromBase64String(base64Binary));
    public Base64Binary(byte[] byes) => Value = bytes;

    public new const string Name = "base64Octet";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(string);
    type IClaimValueType.UnderlyingType => typeof(byte[]);

    public static implicit operator Base64Octet(string base64Binary) => new Base64Binary(base64Binary);
    public static implicit operator Base64Octet(byte[] bytes) => new Base64Binary(bytes);
    public static implicit operator string(Base64Octet base64Binary) => ToBase64String(base64Binary.Value);
    public static implicit operator byte[](Base64Octet base64Binary) => base64Binary.Value;
}


public class HexBinary : XsdClaimValueType, IClaimValueType<HexBinary>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new HexBinary();

    public HexBinary() { }

    public new const string Name = "hexBinary";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(string);
}

public class Sid : XsdClaimValueType, IClaimValueType<Sid, System.Security.Principal.SecurityIdentifier>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Sid();

    public Sid() { }
    public Sid(System.Security.Principal.SecurityIdentifier sid) => Value = sid;

    public new const string Name = "sid";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(string);
}


public class Integer : XsdClaimValueType, IClaimValueType<Integer, int>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Integer();

    public Integer() { }

    public new const string Name = "integer";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(int);
}
public class Long : XsdClaimValueType, IClaimValueType<Long>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Integer();

    public Long() { }
    public Long(long value) => Value = value;

    public new const string Name = "long";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(int);

    public static implicit operator Long(long value) => new Long(value);
    public static implicit operator long(Long value) => value.Value;
}

public class ByteArray : XsdClaimValueType, IClaimValueType<ByteArray, byte[]>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new ByteArray();

    public ByteArray() { }
    public ByteArray(byte[] bytes) => Value = bytes;

    public new const string Name = "base64Binary";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(byte[]);

    public static implicit operator ByteArray(byte[] bytes) => new ByteArray(bytes);
    public static implicit operator byte[](ByteArray bytes) => bytes.Value;
}

public class Integer32 : XsdClaimValueType, IClaimValueType<Integer32, int>, IClaimTypeOrValue
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Integer32();

    public Integer32() { }
    public Integer32(int value) => Value = value;

    public new const string Name = "integer32";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(int);

    public static implicit operator Integer32(int value) => new Integer32(value);
    public static implicit operator int(Integer32 value) => value.Value;
}

public class UInteger32 : XsdClaimValueType, IClaimValueType<UInteger64, uint>, IClaimTypeOrValue, IClaimValueType
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new UInteger32();

    public UInteger32() { }
    public UInteger32(uint value) => Value = value;

    public new const string Name = "uinteger32";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(uint);

    public static implicit operator UInteger32(uint value) => new UInteger32(value);
    public static implicit operator uint(UInteger32 value) => value.Value;
}

public class Integer64 : XsdClaimValueType, IClaimValueType<Integer64>, IClaimTypeOrValue, IClaimValueType
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new Integer64();

    public Integer64() { }
    public Integer64(long value) => Value = value;

    public new const string Name = "integer64";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(long);

    public static implicit operator Integer64(long value) => new Integer64(value);
    public static implicit operator long(Integer64 value) => value.Value;
}
public class UInteger64 : XsdClaimValueType, IClaimValueType<UInteger64, ulong>, IClaimTypeOrValue, IClaimValueType
{
    public static Dgmjr.Identity.ClaimValueTypes.Abstractions.IClaimValueType Instance => new UInteger64();

    public UInteger64() { }
    public UInteger64(ulong value) => Value = value;

    public new const string Name = "uinteger64";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(ulong);

    public static implicit operator UInteger64(ulong value) => new UInteger64(value);
    public static implicit operator ulong(UInteger64 value) => value.Value;
}
