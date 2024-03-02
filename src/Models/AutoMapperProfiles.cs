// /*
//  * AutoMapperProfiles.cs
//  *
//  *   Created: 2022-12-15-08:17:45
//  *   Modified: 2022-12-15-08:17:45
//  *
//  *   Author: David G. Moore, Jr. <david@dgmjr.io>
//  *
//  *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
//  *      License: MIT (https://opensource.org/licenses/MIT)
//  */

// using Dgmjr.Identity.Models;

// namespace Dgmjr.Identity.AutoMapper;

// public class AutoMapperProfile : global::AutoMapper.Profile
// {
//     public AutoMapperProfile( /*IPasswordHasher<User> passwordHasher*/
//     )
//     {
//         // this.CreateMap<SendPulse.Telegram.WebhookMessage, User>()
//         //     .ForMember(u => u.PasswordHash, mcex => mcex.MapFrom((msg, u) => passwordHasher.HashPassword(u, User.DefaultPassword)))
//         //     .ForMember(u => u.TelegramId, mcex => mcex.MapFrom(msg => msg.Contact.LastMessageData.ChatId!.Value))
//         //     .ForMember(u => u.FirstName, mcex => mcex.MapFrom((msg, u) => u.FirstName ?? msg.Contact.Name))
//         //     .ForMember(u => u.TelegramUsername, mcex => mcex.MapFrom((msg, u) => u.TelegramUsername ?? msg.Contact.Username));

//         CreateMap<ApplicationUser, UserDto>()
//             .ForMember(dto => dto.PhoneNumber, mcex => mcex.MapFrom(u => u.PhoneNumber))
//             .ForMember(dto => dto.EmailAddress, mcex => mcex.MapFrom(u => u.EmailAddress))
//             .ReverseMap();
//         CreateMap<UserInsertDto, ApplicationUser>()
//             .ForMember(u => u.PhoneNumber, mcex => mcex.MapFrom(dto => dto.PhoneNumber))
//             .ForMember(u => u.EmailAddress, mcex => mcex.MapFrom(dto => dto.EmailAddress))
//             .ReverseMap();
//         CreateMap<ApplicationUserClaim, C>().ConvertUsing(uc => uc.ToClaim());
//         CreateMap<C, ApplicationUserClaim>().ConvertUsing(c => c.ToUserClaim());
//         CreateMap<RoleInsertDto, ApplicationRole>().ReverseMap();
//         CreateMap<ClaimCreateDto, ApplicationUserClaim>()
//             .ForMember(uc => uc.Type, mcex => mcex.MapFrom(dto => dto.Type))
//             .ForMember(uc => uc.Value, mcex => mcex.MapFrom(dto => dto.Value))
//             .ReverseMap();
//         CreateMap<ClaimCreateDto, C>()
//             .ForMember(c => c.Type, mcex => mcex.MapFrom(dto => dto.Type))
//             .ForMember(c => c.Value, mcex => mcex.MapFrom(dto => dto.Value))
//             .ReverseMap();
//     }
// }
