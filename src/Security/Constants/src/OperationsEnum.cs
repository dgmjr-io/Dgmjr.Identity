/*
 * OperationsEnum.cs
 *
 *   Created: 2023-01-03-12:33:03
 *   Modified: 2023-01-03-12:33:04
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Security.Enums;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

[GenerateEnumerationClass(nameof(Operations), "Dgmjr.Security"), Flags]
public enum Operations : byte
{
    [Display(Name = nameof(Create), Description = "Create a new resource", ShortName = "C")]
    [EnumMember(Value = nameof(Create))]
    Create = 1,

    [Display(Name = nameof(Read), Description = "Read a resource", ShortName = "R")]
    [EnumMember(Value = nameof(Read))]
    Read = 2,

    [Display(Name = nameof(Update), Description = "Update an existing resource", ShortName = "W")]
    [EnumMember(Value = nameof(Update))]
    Update = 4,

    [Display(Name = nameof(Delete), Description = "Delete an existing resource", ShortName = "D")]
    [EnumMember(Value = nameof(Delete))]
    Delete = 8,

    [Display(
        Name = nameof(All),
        Description = "Perform any/all operation(s) on a resource",
        ShortName = "A"
    )]
    [EnumMember(Value = nameof(All))]
    All = Create | Read | Update | Delete
}
