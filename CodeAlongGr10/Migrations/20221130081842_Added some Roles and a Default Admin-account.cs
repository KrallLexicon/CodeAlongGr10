using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAlongGr10.Migrations
{
    public partial class AddedsomeRolesandaDefaultAdminaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarPerson",
                keyColumns: new[] { "CarsRegNumber", "PeopleId" },
                keyValues: new object[] { "ABC-123", "ce976f58-6fb7-4759-8c58-b6a5ad194cc3" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "63c6a8fe-bb04-42ce-811a-762e937d3c30");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "dce42fbb-6d1d-4a72-ad4a-8185dab10ed0");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "ce976f58-6fb7-4759-8c58-b6a5ad194cc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54240856-ee17-4da4-85d8-d828054a40b2", "5e4f5d52-5678-46ed-b22d-8326f83d49b6", "Admin", "ADMIN" },
                    { "fdd6ab3b-ab7a-4cf5-87e5-1d287fe89093", "cd3c227b-5f1a-4d88-ac34-3eeeee189945", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0a59ddb-c674-4674-9e1e-8c1fc255cd81", 0, "899e417b-06fb-4f61-beea-69e0e4cdafcf", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOs13b0Mee5U25kS9tL1HdUtofhTkVM2VPwHeVx0T1xH7plfsuNQQiTm3oExNN1p+g==", null, false, "0d674525-629f-44e7-961f-f7e5d38f7c66", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "20a4177d-e629-4fdf-8f1e-37c0c68d858f", 59, "Sven Svensson", "123456" },
                    { "43a77eb0-8fa7-42e1-92cc-313a20eaad38", 26, "Anna Andersson", "845621" },
                    { "98db20e9-d466-40c2-8c10-d637fd2189f2", 34, "Jonathan Krall", "0737090202" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "54240856-ee17-4da4-85d8-d828054a40b2", "d0a59ddb-c674-4674-9e1e-8c1fc255cd81" });

            migrationBuilder.InsertData(
                table: "CarPerson",
                columns: new[] { "CarsRegNumber", "PeopleId" },
                values: new object[] { "ABC-123", "98db20e9-d466-40c2-8c10-d637fd2189f2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdd6ab3b-ab7a-4cf5-87e5-1d287fe89093");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54240856-ee17-4da4-85d8-d828054a40b2", "d0a59ddb-c674-4674-9e1e-8c1fc255cd81" });

            migrationBuilder.DeleteData(
                table: "CarPerson",
                keyColumns: new[] { "CarsRegNumber", "PeopleId" },
                keyValues: new object[] { "ABC-123", "98db20e9-d466-40c2-8c10-d637fd2189f2" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "20a4177d-e629-4fdf-8f1e-37c0c68d858f");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "43a77eb0-8fa7-42e1-92cc-313a20eaad38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54240856-ee17-4da4-85d8-d828054a40b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0a59ddb-c674-4674-9e1e-8c1fc255cd81");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "98db20e9-d466-40c2-8c10-d637fd2189f2");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "63c6a8fe-bb04-42ce-811a-762e937d3c30", 26, "Anna Andersson", "845621" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "ce976f58-6fb7-4759-8c58-b6a5ad194cc3", 34, "Jonathan Krall", "0737090202" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber" },
                values: new object[] { "dce42fbb-6d1d-4a72-ad4a-8185dab10ed0", 59, "Sven Svensson", "123456" });

            migrationBuilder.InsertData(
                table: "CarPerson",
                columns: new[] { "CarsRegNumber", "PeopleId" },
                values: new object[] { "ABC-123", "ce976f58-6fb7-4759-8c58-b6a5ad194cc3" });
        }
    }
}
