using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "crusts",
                columns: table => new
                {
                    CrustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crusts", x => x.CrustId);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVeg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "toppings",
                columns: table => new
                {
                    ToppingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToppingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVeg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toppings", x => x.ToppingId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_orders_users_CustId",
                        column: x => x.CustId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderdetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderdetails", x => new { x.OrderId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_orderdetails_items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderdetails_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "crusts",
                columns: new[] { "CrustId", "CrustName", "Price" },
                values: new object[,]
                {
                    { 1, "Neapolitan", 3f },
                    { 2, "Chicago-Deep-Dish", 5.5f },
                    { 3, "New-Haven-Style", 4f },
                    { 4, "Flatbread", 3.5f }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "ItemId", "IsVeg", "PizzaName", "Price", "Remarks" },
                values: new object[,]
                {
                    { 1, "Yes", "Cheese Pizza", 15f, "Classic Masterpiece" },
                    { 2, "Yes", "Veggie Pizza", 13f, "Flavoured with Capsicum,Pepper and Onions" },
                    { 3, "No", "Pepperoni Pizza", 16.5f, "Crispy,salty,round Pepperoni" },
                    { 4, "No", "Meat Pizza", 18.5f, "Ground Meat with Sausage" },
                    { 5, "No", "Margheritta Pizza", 18f, "Fresh Mozerilla,Basil and tomatoes" },
                    { 6, "No", "BBQ Chicken Pizza", 16f, "Tangy,sweet" },
                    { 7, "No", "Hawaiian Pizza", 20f, "Pineapple with ham,sweet n salty" }
                });

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "ToppingId", "IsVeg", "Price", "ToppingName" },
                values: new object[,]
                {
                    { 1, "Yes", 3f, "Green Pepper" },
                    { 2, "No", 5.5f, "Black Olives with Chicken pieces" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderdetails_ItemId",
                table: "orderdetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_CustId",
                table: "orders",
                column: "CustId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "crusts");

            migrationBuilder.DropTable(
                name: "orderdetails");

            migrationBuilder.DropTable(
                name: "toppings");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
