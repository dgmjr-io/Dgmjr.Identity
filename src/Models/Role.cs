/*
 * BackroomRole.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-04:59:07
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Models;
using System;
using System.Collections.ObjectModel;
using Dgmjr.Abstractions;
using Microsoft.AspNetCore;
using static System.Guid;
using static Dgmjr.EntityFrameworkCore.Constants.Schemas;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using static Dgmjr.Identity.EntityFrameworkCore.UriMaxLengthConstant;

[Table(TableNames.Role, Schema = IdSchema), DebuggerDisplay("Role ({Id} - {Name} {Uri})")]
[JSerializable(typeof(Role))]
public partial class Role : IdentityRole<long>, IIdentifiable<long>
{
    public const string RoleUriDefaultFormatString = "urn:role:{0}";

    [Key, DbGen(DbGen.Identity), Hashids]
    public override long Id { get; set; } //= NewId;

    [Column(nameof(ConcurrencyStamp), TypeName = DbTypeRowVersion), DbGen(DbGen.Computed)]
    public override string? ConcurrencyStamp { get; set; } = NewGuid().ToString();

    [StringLength(Telegram.Constants.Account.UsernameMaxLength)]
    public override string? Name { get => base.Name ??= Uri?.ToString(); set { base.Name = value; Uri = value.ToUri(); NormalizedName = value.Normalize(); } }

    [StringLength(UriMaxLength)]
    public override string? NormalizedName { get => base.NormalizedName = base.Name.Normalize(); set => base.NormalizedName = value.Normalize(); }
    public string Description { get; set; } = string.Empty;

    private uri? _uri;
    [Column(nameof(Uri)), StringLength(UriMaxLength)]
    public virtual uri? Uri { get => _uri ??= Name.ToUri() ?? uri.From(Format(RoleUriDefaultFormatString, Name)); set => _uri = value; }

    public virtual ICollection<User> Users { get; set; } = new Collection<User>();
    public virtual ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
}

public struct RoleInsertDto
{
    public RoleInsertDto() : this(string.Empty, string.Empty) { }
    public RoleInsertDto(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
