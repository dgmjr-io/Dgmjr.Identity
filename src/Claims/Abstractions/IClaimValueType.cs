using System;
namespace Dgmjr.Identity.ClaimValueTypes.Abstractions;
using Dgmjr.Identity.Claims.Abstractions;

public interface IClaimValueType : IClaimTypeOrValue
{
    object? Value { get; set; }

#if NET7_0_OR_GREATER
    /// <summary>
    /// The underlying data type of the claim value.
    /// </summary>
    public abstract static type UnderlyingType { get; }
#else
    /// <summary>
    /// The underlying data type of the claim value.
    /// </summary>
    type UnderlyingType { get; }
#endif
}

/// <summary>
/// Represents a claim value type.
/// </summary>
/// <typeparam name="TSelf">The type of the claim value type</typeparam>
/// <typeparam name="TUnderlyingType">The underlying data type of the claim value</typeparam>
public interface IClaimValueType<TSelf, TUnderlyingType> : IClaimValueType
    where TSelf : class, IClaimValueType<TSelf, TUnderlyingType>, new()
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Retrieves an instance of the claim value type.
    /// </summary>
    public static virtual IClaimValueType<TSelf, TUnderlyingType> Instance => new TSelf();

    /// <summary>Retieves the underlying data type of the claim value.</summary>
    public static virtual type UnderlyingType => typeof(TUnderlyingType);

    object? IClaimValueType.Value { get => Value; set { var newValue = System.Convert.ChangeType(value,  typeof(TUnderlyingType?)); Value  = newValue == null ? default : (TUnderlyingType)newValue; } }

    public TUnderlyingType? Value { get; set; }
#else
    object? IClaimValueType.Value { get; set; }
    TUnderlyingType? Value { get; set; }
#endif
}
