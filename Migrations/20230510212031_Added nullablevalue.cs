using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4API.Migrations
{
    public partial class Addednullablevalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 4, 5 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumns: new[] { "InterestId", "PersonId" },
                keyValues: new object[] { 4, 5 });

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
        }
    }
}
