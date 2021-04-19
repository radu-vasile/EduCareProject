using Microsoft.EntityFrameworkCore.Migrations;

namespace EduCare.Data.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_Accounts_UserIDAccountID",
                table: "Announcements");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_UserIDAccountID",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "UserIDAccountID",
                table: "Announcements");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Announcements",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserID",
                table: "Announcements",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_AspNetUsers_UserID",
                table: "Announcements",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_AspNetUsers_UserID",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_UserID",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Announcements");

            migrationBuilder.AddColumn<int>(
                name: "UserIDAccountID",
                table: "Announcements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserIDAccountID",
                table: "Announcements",
                column: "UserIDAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserID",
                table: "Accounts",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_Accounts_UserIDAccountID",
                table: "Announcements",
                column: "UserIDAccountID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
