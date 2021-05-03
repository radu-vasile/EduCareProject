using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCareProject.Migrations
{
    public partial class ChangedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswert",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstAnswer",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondAnswer",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdAnswer",
                table: "Questions",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 1, 19, 19, 30, 20, DateTimeKind.Local).AddTicks(5326));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswert",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "FirstAnswer",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "SecondAnswer",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ThirdAnswer",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 4, 24, 18, 50, 40, 540, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }
    }
}
