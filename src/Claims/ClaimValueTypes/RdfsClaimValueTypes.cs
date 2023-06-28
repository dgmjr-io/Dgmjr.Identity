using Microsoft.VisualBasic;
namespace Dgmjr.Identity.ClaimValueTypes;
using Dgmjr.Identity.ClaimValueTypes.Abstractions;

public abstract class RdfsClaimValueType : ClaimValueOrTypeBase, IClaimValueType
{
    public new const string LongUriPrefix = "https://www.w3.org/1999/02/22-rdf-syntax-ns";
    public new const string ShortUriPrefix = "rdf";
    public new const string LongUriSeparator = "#";
    public new const string ShortUriSeparator = ":";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string Name = Dgmjr.Identity.Constants.value;

    type IClaimValueType.UnderlyingType => typeof(void);
}


public class Json : RdfsClaimValueType, IClaimValueType<Json>
{
    public static IClaimValueType Instance => new Json();

    public Json() { }

    public new const string Name = "JSON";
    public new const string LongUriString = $"{RdfsClaimValueType.LongUriPrefix}{RdfsClaimValueType.LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{RdfsClaimValueType.ShortUriPrefix}{RdfsClaimValueType.ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Text.Json.JsonElement);
}

public class Xml : RdfsClaimValueType, IClaimValueType<Json>
{
    public static IClaimValueType Instance => new Json();

    public Xml() { }

    public new const string Name = "XMLLiteral";
    public new const string LongUriString = $"{RdfsClaimValueType.LongUriPrefix}{RdfsClaimValueType.LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{RdfsClaimValueType.ShortUriPrefix}{RdfsClaimValueType.ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Xml.XDocument);
}
