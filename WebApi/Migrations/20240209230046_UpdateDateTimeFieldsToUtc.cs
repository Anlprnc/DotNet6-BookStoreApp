using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class UpdateDateTimeFieldsToUtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e09e0a9-fa4e-4156-b98b-9b643ad223c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8759ceb2-cd62-4334-8730-18572970f1c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb182ab4-5aee-4044-a81f-8b48e3e24637");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b995a6a-bb78-46b4-b9ad-897e3a8ae421", "ffdb6dde-5d35-4250-9cac-471cd317d4f7", "Editor", "EDITOR" },
                    { "7b945168-5fc9-4628-87d3-72f147f153dd", "7fb1e9a4-60c3-433f-9cd1-4c59bbe4cc83", "Admin", "ADMIN" },
                    { "f44ba33b-eb23-4fc7-8e8e-a81b81d98dcf", "d5243bab-809a-4648-af34-92907772ca28", "User", "USER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b995a6a-bb78-46b4-b9ad-897e3a8ae421");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b945168-5fc9-4628-87d3-72f147f153dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f44ba33b-eb23-4fc7-8e8e-a81b81d98dcf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e09e0a9-fa4e-4156-b98b-9b643ad223c2", "70b18f0e-3d8f-4e4d-9445-a9d9ef87407a", "Editor", "EDITOR" },
                    { "8759ceb2-cd62-4334-8730-18572970f1c0", "fb03a1d7-dd13-4e38-8e7b-24dcf0146544", "User", "USER" },
                    { "fb182ab4-5aee-4044-a81f-8b48e3e24637", "79579e35-63f8-4b21-9ead-42aaedce3a88", "Admin", "ADMIN" }
                });
        }
    }
}
