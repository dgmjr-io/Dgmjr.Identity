using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Dgmjr.EntityFrameworkCore.Migrations;
using Dgmjr.Primitives.EntityFrameworkCore;
using Dgmjr.Identity;
using Telegram.Bot.Types;
using SendPulse.Identity;

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
                IdentitySchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsValidGender)
            );
            migrationBuilder.HasIsValidEmailAddressFunction(
                DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsValidEmailAddress)
            );
            migrationBuilder.HasIsValidPhoneNumberFunction(
                DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsValidPhoneNumber)
            );
            // migrationBuilder.HasIsValidBotTokenFunction(
            //     DataSchema.ShortName,
            //     ufn_ + nameof(IdentityDbContext.IsValidBotToken)
            // );
            migrationBuilder.HasIsValidUriFunction(
                DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsUri)
            );
            migrationBuilder.HasIsValidUrlFunction(
                DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsUrl)
            );
            migrationBuilder.HasIsValidUrnFunction(
                DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.IsUrn)
            );
            migrationBuilder.HasGetSendPulseIdFunction(
                DataSchema.ShortName,
                ufn_ + nameof(IIdentityDbContext.GetSendPulseId)
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RollBackIsValidGenderFunction(
                IdentitySchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidGender)
            );
            migrationBuilder.RollBackIsValidBotTokenFunction(
                DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidBotToken)
            );
            migrationBuilder.RollBackIsValidEmailAddressFunction(
                DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidEmailAddress)
            );
            migrationBuilder.RollBackIsValidPhoneNumberFunction(
                DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsValidPhoneNumber)
            );
            migrationBuilder.RollBackIsValidUriFunction(
                DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsUri)
            );
            migrationBuilder.RollBackIsValidUrlFunction(
                DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsUrl)
            );
            migrationBuilder.RollBackIsValidUrnFunction(
                DataSchema.ShortName,
                ufn_ + nameof(AppIdentityDbContext.IsUrn)
            );
            migrationBuilder.Operations.Add(
                new DropFunctionOperation(
                    IdentitySchema.ShortName,
                    ufn_ + nameof(AppIdentityDbContext.GetBotToken)
                )
            );
            migrationBuilder.Operations.Add(
                new DropFunctionOperation(
                    DataSchema.ShortName,
                    ufn_ + nameof(AppIdentityDbContext.GetSendPulseId)
                )
            );
        }
    }
}
