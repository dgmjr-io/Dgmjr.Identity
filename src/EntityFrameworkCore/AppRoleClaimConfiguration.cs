namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppRoleClaimConfiguration
    : IEntityTypeConfiguration<AppRoleClaim>
{
    public virtual void Configure(EntityTypeBuilder<AppRoleClaim> builder)
    {
        builder.ToTable(RoleClaim, IdentitySchema.ShortName, tb => tb.IsTemporal());
        builder.HasKey(e => e.Id).HasName(pk_ + RoleClaim);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.Property(e => e.Properties)
            .HasConversion(new JsonObjectConverter<IStringDictionary>());
        builder.UriProperty(e => e.Type);
        builder.UriProperty(e => e.Issuer);
        builder.UriProperty(e => e.OriginalIssuer);
        builder.UriProperty(e => e.ValueType);
        builder.Ignore(e => e.EntityId);
        builder.Ignore(e => e.Entity);
        builder.HasOne(e => e.Role)
            .WithMany()
            .HasForeignKey(e => e.RoleId)
            .HasPrincipalKey(e => e.Id);
    }
}
