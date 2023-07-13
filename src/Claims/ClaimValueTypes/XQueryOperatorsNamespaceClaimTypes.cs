// #pragma warning disable
// using System.ComponentModel.DataAnnotations;
// using Dgmjr.Identity;

// namespace Dgmjr.Identity.Claims.ClaimValueTypes;
// using Abstractions;

// /// <summary>A URI pattern for representing a claim type in the  http://www.w3.org/TR/2002/WD-xquery-operators-20020816 namespace</summary>
// public abstract class XQueryOperatorsNamespaceClaimTypes : ClaimValueType
// {
//     /// <summary>The name of the claim value type <inheritdoc cref="Name" path="/value" /></summary>
//     /// <value>xs</value>
//     protected const string ShortUriPrefix = "xquery";

//     protected const string LongUriPrefix = $"http://www.w3.org/TR/2002/WD-xquery-operators-20020816";

//     protected new const string _name = "";
//     protected const string _LongUriSeparator = "#";
//     protected const string _ShortUriSeparator = ":";

//     public override string LongUriPrefix => LongUriPrefix;

//     public override string ShortUriPrefix => ShortUriPrefix;

//     public override string Name => _Name;

//     public override string LongUriSeparator => LongUriSeparator;

//     public override string ShortUriSeparator => ShortUriSeparator;

//     public override string LongUriString => $"{_LongUriPrefix}{_LongUriSeparator}{_Name}";

//     public override string ShortUriString => $"{_ShortUriPrefix}{_ShortUriSeparator}{_Name}";
// }


// public class DayTimeDuration : XsdClaimValueType, IClaimValueType<DayTimeDuration>
// {
//     public static IClaimValueType Instance => new DayTimeDuration();

//     public DayTimeDuration() { }

//     public new const string _Name = "dayTimeDuration";

//     public override string Name => _Name;
//     type IClaimValueType.UnderlyingType => typeof(System.TimeSpan);
// }

// public class Duration : XQueryOperatorsNamespaceClaimTypes, IClaimValueType
// {
//     public static IClaimValueType Instance => new Duration();

//     public Duration() { }

//     public new const string _Name = "dayTimeDuration";

//     public override string Name => _Name;
//     override public System.Type UnderlyingType => typeof(System.TimeSpan);
// }


// public class YearMonthDuration : XQueryOperatorsNamespaceClaimTypes, IClaimValueType
// {
//     public static IClaimValueType Instance => new YearMonthDuration();

//     public YearMonthDuration() { }

//     public new const string _Name = "yearMonthDuration";

//     public override string Name => _Name;
//     override public System.Type UnderlyingType => typeof(System.TimeSpan);
// }


// public class Date : XQueryOperatorsNamespaceClaimTypes, IClaimValueType
// {
//     public static IClaimValueType Instance => new Date();

//     public Date() { }

//     public new const string _Name = "yearMonthDuration";

//     public override string Name => _Name;

// #if NET5_0_OR_GREATER
//     override public System.Type UnderlyingType => typeof(System.DateOnly);
// #else
//     override public System.Type UnderlyingType => typeof(System.DateTime);
// #endif
// }



// public class Time : XQueryOperatorsNamespaceClaimTypes, IClaimValueType
// {
//     public static IClaimValueType Instance => new Time();

//     public Time() { }

//     public new const string _Name = "yearMonthDuration";

//     public override string Name => _Name;
// #if NET5_0_OR_GREATER
//         override public System.Type UnderlyingType => typeof(System.TimeOnly);
// #else
//     override public System.Type UnderlyingType => typeof(System.DateTime);
// #endif
// }
