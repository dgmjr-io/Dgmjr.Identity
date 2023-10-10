using System.Security.AccessControl;

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
namespace Dgmjr.Identity.Models.Enums;

[GenerateEnumerationRecordClass("ApplicationUserLoginProvider", "Dgmjr.Identity.Models")]
public enum ApplicationUserLoginProvider
{
    [Uri("https://dgmjr.io/identity/login-provider/none")]
    None = 0,

    [Uri("https://dgmjr.io/identity/login-provider/any")]
    Any = -1,

    [Uri(TelegramBaseUri)]
    Telegram = 1,

    [Uri(SpId.BaseUri)]
    SendPulse = 2,

    [UriAttribute("https://google.com/")]
    Google = 3,

    [UriAttribute("https://facebook.com/")]
    Facebook = 4,

    [UriAttribute("https://twitter.com/")]
    Twitter = 5,

    [UriAttribute("https://microsoft.com/")]
    Microsoft = 6,

    [UriAttribute("https://apple.com/")]
    Apple = 7,

    [UriAttribute("https://github.com/")]
    GitHub = 8,

    [UriAttribute("https://linkedin.com/")]
    LinkedIn = 9,

    [UriAttribute("https://instagram.com/")]
    Instagram = 10,

    [UriAttribute("https://discord.com/")]
    Discord = 11,

    [UriAttribute("https://twitch.com/")]
    Twitch = 12,

    [UriAttribute("https://yahoo.com/")]
    Yahoo = 13,

    [UriAttribute("https://amazon.com/")]
    Amazon = 14,

    [UriAttribute("https://spotify.com/")]
    Spotify = 15,

    [UriAttribute("https://reddit.com/")]
    Reddit = 16,

    [UriAttribute("https://stackoverflow.com/")]
    StackOverflow = 17,

    [UriAttribute("https://paypal.com/")]
    PayPal = 18,

    [UriAttribute("https://stripe.com/")]
    Stripe = 19
}
