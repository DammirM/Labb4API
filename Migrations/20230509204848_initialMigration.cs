using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4API.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => new { x.PersonId, x.InterestId });
                    table.ForeignKey(
                        name: "FK_Links_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "ID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Creating software applications", "Programming" },
                    { 2, "Playing and listening to music", "Music" },
                    { 3, "Playing and watching sports", "Sports" },
                    { 4, "Reading books and articles", "Reading" },
                    { 5, "Playing video games", "Gaming" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "FirstName", "Phone" },
                values: new object[,]
                {
                    { 1, "Damir", "0762445962" },
                    { 2, "Daniel", "653242784295" },
                    { 3, "Alvin", "3275839145734289" },
                    { 4, "Charlie", "3473895374896327" },
                    { 5, "Petter", "7589324653248967" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "InterestId", "PersonId", "ID", "Url" },
                values: new object[,]
                {
                    { 2, 1, 1, "https://www.google.com" },
                    { 3, 2, 2, "https://www.github.com" },
                    { 1, 3, 3, "https://www.stackoverflow.com" },
                    { 5, 4, 4, "https://www.microsoft.com" },
                    { 4, 5, 5, "https://www.amazon.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestId",
                table: "Links",
                column: "InterestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
