using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class bill3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Client_ClientCin",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Products_ProductId",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ClientCin",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ProductId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "ClientCin",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Bill");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ProductFk",
                table: "Bill",
                column: "ProductFk");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Client_ClientFk",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Products_ProductFk",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ProductFk",
                table: "Bill");

            migrationBuilder.AddColumn<int>(
                name: "ClientCin",
                table: "Bill",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Bill",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ClientCin",
                table: "Bill",
                column: "ClientCin");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ProductId",
                table: "Bill",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Client_ClientCin",
                table: "Bill",
                column: "ClientCin",
                principalTable: "Client",
                principalColumn: "Cin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Products_ProductId",
                table: "Bill",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
