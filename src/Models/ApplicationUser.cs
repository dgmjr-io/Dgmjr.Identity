/*
 * User.cs
 *
 *   Created: 2022-12-01-04:59:06
 *   Modified: 2022-12-03-11:30:01
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dgmjr.Identity.Models;

using System.Collections.ObjectModel;
using System.Domain;
using System.Net.Mail;
using System.Xml.Serialization;
using Dgmjr.Abstractions;
using Dgmjr.Identity.Abstractions;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

using static System.Guid;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using static Dgmjr.Identity.EntityFrameworkCore.UriMaxLengthConstant;

[Table(Constants.TableNames.User, Schema = IdentitySchema.ShortName)]
[DebuggerDisplay("User ({UserName} - {Email})")]
public class ApplicationUser<TKey>
    : IIdentityUser<
        ApplicationUser<TKey>,
        ApplicationRole<TKey>,
        TKey,
        ApplicationUserClaim<TKey>,
        ApplicationUserRole<TKey>,
        ApplicationUserLogin<TKey>,
        ApplicationRoleClaim<TKey>,
        ApplicationUserToken<TKey>
    >,
        IHaveClaims<TKey>,
        IHaveUserClaims<
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
    public const string DefaultPassword = "Dav1d is really fuckin' sexy 123!";
    public const string DefaultLockoutEndString = "1/1/1970";
    public static readonly DateTimeOffset DefaultLockoutEnd = DateTimeOffset.Parse(
        DefaultLockoutEndString
    );

    public ApplicationUser()
    {
        LockoutEnd = DefaultLockoutEnd;
    }

    public TKey Id { get; set; }

    public virtual string? TelegramUsername { get; set; }

    [StringLength(Account.UsernameMaxLength, MinimumLength = Account.UsernameMinLength)]
    public virtual string? Username { get; set; }

    public virtual string? GivenName { get; set; } = null;

    public virtual string? Surname { get; set; } = null;

    public virtual string? GoByName { get; set; } = null;

    [DefaultValue(0)]
    public virtual int AccessFailedCount { get; set; } = 0;

    [DefaultValue(true), Column(nameof(IsLockoutEnabled))]
    public virtual bool IsLockoutEnabled { get; set; } = true;

    [DefaultValue(false), Column(nameof(IsEmailConfirmed))]
    public virtual bool IsEmailConfirmed { get; set; } = false;

    [DefaultValue(false), Column(nameof(IsPhoneNumberConfirmed))]
    public virtual bool IsPhoneNumberConfirmed { get; set; } = false;

    [DefaultValue(false), Column(nameof(IsTwoFactorEnabled))]
    public virtual bool IsTwoFactorEnabled { get; set; } = false;

    [DefaultValue(false), Column(nameof(IsLockedOut)), DbGen(DbGen.Computed)]
    public virtual bool IsLockedOut => IsLockoutEnabled && LockoutEnd > DateTimeOffset.Now;

    [DefaultValue(DefaultLockoutEndString)]
    public virtual DateTimeOffset? LockoutEnd { get; set; } = DefaultLockoutEnd;

    public virtual EmailAddress EmailAddress { get; set; }

    public virtual PhoneNumber PhoneNumber { get; set; }

    public virtual string? NormalizedEmailAddress
    {
        get => EmailAddress.ToString()?.Normalize(NormalizationForm.FormKD);
        set
        { /* no op */
        }
    }

    public virtual string? NormalizedUsername
    {
        get => Username.Normalize(NormalizationForm.FormKD);
        set
        { /* no op */
        }
    }

    public virtual IGender Gender { get; set; }

    public override bool Equals(object? obj) =>
        obj
            is IIdentityUser<
                ApplicationUser<TKey>,
                ApplicationRole<TKey>,
                TKey,
                ApplicationUserClaim<TKey>,
                ApplicationUserRole<TKey>,
                ApplicationUserLogin<TKey>,
                ApplicationRoleClaim<TKey>,
                ApplicationUserToken<TKey>
            > user
        && obj is IIdentifiable<long> userId
        && userId.Id.Equals(Id);

    public override int GetHashCode() => Id.GetHashCode();

    public virtual string ConcurrencyStamp { get; set; } =
        Guid.NewGuid().ToByteArray().ToHexString();

    public virtual string? PasswordHash { get; set; } = null;

    [Column(TypeName = "uniqueidentifier")]
    public virtual string SecurityStamp { get; set; } = NewGuid().ToString();

    /// <summary>The roles to which the user belongs</summary>
    public virtual ICollection<ApplicationRole<TKey>> Roles { get; set; } =
        new Collection<ApplicationRole<TKey>>();

    /// <summary>The user's logins for various federated providers</summary>
    public virtual ICollection<ApplicationUserLogin<TKey>> Logins { get; set; } =
        new Collection<ApplicationUserLogin<TKey>>();

    /// <summary>The user's tokens</summary>
    public virtual ICollection<ApplicationUserToken<TKey>> Tokens { get; set; } =
        new Collection<ApplicationUserToken<TKey>>();

    /// <summary>The user's claims</summary>
    public virtual ICollection<ApplicationUserClaim<TKey>> Claims { get; set; } =
        new Collection<ApplicationUserClaim<TKey>>();

    // /// <summary>The user's bots by <see cref="UserContactId.UserContactId" /></summary>
    // public virtual ICollection<Bot> Bots { get; set; } = new Collection<Bot>();
    // /// <summary>A join entity between <see cref="User" />s and <see cref="Bot" />s</summary>
    // public virtual ICollection<UserContactId> ContactIds { get; set; } = new Collection<UserContactId>();
    /// <summary>A join entity between <see cref="User" />s and <see cref="TblRole" />s</summary>
    public virtual ICollection<ApplicationUserRole<TKey>> UserRoles { get; set; } =
        new Collection<ApplicationUserRole<TKey>>();
    public virtual ICollection<ApplicationClaimType<TKey>> ClaimTypes { get; set; } =
        new Collection<ApplicationClaimType<TKey>>();

    //public virtual ICollection<BackroomUserRole> UserRoles { get; set; } = new ObservableCollection<BackroomUserRole>();

    ICollection<C> IHaveClaims<TKey>.Claims
    {
        get => Claims.Select(c => c.ToClaim()).ToArray();
        set { }
    }

    public virtual bool IsBot =>
        ClaimTypes.Any(ct => ct.Uri == Telegram.Identity.ClaimTypes.BotApiToken.UriString);
}

public class ApplicationUser : ApplicationUser<long> { }

public record class ApplicationUserInsertDto<TKey> : ApplicationUserDto<TKey>
{
    /// <summary>Gets or sets the user's password.</summary>
    /// <example>My$3cre1Pa$$w0rd!</example>
    public string? Password { get; set; } = ApplicationUser<long>.DefaultPassword;
}

public record class ApplicationUserInsertDto : ApplicationUserInsertDto<long> { }

public record class ApplicationUserDto<TKey>
{
    public virtual string? UserName { get; set; }
    public virtual string? GivenName { get; set; }
    public virtual string? Surname { get; set; }
    public virtual string? GoByName { get; set; }
    public virtual PhoneNumber? PhoneNumber { get; set; }
    public virtual string? TelegramUsername { get; set; }
    public virtual TKey Id { get; set; }
    public EmailAddress? EmailAddress { get; set; }
}

public record class ApplicationUserDto : ApplicationUserDto<long> { }

// //[AutoGenerateBuilder(typeof(BackroomUser))]
// //public partial class BackroomUserBuilder { }
