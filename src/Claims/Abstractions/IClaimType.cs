namespace Dgmjr.Identity.Claims.Abstractions;
using Dgmjr.Abstractions;
public interface IClaimType<TClaimType, TValue> : IClaimType<TClaimType>, IHaveAWritableValue<TValue>
    where TClaimType : class, IClaimType<TClaimType, TValue>
    where TValue : notnull
{
#if NET7_0_OR_GREATER
    public static virtual TClaimType Create(TValue value) { var instance = TClaimType.Instance; instance.Value = value; return instance; }
#endif
}

public interface IClaimType<TClaimType> : IClaimType
    where TClaimType : class, IClaimType<TClaimType>
{
#if NET7_0_OR_GREATER
    public static virtual TClaimType Instance => Activator.CreateInstance<TClaimType>() as TClaimType ?? throw new InvalidOperationException($"Unable to create instance of {typeof(TClaimType).FullName}");
    public static virtual TClaimType Create(string stringValue) { var instance = TClaimType.Instance; instance.StringValue = stringValue; return instance; }
#endif
}

public interface IClaimType : IClaimTypeOrValue
{
    string? StringValue { get; set; }
    // #if NET7_0_OR_GREATER
    //     public static abstract IClaimType Instance { get; }
    //     public static abstract IClaimType Create(string stringValue);
    // #endif
}
