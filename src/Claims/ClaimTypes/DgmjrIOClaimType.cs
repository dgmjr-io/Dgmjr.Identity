/* 
 * DgmjrClaims.cs
 * 
 *   Created: 2023-03-19-03:04:51
 *   Modified: 2023-03-25-01:55:21
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace Dgmjr.Identity.Claims;

public abstract class DgmjrIOClaimType : ClaimType
{
    /// <inheritdoc cref="Constants.DefaultLongUriSeparator" />
    public new const string _LongUriSeparator = Constants.DefaultLongUriSeparator;
    /// <inheritdoc cref="Constants.DefaultShortUriSeparator" />
    public new const string _ShortUriSeparator = Constants.DefaultShortUriSeparator;
    /// <value><inheritdoc cref="Constants.Dgmjr_IO" path="/value" /><inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" /><inheritdoc cref="Constants.identity" path="/value" /><inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" /><inheritdoc cref="Constants.claims" path="/value" /></value>
    public new const string _LongUriPrefix = $"{Constants.Dgmjr_IO}{Constants.DefaultLongUriSeparator}{Constants.identity}{Constants.DefaultLongUriSeparator}{Constants.claims}";
    /// <value><inheritdoc cref="Constants.Dgmjr" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Constants.identity" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="Constants.claims" path="/value" /></value>
    public new const string _ShortUriPrefix = $"{Constants.Dgmjr}{Constants.DefaultShortUriSeparator}{Constants.identity}{Constants.DefaultShortUriSeparator}{Constants.claims}";
    /// <value><inheritdoc cref="_LongUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultLongUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _LongUriString = $"{_LongUriString}{Constants.DefaultLongUriSeparator}{_Name}";
    /// <value><inheritdoc cref="_ShortUriPrefix" path="/value" /><inheritdoc cref="Constants.DefaultShortUriSeparator" path="/value" /><inheritdoc cref="_Name" path="/value" /></value>
    public new const string _ShortUriString = $"{_ShortUriString}{Constants.DefaultShortUriSeparator}{_Name}";

    /// <value><inheritdoc cref="Constants.claim" path="/value" /></value>
    public new const string _Name = Constants.claim;

    /// <inheritdoc cref="_LongUriString" path="/value" />
    public override string LongUriString => base.LongUriString;

    /// <inheritdoc cref="_ShortUriString" path="/value" />
    public override string ShortUriString => base.ShortUriString;
}
