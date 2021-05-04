using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCareProject.Migrations
{
    public partial class SeedChangedPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 23, 6, 11, 51, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "72b77f2d-cc61-4e00-9d34-9fb804457644");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2c81ae-7c1d-41ce-b290-b70979d82af5",
                column: "ConcurrencyStamp",
                value: "21f667ac-2393-4ef5-89b0-591612cf6d6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7451f78b-1ac7-4f43-9332-a7be44a782bd", "AQAAAAEAACcQAAAAEEd2cwju0R72lFB4YtOr2UDYL/462C1U3pKOpobwyQ+OGXLlPNf2q7E6VTW6uyTWJg==", "a20c7c12-45f5-4380-bbab-eae6aec6809b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd39d272-5656-487a-82f2-2467d87c3839",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dde102c4-b656-4759-88d7-4cecdc515525", "AQAAAAEAACcQAAAAEIgnzoQJtZUYn+4LINjLOzORav89e+kqbDLBXSoZkZpkXUGk2boioq4jC1H+Ww6EDA==", "10d3326b-1bd1-46c1-8f31-3225592dd42b" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 23, 6, 11, 47, DateTimeKind.Local).AddTicks(5706));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 23, 4, 49, 463, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b3552605-b5b1-402a-810d-a430a3d96fe9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2c81ae-7c1d-41ce-b290-b70979d82af5",
                column: "ConcurrencyStamp",
                value: "fcb13d98-a9c0-4a3a-8e73-d3b1c406b2ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01572def-9041-4edb-986a-93fa1a8b6ae3", "parola", "842acf76-5690-4f1a-95f3-dfe0380af151" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd39d272-5656-487a-82f2-2467d87c3839",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f20a2e6-00e1-45b9-a2dc-a1cf1ded2e86", "parola", "d8a21d88-4693-4138-ab68-fa61076acbe9" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 5, 4, 23, 4, 49, 458, DateTimeKind.Local).AddTicks(8707));
        }
    }
}
