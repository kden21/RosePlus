using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RosePlus.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddProductDefaultValueDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComputedColumnSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "current_timestamp at time zone 'UTC'",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComputedColumnSql: "current_timestamp at time zone 'UTC'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                computedColumnSql: "current_timestamp at time zone 'UTC'",
                stored: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                computedColumnSql: "current_timestamp at time zone 'UTC'",
                stored: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "current_timestamp at time zone 'UTC'");
        }
    }
}
