using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Dgmjr.EntityFrameworkCore.Migrations;
using Dgmjr.Primitives.EntityFrameworkCore;
using Dgmjr.Identity;
using Telegram.Bot.Types;

#nullable disable

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialUDFs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Operations.Add(new EnsureSchemaOperation { Name = "data" });
            migrationBuilder.Operations.Add(new EnsureSchemaOperation { Name = "id" });
            migrationBuilder.Operations.Add(
                new CreateFunctionOperation(
                    "id",
                    ufn_ + nameof(IdentityDbContext.GetBotToken),
                    "@userId bigint",
                    GetType().Assembly.ReadAssemblyResourceAllText(
                        ufn_ + nameof(IdentityDbContext.GetBotToken) + ".sql"
                    )
                )
            );
            migrationBuilder.HasIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidGender)
            );
            migrationBuilder.HasIsValidEmailAddressFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidEmailAddress)
            );
            migrationBuilder.HasIsValidPhoneNumberFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidPhoneNumber)
            );
            migrationBuilder.HasIsValidBotTokenFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidBotToken)
            );
            migrationBuilder.HasIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsUri)
            );
            migrationBuilder.HasIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsUrl)
            );
            migrationBuilder.HasIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsUrn)
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RollBackIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidGender)
            );
            migrationBuilder.RollBackIsValidBotTokenFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidBotToken)
            );
            migrationBuilder.RollBackIsValidEmailAddressFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidEmailAddress)
            );
            migrationBuilder.RollBackIsValidPhoneNumberFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidPhoneNumber)
            );
            migrationBuilder.RollBackIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsUri)
            );
            migrationBuilder.RollBackIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsUrl)
            );
            migrationBuilder.RollBackIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsUrn)
            );
        }
    }
}
