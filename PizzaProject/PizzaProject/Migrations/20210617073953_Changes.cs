using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaProject.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CrustName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PizzaName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToppingName",
                table: "orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrustName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "PizzaName",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "ToppingName",
                table: "orders");
        }
    }
}
