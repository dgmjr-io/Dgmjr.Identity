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

using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Domain;
using static System.Guid;
using System.Net.Mail;
using System.Xml.Serialization;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore;

using Dgmjr.Abstractions;
using Dgmjr.Identity.Abstractions;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.UriMaxLengthConstant;

using Humanizer;
using Telegram.Bot.Types;

[Table(EntityFrameworkCore.Constants.TableNames.User, Schema = IdentitySchema.ShortName)]
[DebuggerDisplay($"User ({{{nameof(Username)}}} - {{{nameof(EmailAddress)}}})")]
[Comment("A user is a person who can be authenticated.")]
public class ApplicationUser<TKey>
    : ApplicationIdentityEntity<TKey>,
        IIdentityUser<
            ApplicationUser<TKey>,
            ApplicationRole<TKey>,
            TKey,
            ApplicationUserClaim<TKey>,
            ApplicationUserRole<TKey>,
            ApplicationUserLogin<TKey>,
            ApplicationRoleClaim<TKey>,
            ApplicationUserToken<TKey>
        >,
        IIdentityUser<TKey, ApplicationUser<TKey>, ApplicationRole<TKey>>,
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
    private readonly IPasswordHasher<ApplicationUser<TKey>>? _passwordHasher;

    public ApplicationUser()
    {
        LockoutEnd = DefaultLockoutEnd;
    }

    private ApplicationUser(IPasswordHasher<ApplicationUser<TKey>> passwordHasher)
    {
        _passwordHasher = passwordHasher;
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

    [DefaultValue(false)]
    [Column(nameof(IsLockedOut))]
    [BackingField(nameof(_isLockedOut))]
    [Projectable]
    public virtual bool IsLockedOut => IsLockoutEnabled && LockoutEnd > DateTimeOffset.Now;
    private bool _isLockedOut = false;

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

    public virtual Gender Gender { get; set; }

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

    // public virtual string ConcurrencyStamp { get; } = guid.NewGuid().ToByteArray().ToHexString();

    public virtual string? Password
    {
        set => PasswordHash = _passwordHasher.HashPassword(this, value);
    }

    public virtual string? PasswordHash { get; private set; } = null;

    // [Column(TypeName = "uniqueidentifier")]
    // public virtual string SecurityStamp { get; } = NewGuid().ToString();

    /// <summary>The roles to which the user belongs</summary>
    public virtual ICollection<ApplicationRole<TKey>> Roles { get; } =
        new Collection<ApplicationRole<TKey>>();

    /// <summary>The user's logins for various federated providers</summary>
    public virtual ICollection<ApplicationUserLogin<TKey>> Logins { get; } =
        new Collection<ApplicationUserLogin<TKey>>();

    /// <summary>The user's tokens</summary>
    public virtual ICollection<ApplicationUserToken<TKey>> Tokens { get; } =
        new Collection<ApplicationUserToken<TKey>>();

    /// <summary>The user's claims</summary>
    // public virtual ICollection<ApplicationUserClaim<TKey>> Claims { get; } =
    //     new Collection<ApplicationUserClaim<TKey>>();

    public virtual ICollection<ApplicationUserRole<TKey>> UserRoles { get; } =
        new Collection<ApplicationUserRole<TKey>>();
    public virtual ICollection<ApplicationClaimType<TKey>> ClaimTypes { get; } =
        new Collection<ApplicationClaimType<TKey>>();

    public virtual ICollection<ApplicationUserClaim<TKey>> UserClaims { get; } =
        new Collection<ApplicationUserClaim<TKey>>();

    [NotMapped]
    public ICollection<C> Claims
    {
        get => UserClaims.Select(c => c.ToClaim()).ToArray();
    }

    private Lazy<bool> _isBot = default!;
    private Lazy<bool> LazyIsBot =>
        _isBot ??= new(
            () => ClaimTypes.Any(ct => ct.Uri == Telegram.Identity.ClaimTypes.BotApiToken.UriString)
        );

    [Projectable]
    public virtual bool IsBot =>
        ClaimTypes.Any(ct => ct.Uri == Telegram.Identity.ClaimTypes.BotApiToken.UriString);

    [Projectable]
    public virtual BotApiToken BotToken =>
        (BotApiToken)
            UserClaims
                .FirstOrDefault(
                    c =>
                        c.Type.Equals(Telegram.Identity.ClaimTypes.BotApiToken.UriString)
                        && c.Value != null
                )
                ?.Value;
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
