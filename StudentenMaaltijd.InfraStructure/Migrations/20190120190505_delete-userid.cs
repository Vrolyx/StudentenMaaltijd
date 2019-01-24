using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.InfraStructure.Migrations
{
    public partial class deleteuserid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "CookStudentId",
                table: "Meals",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
