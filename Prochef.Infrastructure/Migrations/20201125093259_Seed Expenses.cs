using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prochef.Infrastructure.Migrations
{
    public partial class SeedExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Date", "IsDeleted", "ProductName", "UsedQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.20000000000000001 },
                    { 26, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.29999999999999999 },
                    { 25, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IceCream", 0.25 },
                    { 24, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.29999999999999999 },
                    { 23, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.29999999999999999 },
                    { 22, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.5 },
                    { 21, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.5 },
                    { 20, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.20000000000000001 },
                    { 19, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.20000000000000001 },
                    { 18, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.20000000000000001 },
                    { 17, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.29999999999999999 },
                    { 16, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.14999999999999999 },
                    { 15, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.14999999999999999 },
                    { 14, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IceCream", 0.29999999999999999 },
                    { 13, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IceCream", 0.29999999999999999 },
                    { 12, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.25 },
                    { 11, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.25 },
                    { 10, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.25 },
                    { 9, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IceCream", 0.20000000000000001 },
                    { 8, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.10000000000000001 },
                    { 7, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.10000000000000001 },
                    { 6, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.10000000000000001 },
                    { 5, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.10000000000000001 },
                    { 4, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.29999999999999999 },
                    { 3, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.29999999999999999 },
                    { 2, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 0.20000000000000001 },
                    { 27, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "IceCream", 0.25 },
                    { 28, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Meet", 0.40000000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 28);
        }
    }
}
