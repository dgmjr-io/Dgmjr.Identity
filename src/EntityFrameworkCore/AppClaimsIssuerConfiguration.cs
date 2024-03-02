namespace Dgmjr.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppClaimsIssuerConfiguration : IEntityTypeConfiguration<AppClaimsIssuer>
{
    public virtual void Configure(EntityTypeBuilder<AppClaimsIssuer> builder)
    {
        builder.ToTable(ClaimsIssuer, IdentitySchema.ShortName, tb => tb.IsTemporal());
        builder.HasKey(e => e.Id).HasName(pk_ + ClaimsIssuer);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.Uri).IsUnicode(false);
        builder.Property(e => e.Name).IsUnicode(false);
        builder.Property(e => e.Description).IsUnicode(false);
        builder
            .HasMany(e => e.UserClaims)
            .WithOne()
            .HasForeignKey(e => e.Issuer)
            .HasPrincipalKey(e => e.Uri);
        builder
            .HasMany(e => e.RoleClaims)
            .WithOne()
            .HasForeignKey(e => e.Issuer)
            .HasPrincipalKey(e => e.Uri);

        builder.HasData(
            new AppClaimsIssuer
            {
                Id = 1,
                Uri = Dgmjr.Identity.ClaimTypes.DgmjrClaims.BaseUri,
                Name = "DGMJR-IO",
                Description = "DGMJR-IO Identity Server"
            },
            new AppClaimsIssuer
            {
                Id = 2,
                Uri = Telegram.Identity.ClaimTypes.TelegramClaimType.UriString,
                Name = nameof(Telegram),
                Description = nameof(Telegram)
            },
            new AppClaimsIssuer
            {
                Id = 3,
                Uri = SendPulse.Identity.ClaimTypeNames.Identity,
                Name = nameof(SendPulse),
                Description = nameof(SendPulse)
            }
        );
    }
}
