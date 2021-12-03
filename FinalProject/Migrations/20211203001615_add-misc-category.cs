using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class addmisccategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 4, "Misc" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "CategoryId", "Description", "PersonId", "Title" },
                values: new object[] { 7, 4, "Can't be categorized in particular, but nourish and sleep is important, and keep me away from daily stress. Good.", 1, "Sleep" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
