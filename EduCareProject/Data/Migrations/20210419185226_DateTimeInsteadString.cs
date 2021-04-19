using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCare.Data.Migrations
{
    public partial class DateTimeInsteadString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Announcements",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CreatedOn",
                table: "Announcements",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
