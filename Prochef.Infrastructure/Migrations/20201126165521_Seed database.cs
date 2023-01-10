using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prochef.Infrastructure.Migrations
{
    public partial class Seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Vegetables" },
                    { 2, false, "Fruits" },
                    { 3, false, "Dairy" },
                    { 4, false, "Meet" },
                    { 5, false, "Eggs" },
                    { 6, false, "Seafood" },
                    { 7, false, "Cereals" }
                });

            migrationBuilder.InsertData(
                table: "MenuSections",
                columns: new[] { "Id", "IsDeleted", "MenuId", "Name" },
                values: new object[,]
                {
                    { 3, false, 1, "Drinks" },
                    { 4, false, 1, "Salads" },
                    { 1, false, 1, "Main dishes" },
                    { 2, false, 1, "Desserts" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Fridge" },
                    { 2, false, "Storeroom" },
                    { 3, false, "Pantry" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Address", "DeliveryTime", "Email", "IsDeleted", "Name", "Phone" },
                values: new object[,]
                {
                    { 6, "str Sumskay 19", 2.0, "seafoodDelivery@email.com", false, "SeafoodDelivery", "+380123123128" },
                    { 1, "str Sumskay 24", 3.0, "vegetablesDelivery@email.com", false, "VegetablesDelivery", "+380123123123" },
                    { 2, "str Sumskay 23", 2.0, "fruitDelivery@email.com", false, "FruitDelivery", "+380123123124" },
                    { 3, "str Sumskay 22", 3.0, "dairyDelivery@email.com", false, "DairyDelivery", "+380123123125" },
                    { 4, "str Sumskay 21", 4.0, "meetDelivery@email.com", false, "MeetDelivery", "+380123123126" },
                    { 5, "str Sumskay 20", 3.0, "eggsDelivery@email.com", false, "EggsDelivery", "+380123123127" },
                    { 7, "str Sumskay 18", 3.0, "cerealsDelivery@email.com", false, "CerealsDelivery", "+380123123129" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Calories", "CategoryId", "DeliveryDate", "IsDeleted", "Name", "PlaceId", "Price", "QuantityInStock", "State", "TermOfUse" },
                values: new object[,]
                {
                    { 3, 120.0, 4, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chicken", 1, 0.0, 5.0, 0, 3.0 },
                    { 4, 180.0, 4, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ham", 1, 0.0, 3.0, 0, 14.0 },
                    { 5, 200.0, 4, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Beef", 1, 0.0, 3.0, 0, 3.0 },
                    { 8, 50.0, 3, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Milk", 1, 0.0, 6.0, 0, 7.0 },
                    { 9, 360.0, 3, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cheese", 1, 0.0, 3.0, 0, 45.0 },
                    { 14, 80.0, 5, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Eggs", 1, 0.0, 40.0, 0, 30.0 },
                    { 15, 150.0, 6, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Salmon", 1, 0.0, 4.0, 0, 3.0 },
                    { 1, 400.0, 1, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Potato", 2, 0.0, 10.0, 0, 90.0 },
                    { 10, 30.0, 1, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cucumber", 2, 0.0, 6.0, 0, 14.0 },
                    { 11, 60.0, 1, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tomato", 2, 0.0, 6.0, 0, 14.0 },
                    { 2, 800.0, 7, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Oil", 3, 0.0, 15.0, 0, 720.0 },
                    { 6, 350.0, 7, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Flour", 3, 0.0, 5.0, 0, 360.0 },
                    { 12, 500.0, 3, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ice-cream", 3, 0.0, 10.0, 0, 180.0 },
                    { 13, 600.0, 7, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Chocolate", 3, 0.0, 5.0, 0, 360.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuSections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuSections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuSections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuSections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Products");
        }
    }
}
