using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.InfraStructure.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 20, 17, 9, 53, 958, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 20, 17, 9, 53, 960, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 20, 17, 9, 53, 960, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 15, 0, 5, 19, 341, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 15, 0, 5, 19, 343, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 15, 0, 5, 19, 343, DateTimeKind.Local));
        }
    }
}
