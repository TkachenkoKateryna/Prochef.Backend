using Microsoft.EntityFrameworkCore.Migrations;

namespace Prochef.Infrastructure.Migrations
{
    public partial class Seeddatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "IsDeleted", "MenuItemId", "ProductId", "Weight" },
                values: new object[,]
                {
                    { 1, false, 1, 1, 0.20000000000000001 },
                    { 28, false, 7, 6, 0.070000000000000007 },
                    { 27, false, 7, 3, 0.29999999999999999 },
                    { 26, false, 6, 4, 0.20000000000000001 },
                    { 25, false, 6, 2, 0.050000000000000003 },
                    { 24, false, 6, 11, 0.10000000000000001 },
                    { 23, false, 6, 10, 0.10000000000000001 },
                    { 22, false, 5, 4, 0.20000000000000001 },
                    { 21, false, 5, 2, 0.050000000000000003 },
                    { 20, false, 5, 11, 0.10000000000000001 },
                    { 19, false, 5, 10, 0.10000000000000001 },
                    { 18, false, 4, 13, 0.050000000000000003 },
                    { 17, false, 4, 12, 0.29999999999999999 },
                    { 16, false, 3, 14, 1.0 },
                    { 15, false, 3, 11, 0.10000000000000001 },
                    { 14, false, 3, 10, 0.10000000000000001 },
                    { 13, false, 3, 9, 0.050000000000000003 },
                    { 12, false, 3, 8, 0.050000000000000003 },
                    { 11, false, 3, 6, 0.20000000000000001 },
                    { 10, false, 3, 5, 0.29999999999999999 },
                    { 9, false, 2, 14, 1.0 },
                    { 8, false, 2, 11, 0.10000000000000001 },
                    { 7, false, 2, 10, 0.10000000000000001 },
                    { 6, false, 2, 9, 0.050000000000000003 },
                    { 5, false, 2, 8, 0.050000000000000003 },
                    { 4, false, 2, 6, 0.20000000000000001 },
                    { 3, false, 2, 3, 0.29999999999999999 },
                    { 2, false, 1, 2, 0.050000000000000003 },
                    { 29, false, 7, 14, 1.0 },
                    { 30, false, 7, 2, 0.059999999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
