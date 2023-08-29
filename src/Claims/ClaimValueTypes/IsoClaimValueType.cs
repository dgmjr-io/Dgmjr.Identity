using System.Globalization;
using System.Linq.Expressions;

using Microsoft.VisualBasic;
/*
 * IsoClaimValueType.cs
 *
 *   Created: 2023-06-28-03:34:34
 *   Modified: 2023-06-28-03:34:34
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Claims.ClaimValueTypes;

using Dgmjr.Identity.Claims.Abstractions;

public static class IsoClaimValueType
{
    /// <value>urn:iso:std:iso</value>
    public const string _LongUriPrefixhe = "urn:iso:std:iso";
    /// <inheritdoc cref="_LongUriPrefix" path="/value" />
    public const string _ShortUriPrefix = _LongUriPrefix;
    public const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{{0}}";
    public const string _ShortUriString = _LongUriString;
}

public class IsoClaimValueType<TSelf, TValue> : ClaimValueType<TSelf, TValue>
    where TSelf : IsoClaimValueType<TSelf, TValue>, new()
    where TValue : notnull
{
    public new const string _LongUriPrefix = "urn:iso:std:iso";
    public new const string _ShortUriPrefix = _LongUriPrefix;
    public new const string _LongUriString = $"{_LongUriPrefix}{_LongUriSeparator}{{0}}";
    public new const string _ShortUriString = _LongUriString;

    /// <value><inheritdoc cref="ClaimValueType{TSelf, TValue}._LongUriPrefix" path="/value" /><inheritdoc cref="ClaimValueType{TSelf, TValue}._LongUriSeparator" path="/value" />{0}</value>
    public override string LongUriString => Format(_LongUriString, StringValue);
    public override string ShortUriString => LongUriString;

    public override string ToString() => LongUriString;
}
public class Language : IsoClaimValueType<Language, CultureInfo>
{
    public static Language Instance => new Language();

    public Language() { }

    public new const string _Name = "639-1";
    public new const string _LongUriString = $"{_LongUriPrefix}{_ShortUriSeparator}{_Name}{{0}}";

    public override string StringValue => Value.TwoLetterISOLanguageName;
    public override string LongUriString => global::System.String.Format(_LongUriString, Value.TwoLetterISOLanguageName);
    public override string ShortUriString => LongUriString;

    public override string ToString() => LongUriString;

    public static implicit operator Language(System.Globalization.CultureInfo cultureInfo) => new Language { Value = cultureInfo };
    public static implicit operator System.Globalization.CultureInfo?(Language language) => language.Value;
    public static implicit operator string(Language language) => language.Value.TwoLetterISOLanguageName;
    public static implicit operator Language(string language) => new Language { Value = new System.Globalization.CultureInfo(language?.Replace($"{_LongUriString}{_LongUriSeparator}", "")) };
    public static implicit operator Language(uri language) => new Language { Value = new System.Globalization.CultureInfo(language?.ToString()?.Replace($"{_LongUriString}{_LongUriSeparator}", "")) };
    public static implicit operator uri(Language language) => language.Uri;
}

public class Country : IsoClaimValueType<Country, string>
{
    public static Country Instance => new Country();

    public Country() { }

    public new const string _Name = "3166";
    public new const string _LongUriString = $"{IsoClaimValueType<Country, string>._LongUriPrefix}{IsoClaimValueType<Country, string>._LongUriSeparator}{_Name}{{0}}";
    public new const string _ShortUriString = $"{IsoClaimValueType<Country, string>._ShortUriPrefix}{IsoClaimValueType<Country, string>._ShortUriSeparator}{_Name}{{0}}";

    public override string LongUriString => Format(_LongUriString, Value);
    public override string ShortUriString => LongUriString;

    public override string ToString() => Value;

    public static implicit operator Country(string country) => new Country { Value = country };
    public static implicit operator string?(Country country) => country.ToString();
    public static implicit operator Country(uri country) => new Country { StringValue = country.ToString().Replace(_ShortUriPrefix + _ShortUriSeparator, "") };
    public static implicit operator uri?(Country country) => country.Uri;

    public override string StringValue { get => (string?)this ?? string.Empty; set => this.Value = value; }
}
