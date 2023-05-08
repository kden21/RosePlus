using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RosePlus.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Add_AttributeConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeEntityCategoryEntity_AttributeEntity_AttributesId",
                table: "AttributeEntityCategoryEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeEntityCategoryEntity_Categories_CategoriesId",
                table: "AttributeEntityCategoryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeEntityCategoryEntity",
                table: "AttributeEntityCategoryEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeEntity",
                table: "AttributeEntity");

            migrationBuilder.RenameTable(
                name: "AttributeEntityCategoryEntity",
                newName: "Category_Attribute");

            migrationBuilder.RenameTable(
                name: "AttributeEntity",
                newName: "Attributes");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeEntityCategoryEntity_CategoriesId",
                table: "Category_Attribute",
                newName: "IX_Category_Attribute_CategoriesId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Attributes",
                type: "character varying(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category_Attribute",
                table: "Category_Attribute",
                columns: new[] { "AttributesId", "CategoriesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Attribute_Attributes_AttributesId",
                table: "Category_Attribute",
                column: "AttributesId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Attribute_Categories_CategoriesId",
                table: "Category_Attribute",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Attribute_Attributes_AttributesId",
                table: "Category_Attribute");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Attribute_Categories_CategoriesId",
                table: "Category_Attribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category_Attribute",
                table: "Category_Attribute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes");

            migrationBuilder.RenameTable(
                name: "Category_Attribute",
                newName: "AttributeEntityCategoryEntity");

            migrationBuilder.RenameTable(
                name: "Attributes",
                newName: "AttributeEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Category_Attribute_CategoriesId",
                table: "AttributeEntityCategoryEntity",
                newName: "IX_AttributeEntityCategoryEntity_CategoriesId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AttributeEntity",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(400)",
                oldMaxLength: 400);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeEntityCategoryEntity",
                table: "AttributeEntityCategoryEntity",
                columns: new[] { "AttributesId", "CategoriesId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeEntity",
                table: "AttributeEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeEntityCategoryEntity_AttributeEntity_AttributesId",
                table: "AttributeEntityCategoryEntity",
                column: "AttributesId",
                principalTable: "AttributeEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeEntityCategoryEntity_Categories_CategoriesId",
                table: "AttributeEntityCategoryEntity",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
