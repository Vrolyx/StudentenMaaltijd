using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.InfraStructure.Migrations
{
    public partial class deletemealstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 15, 0, 1, 43, 830, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 15, 0, 1, 43, 832, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 15, 0, 1, 43, 832, DateTimeKind.Local));
        }
    }
}
