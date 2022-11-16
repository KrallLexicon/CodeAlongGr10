using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    public partial class SeededsomePersondata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
