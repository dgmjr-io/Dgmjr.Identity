namespace Dgmjr.Identity.Claims.Abstractions;
using Dgmjr.Identity.Claims.Abstractions;
public interface IClaimType : IClaimTypeOrValue
{
}

public interface IClaimType<T> : IClaimType
    where T : IClaimType<T>, new()
{
#if NET7_0_OR_GREATER
    public static virtual IClaimType<T> Instance => new T();
#endif
}
