namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppRoleClaimConfiguration : IEntityTypeConfiguration<AppRoleClaim>
{
    public virtual void Configure(EntityTypeBuilder<AppRoleClaim> builder)
    {
        builder.ToTable(RoleClaim, IdentitySchema.ShortName, tb => tb.IsTemporal());
        builder.HasKey(e => e.Id).HasName(pk_ + RoleClaim);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Ignore(e => e.EntityId);
        builder.Ignore(e => e.Entity);
        builder
            .HasOne(e => e.Role)
            .WithMany(e => e.RoleClaims)
            .HasForeignKey(e => e.RoleId)
            .HasPrincipalKey(e => e.Id);
        builder
            .HasOne(e => e.ClaimType)
            .WithMany()
            .HasForeignKey(e => e.Type)
            .HasPrincipalKey(e => e.Uri);
        // builder
        //     .HasOne(e => e.ClaimType)
        //     .WithMany()
        //     .HasForeignKey(e => e.ClaimType)
        //     .HasPrincipalKey(e => e.Uri);
    }
}
