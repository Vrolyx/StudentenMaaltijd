using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentenMaaltijd.InfraStructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MealName = table.Column<string>(nullable: true),
                    PreperationTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MaxAllowedGuests = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "MealStudents",
                columns: table => new
                {
                    MealStudentId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    MealId = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealStudents", x => new { x.MealId, x.StudentId });
                    table.UniqueConstraint("AK_MealStudents_MealStudentId", x => x.MealStudentId);
                    table.ForeignKey(
                        name: "FK_MealStudents_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "Description", "MaxAllowedGuests", "MealName", "PreperationTime", "Price" },
                values: new object[,]
                {
                    { 1, "Super lekkere Chili", 6, "Chili con carne", new DateTime(2019, 1, 15, 0, 1, 43, 830, DateTimeKind.Local), 7.00m },
                    { 2, "Super lekkere spaghetti", 6, "Spaghetti", new DateTime(2019, 1, 15, 0, 1, 43, 832, DateTimeKind.Local), 2.00m },
                    { 3, "Super lekkere stampot", 6, "Stampot", new DateTime(2019, 1, 15, 0, 1, 43, 832, DateTimeKind.Local), 5.00m }
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
                columns: new[] { "MealId", "StudentId", "MealStudentId", "Role" },
                values: new object[,]
                {
                    { 3, 1, 2, "gast" },
                    { 3, 2, 3, "gast" },
                    { 3, 3, 1, "kok" },
                    { 3, 4, 4, "gast" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealStudents_StudentId",
                table: "MealStudents",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealStudents");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
