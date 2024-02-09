using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class eıorjgıwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "996dff40-1dce-4cd9-8464-5e8d68699794");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aabcb2e9-b86a-4c4e-9d08-a3c1e13fda54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f94a7e81-0808-4578-a1ad-2ca8c608206b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "996dff40-1dce-4cd9-8464-5e8d68699794", "69fa2e8e-8633-49ed-bc31-0928bf15146d", "Admin", "ADMIN" },
                    { "aabcb2e9-b86a-4c4e-9d08-a3c1e13fda54", "9da92bb3-9b9c-4b9f-b896-51a8ba3e7686", "Editor", "EDITOR" },
                    { "f94a7e81-0808-4578-a1ad-2ca8c608206b", "355158e0-900f-40b0-9660-9edd465d6454", "User", "USER" }
                });
        }
    }
}
