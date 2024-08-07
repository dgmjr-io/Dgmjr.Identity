namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppClaimTypeConfiguration : IEntityTypeConfiguration<AppClaimType>
{
    public virtual void Configure(EntityTypeBuilder<AppClaimType> builder)
    {
        builder.ToTable(ClaimType, IdentitySchema.ShortName, tb => tb.IsTemporal());
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.HasKey(e => e.Id).HasName(pk_ + ClaimType);
        builder
            .HasIndex(e => e.Uri)
            .HasDatabaseName(ix_ + ClaimType + "_" + nameof(DgmjrId.ClaimType.Uri))
            .IsUnique();
        builder.Property(e => e.Name).IsUnicode(false);
        builder.UriProperty(e => e.Uri).IsUnicode(false);
        builder
            .HasOne(e => e.ValueType)
            .WithMany(e => e.ClaimTypes)
            .HasForeignKey(e => e.ValueTypeUri)
            .HasPrincipalKey(e => e.Uri);
        // builder
        //     .HasMany(e => e.Roles)
        //     .WithMany(e => e.ClaimTypes)
        //     .UsingEntity<AppRoleClaim>(
        //         e =>
        //             e.HasOne(e => e.Role)
        //                 .WithMany()
        //                 .HasForeignKey(e => e.RoleId)
        //                 .HasPrincipalKey(e => e.Id),
        //         e =>
        //             e.HasOne<AppClaimType>()
        //                 .WithMany()
        //                 .HasForeignKey(e => e.Type)
        //                 .HasPrincipalKey(ct => ct.Uri),
        //         e => e.HasKey(e => e.Id)
        // //     );
        // builder
        //     .HasOne(e => e.ValueType)
        //     .WithMany()
        //     .HasForeignKey(e => e.ClaimValueTypeId)
        //     .HasPrincipalKey(e => e.Id);
    }
}
