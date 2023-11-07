using System.Domain;
using System.Net.Mail;

using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialUDFs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE SCHEMA [data];");
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("id.ufn_GetBotToken.sql")
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
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsValidBotApiToken.sql")
            );
            migrationBuilder.HasIsValidUriFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidUri)
            );
            migrationBuilder.HasIsValidUrlFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidUrl)
            );
            migrationBuilder.HasIsValidUrnFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.DataSchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidUrn)
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [id].[ufn_GetBotToken]");
            migrationBuilder.RollBackIsValidGenderFunction(
                Dgmjr.EntityFrameworkCore.DbSchemas.IdentitySchema.ShortName,
                ufn_ + nameof(IdentityDbContext.IsValidGender)
            );
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsValidEmailAddress]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsValidPhoneNumber]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsValidBotApiToken]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsUri]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsUrl]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsUrn]");
        }
    }
}
