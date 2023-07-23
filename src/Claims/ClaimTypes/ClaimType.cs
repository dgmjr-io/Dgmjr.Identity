using System.Security.Claims;
namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity.Claims.ClaimValueTypes;
using System.Runtime.CompilerServices;
using Dgmjr.Identity.Claims.Abstractions;
using global::System;
using System.Security;

public class ClaimType : ClaimType<ClaimType>
{
    public ClaimType(string? uri, string? description = null, string? claimValueType = null, string? value = null) : this(uri.ToUri(), description, claimValueType?.ToUri()!, value) { }
    public ClaimType(@uri? uri, string? description = null, @uri? claimValueType = null, string? value = null)
    {
        Uri = uri;
        Description = description;
        ValueType = claimValueType != null ? new ClaimValueType { Uri = claimValueType, Value = value } : DgmjrCvt.String.Instance with { Value = value };
    }

    public new virtual uri Uri { get; set; }
    public new virtual string LongUriString => Uri;
    public new virtual string ShortUriString => Uri;
    public new virtual string Description { get; set; }
    public new virtual string? StringValue { get; set; }
    public new virtual ClaimValueType ValueType { get; set; }
}

public abstract class ClaimType<TSelf> : ClaimValueOrTypeBase, IClaimType
{
    public static TSelf Instance => Activator.CreateInstance<TSelf>();
    public static TSelf Create(string stringValue) => Instance with { StringValue = stringValue };
    public virtual string? StringValue { get; set; }

    public override int GetHashCode() => Uri.GetHashCode();
    public override bool Equals(object? obj) => Equals(obj as IClaimValueType);
    public static bool operator ==(ClaimType? left, IClaimType? right) => left is null ? right is null : left.Uri.Equals(right.Uri);
    public static bool operator ==(ClaimType? left, IClaimType? right) => left is null && right is not null || left is not null && right is null || !left.Uri.Equals(right.Uri);
}

public abstract class ClaimType<TSelf, TClaimValueType> : ClaimType<TSelf>
    where TClaimValueType : ClaimValueType
{
    public virtual TClaimValueType Value { get => (TClaimValueType)StringValue; set => StringValue = value.ToString(); }
}

public abstract class ClaimType<TSelf, TClaimValueType, TNativeValue> : ClaimType<TSelf, TClaimValueType>
    where TSelf : class, IClaimType<TSelf, TNativeValue>, new()
{
    public static TSelf Create(TNativeValue value) => Instance with { Value = value };
}
