using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class extracategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 3, "Traveling" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "CategoryId", "Description", "PersonId", "Title" },
                values: new object[] { 5, 3, "Driving between Tokyo and Osaka in 6 hours in U-Haul size truck. Speed maniac? Maybe.", 1, "Driving" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "CategoryId", "Description", "PersonId", "Title" },
                values: new object[] { 6, 3, "Not million miler, but travel over 40000 miles per year by airplane. Mileage craze.", 1, "Airplane" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
