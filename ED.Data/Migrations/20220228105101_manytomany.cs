using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Products_productsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Provider_providersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Providings");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_providersId",
                table: "Providings",
                newName: "IX_Providings_providersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providings",
                table: "Providings",
                columns: new[] { "productsProductId", "providersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Products_productsProductId",
                table: "Providings",
                column: "productsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Provider_providersId",
                table: "Providings",
                column: "providersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Products_productsProductId",
                table: "Providings");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Provider_providersId",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providings",
                table: "Providings");

            migrationBuilder.RenameTable(
                name: "Providings",
                newName: "ProductProvider");

            migrationBuilder.RenameIndex(
                name: "IX_Providings_providersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_providersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "productsProductId", "providersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Products_productsProductId",
                table: "ProductProvider",
                column: "productsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Provider_providersId",
                table: "ProductProvider",
                column: "providersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
