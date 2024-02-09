using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRefreshTokenFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

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
    }
}
