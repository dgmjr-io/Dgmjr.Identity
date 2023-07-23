namespace Dgmjr.Identity.Claims.ClaimValueTypes;
using System.Runtime.Serialization.Json;
using XE = System.Xml.Linq.XElement;
using Dgmjr.Identity.Claims.Abstractions;
using static RdfsClaimValueType;

internal static class RdfsClaimValueType
{
    /// <value>https://www.w3.org/1999/02/22-rdf-syntax-ns</value>
    public new const string _LongUriPrefix = "https://www.w3.org/1999/02/22-rdf-syntax-ns";
    /// <value>rdf</value>
    public new const string _ShortUriPrefix = "rdf";
    /// <value>#</value>
    public new const string _LongUriSeparator = "#";
    /// <value>:</value>
    public new const string _ShortUriSeparator = ":";
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";
    /// <inheritdoc cref="Dgmjr.Identity.Constants.value" path="/value" />
    public new const string _Name = Dgmjr.Identity.Constants.value;
}

public abstract class RdfsClaimValueType<TSelf, TValue> : ClaimValueType<TSelf, TValue>
    where TSelf : RdfsClaimValueType<TSelf, TValue>
    where TValue : notnull
{
}


public class Json : RdfsClaimValueType<Json, JElem>
{
    public static Json Instance => new();

    public Json() { }

    /// <value>JSON</value>
    public new const string _Name = "JSON";
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    public override string StringValue { get => Value.ToString(); set => base.Value = JDoc.Parse(value).RootElement; }

    /// <inheritdoc cref="_Name" path="/value" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" path="/value" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" path="/value" />
    public override string ShortUriString => _ShortUriString;
}

public class Xml : RdfsClaimValueType<Xml, XE>
{
    public static Xml Instance => new();

    public Xml() { }

    /// <value>XMLLiteral</value>
    public new const string _Name = "XMLLiteral";
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="_LongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="_ShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";

    /// <inheritdoc cref="_Name" path="/value" />
    public override string Name => _Name;
    /// <inheritdoc cref="_LongUriString" path="/value" />
    public override string LongUriString => _LongUriString;
    /// <inheritdoc cref="_ShortUriString" path="/value" />
    public override string ShortUriString => _ShortUriString;


    public override string StringValue { get; set; }
    public override XE Value { get => XE.Parse(StringValue); set => StringValue = value.ToString(); }
}
