using System.Security.Claims;
namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity;

public abstract class Soap2009BaseClaimType<TSelf, TValue> : ClaimType<TSelf, TValue>
    where TSelf : ClaimType<TSelf, TValue>
{
    /// <inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" />
    public new const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;
    /// <inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" />
    public new const string _LongUriSeparator = Constants.DefaultLongUriSeparator;
    /// <inheritdoc cref="Constants.soap" path="/value" />
    public new const string _ShortUriPrefix = Constants.soap;
    /// <inheritdoc cref="Constants.Soap2009Identity" path="/value" />
    public new const string _LongUriPrefix = Constants.Soap2009Identity;
    /// <inheritdoc cref="Constants.DefaultClaimName" path="/value" />
    public new const string _Name = Constants.DefaultClaimName;
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

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
