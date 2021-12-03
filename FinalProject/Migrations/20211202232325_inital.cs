using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                    table.ForeignKey(
                        name: "FK_Hobbies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hobbies_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 1, "Computer" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Title" },
                values: new object[] { 2, "Cooking" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "Description", "FirstName", "LastName" },
                values: new object[] { 1, "Takuro Fukuda is the person born in Japan in 1999, but living in the US alone over five years. He started his carrer in programming field since he was 10 years old.", "Takuro", "Fukuda" });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "CategoryId", "Description", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Takuro likes programming. He made his hobby for his job.", 1, "Programming" },
                    { 2, 1, "Takuro also likes net surfing. Whenever he have free time, he did netsurfing to expand his knowledges.", 1, "Net surfing" },
                    { 3, 2, "Takuro learned how to make Japanese meal in the elementary school. And he likes to cook and eat that. Though it is not easy in the US.", 1, "Japanese meal" },
                    { 4, 2, "In the US, it is easy to cook american meal so he decide to learn how to make it.", 1, "American meal" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_CategoryId",
                table: "Hobbies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_PersonId",
                table: "Hobbies",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
