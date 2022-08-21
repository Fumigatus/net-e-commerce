using Microsoft.EntityFrameworkCore.Migrations;

namespace net_e_commerce.Migrations
{
    public partial class models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mint",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mint",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
