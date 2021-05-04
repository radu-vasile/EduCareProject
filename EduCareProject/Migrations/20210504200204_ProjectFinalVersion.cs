using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCareProject.Migrations
{
    public partial class ProjectFinalVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 23, 2, 3, 397, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "cee50e45-1e4b-44fe-950b-c5d002d0ef25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2c81ae-7c1d-41ce-b290-b70979d82af5",
                column: "ConcurrencyStamp",
                value: "f6abcb8f-e66a-4a95-ae0e-7809f111a77d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00a4e0a6-341c-47ff-902d-2e28da9275c3", "myTeacher@educare.ro", "AQAAAAEAACcQAAAAEDPFFY1I6Rp3E94MaC4MXnFfsU5yUgrxup4Zz2RWy/u1CSn3QVeOFz9CD8ojTWmZxQ==", "95566ff9-db67-4058-ad5a-f4401be4dc2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd39d272-5656-487a-82f2-2467d87c3839",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78aeae0e-f091-4a8a-b724-f6c2c3d8efd2", "myStudent@educare.ro", "AQAAAAEAACcQAAAAEECwjzJoDN7810yzIypz7NyziBjA7E4tFGqzjmwI7IEn9kwzOfP1fkv5a1TyrHhXAw==", "643fb3a6-3e73-40df-bdbc-e76cdf43ec30" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 23, 2, 3, 393, DateTimeKind.Local).AddTicks(3722));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 22, 57, 51, 967, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e305b1c6-f3e5-4a57-9164-a7fafb01245a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2c81ae-7c1d-41ce-b290-b70979d82af5",
                column: "ConcurrencyStamp",
                value: "426ccf79-d570-48d2-806a-b6f0161ab1ff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c014ab75-0de7-48d5-af41-aba56c0a663f", null, "AQAAAAEAACcQAAAAED2yxe8a09zhrtbk3+fElOQx6pSmXJbNynNB6W0Sr2OUVLdkGhIxlyG/5wi+46DbYQ==", "87c6c20b-88af-4ba7-820a-a68451aff722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd39d272-5656-487a-82f2-2467d87c3839",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707d74a1-7127-4332-8492-c90e1029eda9", null, "AQAAAAEAACcQAAAAEE3iCydHjpWMuNgzgNaaFvEUShog777R0gl+B3LfSiq7DB/EbdNnsf8NUH5ti17LHg==", "4c43c9ea-e84b-4b3f-82f1-37935b9e073f" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 22, 57, 51, 963, DateTimeKind.Local).AddTicks(9857));
        }
    }
}
