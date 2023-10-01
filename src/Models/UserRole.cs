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
using static Dgmjr.EntityFrameworkCore.Constants.DbTypeNames;
using static Dgmjr.EntityFrameworkCore.Constants.Schemas;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

/// <summary>A join entity between <see cref="User" />s and <see cref="Role" />s</summary>
[
    Table(TableNames.UserRole, Schema = IdSchema),
    DebuggerDisplay("User Role ({Id} - User ID: {UserId}, Role: {Role})")
]
[JSerializable(typeof(UserRole))]
public class UserRole : IdentityUserRole<long>, IIdentifiable<int> //, IUserAssociatedEntity//, IHaveTimestamps
{
    [Key, DbGen(DbGen.None), Column(nameof(Id), TypeName = DbTypeInt)]
    public virtual int Id { get; set; } //= NewId;

    [Column(nameof(RoleId), Order = 2, TypeName = DbTypeInt)]
    public override long RoleId
    {
        get => base.RoleId;
        set => base.RoleId = value;
    }

    [Column(nameof(UserId), Order = 1, TypeName = DbTypeInt)]
    public override long UserId
    {
        get => base.UserId;
        set => base.UserId = value;
    }

    public User User { get; set; }
    public Role Role { get; set; }

    //[ForeignKey(ColUserId)]
    //public virtual BackroomUser User { get; set; }

    //[ForeignKey(nameof(RoleId))]
    //public virtual BackroomRole Role { get; set; }


    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }
}

public struct UserRoleInsertDto
{
    public long UserId { get; set; }
    public long RoleId { get; set; }
}
