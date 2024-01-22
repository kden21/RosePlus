using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RosePlus.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class EditFKProductAttributeValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValues_Attributes_AttributeId",
                table: "AttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValues_Products_Id",
                table: "AttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_AttributeValues_AttributeId",
                table: "AttributeValues");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AttributeValues",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_ProductId",
                table: "AttributeValues",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValues_Attributes_ProductId",
                table: "AttributeValues",
                column: "ProductId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValues_Products_ProductId",
                table: "AttributeValues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValues_Attributes_ProductId",
                table: "AttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValues_Products_ProductId",
                table: "AttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_AttributeValues_ProductId",
                table: "AttributeValues");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AttributeValues",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_AttributeId",
                table: "AttributeValues",
                column: "AttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValues_Attributes_AttributeId",
                table: "AttributeValues",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValues_Products_Id",
                table: "AttributeValues",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
