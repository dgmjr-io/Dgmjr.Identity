/*
 * ApplicationUserClaim.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-03-01:07:46
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using AutoMapper;
using Dgmjr.Abstractions;
using Dgmjr.Identity.Abstractions;

using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Dgmjr.Identity.Models;

using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using static Dgmjr.Identity.EntityFrameworkCore.UriMaxLengthConstant;

[Table(TblUserClaim, Schema = IdentitySchema.ShortName)]
[DebuggerDisplay("User Claim ({Id} - User ID: {UserId}, {Type}: {Value})")]
[JSerializable(typeof(ApplicationUserClaim))]
public class ApplicationUserClaim<TKey>
    : EntityClaim<ApplicationUserClaim<TKey>, ApplicationUser<TKey>, TKey>,
        IIdentityUserClaim<
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            TKey,
            ApplicationUserClaim<TKey>,
            ApplicationUserRole<TKey>,
            ApplicationUserLogin<TKey>,
            ApplicationRoleClaim<TKey>,
            ApplicationUserToken<TKey>
        >
    where TKey : IEquatable<TKey>, IComparable
{
    public static implicit operator ApplicationUserClaim<TKey>(C claim) =>
        FromClaim(claim) as ApplicationUserClaim<TKey>;

    public ApplicationUser<TKey> User
    {
        get => Entity;
        set => Entity = value;
    }

    public virtual TKey UserId
    {
        get => EntityId;
        set => EntityId = value;
    }
}

public class ApplicationUserClaim : ApplicationUserClaim<long> { }

public record struct ApplicationUserClaimCreateDto
{
    public ApplicationUserClaimCreateDto()
    {
        Type = DgmjrCt.Unknown.UriString;
        Issuer = DgmjrIo;
        ValueType = DgmjrCvt.String.UriString;
        Value = string.Empty;
    }

    /// <summary>The value of the claim</summary>
    /// <example>Justin</example>
    /// <remarks>See <see href="https://learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimvaluetypes?view=net-8.0">Claim.Value</see> for more information.</remarks>
    /// <default />
    public string Value { get; set; } = string.Empty;

    /// <summary>The type of the claim</summary>
    /// <example>http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name</example>
    /// <remarks>See <see href="https://learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimvaluetypes?view=net-8.0">ClaimTypes</see> for more information.</remarks>
    /// <default><inheritdoc cref="DgmjrCt.Unknown.UriString" path="/value/text()" /></default>
    public uri? Type { get; set; } = DgmjrCt.Unknown.UriString;

    /// <summary>The issuer of the claim</summary>
    /// <example><inheritdoc cref="DgmjrIo" path="/value" /></example>
    /// <remarks>See <see href="https://learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimvaluetypes?view=net-8.0">Claim.Issuer</see> for more information.</remarks>
    /// <default><inheritdoc cref="DgmjrIo" path="/value/text()" /></default>
    public uri? Issuer { get; set; } = DgmjrIo;

    /// <summary>The type of the claim's value</summary>
    /// <example>http://www.w3.org/2001/XMLSchema#string</example>
    /// <remarks>See <see href="https://learn.microsoft.com/en-us/dotnet/api/system.security.claims.claimvaluetypes?view=net-8.0">ClaimValueType</see> for more information.</remarks>
    /// <default><inheritdoc cref="DgmjrCvt.String.UriString" path="/value/text()" /></default>
    public uri? ValueType { get; set; } = DgmjrCvt.String.UriString;
}
