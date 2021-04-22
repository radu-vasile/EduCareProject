using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCareProject.Migrations
{
    public partial class SeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcements",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Announcements",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CreatedOn", "Description", "Title" },
                values: new object[] { 1, new DateTime(2021, 4, 22, 9, 47, 25, 160, DateTimeKind.Local).AddTicks(4040), "ABCDEF", "First assignment" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AssignmentId", "Content" },
                values: new object[] { 1, 1, "ABC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }
    }
}
