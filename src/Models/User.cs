/* 
 * User.cs
 * 
 *   Created: 2023-03-19-03:05:09
 *   Modified: 2023-03-28-02:51:52
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

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
using static System.Guid;
using static Dgmjr.EntityFrameworkCore.Constants.DbTypeNames;
using static Dgmjr.EntityFrameworkCore.Constants.Schemas;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using static Dgmjr.Identity.EntityFrameworkCore.UriMaxLengthConstant;

[Table(TableNames.User, Schema = IdSchema), DebuggerDisplay("User ({UserName} - {Email})")/*, AutoGenerateBuilder*/]
[JSerializable(typeof(User))]
public class User : IdentityUser<long>, IIdentifiable<long>, IUser, IHaveUserClaims, IHaveClaims//, IHaveTimestamps
{
    public const string DefaultPassword = "Just1n is really fuckin sexy!";
    public const string DefaultLockoutEndString = "1/1/1970";
    public static readonly DateTimeOffset DefaultLockoutEnd = DateTimeOffset.Parse(DefaultLockoutEndString);

    public User()
    {
        LockoutEnd = DefaultLockoutEnd;
    }

    /// <summary>Gets or sets the user's Telegram ID 64, a-bit signed integer</summary>
    /// <example>1234567</example>
    public override long Id { get => base.Id; set => base.Id = value; }
    /// <inheritdoc cref="IBasicUserInfo.TelegramUsername" />
    public virtual string? TelegramUsername { get; set; }

    /// <inheritdoc cref="IBasicUserInfo.GivenName" />
    public virtual string? GivenName { get; set; } = null;
    /// <inheritdoc cref="IBasicUserInfo.Surname" />
    public virtual string? Surname { get; set; } = null;
    /// <inheritdoc cref="IBasicUserInfo.GoByName" />
    public virtual string? GoByName { get; set; } = null;

