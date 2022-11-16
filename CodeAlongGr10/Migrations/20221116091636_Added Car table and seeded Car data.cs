using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    public partial class AddedCartableandseededCardata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    RegNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.RegNumber);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "RegNumber", "Brand", "CarModel" },
                values: new object[] { "ABC-123", "SAAB", "93" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "448ac5ec-2565-4a1b-9908-b2655d64ddf7", 26, "Anna Andersson", "845621" },
                    { "97c03e0a-5c99-4a5e-870b-e1b1effb0738", 59, "Sven Svensson", "123456" },
                    { "d1b78b2f-4f15-4ec2-84ce-64918da23932", 34, "Jonathan Krall", "0737090202" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "448ac5ec-2565-4a1b-9908-b2655d64ddf7");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "97c03e0a-5c99-4a5e-870b-e1b1effb0738");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "d1b78b2f-4f15-4ec2-84ce-64918da23932");

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
    }
}
