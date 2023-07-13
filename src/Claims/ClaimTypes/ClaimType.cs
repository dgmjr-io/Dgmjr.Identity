namespace Dgmjr.Identity.Claims;

using System.Runtime.CompilerServices;
using Dgmjr.Identity.Claims.Abstractions;
using global::System;

public abstract class ClaimType : ClaimValueOrTypeBase, IClaimType
{
    public virtual string? StringValue { get; set; }

    public override int GetHashCode() => Uri.GetHashCode();
    public override bool Equals(object? obj) => Equals(obj as IClaimValueType);
    public static bool operator ==(ClaimType? left, IClaimType? right) => left is null ? right is null : left.Uri.Equals(right.Uri);
    public static bool operator ==(ClaimType? left, IClaimType? right) => left is null && right is not null || left is not null && right is null || !left.Uri.Equals(right.Uri);
}

public abstract class ClaimType<TSelf> : ClaimType, IClaimType<TSelf>
{
    public static TSelf Instance => Activator.CreateInstance<TSelf>();
    public static TSelf Create(string stringValue) => Instance with { StringValue = stringValue };
}

public abstract class ClaimType<TSelf, TValue> : ClaimType<TValue>, IClaimType<TSelf, TValue>
    where TSelf : class, IClaimType<TSelf, TValue>, new()
{
    public static TSelf Create(TValue value) => Instance with { Value = value };
}
