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

namespace Dgmjr.Identity.ClaimValueTypes;
using Abstractions;

public abstract class IsoClaimValueType : ClaimValueType, IClaimTypeOrValue, IClaimValueType
{
    public new const string LongUriPrefix = "urn:iso:std:iso";
    public new const string ShortUriPrefix = LongUriPrefix;
    public new const string LongUriSeparator = ":";
    public new const string ShortUriSeparator = LongUriSeparator;
    public new const string ShortUriString = $"{ShortUriPrefix}{ShortUriSeparator}{Name}";
    public new const string LongUriString = $"{LongUriPrefix}{LongUriSeparator}{Name}";
    public new const string Name = "value";
}

public class Language : IsoClaimValueType, IClaimTypeOrValue, IClaimValueType<Language>
{
    public static IClaimValueType Instance => new Language();

    public Language() { }

    public new const string Name = "language";
    public new const string LongUriString = $"{IsoClaimValueType.LongUriPrefix}{IsoClaimValueType.LongUriSeparator}{Name}";
    public new const string ShortUriString = $"{IsoClaimValueType.ShortUriPrefix}{IsoClaimValueType.ShortUriSeparator}{Name}";

    string IClaimTypeOrValue.Name => Name;
    string IClaimTypeOrValue.LongUriString => LongUriString;
    string IClaimTypeOrValue.ShortUriString => ShortUriString;
    type IClaimValueType.UnderlyingType => typeof(System.Globalization.CultureInfo);
}
