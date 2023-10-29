using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "id");

            migrationBuilder.CreateTable(
                name: "tbl_ClaimValueType",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Example = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Uri = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClaimValueType", x => x.Id);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_Role",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Uri = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Role", x => x.Id);
                },
                comment: "The Roles table contains the roles for the application.")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_User",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    TelegramUsername = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Username = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    GivenName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    GoByName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    IsLockoutEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    IsTwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "cast(CASE WHEN LockoutEnd IS NOT NULL AND LockoutEnd > GetUtcDate() THEN 1 ELSE 0 END as bit)")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValueSql: "'1/1/1970 12:00:00 AM -05:00'")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    EmailAddress = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PhoneNumber = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    NormalizedEmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    NormalizedUsername = table.Column<string>(type: "nvarchar(450)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Gender = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false, defaultValue: "?", comment: "Gender data types:\nM: Male (A person of the male sex, i.e., a human being with both an X and a Y chromosome and (usually) a penis (e.g., eunuchs and nullos are also still men).)\nF: Female (A person of the female sex, i.e., a human being with two X chromosomes and (usually) a vagina.  Does not (and never will) have a penis.)\nXYYM: XYY Male (A person of the male sex, i.e., a human being with both an X and a Y chromosome, and (usually) a penis, as well as an extra \"Y\" chromosome (for good luck).)\nXXYM: XXY Male (A person of the male sex, i.e., a human being with both an X and a Y chromosome, and (usually) a penis, as well as an extra \"X\" chromosome (for good luck).)\n?: Unknown (A person of unknown sex.)\nO: Genderqueer (Someone who thinks it is sooooooo special that it is in a gender all of its own.)\nA: Agender (A schizophrenic human who thinks s/he is too fucking special & refuses to identify with either gender (even if it's blatantly obvious))\nO: Genderfluid (A schizophrenic human who thinks \"they\" are simultaneously male and female.)\nN: Gender Neutral (A human who thinks s/he is too special.)\nTM: Transman (A confused female who fancies herself a male.  Often takes testosterone supplements to grow facial hair, but can't change her DNA or the fact that she doesn't (and never will) have a penis..)\nTF: Transwoman (A confused male who fancies himself a female.  Often gets breast implants.  May or may not have his penis surgically removed, but still can't change his DNA.)\nO: Genderfluid (A schizophrenic human who thinks \"they\" are simultaneously male and female.)")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ConcurrencyStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_User", x => x.Id);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_UserClaim",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Value = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Type = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ValueType = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Issuer = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    OriginalIssuer = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_UserClaim_tbl_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "id",
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_UserLogin",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Provider = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserLogin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_UserLogin_tbl_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "id",
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_UserRole",
                schema: "id",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_UserRole_tbl_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "id",
                        principalTable: "tbl_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_UserRole_tbl_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "id",
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_UserToken",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Provider = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Value = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_UserToken_tbl_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "id",
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "ApplicationClaimType<long>ApplicationUser<long>",
                schema: "id",
                columns: table => new
                {
                    ClaimTypesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "ApplicationClaimType<long>ApplicationUser<long>History")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    UsersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "ApplicationClaimType<long>ApplicationUser<long>History")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "ApplicationClaimType<long>ApplicationUser<long>History")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "ApplicationClaimType<long>ApplicationUser<long>History")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationClaimType<long>ApplicationUser<long>", x => new { x.ClaimTypesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationClaimType<long>ApplicationUser<long>_tbl_User_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "id",
                        principalTable: "tbl_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "ApplicationClaimType<long>ApplicationUser<long>History")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_ClaimType",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Example = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Uri = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ClaimValueTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ApplicationClaimTypelongId = table.Column<long>(name: "ApplicationClaimType<long>Id", type: "bigint", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ApplicationClaimValueTypelongId = table.Column<long>(name: "ApplicationClaimValueType<long>Id", type: "bigint", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ApplicationRoleClaimlongId = table.Column<long>(name: "ApplicationRoleClaim<long>Id", type: "bigint", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClaimType", x => x.Id);
                    table.UniqueConstraint("AK_tbl_ClaimType_Uri", x => x.Uri);
                    table.ForeignKey(
                        name: "FK_tbl_ClaimType_tbl_ClaimType_ApplicationClaimType<long>Id",
                        column: x => x.ApplicationClaimTypelongId,
                        principalSchema: "id",
                        principalTable: "tbl_ClaimType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_ClaimType_tbl_ClaimValueType_ApplicationClaimValueType<long>Id",
                        column: x => x.ApplicationClaimValueTypelongId,
                        principalSchema: "id",
                        principalTable: "tbl_ClaimValueType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tbl_ClaimType_tbl_ClaimValueType_ClaimValueTypeId",
                        column: x => x.ClaimValueTypeId,
                        principalSchema: "id",
                        principalTable: "tbl_ClaimValueType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "tbl_RoleClaim",
                schema: "id",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Value = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Type = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    ValueType = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Issuer = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    OriginalIssuer = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_RoleClaim_tbl_ClaimType_Type",
                        column: x => x.Type,
                        principalSchema: "id",
                        principalTable: "tbl_ClaimType",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_RoleClaim_tbl_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "id",
                        principalTable: "tbl_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationClaimType<long>ApplicationUser<long>_UsersId",
                schema: "id",
                table: "ApplicationClaimType<long>ApplicationUser<long>",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_ApplicationClaimType<long>Id",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ApplicationClaimType<long>Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_ApplicationClaimValueType<long>Id",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ApplicationClaimValueType<long>Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_ApplicationRoleClaim<long>Id",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ApplicationRoleClaim<long>Id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_ClaimValueTypeId",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ClaimValueTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_Uri",
                schema: "id",
                table: "tbl_ClaimType",
                column: "Uri",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoleClaim_RoleId",
                schema: "id",
                table: "tbl_RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoleClaim_Type",
                schema: "id",
                table: "tbl_RoleClaim",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserEmail",
                schema: "id",
                table: "tbl_User",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserNormalizedEmailAddress",
                schema: "id",
                table: "tbl_User",
                column: "NormalizedEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserNormalizedUsername",
                schema: "id",
                table: "tbl_User",
                column: "NormalizedUsername");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserTelegramUsername",
                schema: "id",
                table: "tbl_User",
                column: "TelegramUsername");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserUsername",
                schema: "id",
                table: "tbl_User",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserClaim_UserId",
                schema: "id",
                table: "tbl_UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserLogin_UserId",
                schema: "id",
                table: "tbl_UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRole_RoleId",
                schema: "id",
                table: "tbl_UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRole_UserId",
                schema: "id",
                table: "tbl_UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserToken_UserId",
                schema: "id",
                table: "tbl_UserToken",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationClaimType<long>ApplicationUser<long>_tbl_ClaimType_ClaimTypesId",
                schema: "id",
                table: "ApplicationClaimType<long>ApplicationUser<long>",
                column: "ClaimTypesId",
                principalSchema: "id",
                principalTable: "tbl_ClaimType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_ClaimType_tbl_RoleClaim_ApplicationRoleClaim<long>Id",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ApplicationRoleClaim<long>Id",
                principalSchema: "id",
                principalTable: "tbl_RoleClaim",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_RoleClaim_tbl_ClaimType_Type",
                schema: "id",
                table: "tbl_RoleClaim");

            migrationBuilder.DropTable(
                name: "ApplicationClaimType<long>ApplicationUser<long>",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "ApplicationClaimType<long>ApplicationUser<long>History")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_UserClaim",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_UserLogin",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_UserRole",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_UserToken",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_User",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_ClaimType",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_ClaimValueType",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_RoleClaim",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "tbl_Role",
                schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");
        }
    }
}
