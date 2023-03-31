/*
 * UserLoginProviderEnum.cs
 *
 *   Created: 2022-12-03-11:03:25
 *   Modified: 2022-12-03-11:03:25
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

extern alias DgmjrCm;
namespace Dgmjr.Identity.Models;

[GenerateEnumerationRecordClass("UserLoginProvider", "Dgmjr.Identity.Models")]
public enum UserLoginProviderEnum
{
    [DgmjrCm.System.ComponentModel.DataAnnotations.Uri(DgmjrCt.UnknownLoginProvider)]
    None = 0,
    [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute(DgmjrCt.UnknownLoginProvider)]
    Any = -1,
    [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute(global::Telegram.Identity.ClaimTypeNames.BaseUri)]
    Telegram = 1,
    [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute(SpId.BaseUri)]
    SendPulse = 2

    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://google.com/")]
    // Google = 3,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://facebook.com/")]
    // Facebook = 4,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://twitter.com/")]
    // Twitter = 5,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://microsoft.com/")]
    // Microsoft = 6,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://apple.com/")]
    // Apple = 7,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://github.com/")]
    // GitHub = 8,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://linkedin.com/")]
    // LinkedIn = 9,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://instagram.com/")]
    // Instagram = 10,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://discord.com/")]
    // Discord = 11,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://twitch.com/")]
    // Twitch = 12,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://yahoo.com/")]
    // Yahoo = 13,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://amazon.com/")]
    // Amazon = 14,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://spotify.com/")]
    // Spotify = 15,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://reddit.com/")]
    // Reddit = 16,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://stackoverflow.com/")]
    // StackOverflow = 17,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://paypal.com/")]
    // PayPal = 18,
    // [DgmjrCm.System.ComponentModel.DataAnnotations.UriAttribute("https://stripe.com/")]
    // Stripe = 19
}
