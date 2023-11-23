/*
 * IdentityDbContext.cs
 *
 *   Created: 2022-12-05-08:06:03
 *   Modified: 2022-12-05-08:06:03
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
#pragma warning disable
namespace Dgmjr.Identity;

using System;
using System.Data;
using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

using Dgmjr.EntityFrameworkCore;
using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.Abstractions;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;
using Dgmjr.Identity.Models;

using MSID = Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Telegram.Bot.Types;

public class IdentityDbContext(DbContextOptions options)
    : DbContext(options),
        IDbContext,
        IIdentityDbContext
{
    public static string DefaultConnectionStringConfigurationKey => "IdentityDb";

public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
    : this(options as DbContextOptions) { }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder
        .EnableSensitiveDataLogging()
        .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
        .EnableDetailedErrors()
        .ConfigureWarnings(_ => { })
        .UseSqlServer(options =>
        {
            options.MigrationsAssembly(typeof(AppIdentityDbContext).Assembly.FullName);
            options.EnableRetryOnFailure();
        })
        .UseProjectables()
        .AddInterceptors(new SoftDeleteInterceptor());

    base.OnConfiguring(optionsBuilder);
}

protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
{
    base.ConfigureConventions(configurationBuilder);
    configurationBuilder
        .Properties<uri>()
        .AreUnicode(false)
        .HaveMaxLength(Dgmjr.EntityFrameworkCore.Constants.UriMaxLengthConstant.UriMaxLength)
        .HaveConversion<UriEfCoreValueConverter>();
    configurationBuilder
        .Properties<BotApiToken>()
        .AreUnicode(false)
        .AreFixedLength(true)
        .HaveMaxLength(BotApiToken.Length)
        .HaveColumnType(Format(DbTypeNames.CharX.ShortName, BotApiToken.Length))
        .HaveConversion<BotApiTokenConverter>();
    configurationBuilder
        .Properties<ObjectId>()
        .AreUnicode(false)
        .AreFixedLength(true)
        .HaveMaxLength(ObjectId.Length)
        .HaveColumnType(Format(DbTypeNames.CharX.ShortName, ObjectId.Length))
        .HaveConversion<RegexValueObjectEfCoreConverter<ObjectId>>();
    configurationBuilder
        .Properties<PhoneNumber>()
        .AreUnicode(false)
        .HaveMaxLength(PhoneNumber.MaxLength)
        .HaveConversion<RegexValueObjectEfCoreConverter<PhoneNumber>>();
    configurationBuilder
        .Properties<EmailAddress>()
        .HaveMaxLength(Dgmjr.EntityFrameworkCore.Constants.UriMaxLengthConstant.UriMaxLength)
        .HaveConversion<RegexValueObjectEfCoreConverter<EmailAddress>>();
    configurationBuilder
        .Properties<IStringDictionary>()
        .HaveColumnType(DbTypeNames.NVarCharMax.ShortName)
        .HaveConversion<JsonObjectConverter<IStringDictionary>>();
    configurationBuilder
        .Properties<StringDictionary>()
        .HaveColumnType(DbTypeNames.NVarCharMax.ShortName)
        .HaveConversion<JsonObjectConverter<StringDictionary>>();
    configurationBuilder
        .Properties<IGender>()
        .HaveMaxLength(8)
        .AreUnicode(false)
        .HaveConversion<GenderEfCoreValueConverter>();
    configurationBuilder
        .Properties<Models.Abstractions.IUserLoginProvider>()
        .AreUnicode(false)
        .HaveMaxLength(32)
        .HaveConversion<UserLoginProviderConverter>();

    configurationBuilder.DefaultTypeMapping<BotApiToken>(
        b => b.HasConversion<BotApiTokenConverter>()
    );
    configurationBuilder.DefaultTypeMapping<ObjectId>(
        b => b.HasConversion<RegexValueObjectEfCoreConverter<ObjectId>>()
    );
    configurationBuilder.DefaultTypeMapping<PhoneNumber>(
        b => b.HasConversion<RegexValueObjectEfCoreConverter<PhoneNumber>>()
    );
    configurationBuilder.DefaultTypeMapping<EmailAddress>(
        b => b.HasConversion<RegexValueObjectEfCoreConverter<EmailAddress>>()
    );
    configurationBuilder.DefaultTypeMapping<StringDictionary>(
        b => b.HasConversion<JsonObjectConverter<StringDictionary>>()
    );
    configurationBuilder.DefaultTypeMapping<UserLoginProvider>(
        b => b.HasConversion<UserLoginProviderConverter>()
    );
    // configurationBuilder.DefaultTypeMapping<Gender>(
    //     b => b.HasConversion<GenderEfCoreValueConverter>()
    // );
}

[DbFunction(ufn_ + nameof(IsBot), Schema = IdentitySchema.ShortName)]
public virtual bool IsBot(long userId) => !GetBotToken(userId).IsEmpty;

[DbFunction(ufn_ + nameof(IsBot), Schema = IdentitySchema.ShortName)]
public virtual BotApiToken GetBotToken(long userId) => throw new NotImplementedException();

[DbFunction(ufn_ + nameof(GetSendPulseId), Schema = IdentitySchema.ShortName)]
public virtual ObjectId GetSendPulseId(long userId) => throw new NotImplementedException();

[DbFunction(ufn_ + nameof(IsValidBotToken), Schema = DataSchema.ShortName)]
public virtual bool IsValidBotToken(string token) => BotApiToken.TryParse(token, out _);

[DbFunction(ufn_ + nameof(IsValidEmailAddress), Schema = IdentitySchema.ShortName)]
public virtual bool IsValidEmailAddress(string email) => EmailAddress.TryParse(email, out _);

[DbFunction(ufn_ + nameof(IsValidPhoneNumber), Schema = IdentitySchema.ShortName)]
public virtual bool IsValidPhoneNumber(string phoneNumber) =>
    PhoneNumber.TryParse(phoneNumber, out _);

[DbFunction(ufn_ + nameof(IsValidGender), Schema = IdentitySchema.ShortName)]
public virtual bool IsValidGender(string gender) => Gender.TryParse(gender, out _);

[DbFunction(ufn_ + nameof(IsUri), Schema = IdentitySchema.ShortName)]
public virtual bool IsUri(string uri) => System.uri.TryParse(uri, out _);

[DbFunction(ufn_ + nameof(IsUrn), Schema = IdentitySchema.ShortName)]
public virtual bool IsUrn(string urn) => System.urn.TryParse(urn, out _);

[DbFunction(ufn_ + nameof(IsUrl), Schema = IdentitySchema.ShortName)]
public virtual bool IsUrl(string url) => System.url.TryParse(url, out _);

[DbFunction(ufn_ + nameof(IsValidObjectId), Schema = IdentitySchema.ShortName)]
public virtual bool IsValidObjectId(string objectId) => ObjectId.TryParse(objectId, out _);

public override int SaveChanges(bool acceptAllChangesOnSuccess)
{
    OnBeforeSaving();
    return base.SaveChanges(acceptAllChangesOnSuccess);
}

public override async Task<int> SaveChangesAsync(
    bool acceptAllChangesOnSuccess,
    CancellationToken cancellationToken = default(CancellationToken)
)
{
    OnBeforeSaving();
    return (await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken));
}

protected virtual void OnBeforeSaving()
{
    var entries = ChangeTracker.Entries();
    var utcNow = DateTimeOffset.UtcNow;

    foreach (var entry in entries)
    {
        // for entities that inherit from BaseEntity,
        // set UpdatedOn / CreatedOn appropriately
        if (entry.Entity is IIdentityEntity trackable)
        {
            switch (entry.State)
            {
                case EntityState.Modified:
                    /* do nothing */
                    break;
                case EntityState.Added:
                    /* do nothing */
                    break;
                case EntityState.Deleted:
                    // mark the entity as deleted and set it to modified instead of deleted
                    trackable.Deleted = utcNow;
                    entry.State = EntityState.Modified;
                    break;
            }
        }
    }
}
}
