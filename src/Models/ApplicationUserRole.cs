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

/// <summary>A join entity between <see cref="User" />s and <see cref="Role"
/// />s</summary>
[Table(EntityFrameworkCore.Constants.TableNames.UserRole,
       Schema = IdentitySchema.ShortName)]
[DebuggerDisplay("User Role ({Id} - User ID: {UserId}, Role: {Role})")]
public class ApplicationUserRole<TKey>
    : ApplicationIdentityEntity<TKey>,
      IIdentityUserRole<ApplicationUser<TKey>, ApplicationRole<TKey>, TKey,
                        ApplicationUserClaim<TKey>, ApplicationUserRole<TKey>,
                        ApplicationUserLogin<TKey>, ApplicationRoleClaim<TKey>,
                        ApplicationUserToken<TKey>>
    where TKey : IEquatable<TKey>, IComparable {
  [Key, DbGen(DbGen.Identity), Column(TypeName = BigInt.ShortName)]
  public virtual TKey Id { get; set; }

  [Column(nameof(RoleId), Order = 2, TypeName = BigInt.ShortName)]
  public virtual TKey RoleId { get; set; }

  [Column(nameof(UserId), Order = 1, TypeName = BigInt.ShortName)]
  public virtual TKey UserId { get; set; }

  public ApplicationUser<TKey> User { get; set; }
  public ApplicationRole<TKey> Role { get; set; }

  //[ForeignKey(ColUserId)]
  // public virtual BackroomUser User { get; set; }

  //[ForeignKey(nameof(RoleId))]
  // public virtual BackroomRole Role { get; set; }

  //         public Timestamp Created { get; set; }
  //         public Timestamp LastUpdated { get; set; }
  //         public Timestamp? Deleted { get; set; }
}

public class ApplicationUserRole : ApplicationUserRole<long> {}

public record class ApplicationUserUserRoleInsertDto<TKey> {
  public long UserId { get; set; }
  public long RoleId { get; set; }
}

public record class ApplicationUserUserRoleInsertDto
    : ApplicationUserUserRoleInsertDto<long> {}
