using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCareProject.Migrations
{
    public partial class NewFieldInAssignmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfQuestions",
                table: "Assignments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 24, 18, 50, 40, 540, DateTimeKind.Local).AddTicks(4328));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfQuestions",
                table: "Assignments");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 22, 9, 47, 25, 160, DateTimeKind.Local).AddTicks(4040));
        }
    }
}
