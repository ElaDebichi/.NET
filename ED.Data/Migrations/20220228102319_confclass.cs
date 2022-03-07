using Microsoft.EntityFrameworkCore.Migrations;

namespace ED.Data.Migrations
{
    public partial class confclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Providers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Username",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValue: "Username");
        }
    }
}
