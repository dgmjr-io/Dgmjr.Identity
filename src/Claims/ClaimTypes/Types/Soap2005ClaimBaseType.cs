namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity;

internal static class Soap2005BaseClaimType
{
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { Value = value };
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(string stringValue) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { StringValue = stringValue };
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue };
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description };
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description, string? claimValueType) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description, ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = stringValue } : DgmjrCvt.String.Instance with { Value = stringValue } };
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description, string? claimValueType, string? uri) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description, ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = stringValue } : DgmjrCvt.String.Instance with { Value = stringValue }, Uri = uri.ToUri() };
    public static Soap2005BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description, string? claimValueType, @uri? uri) where TSelf : Soap2005BaseClaimType<TSelf, TValue> => Soap2005BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description, ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = stringValue } : DgmjrCvt.String.Instance with { Value = stringValue }, Uri = uri };

    /// <inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" />
    public const string _LongUriSeparator = Constants.DefaultLongUriSeparator;
    /// <inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" />
    public const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;
    /// <inheritdoc cref="Constants.soap" path="/value" />
    public new const string _ShortUriPrefix = Constants.soap;
    /// <inheritdoc cref="Constants.Soap2005Identity" path="/value" />
    public new const string _LongUriPrefix = Constants.Soap2005Identity;
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value>Soap2005BaseClaimType</value>
    public new const string _Name = nameof(Soap2005BaseClaimType);
}

public abstract class Soap2005BaseClaimType<TSelf, TValue> : ClaimType<TSelf, TValue>
    where TSelf : ClaimType<TSelf, TValue>
{
    /// <inheritdoc cref="Soap2005BaseClaimType._ShortUriSeparator" path="/value" />
    public new const string _ShortUriSeparator = Soap2005BaseClaimType._ShortUriSeparator;
    /// <inheritdoc cref="Soap2005BaseClaimType._LongUriSeparator" path="/value" />
    public new const string _LongUriSeparator = Soap2005BaseClaimType._LongUriSeparator;
    /// <inheritdoc cref="Soap2005BaseClaimType._ShortUriPrefix" path="/value" />
    public new const string _ShortUriPrefix = Constants.soap;
    /// <inheritdoc cref="Soap2005BaseClaimType._LongUriPrefix" path="/value" />
    public new const string _LongUriPrefix = Constants.Soap2005Identity;
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="Soap2005BaseClaimType._Name" path="/value" />
    public new const string _Name = Soap2005BaseClaimType._Name;


    /// <inheritdoc cref="_Name" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriPrefix" />
    public override string LongUriPrefix => _LongUriPrefix;
    /// <inheritdoc cref="_ShortUriPrefix" />
    public override string ShortUriPrefix => _ShortUriPrefix;
    /// <inheritdoc cref="_LongUriSeparator" />
    public override string LongUriSeparator => _LongUriSeparator;
    /// <inheritdoc cref="_ShortUriSeparator" />
    public override string ShortUriSeparator => _ShortUriSeparator;
    /// <inheritdoc cref="_LongUriString" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public override string ShortUriString => _ShortUriString;
}
