namespace Dgmjr.Identity.ClaimValueTypes;
using Dgmjr.Identity.ClaimValueTypes.Abstractions;

public abstract class ClaimValueType : ClaimValueOrTypeBase, IClaimValueType
{
    public new const string ShortUriSeparator = ":";
    public new const string LongUriSeparator = "/";
    public new const string ShortUriPrefix = $"{Constants.identity}{ShortUriSeparator}{Constants.claim}{ShortUriSeparator}{Constants.value}";
    public new const string LongUriPrefix = $"{Constants.Dgmjr_IO}{LongUriSeparator}{Constants.identity}{LongUriSeparator}{Constants.claim}{LongUriSeparator}{Constants.value}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string Name = "";

    type IClaimValueType.UnderlyingType => typeof(void);
    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    string IClaimTypeOrValue.LongUriString => LongUriString;
}
