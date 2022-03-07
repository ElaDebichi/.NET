using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class bill5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ProductFk",
                table: "Bill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                columns: new[] { "ProductFk", "ClientFk", "Date" });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ClientFk",
                table: "Bill",
                column: "ClientFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ClientFk",
                table: "Bill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                columns: new[] { "ClientFk", "ProductFk", "Date" });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ProductFk",
                table: "Bill",
                column: "ProductFk");
        }
    }
}
