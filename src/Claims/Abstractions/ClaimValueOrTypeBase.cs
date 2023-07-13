namespace Dgmjr.Identity.Claims.Abstractions;
using System;
using Claims.Abstractions;
using static Constants;

public abstract class ClaimValueOrTypeBase : IClaimTypeOrValue, IEquatable<IClaimTypeOrValue>
{
    /// <inheritdoc cref="DefaultLongUriPrefix"  />
    public const string _LongUriPrefix = DefaultLongUriPrefix;
    /// <inheritdoc cref="DefaultShortUriPrefix" />
    public const string _ShortUriPrefix = DefaultShortUriPrefix;
    /// <inheritdoc cref="DefaultClaimName" />
    public const string _Name = DefaultClaimName;
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" />
    public const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";
    /// <inheritdoc cref="DefaultLongUriSeparator" />
    public const string _LongUriSeparator = DefaultLongUriSeparator;
    /// <inheritdoc cref="DefaultShortUriSeparator" />
    public const string _ShortUriSeparator = DefaultShortUriSeparator;

    /// <value>A URI for representing a claim value or type in the <inheritdoc cref="_LongUriPrefix" path="/value" /> namespace</value>
    public const string _Description = $"A URI for representing a claim value or type in the {_LongUriPrefix} namespace";

    // Abstract properties
    /// <inheritdoc cref="_LongUriPrefix" />
    public virtual string LongUriPrefix => _LongUriPrefix;
    /// <inheritdoc cref="_ShortUriPrefix" />
    public virtual string ShortUriPrefix => _ShortUriPrefix;
    /// <inheritdoc cref="_Name"  />
    public virtual string Name => _Name;
    /// <inheritdoc cref="_LongUriSeparator"  />
    public virtual string LongUriSeparator => _LongUriSeparator;
    /// <inheritdoc cref="_ShortUriSeparator" />
    public virtual string ShortUriSeparator => _ShortUriSeparator;
    /// <inheritdoc cref="_LongUriString" />
    public virtual string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public virtual string ShortUriString => _ShortUriString;
    /// <inheritdoc cref="_Description" />
    public virtual string Description => _Description;

    public override string ToString() => LongUriString;

    private string[] _synonyms;
    /// <summary>
    /// A list of synonyms for the <see cref="LongUriString" /> and <see cref="ShortUriString" /> properties
    /// </summary>
    public virtual string[] Synonyms
    {
        get => _synonyms ??= new[] { LongUriString, ShortUriString }.Distinct().ToArray();
        init => _synonyms = value;
    }

    /// Defined properties
    /// <inheritdoc cref="_LongUriString" />
    public virtual uri Uri => LongUri;
    /// <inheritdoc cref="_LongUriString" />
    public virtual uri LongUri => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" />
    public virtual uri ShortUri => _ShortUriString;

    // override object.Equals
    public override bool Equals(object? obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        if (obj is IClaimTypeOrValue ictov)
        {
            return this.Equals(ictov);
        }
        return base.Equals(obj);
    }

    public virtual bool Equals(IClaimTypeOrValue? other)
    {
        return Uri.Equals(other.Uri);
    }

    // override object.GetHashCode
    public override int GetHashCode() => Uri.GetHashCode();
}
