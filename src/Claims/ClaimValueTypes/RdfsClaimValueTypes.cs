using Microsoft.VisualBasic;
namespace Dgmjr.Identity.Claims.ClaimValueTypes;
using XE = System.Xml.Linq.XElement;
using Dgmjr.Identity.Claims.Abstractions;

public abstract class RdfsClaimValueType<TSelf, TValue> : ClaimValueType<TSelf, TValue>, IClaimValueType
    where TSelf : RdfsClaimValueType<TSelf, TValue>
{
    public new const string _LongUriPrefix = "https://www.w3.org/1999/02/22-rdf-syntax-ns";
    public new const string _ShortUriPrefix = "rdf";
    public new const string _LongUriSeparator = "#";
    public new const string _ShortUriSeparator = ":";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _Name = Dgmjr.Identity.Constants.value;
}


public class Json : RdfsClaimValueType<Json, JElem>
{
    public static Json Instance => new();

    public Json() { }

    public new const string _Name = "JSON";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";
    public new const string _ShortUriPrefix = RdfsClaimValueType<Json, JElem>._ShortUriPrefix;
    public new const string _LongUriPrefix = RdfsClaimValueType<Json, JElem>._LongUriPrefix;

    public new const string _ShortUriSeparator = RdfsClaimValueType<Json, JElem>._ShortUriPrefix;

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;
}

public class Xml : RdfsClaimValueType<Xml, XE>
{
    public static Xml Instance => new();

    public Xml() { }

    public new const string _Name = "XMLLiteral";
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string Name => _Name;
    public override string LongUriString => _LongUriString;
    public override string ShortUriString => _ShortUriString;


    public override string StringValue { get; set; }
    public override XE Value { get => XE.Parse(StringValue); set => StringValue = value.ToString(); }
}
