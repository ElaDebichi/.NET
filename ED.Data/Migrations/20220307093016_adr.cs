using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class adr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Products",
                newName: "Adress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "Adress_City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress_StreetAdress",
                table: "Products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "Adress_City",
                table: "Products",
                newName: "City");
        }
    }
}
