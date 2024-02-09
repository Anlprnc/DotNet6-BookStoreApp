using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7266d9bd-acd4-4eee-b963-36e3e4ce7eaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4417ce0-56c7-401e-a975-54606b82c766");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffc393ca-7d6d-42bc-90b9-75cd34055f00");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "7266d9bd-acd4-4eee-b963-36e3e4ce7eaf", "c73449ae-0e96-4118-93ab-95565e19bfa8", "Admin", "ADMIN" },
                    { "a4417ce0-56c7-401e-a975-54606b82c766", "74ea119e-57ed-4019-ae09-2d40d17a5151", "User", "USER" },
                    { "ffc393ca-7d6d-42bc-90b9-75cd34055f00", "3b68bc69-1a3b-471e-8306-b7b4ef6dcf32", "Editor", "EDITOR" }
                });
        }
    }
}
