using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication13.DAL.Migrations
{
    public partial class build2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "payments");

            migrationBuilder.AddColumn<int>(
                name: "money",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "money",
                table: "payments");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "payments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
