using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "311d092f-507e-4a1a-ba13-c1be9741f626");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "6bde87a5-aed6-410a-85b5-244d5cb7a9ab");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "75214a5e-c148-4b52-b659-30e45225ca32");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "93e25185-9ba4-4a99-9c6b-f7e23cfe0884", 59, "Sven Svensson", "123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "b6806142-f23b-44f2-be36-c09debc3c681", 34, "Jonathan Krall", "0737090202" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "e0a3ea6a-db74-4039-8035-0af4056eb635", 26, "Anna Andersson", "845621" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "93e25185-9ba4-4a99-9c6b-f7e23cfe0884");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "b6806142-f23b-44f2-be36-c09debc3c681");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "e0a3ea6a-db74-4039-8035-0af4056eb635");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "311d092f-507e-4a1a-ba13-c1be9741f626", 26, "Anna Andersson", "845621" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "6bde87a5-aed6-410a-85b5-244d5cb7a9ab", 34, "Jonathan Krall", "0737090202" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "75214a5e-c148-4b52-b659-30e45225ca32", 59, "Sven Svensson", "123456" });
        }
    }
}
