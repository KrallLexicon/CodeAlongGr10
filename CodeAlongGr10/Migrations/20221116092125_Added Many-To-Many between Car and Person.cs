using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    public partial class AddedManyToManybetweenCarandPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "CarPerson",
                columns: table => new
                {
                    CarsRegNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPerson", x => new { x.CarsRegNumber, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_CarPerson_Cars_CarsRegNumber",
                        column: x => x.CarsRegNumber,
                        principalTable: "Cars",
                        principalColumn: "RegNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarPerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CarPerson_PeopleId",
                table: "CarPerson",
                column: "PeopleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarPerson");

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
                values: new object[] { "448ac5ec-2565-4a1b-9908-b2655d64ddf7", 26, "Anna Andersson", "845621" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "97c03e0a-5c99-4a5e-870b-e1b1effb0738", 59, "Sven Svensson", "123456" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "d1b78b2f-4f15-4ec2-84ce-64918da23932", 34, "Jonathan Krall", "0737090202" });
        }
    }
}
