using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RosePlus.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Add_ProductToFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_File",
                columns: table => new
                {
                    PhotosId = table.Column<int>(type: "integer", nullable: false),
                    ProductEntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_File", x => new { x.PhotosId, x.ProductEntityId });
                    table.ForeignKey(
                        name: "FK_Product_File_Files_PhotosId",
                        column: x => x.PhotosId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_File_Products_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_File_ProductEntityId",
                table: "Product_File",
                column: "ProductEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_File");
        }
    }
}
