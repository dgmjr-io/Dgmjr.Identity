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
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("id.ufn_IsValidGender.sql")
            );
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsValidEmailAddress.sql")
            );
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsValidPhoneNumber.sql")
            );
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsValidBotApiToken.sql")
            );
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsUri.sql")
            );
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsUrl.sql")
            );
            migrationBuilder.Sql(
                GetType().Assembly.ReadAssemblyResourceAllText("data.ufn_IsUrn.sql")
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [id].[ufn_GetBotToken]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [id].[ufn_IsValidGender]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsValidEmailAddress]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsValidPhoneNumber]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsValidBotApiToken]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsUri]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsUrl]");
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS [data].[ufn_IsUrn]");
        }
    }
}
