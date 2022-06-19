using Microsoft.EntityFrameworkCore.Migrations;

namespace NatoursRepositoryLayer.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeopleBooked",
                table: "packages");

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "packages",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "packages");

            migrationBuilder.AddColumn<int>(
                name: "PeopleBooked",
                table: "packages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
