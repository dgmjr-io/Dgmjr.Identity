using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Dgmjr.EntityFrameworkCore.Migrations;
using Dgmjr.Primitives.EntityFrameworkCore;
using Dgmjr.Identity;
using Telegram.Bot.Types;
using static Dgmjr.Identity.EntityFrameworkCore.Migrations.Constants.FunctionNames;

#nullable disable

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialUDFs : Migration
    {
        private const string _sql = ".sql";

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Operations.Add(new EnsureSchemaOperation { Name = "data" });
            migrationBuilder.Operations.Add(new EnsureSchemaOperation { Name = "id" });
            migrationBuilder.Operations.Add(
                new CreateFunctionOperation(
                    "id",
                    ufn_ + GetBotToken,
                    "@userId bigint",
                    GetType().Assembly.ReadAssemblyResourceAllText(ufn_ + GetBotToken + _sql)
                )
            );
            migrationBuilder.HasIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + IsValidGender
            );
            migrationBuilder.HasIsValidEmailAddressFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsValidEmailAddress
            );
            migrationBuilder.HasIsValidPhoneNumberFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsValidPhoneNumber
            );
            migrationBuilder.HasIsValidBotTokenFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsValidBotToken
            );
            migrationBuilder.HasIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsUri
            );
            migrationBuilder.HasIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsUrl
            );
            migrationBuilder.HasIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsUrn
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RollBackIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + IsValidGender
            );
            migrationBuilder.RollBackIsValidBotTokenFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsValidBotToken
            );
            migrationBuilder.RollBackIsValidEmailAddressFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsValidEmailAddress
            );
            migrationBuilder.RollBackIsValidPhoneNumberFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsValidPhoneNumber
            );
            migrationBuilder.RollBackIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsUri
            );
            migrationBuilder.RollBackIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsUrl
            );
            migrationBuilder.RollBackIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + IsUrn
            );
        }
    }
}
