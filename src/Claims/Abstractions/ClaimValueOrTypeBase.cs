using System;
namespace Dgmjr.Identity;
using Claims.Abstractions;

public abstract class ClaimValueOrTypeBase : IClaimTypeOrValue, IEquatable<IClaimTypeOrValue>
{
    public const string LongUriPrefix = Constants.DefaultLongUriPrefix;
    public const string ShortUriPrefix = Constants.DefaultShortUriPrefix;
    public const string Name = Constants.DefaultClaimName;

    // Abstract properties
    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.Name { get; }
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.Description => Description;

    // Defined properties
    public virtual uri Uri => LongUriString;
    public virtual uri LongUri => LongUriString;
    public virtual uri ShortUri => ShortUriString;
    public const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";
    public const string LongUriSeparator = Constants.DefaultLongUriSeparator;
    public const string ShortUriSeparator = Constants.DefaultShortUriSeparator;
    public const string Description = $"A URI for representing a claim value or type in the {LongUriPrefix} namespace";


    // Methods
    public virtual bool Equals(IClaimTypeOrValue? other)
    {
        if (other is null)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        return Uri == other.Uri;
    }

    public override bool Equals(object? obj) => Equals(obj as IClaimTypeOrValue);

    public override int GetHashCode() => Uri.GetHashCode();

    // Operators
    public static bool operator ==(ClaimValueOrTypeBase? left, IClaimTypeOrValue? right) => Equals(left, right);
    public static bool operator !=(ClaimValueOrTypeBase? left, IClaimTypeOrValue? right) => !Equals(left, right);
    public static bool operator ==(IClaimTypeOrValue? left, ClaimValueOrTypeBase? right) => Equals(left, right);
    public static bool operator !=(IClaimTypeOrValue? left, ClaimValueOrTypeBase? right) => !Equals(left, right);
}
