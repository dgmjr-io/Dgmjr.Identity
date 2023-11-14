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
        private const string _sql = ".sql";

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Operations.Add(new EnsureSchemaOperation { Name = "data" });
            migrationBuilder.Operations.Add(new EnsureSchemaOperation { Name = "id" });
            migrationBuilder.Operations.Add(
                new CreateFunctionOperation(
                    "id",
                    ufn_ + nameof(IIdentityDbContext.GetBotToken),
                    "@userId bigint",
                    GetType().Assembly.ReadAssemblyResourceAllText(
                        ufn_ + nameof(IIdentityDbContext.GetBotToken) + _sql
                    )
                )
            );
            migrationBuilder.HasIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsValidGender)
            );
            migrationBuilder.HasIsValidEmailAddressFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsValidEmailAddress)
            );
            migrationBuilder.HasIsValidPhoneNumberFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsValidPhoneNumber)
            );
            // migrationBuilder.HasIsValidBotTokenFunction(
            //     Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
            //     ufn_ + nameof(IdentityDbContext.IsValidBotToken)
            // );
            migrationBuilder.HasIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsUri)
            );
            migrationBuilder.HasIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsUrl)
            );
            migrationBuilder.HasIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsUrn)
            );
            migrationBuilder.HasGetSendPulseIdFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.GetSendPulseId)
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RollBackIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidGender)
            );
            migrationBuilder.RollBackIsValidBotTokenFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidBotToken)
            );
            migrationBuilder.RollBackIsValidEmailAddressFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidEmailAddress)
            );
            migrationBuilder.RollBackIsValidPhoneNumberFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidPhoneNumber)
            );
            migrationBuilder.RollBackIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsUri)
            );
            migrationBuilder.RollBackIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsUrl)
            );
            migrationBuilder.RollBackIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsUrn)
            );
            migrationBuilder.Operations.Add(
                new DropFunctionOperation(
                    Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                    ufn_ + nameof(AppIdentityDbContext.GetBotToken)
                )
            );
            migrationBuilder.Operations.Add(
                new DropFunctionOperation(
                    Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                    ufn_ + nameof(AppIdentityDbContext.GetSendPulseId)
                )
            );
        }
    }
}
