using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "FirstName", "Gender", "LastName", "StudentClass", "Subject" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 10, 18, 10, 139, DateTimeKind.Utc).AddTicks(662), "John", "Male", "Deo", "Senior secondar school", "Math" },
                    { 2, new DateTime(2023, 6, 1, 10, 18, 10, 139, DateTimeKind.Utc).AddTicks(673), "Carlos", "Female", "Temi", "Senior secondar school", "Math" },
                    { 3, new DateTime(2023, 6, 1, 10, 18, 10, 139, DateTimeKind.Utc).AddTicks(675), "Dayo", "Male", "Benson", "Senior secondar school", "Math" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "SubjectDescription", "SubjectName" },
                values: new object[,]
                {
                    { 1, "Duo aliquyam at blandit ea enim et clita amet sanctus amet sanctus amet sanctus", "Mathematic" },
                    { 2, "Duo aliquyam at blandit ea enim et clita amet sanctus amet sanctus amet sanctus", "Computer Science" },
                    { 3, "Duo aliquyam at blandit ea enim et clita amet sanctus amet sanctus amet sanctus", "English Language" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
