/*
 * UserContactId.cs
 *
 *   Created: 2023-03-19-03:05:09
 *   Modified: 2023-03-28-02:39:57
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

/*
 * UserContactId.cs
 *
 *   Created: 2022-12-10-09:51:26
 *   Modified: 2022-12-10-09:51:27
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Models;

using System;
using Dgmjr.Identity.Abstractions;

// /// <summary>A join entity between <see cref="Models.User" />s and <see cref="Models.Bot" />s</summary>
// public record UserContactId : IUserContactId
// {
//     [Key, DbGen(DbGen.Identity)]
//     public virtual int Id { get; set; }

//     [Hashids]
//     public virtual int UserId { get; set; }
//     [Hashids]
//     public virtual int BotId { get; set; }
//     public virtual ObjectId ContactId { get; set; }

//     public virtual Bot? Bot { get; set; }
//     public virtual User? User { get; set; }
// }

// public record UserContactIdInsertDto
// {
//     /// <summary>Gets or sets the user identifier.</summary>
//     [Hashids]
//     public int UserId { get; set; }
//     /// <summary>Gets or sets the bot's identifier.</summary>
//     [Hashids]
//     public int BotId { get; set; }
//     /// <summary>Gets or sets the users <see cref="ObjectId" /> unique to that <see cref="Models.Bot" />.</summary>
//     public ObjectId ContactId { get; set; }
// }
