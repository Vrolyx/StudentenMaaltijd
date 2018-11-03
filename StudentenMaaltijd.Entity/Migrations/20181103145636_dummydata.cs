using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.Entity.Migrations
{
    public partial class dummydata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "Description", "MaxAllowedGuests", "MealName", "PreperationTime", "Price" },
                values: new object[,]
                {
                    { 1, "Super lekkere Chili", 6, "Chili con carne", new DateTime(2018, 11, 3, 7, 56, 35, 686, DateTimeKind.Local), 7.00m },
                    { 2, "Super lekkere spaghetti", 6, "Spaghetti", new DateTime(2018, 11, 3, 7, 56, 35, 687, DateTimeKind.Local), 2.00m },
                    { 3, "Super lekkere stampot", 6, "Stampot", new DateTime(2018, 11, 3, 7, 56, 35, 687, DateTimeKind.Local), 5.00m }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "PhoneNumber", "StudentName" },
                values: new object[,]
                {
                    { 1, "wessel.vrolijks@gmail.com", "0681839791", "Wessel Vrolijks" },
                    { 2, "rvgoor@gmail.com", "0612345678", "Ruben van Goor" },
                    { 3, "mvbergen@gmail.com", "06456925", "Milan van Bergen" },
                    { 4, "svwichen@gmail.com", "0642376589", "Stijn van Wichen" },
                    { 5, "ddgroot@gmail.com", "0612078506", "Derk de Groot" }
                });

            migrationBuilder.InsertData(
                table: "MealStudents",
                columns: new[] { "MealId", "StudentId", "Role" },
                values: new object[,]
                {
                    { 3, 1, "gast" },
                    { 3, 2, "gast" },
                    { 3, 3, "kok" },
                    { 3, 4, "gast" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MealStudents",
                keyColumns: new[] { "MealId", "StudentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "MealStudents",
                keyColumns: new[] { "MealId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MealStudents",
                keyColumns: new[] { "MealId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "MealStudents",
                keyColumns: new[] { "MealId", "StudentId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);
        }
    }
}
