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

[GenerateEnumerationRecordStruct("ApplicationUserLoginProvider", "Dgmjr.Identity.Models")]
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

    [Uri("https://google.com")]
    Google = 3,

    [Uri("https://facebook.com")]
    Facebook = 4,

    [Uri("https://twitter.com")]
    Twitter = 5,

    [Uri("https://microsoft.com")]
    Microsoft = 6,

    [Uri("https://apple.com")]
    Apple = 7,

    [Uri("https://github.com")]
    GitHub = 8,

    [Uri("https://linkedin.com")]
    LinkedIn = 9,

    [Uri("https://instagram.com")]
    Instagram = 10,

    [Uri("https://discord.com")]
    Discord = 11,

    [Uri("https://twitch.com")]
    Twitch = 12,

    [Uri("https://yahoo.com")]
    Yahoo = 13,

    [Uri("https://amazon.com")]
    Amazon = 14,

    [Uri("https://spotify.com")]
    Spotify = 15,

    [Uri("https://reddit.com")]
    Reddit = 16,

    [Uri("https://stackoverflow.com")]
    StackOverflow = 17,

    [Uri("https://paypal.com")]
    PayPal = 18,

    [Uri("https://stripe.com")]
    Stripe = 19
}
