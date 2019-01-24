using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.InfraStructure.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 23, 21, 37, 33, 17, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 21, 21, 37, 33, 19, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 22, 21, 37, 33, 19, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 23, 20, 5, 5, 279, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 21, 20, 5, 5, 281, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 22, 20, 5, 5, 281, DateTimeKind.Local));
        }
    }
}
