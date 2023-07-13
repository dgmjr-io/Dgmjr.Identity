namespace Dgmjr.Identity.Claims.ClaimValueTypes;
using Dgmjr.Identity.Claims.Abstractions;

/// <summary>
/// Represents the base class for claim value types.
/// </summary>
/// <typeparam name="TValue">The underlying value type.</typeparam>
public abstract partial class ClaimValueType<TSelf, TValue> : ClaimValueOrTypeBase
    where TSelf : ClaimValueType<TSelf, TValue>
    where TValue : notnull
{
    /// <summary>
    /// The short URI separator.
    /// </summary>
    public new const string _ShortUriSeparator = ":";

    /// <summary>
    /// The long URI separator.
    /// </summary>
    public new const string _LongUriSeparator = "/";

    /// <summary>
    /// The short URI prefix.
    /// </summary>
    public new const string _ShortUriPrefix = $"{Constants.identity}{_ShortUriSeparator}{Constants.identity}{_ShortUriSeparator}{Constants.claim}{_ShortUriSeparator}{Constants.value}";

    /// <summary>
    /// The long URI prefix.
    /// </summary>
    public new const string _LongUriPrefix = $"{Constants.Dgmjr_IO}{_LongUriSeparator}{Constants.claim}{_LongUriSeparator}{Constants.value}";

    /// <summary>
    /// The short URI string.
    /// </summary>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <summary>
    /// The long URI string.
    /// </summary>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";

    /// <summary>
    /// The name.
    /// </summary>
    public new const string _Name = "";

    public virtual string StringValue { get => Value.ToString(); set => Convert.ChangeType(value, typeof(TValue)); }
    public virtual TValue Value { get; set; }

    public override string Name => _Name;
    public override string ShortUriPrefix => _ShortUriPrefix;
    public override string LongUriPrefix => _LongUriPrefix;
    public override string ShortUriSeparator => _ShortUriSeparator;
    public override string LongUriSeparator => _LongUriSeparator;
    public override string ShortUriString => _ShortUriString;
    public override string LongUriString => _LongUriString;

    public static TSelf Create(string s)
    {
        var @new = Activator.CreateInstance<TSelf>();
        @new.StringValue = s;
        return @new;
    }

    public static TSelf Create(TValue value)
    {
        var @new = Activator.CreateInstance<TSelf>();
        @new.Value = value;
        return @new;
    }
}
