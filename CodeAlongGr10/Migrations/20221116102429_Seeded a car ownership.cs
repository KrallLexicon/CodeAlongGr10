using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    public partial class Seededacarownership : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "506f160f-fa70-4b39-be15-99cfc192edd9");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d0c17b10-e648-4c6d-8258-19cd5f8c4ade");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d10534fb-1812-43f0-8cea-5d211458d0b3");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "47e00f99-b7a7-4c9a-8f3a-220ae409dbd1", 59, "Sven Svensson", "123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "7ee8a988-beff-4aaa-9bff-f92980fd48b3", 26, "Anna Andersson", "845621" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "c2fdfbce-ee16-4bde-be11-762854a8f654", 34, "Jonathan Krall", "0737090202" });

            migrationBuilder.InsertData(
                table: "CarPerson",
                columns: new[] { "CarsRegNumber", "PeopleId" },
                values: new object[] { "ABC-123", "c2fdfbce-ee16-4bde-be11-762854a8f654" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarPerson",
                keyColumns: new[] { "CarsRegNumber", "PeopleId" },
                keyValues: new object[] { "ABC-123", "c2fdfbce-ee16-4bde-be11-762854a8f654" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "47e00f99-b7a7-4c9a-8f3a-220ae409dbd1");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7ee8a988-beff-4aaa-9bff-f92980fd48b3");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "c2fdfbce-ee16-4bde-be11-762854a8f654");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "506f160f-fa70-4b39-be15-99cfc192edd9", 26, "Anna Andersson", "845621" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "d0c17b10-e648-4c6d-8258-19cd5f8c4ade", 59, "Sven Svensson", "123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "d10534fb-1812-43f0-8cea-5d211458d0b3", 34, "Jonathan Krall", "0737090202" });
        }
    }
}
