namespace Dgmjr.Identity.Claims;
using Dgmjr.Identity;

public abstract class Soap2005ClaimBaseType : ClaimType, IClaimTypeOrValue
{
    public new const string ShortUriSeparator = Constants.DefaultShortUriSeparator;
    public new const string LongUriSeparator = Constants.DefaultLongUriSeparator;
    public new const string ShortUriPrefix = Constants.soap;
    public new const string LongUriPrefix = Constants.Soap2005Identity;
    public new const string Name = Constants.DefaultClaimName;
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriPrefix => LongUriPrefix;
    string IClaimTypeOrValue.ShortUriPrefix => ShortUriPrefix;
    string IClaimTypeOrValue.LongUriSeparator => LongUriSeparator;
    string IClaimTypeOrValue.ShortUriSeparator => ShortUriSeparator;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
}