    /// <summary>The number of times the user tried and failed to authenticate.</summary>
    [DefaultValue(0)]
    public override int AccessFailedCount { get; set; } = 0;
    /// <summary>Gets or sets a flag indicating if the user can be locked out.</summary>
    /// <value><pre><b>True</b></pre> if the user <b><b>can</b></b> be locked out, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(true), Column("Is" + nameof(LockoutEnabled))]
    public override bool LockoutEnabled { get; set; } = true;
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone number.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="Email"/> address in his profile, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(EmailConfirmed))]
    public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }
    /// <summary>Gets or sets a flag indicating if a user has confirmed his telephone address.</summary>
    /// <value><pre><b>True</b></pre> if the user has confirmed ownership of the <see cref="PhoneNumber"/> in his profile, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(PhoneNumberConfirmed))]
    public override bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }
    /// <summary>Gets or sets a flag indicating if a user has two-factor authentication set up.</summary>
    /// <value><pre><b>True</b></pre> if the user has two-factor authentication set up,  <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(TwoFactorEnabled))]
    public override bool TwoFactorEnabled { get => base.TwoFactorEnabled; set => base.TwoFactorEnabled = value; }
    /// <summary>Gets or sets a flag indicating whether the user has been locked out (either deliberately be an administrator or by exhausting the number of attempts allowed to authenticate.</summary>
    /// <value><pre>True</pre> if the user <b><i>is locked out</i></b> right now, <pre><b>false</b></pre> otherwise.</value>
    [DefaultValue(false), Column("Is" + nameof(LockedOut))]
    public virtual bool LockedOut => LockoutEnabled && LockoutEnd > Now;

    /// <inheritdoc cref="IdentityUser{int}.LockoutEnd" />
    [DefaultValue(typeof(DateTimeOffset), DefaultLockoutEndString)]
    public override DateTimeOffset? LockoutEnd { get => base.LockoutEnd ??= DateTimeOffset.Parse(DefaultLockoutEndString); set => base.LockoutEnd = value; }

    /// <summary>Gets or sets the user's email address as a string.</summary>
    [Column("EmailAddress", TypeName = DbTypeNVarChar), JIgnore, XIgnore]
    public override string? Email { get => base.Email; set { base.Email = value; base.NormalizedEmail = value?.Normalize(); } }
    /// <summary>Gets or sets the normalized email address for this user as a string.</summary>
    [Column(nameof(NormalizedEmailAddress)), JIgnore, XIgnore]
    public override string? NormalizedEmail { get => base.NormalizedEmail = Email?.Normalize(); set { base.NormalizedEmail = value?.Normalize(); } }
    /// <summary>Gets or sets the user's username (usually the same as the <see cref="TelegramUsername" />)</summary>
    /// <example>Dgmjr</example>
    [JProp("username"), XElem("username")]
    public override string? UserName { get => base.UserName; set { base.UserName = value; base.NormalizedUserName = value?.Normalize(); } }

    public override string? NormalizedUserName { get => base.NormalizedUserName = UserName?.Normalize(); set => base.NormalizedUserName = value?.Normalize(); }

    public override bool Equals(object? obj)
        => obj is IBasicUserInfo user && obj is IIdentifiable<int> userId && userId.Id == Id;

    public override int GetHashCode() => Id.GetHashCode();

    /// <inheritdoc cref="IBasicUserInfo.PhoneNumber" />
    /// <example>+19185256012</example>
    [NotMapped]
    public override string? PhoneNumber { get; set; }

    /// <inheritdoc cref="IUser.ConcurrencyStamp" />
    [Timestamp, Column(nameof(ConcurrencyStamp), TypeName = DbTypeRowVersion), DbGen(DbGen.Computed), JsonIgnore]
    public override string ConcurrencyStamp { get => base.ConcurrencyStamp; set => base.ConcurrencyStamp = value; }

    /// <summary>A hashed and salted representation of the user's password.</summary>
    [JsonIgnore]
    public override string? PasswordHash { get; set; } = null;
    /// <summary>A random value that must change whenever a users credentials change (password changed, login removed)</summary>

    [Timestamp, Column(nameof(SecurityStamp), TypeName = DbTypeNVarChar)]
    public override string? SecurityStamp { get; set; } = NewGuid().ToString();
    /// <summary>Gets or sets the normalized email address for this user as a data structure.</summary>
    [NotMapped]
    public virtual EmailAddress? NormalizedEmailAddress { get => NormalizedEmail; set => NormalizedEmail = value; }
    /// <summary>Gets or sets the the user's email address as a data structure.</summary>
    public virtual EmailAddress? EmailAddress { get => Email; set => Email = value; }
    [NotMapped]
    public virtual PhoneNumber? Phone { get => PhoneNumber; set => PhoneNumber = value; }
    /// <summary>Gets or sets the user's phone number as a data structure in E.164 format</summary>
    /// <example>+19185256012</example>
    PhoneNumber? IBasicUserInfo.PhoneNumber { get => Phone; set => Phone = value; }

    /// <summary>The roles to which the user belongs</summary>
    public virtual ICollection<Role> Roles { get; set; } = new Collection<Role>();
    /// <summary>The user's logins for various federated providers</summary>
    public virtual ICollection<UserLogin> Logins { get; set; } = new Collection<UserLogin>();
    /// <summary>The user's tokens</summary>
    public virtual ICollection<UserToken> Tokens { get; set; } = new Collection<UserToken>();
    /// <summary>The user's claims</summary>
    public virtual ICollection<UserClaim> Claims { get; set; } = new Collection<UserClaim>();
    // /// <summary>The user's bots by <see cref="UserContactId.UserContactId" /></summary>
    // public virtual ICollection<Bot> Bots { get; set; } = new Collection<Bot>();
    // /// <summary>A join entity between <see cref="User" />s and <see cref="Bot" />s</summary>
    // public virtual ICollection<UserContactId> ContactIds { get; set; } = new Collection<UserContactId>();
    /// <summary>A join entity between <see cref="User" />s and <see cref="Role" />s</summary>
    public virtual ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();
    public virtual ICollection<ClaimType> ClaimTypes { get; set; } = new Collection<ClaimType>();
    //public virtual ICollection<BackroomUserRole> UserRoles { get; set; } = new ObservableCollection<BackroomUserRole>();

    ICollection<C> IHaveClaims.Claims { get => Claims.Select(c => c.ToClaim()).ToArray(); set { } }
    ICollection<IUserClaim> IHaveUserClaims.Claims { get => Claims.OfType<IUserClaim>().ToArray(); set { } }
}

public record class UserInsertDto : UserDto, IBasicUserInfo
{
    /// <summary>Gets or sets the user's password.</summary>
    /// <example>My$3cre1Pa$$w0rd!</example>
    public string? Password { get; set; } = User.DefaultPassword;
}

public record class UserDto : IBasicUserInfo
{
    public virtual string? UserName { get; set; }
    public virtual string? GivenName { get; set; }
    public virtual string? Surname { get; set; }
    public virtual string? GoByName { get; set; }
    public virtual PhoneNumber? PhoneNumber { get; set; }
    public virtual string? TelegramUsername { get; set; }
    public virtual long Id { get; set; }
    public EmailAddress? EmailAddress { get; set; }
}

// //[AutoGenerateBuilder(typeof(BackroomUser))]
// //public partial class BackroomUserBuilder { }
