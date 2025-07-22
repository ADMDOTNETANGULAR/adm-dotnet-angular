using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShopping.OrderService.Migrations
{
    /// <inheritdoc />
    public partial class OrderDBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "ProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 2000 },
                    { 2, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 500 },
                    { 3, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, 900 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
