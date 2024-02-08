using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a631c22-acc2-4dc4-b2bd-162bfa42c007", "197b3fda-a70d-44dc-869a-752d96a791ba", "User", "USER" },
                    { "50ebdc3a-2928-4252-bbd4-537aaf54f27e", "e792aa74-c909-4217-ab94-6c726b9cec6f", "Editor", "EDITOR" },
                    { "f2127084-080a-41b0-ac13-c1412b38386d", "86f4fc6c-999d-4b7a-ad1c-68ce32d284cb", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a631c22-acc2-4dc4-b2bd-162bfa42c007");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50ebdc3a-2928-4252-bbd4-537aaf54f27e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2127084-080a-41b0-ac13-c1412b38386d");
        }
    }
}
