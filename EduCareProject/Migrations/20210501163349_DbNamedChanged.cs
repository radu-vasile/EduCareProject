using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCareProject.Migrations
{
    public partial class DbNamedChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswert",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswer",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 1, 19, 33, 48, 895, DateTimeKind.Local).AddTicks(2430));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswert",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 1, 19, 19, 30, 20, DateTimeKind.Local).AddTicks(5326));
        }
    }
}
