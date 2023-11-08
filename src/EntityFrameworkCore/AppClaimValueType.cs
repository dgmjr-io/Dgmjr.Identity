namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppClaimValueTypeConfiguration
    : IEntityTypeConfiguration<AppClaimValueType>
{
    public virtual void Configure(EntityTypeBuilder<AppClaimValueType> builder)
    {
        builder.ToTable(ClaimValueType, IdentitySchema.ShortName,
                        tb => tb.IsTemporal());
        builder.Property(e => e.Id).ValueGeneratedOnAdd();
        builder.HasKey(e => e.Id).HasName(pk_ + ClaimValueType);
        builder.Property(e => e.Name).IsUnicode(false);
        builder.UriProperty(e => e.Uri).IsUnicode(false);
    }
}
