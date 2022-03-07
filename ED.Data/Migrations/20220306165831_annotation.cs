using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class annotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Products_productsProductId",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Herbs",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LabName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StreetAdress",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.CreateTable(
                name: "Biological",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Herbs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biological", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Biological_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chemical",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LabName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAdress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chemical", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Chemical_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Product_productsProductId",
                table: "Providings",
                column: "productsProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Product_productsProductId",
                table: "Providings");

            migrationBuilder.DropTable(
                name: "Biological");

            migrationBuilder.DropTable(
                name: "Chemical");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Herbs",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAdress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "categoryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Products_productsProductId",
                table: "Providings",
                column: "productsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
