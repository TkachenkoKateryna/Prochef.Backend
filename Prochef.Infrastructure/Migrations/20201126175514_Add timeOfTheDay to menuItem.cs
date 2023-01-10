using Microsoft.EntityFrameworkCore.Migrations;

namespace Prochef.Infrastructure.Migrations
{
    public partial class AddtimeOfTheDaytomenuItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeOfTheDay",
                table: "MenuItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeOfTheDay",
                table: "MenuItems");
        }
    }
}
