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
    public new const string LongUriSeparator = Constants.DefaultLongUriSeparator;
    public new const string ShortUriSeparator = Constants.DefaultShortUriSeparator;
    public new const string LongUriPrefix = $"{Constants.Dgmjr_IO}{DefaultLongUriSeparator}{Constants.identity}{DefaultLongUriSeparator}{Constants.claim}";
    public new const string ShortUriPrefix = $"{Constants.Dgmjr}{DefaultShortUriSeparator}{Constants.identity}{DefaultShortUriSeparator}{Constants.claim}";
}
