using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(name: "id");

            migrationBuilder
                .CreateTable(
                    name: "tbl_ClaimsIssuer",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Uri = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Name = table
                                .Column<string>(
                                    type: "varchar(max)",
                                    unicode: false,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Description = table
                                .Column<string>(
                                    type: "varchar(max)",
                                    unicode: false,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimsIssuerHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_ClaimsIssuer", x => x.Id);
                        table.UniqueConstraint("AK_tbl_ClaimsIssuer_Uri", x => x.Uri);
                    },
                    comment: "A claims issuer is an entity that issues claims."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimsIssuerHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_ClaimValueType",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Example = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Default = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Uri = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Name = table
                                .Column<string>(
                                    type: "varchar(max)",
                                    unicode: false,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Description = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimValueTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_ClaimValueType", x => x.Id);
                        table.UniqueConstraint("AK_tbl_ClaimValueType_Uri", x => x.Uri);
                    },
                    comment: "A claim value type is a type of value that a claim can have."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_Role",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ConcurrencyStamp = table
                                .Column<byte[]>(type: "rowversion", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Name = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            NormalizedName = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Description = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Uri = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_Role", x => x.Id);
                    },
                    comment: "The Roles table contains the roles for the application."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_User",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            TelegramUsername = table
                                .Column<string>(
                                    type: "varchar(33)",
                                    unicode: false,
                                    maxLength: 33,
                                    nullable: true
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Username = table
                                .Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            GivenName = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Surname = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            GoByName = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            AccessFailedCount = table
                                .Column<int>(type: "int", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            IsLockoutEnabled = table
                                .Column<bool>(type: "bit", nullable: false, defaultValueSql: "1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            IsEmailConfirmed = table
                                .Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            IsPhoneNumberConfirmed = table
                                .Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            IsTwoFactorEnabled = table
                                .Column<bool>(type: "bit", nullable: false, defaultValueSql: "0")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            LockoutEnd = table
                                .Column<DateTimeOffset>(
                                    type: "datetimeoffset",
                                    nullable: true,
                                    defaultValueSql: "'1/1/1970 12:00:00 AM -05:00'"
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            EmailAddress = table
                                .Column<string>(
                                    type: "nvarchar(2048)",
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PhoneNumber = table
                                .Column<string>(
                                    type: "varchar(24)",
                                    unicode: false,
                                    maxLength: 24,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            NormalizedEmailAddress = table
                                .Column<string>(type: "nvarchar(450)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            NormalizedUsername = table
                                .Column<string>(type: "nvarchar(450)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Gender = table
                                .Column<string>(
                                    type: "varchar(8)",
                                    unicode: false,
                                    maxLength: 8,
                                    nullable: false,
                                    defaultValue: "?",
                                    comment: "Gender data types:\nM: Male (A person of the male sex, i.e., a human being with both an X and a Y chromosome and (usually) a penis (e.g., eunuchs and nullos are also still men).)\nF: Female (A person of the female sex, i.e., a human being with two X chromosomes and (usually) a vagina.  Does not (and never will) have a penis.)\nXYYM: XYY Male (A person of the male sex, i.e., a human being with both an X and a Y chromosome, and (usually) a penis, as well as an extra \"Y\" chromosome (for good luck).)\nXXYM: XXY Male (A person of the male sex, i.e., a human being with both an X and a Y chromosome, and (usually) a penis, as well as an extra \"X\" chromosome (for good luck).)\n?: Unknown (A person of unknown sex.)\nO: Genderqueer (Someone who thinks it is sooooooo special that it is in a gender all of its own.)\nA: Agender (A schizophrenic human who thinks s/he is too fucking special & refuses to identify with either gender (even if it's blatantly obvious))\nO: Genderfluid (A schizophrenic human who thinks \"they\" are simultaneously male and female.)\nN: Gender Neutral (A human who thinks s/he is too special.)\nTM: Transman (A confused female who fancies herself a male.  Often takes testosterone supplements to grow facial hair, but can't change her DNA or the fact that she doesn't (and never will) have a penis..)\nTF: Transwoman (A confused male who fancies himself a female.  Often gets breast implants.  May or may not have his penis surgically removed, but still can't change his DNA.)\nO: Genderfluid (A schizophrenic human who thinks \"they\" are simultaneously male and female.)"
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PasswordHash = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ConcurrencyStamp = table
                                .Column<byte[]>(
                                    type: "rowversion",
                                    rowVersion: true,
                                    nullable: true
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_User", x => x.Id);
                        table.CheckConstraint(
                            "ck_EmailAddress",
                            "[data].[ufn_IsValidEmailAddress](EmailAddress) = 1"
                        );
                        table.CheckConstraint("ck_Gender", "[id].[ufn_IsValidGender](Gender) = 1");
                        table.CheckConstraint(
                            "ck_PhoneNumber",
                            "[data].[ufn_IsValidPhoneNumber](PhoneNumber) = 1"
                        );
                        table.CheckConstraint(
                            "TelegramUsername",
                            "\r\n                    [TelegramUsername] IS NULL\r\n                    OR (\r\n                            len([TelegramUsername]) >= 5\r\n                            AND len([TelegramUsername]) <= (32 + 1)\r\n                            AND [TelegramUsername] LIKE '@%'\r\n                        )\r\n                    "
                        );
                    },
                    comment: "A user is a person who can be authenticated."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_ClaimType",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Example = table
                                .Column<string>(type: "nvarchar(max)", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Uri = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Name = table
                                .Column<string>(
                                    type: "varchar(max)",
                                    unicode: false,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ValueTypeUri = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Description = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ApplicationUserlongId = table
                                .Column<long>(
                                    name: "ApplicationUser<long>Id",
                                    type: "bigint",
                                    nullable: true
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_ClaimTypeHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_ClaimType", x => x.Id);
                        table.UniqueConstraint("AK_tbl_ClaimType_Uri", x => x.Uri);
                        table.ForeignKey(
                            name: "FK_tbl_ClaimType_tbl_ClaimValueType_ValueTypeUri",
                            column: x => x.ValueTypeUri,
                            principalSchema: "id",
                            principalTable: "tbl_ClaimValueType",
                            principalColumn: "Uri",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_tbl_ClaimType_tbl_User_ApplicationUser<long>Id",
                            column: x => x.ApplicationUserlongId,
                            principalSchema: "id",
                            principalTable: "tbl_User",
                            principalColumn: "Id"
                        );
                    },
                    comment: "A claim type is a type of claim that can be assigned to a user."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_UserLogin",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ProviderKey = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Provider = table
                                .Column<string>(
                                    type: "varchar(32)",
                                    unicode: false,
                                    maxLength: 32,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            UserId = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Created = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserLoginHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_UserLogin", x => x.Id);
                        table.ForeignKey(
                            name: "FK_tbl_UserLogin_tbl_User_UserId",
                            column: x => x.UserId,
                            principalSchema: "id",
                            principalTable: "tbl_User",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    },
                    comment: "A user login is a login that is assigned to a user."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_UserRole",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            UserId = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserRoleHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            RoleId = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserRoleHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserRoleHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserRoleHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserRoleHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserRoleHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_UserRole", x => x.Id);
                        table.ForeignKey(
                            name: "FK_tbl_UserRole_tbl_Role_RoleId",
                            column: x => x.RoleId,
                            principalSchema: "id",
                            principalTable: "tbl_Role",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_tbl_UserRole_tbl_User_UserId",
                            column: x => x.UserId,
                            principalSchema: "id",
                            principalTable: "tbl_User",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    },
                    comment: "A user role is a role that is assigned to a user."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_UserToken",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            UserId = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ProviderId = table
                                .Column<int>(type: "int", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ProviderName = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ProviderDisplayName = table
                                .Column<string>(type: "nvarchar(max)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Provider = table
                                .Column<string>(
                                    type: "varchar(32)",
                                    unicode: false,
                                    maxLength: 32,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Name = table
                                .Column<string>(
                                    type: "nvarchar(64)",
                                    maxLength: 64,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Value = table
                                .Column<string>(
                                    type: "nvarchar(256)",
                                    maxLength: 256,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Created = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserTokenHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_UserToken", x => x.Id);
                        table.ForeignKey(
                            name: "FK_tbl_UserToken_tbl_User_UserId",
                            column: x => x.UserId,
                            principalSchema: "id",
                            principalTable: "tbl_User",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    },
                    comment: "A user token is a token that is assigned to a user."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_RoleClaim",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            RoleId = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Value = table
                                .Column<string>(
                                    type: "nvarchar(2048)",
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Type = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ValueType = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Issuer = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            OriginalIssuer = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Properties = table
                                .Column<string>(type: "nvarchar(MAX)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_RoleClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_RoleClaim", x => x.Id);
                        table.ForeignKey(
                            name: "FK_tbl_RoleClaim_tbl_ClaimType_Type",
                            column: x => x.Type,
                            principalSchema: "id",
                            principalTable: "tbl_ClaimType",
                            principalColumn: "Uri",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_tbl_RoleClaim_tbl_ClaimsIssuer_Issuer",
                            column: x => x.Issuer,
                            principalSchema: "id",
                            principalTable: "tbl_ClaimsIssuer",
                            principalColumn: "Uri",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_tbl_RoleClaim_tbl_Role_RoleId",
                            column: x => x.RoleId,
                            principalSchema: "id",
                            principalTable: "tbl_Role",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    },
                    comment: "A role claim is a claim that is assigned to a role."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .CreateTable(
                    name: "tbl_UserClaim",
                    schema: "id",
                    columns: table =>
                        new
                        {
                            Id = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1")
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            UserId = table
                                .Column<long>(type: "bigint", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodEnd = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            PeriodStart = table
                                .Column<DateTime>(type: "datetime2", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Deleted = table
                                .Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Value = table
                                .Column<string>(
                                    type: "nvarchar(2048)",
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Type = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            ValueType = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Issuer = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            OriginalIssuer = table
                                .Column<string>(
                                    type: "varchar(2048)",
                                    unicode: false,
                                    maxLength: 2048,
                                    nullable: false
                                )
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                ),
                            Properties = table
                                .Column<string>(type: "nvarchar(MAX)", nullable: false)
                                .Annotation("SqlServer:IsTemporal", true)
                                .Annotation(
                                    "SqlServer:TemporalHistoryTableName",
                                    "tbl_UserClaimHistory"
                                )
                                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                                .Annotation(
                                    "SqlServer:TemporalPeriodStartColumnName",
                                    "PeriodStart"
                                )
                        },
                    constraints: table =>
                    {
                        table.PrimaryKey("pk_tbl_UserClaim", x => x.Id);
                        table.ForeignKey(
                            name: "FK_tbl_UserClaim_tbl_ClaimType_Type",
                            column: x => x.Type,
                            principalSchema: "id",
                            principalTable: "tbl_ClaimType",
                            principalColumn: "Uri",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_tbl_UserClaim_tbl_ClaimsIssuer_Issuer",
                            column: x => x.Issuer,
                            principalSchema: "id",
                            principalTable: "tbl_ClaimsIssuer",
                            principalColumn: "Uri",
                            onDelete: ReferentialAction.Cascade
                        );
                        table.ForeignKey(
                            name: "FK_tbl_UserClaim_tbl_User_UserId",
                            column: x => x.UserId,
                            principalSchema: "id",
                            principalTable: "tbl_User",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade
                        );
                    },
                    comment: "A user claim is a claim that is assigned to a user."
                )
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.InsertData(
                schema: "id",
                table: "tbl_ClaimValueType",
                columns: new[]
                {
                    "Id",
                    "Default",
                    "Deleted",
                    "Description",
                    "Example",
                    "Name",
                    "Uri"
                },
                values: new object[,]
                {
                    {
                        1L,
                        "",
                        null,
                        "The claim value type for a String",
                        "",
                        "String",
                        "http://schemas.xmlsoap.org/identity/claims/dns"
                    },
                    {
                        2L,
                        "",
                        null,
                        "The claim value type for a EmailAddress",
                        "",
                        "EmailAddress",
                        "http://schemas.xmlsoap.org/identity/claimsUPN"
                    },
                    {
                        3L,
                        "",
                        null,
                        "The claim value type for a EmailAddress",
                        "",
                        "EmailAddress",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"
                    },
                    {
                        4L,
                        "+10000000000",
                        null,
                        "The claim value type for a PhoneNumber",
                        "+19174097331",
                        "PhoneNumber",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/phone"
                    },
                    {
                        5L,
                        "",
                        null,
                        "The claim value type for a RSA",
                        "",
                        "RSA",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa"
                    },
                    {
                        6L,
                        "",
                        null,
                        "The claim value type for a XElement",
                        "",
                        "XElement",
                        "http://www.w3.org/2000/09/xmldsig#DSAKeyValue"
                    },
                    {
                        7L,
                        "",
                        null,
                        "The claim value type for a KeyInfo",
                        "",
                        "KeyInfo",
                        "http://www.w3.org/2000/09/xmldsig#KeyInfo"
                    },
                    {
                        8L,
                        "",
                        null,
                        "The claim value type for a XElement",
                        "",
                        "XElement",
                        "http://www.w3.org/2000/09/xmldsig#RSAKeyValue"
                    },
                    {
                        9L,
                        "",
                        null,
                        "The claim value type for a Byte[]",
                        "",
                        "Byte[]",
                        "http://www.w3.org/2001/XMLSchema#base64Binary"
                    },
                    {
                        10L,
                        "",
                        null,
                        "The claim value type for a Boolean",
                        "",
                        "Boolean",
                        "http://www.w3.org/2001/XMLSchema#boolean"
                    },
                    {
                        11L,
                        "",
                        null,
                        "The claim value type for a DateOnly",
                        "",
                        "DateOnly",
                        "http://www.w3.org/2001/XMLSchema#date"
                    },
                    {
                        12L,
                        "",
                        null,
                        "The claim value type for a DateTime",
                        "",
                        "DateTime",
                        "http://www.w3.org/2001/XMLSchema#dateTime"
                    },
                    {
                        13L,
                        "",
                        null,
                        "The claim value type for a DayTimeDuration",
                        "",
                        "DayTimeDuration",
                        "http://www.w3.org/2001/XMLSchema#dayTimeDuration"
                    },
                    {
                        14L,
                        "",
                        null,
                        "The claim value type for a Double",
                        "",
                        "Double",
                        "http://www.w3.org/2001/XMLSchema#double"
                    },
                    {
                        15L,
                        "",
                        null,
                        "The claim value type for a String",
                        "",
                        "String",
                        "http://www.w3.org/2001/XMLSchema#fqbn"
                    },
                    {
                        16L,
                        "",
                        null,
                        "The claim value type for a Byte[]",
                        "",
                        "Byte[]",
                        "http://www.w3.org/2001/XMLSchema#hexBinary"
                    },
                    {
                        17L,
                        "",
                        null,
                        "The claim value type for a Int32",
                        "",
                        "Int32",
                        "http://www.w3.org/2001/XMLSchema#integer"
                    },
                    {
                        18L,
                        "",
                        null,
                        "The claim value type for a Int32",
                        "",
                        "Int32",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        19L,
                        "",
                        null,
                        "The claim value type for a Int64",
                        "",
                        "Int64",
                        "http://www.w3.org/2001/XMLSchema#integer64"
                    },
                    {
                        20L,
                        "",
                        null,
                        "The claim value type for a String",
                        "",
                        "String",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        21L,
                        "",
                        null,
                        "The claim value type for a TimeOnly",
                        "",
                        "TimeOnly",
                        "http://www.w3.org/2001/XMLSchema#time"
                    },
                    {
                        22L,
                        "",
                        null,
                        "The claim value type for a UInt32",
                        "",
                        "UInt32",
                        "http://www.w3.org/2001/XMLSchema#uinteger32"
                    },
                    {
                        23L,
                        "",
                        null,
                        "The claim value type for a UInt64",
                        "",
                        "UInt64",
                        "http://www.w3.org/2001/XMLSchema#uinteger64"
                    },
                    {
                        24L,
                        "",
                        null,
                        "The claim value type for a YearMonthDuration",
                        "",
                        "YearMonthDuration",
                        "http://www.w3.org/2001/XMLSchema#yearMonthDuration"
                    },
                    {
                        25L,
                        "000000000000000000000000",
                        null,
                        "The claim value type for a ObjectId",
                        "abcdef0123456789abcdef01",
                        "ObjectId",
                        "https://www.mongodb.com/docs/manual/reference/method/ObjectId"
                    },
                    {
                        26L,
                        "",
                        null,
                        "The claim value type for a uri",
                        "",
                        "uri",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        27L,
                        "",
                        null,
                        "The claim value type for a JsonElement",
                        "",
                        "JsonElement",
                        "https://www.w3.org/2001/XMLSchema#json"
                    },
                    {
                        28L,
                        "",
                        null,
                        "The claim value type for a Guid",
                        "",
                        "Guid",
                        "https://www.w3.org/2001/XMLSchema#uuidType"
                    },
                    {
                        29L,
                        "nobody@nowhere.com",
                        null,
                        "The claim value type for a EmailAddress",
                        "somewhere@overtherainbow.com",
                        "EmailAddress",
                        "urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name"
                    },
                    {
                        30L,
                        "",
                        null,
                        "The claim value type for a X500DistinguishedName",
                        "",
                        "X500DistinguishedName",
                        "urn:oasis:names:tc:xacml:1.0:data-type:x500Name"
                    },
                    {
                        31L,
                        "",
                        null,
                        "The claim value type for a String",
                        "",
                        "String",
                        "urn:oasis:names:tc:xacml:2.0:data-type:dnsName"
                    },
                    { 32L, "", null, "The claim value type for a ipAddress", "", "ipAddress", "" }
                }
            );

            migrationBuilder.InsertData(
                schema: "id",
                table: "tbl_ClaimsIssuer",
                columns: new[] { "Id", "Deleted", "Description", "Name", "Uri" },
                values: new object[,]
                {
                    { 1L, null, "DGMJR-IO Identity Server", "DGMJR-IO", "https://dgmjr.io/" },
                    { 2L, null, "Telegram", "Telegram", "https://telegram.org/identity" },
                    { 3L, null, "SendPulse", "SendPulse", "https://sendpulse.com/identity" }
                }
            );

            migrationBuilder.InsertData(
                schema: "id",
                table: "tbl_ClaimType",
                columns: new[]
                {
                    "Id",
                    "ApplicationUser<long>Id",
                    "Deleted",
                    "Description",
                    "Example",
                    "Name",
                    "Uri",
                    "ValueTypeUri"
                },
                values: new object[,]
                {
                    {
                        33L,
                        null,
                        null,
                        "The claim type for a CommonName",
                        null,
                        "CommonName",
                        "http://schemas.microsoft.com/claims/CommonName",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        34L,
                        null,
                        null,
                        "The claim type for a Email",
                        null,
                        "Email",
                        "http://schemas.microsoft.com/claims/emailaddress",
                        "urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name"
                    },
                    {
                        35L,
                        null,
                        null,
                        "The claim type for a Upn",
                        null,
                        "Upn",
                        "http://schemas.microsoft.com/claims/upn",
                        "http://schemas.xmlsoap.org/identity/claimsUPN"
                    },
                    {
                        36L,
                        null,
                        null,
                        "The claim type for a AuthenticationInstant",
                        null,
                        "AuthenticationInstant",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationinstant",
                        "http://www.w3.org/2001/XMLSchema#dateTime"
                    },
                    {
                        37L,
                        null,
                        null,
                        "The claim type for a AuthenticationMethod",
                        null,
                        "AuthenticationMethod",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/authenticationmethod",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        38L,
                        null,
                        null,
                        "The claim type for a CookiePath",
                        null,
                        "CookiePath",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/cookiepath",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        39L,
                        null,
                        null,
                        "The claim type for a DenyOnlyPrimaryGroupSid",
                        null,
                        "DenyOnlyPrimaryGroupSid",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        40L,
                        null,
                        null,
                        "The claim type for a DenyOnlyPrimarySid",
                        null,
                        "DenyOnlyPrimarySid",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        41L,
                        null,
                        null,
                        "The claim type for a DenyOnlyWindowsDeviceGroup",
                        null,
                        "DenyOnlyWindowsDeviceGroup",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        42L,
                        null,
                        null,
                        "The claim type for a DisplayName",
                        null,
                        "DisplayName",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/displayname",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        43L,
                        null,
                        null,
                        "The claim type for a Dsa",
                        null,
                        "Dsa",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/dsa",
                        "http://www.w3.org/2000/09/xmldsig#DSAKeyValue"
                    },
                    {
                        44L,
                        null,
                        null,
                        "The claim type for a Expiration",
                        null,
                        "Expiration",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/expiration",
                        "http://www.w3.org/2001/XMLSchema#dateTime"
                    },
                    {
                        45L,
                        null,
                        null,
                        "The claim type for a Expired",
                        null,
                        "Expired",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/expired",
                        "http://www.w3.org/2001/XMLSchema#boolean"
                    },
                    {
                        46L,
                        null,
                        null,
                        "The claim type for a GroupSid",
                        null,
                        "GroupSid",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        47L,
                        null,
                        null,
                        "The claim type for a IsPersistent",
                        null,
                        "IsPersistent",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/ispersistent",
                        "http://www.w3.org/2001/XMLSchema#boolean"
                    },
                    {
                        48L,
                        null,
                        null,
                        "The claim type for a PrimaryGroupSid",
                        null,
                        "PrimaryGroupSid",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        49L,
                        null,
                        null,
                        "The claim type for a PrimarySid",
                        null,
                        "PrimarySid",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        50L,
                        null,
                        null,
                        "The claim type for a Role",
                        null,
                        "Role",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        51L,
                        null,
                        null,
                        "The claim type for a SerialNumber",
                        null,
                        "SerialNumber",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/serialnumber",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        52L,
                        null,
                        null,
                        "The claim type for a UserData",
                        null,
                        "UserData",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        53L,
                        null,
                        null,
                        "The claim type for a Version",
                        null,
                        "Version",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/version",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        54L,
                        null,
                        null,
                        "The claim type for a WindowsAccountName",
                        null,
                        "WindowsAccountName",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsaccountname",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        55L,
                        null,
                        null,
                        "The claim type for a WindowsDeviceClaim",
                        null,
                        "WindowsDeviceClaim",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        56L,
                        null,
                        null,
                        "The claim type for a WindowsDeviceGroup",
                        null,
                        "WindowsDeviceGroup",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        57L,
                        null,
                        null,
                        "The claim type for a WindowsFqbnVersion",
                        null,
                        "WindowsFqbnVersion",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsfqbnversion",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        58L,
                        null,
                        null,
                        "The claim type for a WindowsSubAuthority",
                        null,
                        "WindowsSubAuthority",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        59L,
                        null,
                        null,
                        "The claim type for a WindowsUserClaim",
                        null,
                        "WindowsUserClaim",
                        "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        60L,
                        null,
                        null,
                        "The claim type for a passwordchangeurl",
                        null,
                        "passwordchangeurl",
                        "http://schemas.microsoft.com/ws/2012/01/passwordchangeurl",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        61L,
                        null,
                        null,
                        "The claim type for a passwordexpirationdays",
                        null,
                        "passwordexpirationdays",
                        "http://schemas.microsoft.com/ws/2012/01/passwordexpirationdays",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        62L,
                        null,
                        null,
                        "The claim type for a passwordexpirationtime",
                        null,
                        "passwordexpirationtime",
                        "http://schemas.microsoft.com/ws/2012/01/passwordexpirationtime",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        63L,
                        null,
                        null,
                        "The claim type for a Anonymous",
                        null,
                        "Anonymous",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/anonymous",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        64L,
                        null,
                        null,
                        "The claim type for a Authenticated",
                        null,
                        "Authenticated",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authenticated",
                        "http://www.w3.org/2001/XMLSchema#boolean"
                    },
                    {
                        65L,
                        null,
                        null,
                        "The claim type for a AuthorizationDecision",
                        null,
                        "AuthorizationDecision",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/authorizationdecision",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        66L,
                        null,
                        null,
                        "The claim type for a Country",
                        null,
                        "Country",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        67L,
                        null,
                        null,
                        "The claim type for a DateOfBirth",
                        null,
                        "DateOfBirth",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth",
                        "http://www.w3.org/2001/XMLSchema#dateTime"
                    },
                    {
                        68L,
                        null,
                        null,
                        "The claim type for a DenyOnlySid",
                        null,
                        "DenyOnlySid",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        69L,
                        null,
                        null,
                        "The claim type for a Dns",
                        null,
                        "Dns",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dns",
                        "http://schemas.xmlsoap.org/identity/claims/dns"
                    },
                    {
                        70L,
                        null,
                        null,
                        "The claim type for a Email2005",
                        null,
                        "Email2005",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress",
                        "urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name"
                    },
                    {
                        71L,
                        null,
                        null,
                        "The claim type for a Gender",
                        null,
                        "Gender",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        72L,
                        null,
                        null,
                        "The claim type for a GivenName",
                        null,
                        "GivenName",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        73L,
                        null,
                        null,
                        "The claim type for a Hash",
                        null,
                        "Hash",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/hash",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        74L,
                        null,
                        null,
                        "The claim type for a HomePhone",
                        null,
                        "HomePhone",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/homephone",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/phone"
                    },
                    {
                        75L,
                        null,
                        null,
                        "The claim type for a Locality",
                        null,
                        "Locality",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/locality",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        76L,
                        null,
                        null,
                        "The claim type for a MobilePhone	",
                        null,
                        "MobilePhone	",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/phone"
                    },
                    {
                        77L,
                        null,
                        null,
                        "The claim type for a Name",
                        null,
                        "Name",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        78L,
                        null,
                        null,
                        "The claim type for a NameIdentifier",
                        null,
                        "NameIdentifier",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        79L,
                        null,
                        null,
                        "The claim type for a OtherPhone",
                        null,
                        "OtherPhone",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/phone"
                    },
                    {
                        80L,
                        null,
                        null,
                        "The claim type for a PostalCode",
                        null,
                        "PostalCode",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        81L,
                        null,
                        null,
                        "The claim type for a Rsa",
                        null,
                        "Rsa",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa",
                        "http://www.w3.org/2000/09/xmldsig#RSAKeyValue"
                    },
                    {
                        82L,
                        null,
                        null,
                        "The claim type for a Sid",
                        null,
                        "Sid",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        83L,
                        null,
                        null,
                        "The claim type for a Spn",
                        null,
                        "Spn",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/spn",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        84L,
                        null,
                        null,
                        "The claim type for a StateOrProvince",
                        null,
                        "StateOrProvince",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        85L,
                        null,
                        null,
                        "The claim type for a StreetAddress",
                        null,
                        "StreetAddress",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        86L,
                        null,
                        null,
                        "The claim type for a Surname",
                        null,
                        "Surname",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        87L,
                        null,
                        null,
                        "The claim type for a System",
                        null,
                        "System",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/system",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        88L,
                        null,
                        null,
                        "The claim type for a Thumbprint",
                        null,
                        "Thumbprint",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/thumbprint. A thumbprint is a globally unique SHA-1 hash of an X.509 certificate",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        89L,
                        null,
                        null,
                        "The claim type for a Upn2005",
                        null,
                        "Upn2005",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn",
                        "http://schemas.xmlsoap.org/identity/claimsUPN"
                    },
                    {
                        90L,
                        null,
                        null,
                        "The claim type for a Uri",
                        null,
                        "Uri",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        91L,
                        null,
                        null,
                        "The claim type for a Webpage",
                        null,
                        "Webpage",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/webpage",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        92L,
                        null,
                        null,
                        "The claim type for a X500DistinguishedName",
                        null,
                        "X500DistinguishedName",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/x500distinguishedname",
                        "urn:oasis:names:tc:xacml:1.0:data-type:x500Name"
                    },
                    {
                        93L,
                        null,
                        null,
                        "The claim type for a Actor",
                        null,
                        "Actor",
                        "http://schemas.xmlsoap.org/ws/2009/09/identity/claims/actor",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        94L,
                        null,
                        null,
                        "The claim type for a blank",
                        null,
                        "blank",
                        "https://dgmjr.io/identity/unknown",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        95L,
                        null,
                        null,
                        "The claim type for a acr",
                        null,
                        "acr",
                        "https://jwt.io/acr",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        96L,
                        null,
                        null,
                        "The claim type for a actort",
                        null,
                        "actort",
                        "https://jwt.io/actort",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        97L,
                        null,
                        null,
                        "The claim type for a aio",
                        null,
                        "aio",
                        "https://jwt.io/aio",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        98L,
                        null,
                        null,
                        "The claim type for a appid",
                        null,
                        "appid",
                        "https://jwt.io/appid",
                        "https://www.w3.org/2001/XMLSchema#uuidType"
                    },
                    {
                        99L,
                        null,
                        null,
                        "The claim type for a appidacr",
                        null,
                        "appidacr",
                        "https://jwt.io/appidacr",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        100L,
                        null,
                        null,
                        "The claim type for a at_hash",
                        null,
                        "at_hash",
                        "https://jwt.io/at_hash",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        101L,
                        null,
                        null,
                        "The claim type for a azp",
                        null,
                        "azp",
                        "https://jwt.io/azp",
                        "https://www.w3.org/2001/XMLSchema#uuidType"
                    },
                    {
                        102L,
                        null,
                        null,
                        "The claim type for a azpacr",
                        null,
                        "azpacr",
                        "https://jwt.io/azpacr",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        103L,
                        null,
                        null,
                        "The claim type for a birthdate",
                        null,
                        "birthdate",
                        "https://jwt.io/birthdate",
                        "http://www.w3.org/2001/XMLSchema#date"
                    },
                    {
                        104L,
                        null,
                        null,
                        "The claim type for a c_hash",
                        null,
                        "c_hash",
                        "https://jwt.io/c_hash",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        105L,
                        null,
                        null,
                        "The claim type for a email",
                        null,
                        "email",
                        "https://jwt.io/email",
                        "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"
                    },
                    {
                        106L,
                        null,
                        null,
                        "The claim type for a exp",
                        null,
                        "exp",
                        "https://jwt.io/exp",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        107L,
                        null,
                        null,
                        "The claim type for a familyname",
                        null,
                        "familyname",
                        "https://jwt.io/familyname",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        108L,
                        null,
                        null,
                        "The claim type for a givenname",
                        null,
                        "givenname",
                        "https://jwt.io/givenname",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        109L,
                        null,
                        null,
                        "The claim type for a groups:src1",
                        null,
                        "groups:src1",
                        "https://jwt.io/groups:src1",
                        "https://www.w3.org/2001/XMLSchema#json"
                    },
                    {
                        110L,
                        null,
                        null,
                        "The claim type for a hasgroups",
                        null,
                        "hasgroups",
                        "https://jwt.io/hasgroups",
                        "http://www.w3.org/2001/XMLSchema#boolean"
                    },
                    {
                        111L,
                        null,
                        null,
                        "The claim type for a iat",
                        null,
                        "iat",
                        "https://jwt.io/iat",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        112L,
                        null,
                        null,
                        "The claim type for a idp",
                        null,
                        "idp",
                        "https://jwt.io/idp",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        113L,
                        null,
                        null,
                        "The claim type for a iss",
                        null,
                        "iss",
                        "https://jwt.io/iss",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        114L,
                        null,
                        null,
                        "The claim type for a name",
                        null,
                        "name",
                        "https://jwt.io/name",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        115L,
                        null,
                        null,
                        "The claim type for a nameid",
                        null,
                        "nameid",
                        "https://jwt.io/nameid",
                        "http://www.w3.org/2001/XMLSchema#integer64"
                    },
                    {
                        116L,
                        null,
                        null,
                        "The claim type for a nbf",
                        null,
                        "nbf",
                        "https://jwt.io/nbf",
                        "http://www.w3.org/2001/XMLSchema#integer32"
                    },
                    {
                        117L,
                        null,
                        null,
                        "The claim type for a nonce",
                        null,
                        "nonce",
                        "https://jwt.io/nonce",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        118L,
                        null,
                        null,
                        "The claim type for a oid",
                        null,
                        "oid",
                        "https://jwt.io/oid",
                        "https://www.w3.org/2001/XMLSchema#uuidType"
                    },
                    {
                        119L,
                        null,
                        null,
                        "The claim type for a preferred_username",
                        null,
                        "preferred_username",
                        "https://jwt.io/preferred_username",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        120L,
                        null,
                        null,
                        "The claim type for a rh",
                        null,
                        "rh",
                        "https://jwt.io/rh",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        121L,
                        null,
                        null,
                        "The claim type for a scp",
                        null,
                        "scp",
                        "https://jwt.io/scp",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        123L,
                        null,
                        null,
                        "The claim type for a sub",
                        null,
                        "sub",
                        "https://jwt.io/sub",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        124L,
                        null,
                        null,
                        "The claim type for a tid",
                        null,
                        "tid",
                        "https://jwt.io/tid",
                        "https://www.w3.org/2001/XMLSchema#uuidType"
                    },
                    {
                        125L,
                        null,
                        null,
                        "The claim type for a unique_name",
                        null,
                        "unique_name",
                        "https://jwt.io/unique_name",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        126L,
                        null,
                        null,
                        "The claim type for a uti",
                        null,
                        "uti",
                        "https://jwt.io/uti",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        127L,
                        null,
                        null,
                        "The claim type for a ver",
                        null,
                        "ver",
                        "https://jwt.io/ver",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        128L,
                        null,
                        null,
                        "The claim type for a website",
                        null,
                        "website",
                        "https://jwt.io/website",
                        "https://www.w3.org/2001/XMLSchema#anyURI"
                    },
                    {
                        129L,
                        null,
                        null,
                        "The claim type for a objectid",
                        null,
                        "objectid",
                        "https://www.mongodb.com/docs/manual/reference/method/ObjectId",
                        "https://www.mongodb.com/docs/manual/reference/method/ObjectId"
                    },
                    {
                        130L,
                        null,
                        null,
                        "The claim type for a Custom",
                        null,
                        "Custom",
                        "urn:identity:claim:custom",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        131L,
                        null,
                        null,
                        "The claim type for a GenericClaimTypePattern",
                        null,
                        "GenericClaimTypePattern",
                        "urn:identity:claim:custom:{0}",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        132L,
                        null,
                        null,
                        "The claim type for a GenericClaimsIssuerTypePattern",
                        null,
                        "GenericClaimsIssuerTypePattern",
                        "urn:identity:claim:issuer:custom:{0}",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        133L,
                        null,
                        null,
                        "The claim type for a Unknown",
                        null,
                        "Unknown",
                        "urn:identity:claim:unknown",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        134L,
                        null,
                        null,
                        "The claim type for a SecurityStamp",
                        null,
                        "SecurityStamp",
                        "urn:identity:securitystamp",
                        "http://www.w3.org/2001/XMLSchema#string"
                    },
                    {
                        135L,
                        null,
                        null,
                        "The claim type for a LoginProviderPattern",
                        null,
                        "LoginProviderPattern",
                        "urn:users:login:provider:{0}",
                        "http://www.w3.org/2001/XMLSchema#string"
                    }
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_ApplicationUser<long>Id",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ApplicationUser<long>Id"
            );

            migrationBuilder.CreateIndex(
                name: "ix_tbl_ClaimType_Uri",
                schema: "id",
                table: "tbl_ClaimType",
                column: "Uri",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimType_ValueTypeUri",
                schema: "id",
                table: "tbl_ClaimType",
                column: "ValueTypeUri"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_ClaimValueType_Uri",
                schema: "id",
                table: "tbl_ClaimValueType",
                column: "Uri",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoleClaim_Issuer",
                schema: "id",
                table: "tbl_RoleClaim",
                column: "Issuer"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoleClaim_RoleId",
                schema: "id",
                table: "tbl_RoleClaim",
                column: "RoleId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_RoleClaim_Type",
                schema: "id",
                table: "tbl_RoleClaim",
                column: "Type"
            );

            migrationBuilder.CreateIndex(
                name: "ix_tbl_UserEmailAddress",
                schema: "id",
                table: "tbl_User",
                column: "EmailAddress"
            );

            migrationBuilder.CreateIndex(
                name: "ix_tbl_UserNormalizedEmailAddress",
                schema: "id",
                table: "tbl_User",
                column: "NormalizedEmailAddress"
            );

            migrationBuilder.CreateIndex(
                name: "ix_tbl_UserNormalizedUsername",
                schema: "id",
                table: "tbl_User",
                column: "NormalizedUsername"
            );

            migrationBuilder.CreateIndex(
                name: "ix_tbl_UserTelegramUsername",
                schema: "id",
                table: "tbl_User",
                column: "TelegramUsername"
            );

            migrationBuilder.CreateIndex(
                name: "ix_tbl_UserUsername",
                schema: "id",
                table: "tbl_User",
                column: "Username"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserClaim_Issuer",
                schema: "id",
                table: "tbl_UserClaim",
                column: "Issuer"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserClaim_Type",
                schema: "id",
                table: "tbl_UserClaim",
                column: "Type"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserClaim_UserId",
                schema: "id",
                table: "tbl_UserClaim",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserLogin_UserId",
                schema: "id",
                table: "tbl_UserLogin",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRole_RoleId",
                schema: "id",
                table: "tbl_UserRole",
                column: "RoleId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserRole_UserId",
                schema: "id",
                table: "tbl_UserRole",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_tbl_UserToken_UserId",
                schema: "id",
                table: "tbl_UserToken",
                column: "UserId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .DropTable(name: "tbl_RoleClaim", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_UserClaim", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserClaimHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_UserLogin", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserLoginHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_UserRole", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserRoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_UserToken", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserTokenHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_ClaimType", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_ClaimsIssuer", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimsIssuerHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_Role", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_RoleHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_ClaimValueType", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_ClaimValueTypeHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder
                .DropTable(name: "tbl_User", schema: "id")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "tbl_UserHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "id")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");
        }
    }
}
