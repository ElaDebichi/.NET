using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class confclass1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_providersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providers",
                table: "Providers");

            migrationBuilder.RenameTable(
                name: "Providers",
                newName: "Prov");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Prov",
                newName: "Name");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Prov_providersId",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prov",
                table: "Prov");

            migrationBuilder.RenameTable(
                name: "Prov",
                newName: "Providers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Providers",
                newName: "Nom");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providers",
                table: "Providers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_providersId",
                table: "ProductProvider",
                column: "providersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
