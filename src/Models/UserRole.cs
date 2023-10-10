/*
 * UserRole.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-05-03:50:21
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity.Models;

using Abstractions;
using Dgmjr.Abstractions;
using Microsoft.AspNetCore.Identity;

/// <summary>A join entity between <see cref="User" />s and <see cref="Role" />s</summary>
[Table(Constants.TableNames.TblUserRole, Schema = IdentitySchema.ShortName)]
[DebuggerDisplay("User Role ({Id} - User ID: {UserId}, Role: {Role})")]
public class ApplicationUserRole : IIdentityUserRole<long>
{
    [Key, DbGen(DbGen.Identity), Column(TypeName = DbTypeBigInt.ShortName)]
    public virtual long Id { get; set; }

    [Column(nameof(RoleId), Order = 2, TypeName = DbTypeBigInt.ShortName)]
    public virtual long RoleId { get; set; }

    [Column(nameof(UserId), Order = 1, TypeName = DbTypeBigInt.ShortName)]
    public virtual long UserId { get; set; }

    public ApplicationUser User { get; set; }
    public ApplicationRole Role { get; set; }

    //[ForeignKey(ColUserId)]
    //public virtual BackroomUser User { get; set; }

    //[ForeignKey(nameof(RoleId))]
    //public virtual BackroomRole Role { get; set; }


    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }
}

public struct ApplicationUserUserRoleInsertDto
{
    public long UserId { get; set; }
    public long RoleId { get; set; }
}
