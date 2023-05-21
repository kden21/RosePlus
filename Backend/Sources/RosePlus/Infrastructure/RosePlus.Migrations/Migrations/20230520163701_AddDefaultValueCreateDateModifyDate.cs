using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RosePlus.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultValueCreateDateModifyDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "AttributeValues",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AttributeValues",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Attributes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Attributes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "AttributeValues",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "AttributeValues",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Attributes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Attributes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");
        }
    }
}
