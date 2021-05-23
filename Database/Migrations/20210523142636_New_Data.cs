using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class New_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Name a House You Never Want to Be In: " },
                    { 2, "Name Something Associated with Vampires: " },
                    { 3, "Name Something in a Bakery a Baker Might Call His Wife: " },
                    { 4, "Tell Me A Word That Rhymes with “Election”: " },
                    { 5, "Name Something Snowmen Might Have Nightmares About: " }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hash",
                value: "mBYs2jkBi9RZupsILs74MfO/nRx9dVw31zjBJ4KQXefiBbS2");

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Popularity", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, 27, 1, "Haunted House" },
                    { 23, 5, 3, "Donut" },
                    { 24, 4, 3, "Doughy" },
                    { 25, 32, 4, "Selection" },
                    { 26, 23, 4, "Erection" },
                    { 27, 6, 4, "Perfection" },
                    { 28, 6, 4, "Detection" },
                    { 29, 5, 4, "Protection" },
                    { 22, 5, 3, "Sugar" },
                    { 30, 4, 4, "Rejectionr" },
                    { 32, 4, 4, "Section" },
                    { 33, 62, 5, "Sun" },
                    { 34, 14, 5, "Fire" },
                    { 35, 3, 5, "Blow Dryers" },
                    { 36, 3, 5, "Rain" },
                    { 37, 3, 5, "Shovel" },
                    { 38, 2, 5, "Drought" },
                    { 31, 4, 4, "Collection" },
                    { 21, 7, 3, "Muffin" },
                    { 20, 8, 3, "Cupcake" },
                    { 19, 9, 3, "Sweetie" },
                    { 2, 11, 1, "Jail" },
                    { 3, 8, 1, "Doghouse" },
                    { 4, 7, 1, "Drug House" },
                    { 5, 7, 1, "Small House" },
                    { 6, 6, 1, "Glass House" },
                    { 7, 5, 1, "Cat House" },
                    { 8, 5, 1, "Outhouse" },
                    { 9, 33, 2, "Twilight" },
                    { 10, 29, 2, "Blood" },
                    { 11, 9, 2, "Garlic" },
                    { 12, 7, 2, "Bat" },
                    { 13, 7, 2, "Cape" },
                    { 14, 5, 2, "Dracula" },
                    { 15, 4, 2, "Fangs" },
                    { 16, 4, 2, "Halloween" },
                    { 17, 32, 3, "Buns" },
                    { 18, 9, 3, "His Oven" },
                    { 39, 2, 5, "Snowballs" },
                    { 40, 2, 5, "Peeing Dogs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Hash",
                value: "WrsPW+exqGYsO2XgWjg+sOm9I/+ry2zfHHwreUMmdVpvJb6/");
        }
    }
}
