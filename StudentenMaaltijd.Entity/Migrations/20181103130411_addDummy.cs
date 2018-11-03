using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.Entity.Migrations
{
    public partial class addDummy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Meals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Meals",
                nullable: true);
        }
    }
}
