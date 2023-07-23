namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity;

internal static class MicrosoftSoap2008BaseClaimType
{
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { Value = value };
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(string stringValue) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { StringValue = stringValue };
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue };
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description };
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description, string? claimValueType) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description, ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = stringValue } : DgmjrCvt.String.Instance with { Value = stringValue } };
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description, string? claimValueType, string? uri) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description, ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = stringValue } : DgmjrCvt.String.Instance with { Value = stringValue }, Uri = uri.ToUri() };
    public static MicrosoftSoap2008BaseClaimType<TSelf, TValue> Create<TSelf, TValue>(TValue value, string stringValue, string? description, string? claimValueType, @uri? uri) where TSelf : MicrosoftSoap2008BaseClaimType<TSelf, TValue> => MicrosoftSoap2008BaseClaimType<TSelf, TValue>.Instance with { Value = value, StringValue = stringValue, Description = description, ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = stringValue } : DgmjrCvt.String.Instance with { Value = stringValue }, Uri = uri };

    /// <inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" />
    public const string _LongUriSeparator = Constants.DefaultLongUriSeparator;
    /// <inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" />
    public const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;
    /// <inheritdoc cref="Constants.soap" path="/value" />
    public new const string _ShortUriPrefix = Constants.soap;
    /// <inheritdoc cref="Constants.Microsoft2008Identity" path="/value" />
    public new const string _LongUriPrefix = Constants.Microsoft2008Identity;
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value>MicrosoftSoap2008BaseClaimType</value>
    public new const string _Name = nameof(MicrosoftSoap2008BaseClaimType);
}

public abstract class MicrosoftSoap2008BaseClaimType<TSelf, TValue> : ClaimType<TSelf, TValue>
    where TSelf : ClaimType<TSelf, TValue>
{
    /// <inheritdoc cref="MicrosoftSoap2008BaseClaimType._ShortUriSeparator" path="/value" />
    public new const string _ShortUriSeparator = MicrosoftSoap2008BaseClaimType._ShortUriSeparator;
    /// <inheritdoc cref="MicrosoftSoap2008BaseClaimType._LongUriSeparator" path="/value" />
    public new const string _LongUriSeparator = MicrosoftSoap2008BaseClaimType._LongUriSeparator;
    /// <inheritdoc cref="MicrosoftSoap2008BaseClaimType._ShortUriPrefix" path="/value" />
    public new const string _ShortUriPrefix = Constants.soap;
    /// <inheritdoc cref="MicrosoftSoap2008BaseClaimType._LongUriPrefix" path="/value" />
    public new const string _LongUriPrefix = Constants.Microsoft2008Identity;
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="MicrosoftSoap2008BaseClaimType._Name" path="/value" />
    public new const string _Name = MicrosoftSoap2008BaseClaimType._Name;


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
