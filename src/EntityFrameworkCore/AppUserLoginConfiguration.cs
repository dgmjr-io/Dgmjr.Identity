namespace Dgmjr.Identity.EntityFrameworkCore;

using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Dgmjr.EntityFrameworkCore.DbSchemas;
using Dgmjr.Identity.EntityFrameworkCore.Constants;
using static Dgmjr.Identity.EntityFrameworkCore.Constants.TableNames;

public class AppUserLoginConfiguration : IEntityTypeConfiguration<AppUserLogin>
{
    public virtual void Configure(EntityTypeBuilder<AppUserLogin> builder)
    {
        builder.ToTable(UserLogin, IdentitySchema.ShortName, tb => tb.IsTemporal());
        builder.HasKey(e => e.Id).HasName(pk_ + UserLogin);
        builder
            .HasOne(e => e.User)
            .WithMany(u => u.Logins)
            .HasForeignKey(e => e.UserId)
            .HasPrincipalKey(e => e.Id);
        builder
            .Property(e => e.Provider)
            .IsUnicode(false)
            .HasConversion(v => v.ToString(), v => AppUserLoginProvider.Parse(v));
    }
}
