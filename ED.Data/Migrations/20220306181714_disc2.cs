using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class disc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biological");

            migrationBuilder.DropTable(
                name: "Chemical");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Herbs",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAdress",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Herbs",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LabName",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "StreetAdress",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Product");

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
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
        }
    }
}
