namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppUserTokenConfiguration
    : IEntityTypeConfiguration<AppUserToken> {
  public virtual void Configure(EntityTypeBuilder<AppUserToken> builder) {
    builder.ToTable(UserToken, IdentitySchema.ShortName, tb => tb.IsTemporal());
    builder.HasKey(e => e.Id).HasName(pk_ + UserToken);
    builder.Property(e => e.Id).ValueGeneratedOnAdd();
    builder.HasOne(e => e.User)
        .WithMany(u => u.Tokens)
        .HasForeignKey(e => e.UserId)
        .HasPrincipalKey(e => e.Id);
    builder.Property(e => e.Provider)
        .IsUnicode(false)
        .HasConversion(v => v.Uri.ToString(),
                       v => AppUserLoginProvider.Parse(v));
  }
}
