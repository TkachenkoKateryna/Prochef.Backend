using Microsoft.EntityFrameworkCore.Migrations;

namespace Prochef.Infrastructure.Migrations
{
    public partial class Seeddatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "Price", "SectionId" },
                values: new object[,]
                {
                    { 1, "Potato fried in the oil", false, "French Fries", 0.0, 1 },
                    { 2, "2 Buns with chicken, cheese and vegetables", false, "Chicken Burger", 0.0, 1 },
                    { 3, "2 Buns with beef, cheese and vegetables", false, "Beef burger", 0.0, 1 },
                    { 4, "Ice-cream with chocolate", false, "Ice-cream", 0.0, 2 },
                    { 5, "Vegetables with ham", false, "Salad with ham", 0.0, 3 },
                    { 6, "Vegetables with salmon", false, "Salad with salmon", 0.0, 3 },
                    { 7, "Chicken fried in flour and eggs", false, "Chicken Nuggets", 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "VendorCategories",
                columns: new[] { "CategoryId", "VendorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "VendorCategories",
                keyColumns: new[] { "CategoryId", "VendorId" },
                keyValues: new object[] { 7, 7 });
        }
    }
}
