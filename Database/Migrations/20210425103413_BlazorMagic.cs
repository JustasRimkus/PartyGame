using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class BlazorMagic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hash",
                value: "DKqYIu4PWVk7YgzK4LuG/tPF/TYyaeg9y2BhVGHiuZoYQ8gk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hash",
                value: "/imIZrAGnJSHx4r2QmSEhCnRVRuWByhoPSX7E9eLLECCh9Vn");
        }
    }
}
