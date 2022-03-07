using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class confclass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Prov_providersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prov",
                table: "Prov");

            migrationBuilder.RenameTable(
                name: "Prov",
                newName: "Provider");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provider",
                table: "Provider",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Provider_providersId",
                table: "ProductProvider",
                column: "providersId",
                principalTable: "Provider",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Provider_providersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provider",
                table: "Provider");

            migrationBuilder.RenameTable(
                name: "Provider",
                newName: "Prov");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prov",
                table: "Prov",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Prov_providersId",
                table: "ProductProvider",
                column: "providersId",
                principalTable: "Prov",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
