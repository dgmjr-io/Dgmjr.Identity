/*
 * Operation.cs
 *
 *   Created: 2023-01-03-12:33:03
 *   Modified: 2023-01-03-12:33:04
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Security;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

[GenerateEnumerationRecordStruct(nameof(Operations), "Dgmjr.Security")]
public enum OperationsEnum
{
    [Display(Name = "Create", Description = "Create a new resource"), EnumMember(Value = "Create")]
    Create,
    [Display(Name = "Read", Description = "Read a resource"), EnumMember(Value = "Read")]
    Read,
    [Display(Name = "Update", Description = "Update an existing resource"), EnumMember(Value = "Update")]
    Update,
    [Display(Name = "Delete", Description = "Delete an eixsting resource"), EnumMember(Value = "Delete")]
    Delete
}
