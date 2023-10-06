/*
 * RoleClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-01-05:35:10
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Identity.Models;

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Dgmjr.Abstractions;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;
using static Dgmjr.EntityFrameworkCore.Constants.DbTypeNames;
using static Dgmjr.EntityFrameworkCore.Constants.Schemas;
using static Dgmjr.Identity.EntityFrameworkCore.UriMaxLengthConstant;

[DebuggerDisplay("Role Claim ({Id} Role ID: {RoleId}, {Type}: {Value})")]
[JSerializable(typeof(ApplicationRoleClaim))]
public class ApplicationRoleClaim : IIdentityRoleClaim<long>
{
    public virtual long Id { get; set; }

    [Hashids]
    public virtual long RoleId { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "A value must be specified.")]
    public virtual string? ClaimValue { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "A claim type name must be specified.")]
    public virtual string? ClaimType { get; set; }

    [Url, Required]
    public virtual uri? Type { get; set; } = DgmjrCt.String.Uri;

    [Url, Required]
    public virtual uri? ValueType { get; set; } = System.uri.From(DgmjrCvt.);

    [Column(nameof(Issuer), TypeName = DbTypeNVarChar), Url, StringLength(UriMaxLength), Required]
    public virtual uri? Issuer { get; set; } = System.uri.From(DgmjrCt.BaseUri);

    [
        Column(nameof(OriginalIssuer), TypeName = DbTypeNVarChar),
        Url,
        StringLength(UriMaxLength),
        Required
    ]
    public virtual uri? OriginalIssuer { get; set; } = System.uri.From(DgmjrCt.BaseUri);

    [Column(nameof(Properties), TypeName = DbTypeNVarChar), StringLength(UriMaxLength), XmlIgnore]
    public virtual IStringDictionary Properties { get; set; } = new StringDictionary();

    public virtual Role? Role { get; set; }
    public long EntityId
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public string? Value
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    // int IEntityClaim.EntityId { get => UserId; set => UserId = value; }

    public virtual void InitializeFromClaim(C? claim)
    {
        Type = claim.Type.CreateUri(DgmjrCt.GenericClaimTypePattern)!;
        ClaimValue = claim.Value;
        Issuer = claim.Issuer.CreateUri(DgmjrCt.GenericClaimsIssuerTypePattern)!;
        OriginalIssuer = claim.OriginalIssuer.CreateUri(DgmjrCt.GenericClaimsIssuerTypePattern)!;
        Properties = claim.Properties;
        ValueType = claim.ValueType.CreateUri(DgmjrCvt.Namespaces)!;
        RoleId = claim.Properties.ContainsKey(nameof(RoleId))
            ? int.Parse(claim.Properties[nameof(RoleId)])
            : default;
        Id = claim.Properties.ContainsKey(nameof(Id))
            ? int.Parse(claim.Properties[nameof(Id)])
            : default;
    }

    public virtual C ToClaim()
    {
        var claim = new C(
            Type.ToString(),
            ClaimValue,
            ValueType?.ToString(),
            Issuer.ToString(),
            OriginalIssuer.ToString()
        );
        claim.Properties[nameof(RoleId)] = RoleId.ToString();
        claim.Properties[nameof(Id)] = Id.ToString();
        return claim;
    }

    public static ApplicationRoleClaim FromClaim(int roleId, C c)
    {
        var userClaim = new ApplicationRoleClaim();
        userClaim.InitializeFromClaim(c);
        userClaim.RoleId = roleId;
        return userClaim;
    }

    public static implicit operator C(ApplicationRoleClaim claim) => claim.ToClaim();

    public static implicit operator ApplicationRoleClaim(C claim)
    {
        var newClaim = new ApplicationRoleClaim();
        newClaim.InitializeFromClaim(claim);
        return newClaim;
    }

    //         public Timestamp Created { get; set; }
    //         public Timestamp LastUpdated { get; set; }
    //         public Timestamp? Deleted { get; set; }
}

public struct RoleClaimInsertDto
{
    public RoleClaimInsertDto() => Properties = new StringDictionary();

    [Required, Url, StringLength(UriMaxLength)]
    public Uri Type { get; set; }

    [Required, Url, StringLength(UriMaxLength)]
    public Uri ValueType { get; set; }

    [StringLength(256)]
    public string? Value { get; set; }

    [Required, Url, StringLength(UriMaxLength)]
    public Uri Issuer { get; set; }

    [Required, Url, StringLength(UriMaxLength)]
    public Uri OriginalIssuer { get; set; }

    [Required]
    public StringDictionary Properties { get; set; } = new StringDictionary();
}
