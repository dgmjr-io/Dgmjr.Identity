using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
namespace Dgmjr.Identity.Claims.Abstractions;


public interface IClaimValueType<TSelf, TValue> : IClaimValueType<TSelf>, IHaveAWritableValue<TValue>
    where TSelf : class, IClaimValueType<TSelf, TValue>
    where TValue : notnull
{
#if NET7_0_OR_GREATER
    public static virtual TSelf Create(TValue value) { var instance = TSelf.Instance; instance.Value = value; return instance; }
#endif
}

public interface IClaimValueType<TSelf> : IClaimValueType
    where TSelf : class, IClaimValueType<TSelf>
{
#if NET7_0_OR_GREATER
    public static virtual TSelf Instance => Activator.CreateInstance<TSelf>() as TSelf ?? throw new InvalidOperationException($"Unable to create instance of {typeof(TSelf).FullName}");
    public static virtual TSelf Create(string stringValue) { var instance = TSelf.Instance; instance.StringValue = stringValue; return instance; }
#endif
}

public interface IClaimValueType : IClaimTypeOrValue
{
    string? StringValue { get; set; }
    // #if NET7_0_OR_GREATER
    //     public static abstract IClaimType Instance { get; }
    //     public static abstract IClaimType Create(string stringValue);
    // #endif
}
