using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.InfraStructure.Migrations
{
    public partial class link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Students_CookStudentId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_CookStudentId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "CookStudentId",
                table: "Meals");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 23, 22, 3, 57, 343, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 21, 22, 3, 57, 345, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "PreperationTime",
                value: new DateTime(2019, 1, 22, 22, 3, 57, 345, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CookStudentId",
                table: "Meals",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CookStudentId",
                table: "Meals",
                column: "CookStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Students_CookStudentId",
                table: "Meals",
                column: "CookStudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
