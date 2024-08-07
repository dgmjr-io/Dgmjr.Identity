/*
 * UserLoginProvider.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-05:36:42
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity.Models;

using System.Text;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using Dgmjr.Abstractions;
using Dgmjr.Enumerations.Abstractions;
using Dgmjr.Identity.Abstractions;
using Dgmjr.Identity.Models;
using Dgmjr.Identity.Models.Abstractions;
using static Dgmjr.Identity.Models.Enums.UserLoginProvider;

public class UserLoginProviderConverter : ValueConverter<IUserLoginProvider, string>
{
    public UserLoginProviderConverter()
        : base(v => v.ShortName, v => UserLoginProvider.Parse(v)) { }
}

public class UserLoginProviderJsonConverter : JsonConverter<IUserLoginProvider>
{
    public override IUserLoginProvider Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var value = reader.GetInt32();
        return UserLoginProvider.FromId(value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        IUserLoginProvider value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(((IIdentifiable<int>)value).Id);
    }
}

// public partial record class UserLoginProvider //: Dgmjr.Enumerations.EnumerationClass<UserLoginProvider, int, UserLoginProviderEnum>
// {
//     //     public static readonly UserLoginProvider Any = new(0, UserLoginProviderEnum.None, nameof(Any));
//     //     public static readonly UserLoginProvider Telegram = new(1, UserLoginProviderEnum.Telegram, nameof(Telegram));
//     //     public static readonly UserLoginProvider Google = new(2, UserLoginProviderEnum.Google, nameof(Google));
//     //     public static readonly UserLoginProvider Facebook = new(3, UserLoginProviderEnum.Facebook, nameof(Facebook));
//     //     public static readonly UserLoginProvider Twitter = new(4, UserLoginProviderEnum.Twitter, nameof(Twitter));
//     //     public static readonly UserLoginProvider Microsoft = new(5, UserLoginProviderEnum.Microsoft, nameof(Microsoft));

//     //     public UserLoginProvider(int id, UserLoginProviderEnum value, string name) : base(id, value, name) { }
// }

// // using Backroom.Data.Models;
// // using Humanizer;

// // namespace Backroom.Identity.Models
// // {
// //     //[Table(nameof(UserLoginProvider))]
// //     public class UserLoginProvider : Entity<UserLoginProviderEnum>, IHaveAnId<UserLoginProviderEnum>
// //     {
// //         //public UserLoginProvider(UserLoginProviderEnum id, string name) : base((byte)id, name) { }
// //         //public UserLoginProvider() : base() { }//this(default, default) { }

// //         //[Key, Column(ColId)/*, DbGen(Computed)*/]
// //         //public virtual UserLoginProviderEnum Value
// //         //{
// //         //    get => (UserLoginProviderEnum)Id;
// //         //    set => Id = (byte)(object)value;
// //         //}

// //         // public static readonly IEnumerable<UserLoginProvider> All = new[] { Telegram, Any, Google, Facebook, Twitter, Microsoft }!;

// //         // [Key, Column(ColId)]
// //         //public override byte Id { get => base.Id; protected set => base.Id = value; }

// //         //public static readonly UserLoginProvider Telegram = new UserLoginProvider(TelegramLoginProvider, nameof(Telegram));
// //         //public static readonly UserLoginProvider Any = new UserLoginProvider(AnyLoginProvider, nameof(Any));
// //         //public static readonly UserLoginProvider Google = new UserLoginProvider(GoogleLoginProvider, nameof(Google));
// //         //public static readonly UserLoginProvider Facebook = new UserLoginProvider(FacebookLoginProvider, nameof(Facebook));
// //         //public static readonly UserLoginProvider Twitter = new UserLoginProvider(TwitterLoginProvider, nameof(Twitter));
// //         //public static readonly UserLoginProvider Microsoft = new UserLoginProvider(MicrosoftLoginProvider, nameof(Microsoft));

// //         //public static implicit operator UserLoginProvider(UserLoginProviderEnum @enum)
// //         //    => @enum switch
// //         //    {
// //         //        AnyLoginProvider => Any,
// //         //        TelegramLoginProvider => Telegram,
// //         //        GoogleLoginProvider => Google,
// //         //        FacebookLoginProvider => Facebook,
// //         //        TwitterLoginProvider => Twitter,
// //         //        MicrosoftLoginProvider => Microsoft,
// //         //        _ => throw new ArgumentException(nameof(@enum), "The value was not recognized.")
// //         //    };

// //         //public static implicit operator UserLoginProviderEnum(UserLoginProvider provider) => provider.Value;

// //         //public static implicit operator UserLoginProvider(string name)
// //         //    => name switch
// //         //    {
// //         //        nameof(Any) => Any,
// //         //        nameof(Telegram) => Telegram,
// //         //        nameof(Google) => Google,
// //         //        nameof(Facebook) => Facebook,
// //         //        nameof(Twitter) => Twitter,
// //         //        nameof(Microsoft) => Microsoft,
// //         //        _ => new UserLoginProvider(byte.MinValue, name)
// //         //    };

// //         //public static implicit operator string(UserLoginProvider provider) => provider.Name;

// //         //public static implicit operator byte(UserLoginProvider provider) => provider.Id;
// //         //public static implicit operator UserLoginProvider(byte id) => (UserLoginProvider)(UserLoginProviderEnum)(object)id;
// //     }
// // }
