using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Hash", "Role", "Username" },
                values: new object[] { 1, "maintianer@partygame.com", "/imIZrAGnJSHx4r2QmSEhCnRVRuWByhoPSX7E9eLLECCh9Vn", 1, "Maintainer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
