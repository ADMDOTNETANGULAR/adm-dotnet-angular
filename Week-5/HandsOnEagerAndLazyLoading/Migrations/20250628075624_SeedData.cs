using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnEagerAndLazyLoading.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "Date",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldMaxLength: 5);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "C001", "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { "C002", "Books" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price" },
                values: new object[] { 1, "C001", "Laptop", 50000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price" },
                values: new object[] { 2, "C001", "Smartphone", 20000.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price" },
                values: new object[] { 3, "C002", "Fiction Book", 300.0 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "ProductId" },
                values: new object[] { new Guid("70ae1a29-e142-42a6-864e-98a83593542d"), new DateTime(2025, 6, 28, 13, 26, 24, 347, DateTimeKind.Local).AddTicks(6374), 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "ProductId" },
                values: new object[] { new Guid("76575f09-43a0-4de7-b2fc-4d1091e48807"), new DateTime(2025, 6, 28, 13, 26, 24, 347, DateTimeKind.Local).AddTicks(6358), 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "OrderDate", "ProductId" },
                values: new object[] { new Guid("e3a9f50a-8ed3-4ef4-afed-2fcd173ff730"), new DateTime(2025, 6, 28, 13, 26, 24, 347, DateTimeKind.Local).AddTicks(6376), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("70ae1a29-e142-42a6-864e-98a83593542d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("76575f09-43a0-4de7-b2fc-4d1091e48807"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e3a9f50a-8ed3-4ef4-afed-2fcd173ff730"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "C001");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "C002");

            migrationBuilder.AlterColumn<string>(
                name: "OrderDate",
                table: "Orders",
                type: "char(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldMaxLength: 5);
        }
    }
}
