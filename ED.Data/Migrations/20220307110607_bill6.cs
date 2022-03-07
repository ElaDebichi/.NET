using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class bill6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Client_ClientFk",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Products_ProductFk",
                table: "Bill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Bills");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_ClientFk",
                table: "Bills",
                newName: "IX_Bills_ClientFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Cin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bills",
                table: "Bills",
                columns: new[] { "ProductFk", "ClientFk", "Date" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Clients_ClientFk",
                table: "Bills",
                column: "ClientFk",
                principalTable: "Clients",
                principalColumn: "Cin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Products_ProductFk",
                table: "Bills",
                column: "ProductFk",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Clients_ClientFk",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Products_ProductFk",
                table: "Bills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bills",
                table: "Bills");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameTable(
                name: "Bills",
                newName: "Bill");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ClientFk",
                table: "Bill",
                newName: "IX_Bill_ClientFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Cin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                columns: new[] { "ProductFk", "ClientFk", "Date" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Client_ClientFk",
                table: "Bill",
                column: "ClientFk",
                principalTable: "Client",
                principalColumn: "Cin",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Products_ProductFk",
                table: "Bill",
                column: "ProductFk",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
