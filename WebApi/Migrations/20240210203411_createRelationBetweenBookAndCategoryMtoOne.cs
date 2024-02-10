using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class createRelationBetweenBookAndCategoryMtoOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6077ca34-ef3f-49bb-8659-0ee47bde4d72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77bf37a0-ea83-44e7-90f2-e86d573f351f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99a4cbf0-d394-437c-a0ea-0508ce3313fd");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a6ca1a1-94b2-4274-80b8-cd6d3fde4f72", "4728a7ef-e335-41ce-8135-36486bcb0109", "Admin", "ADMIN" },
                    { "a7f0c1a1-4abf-4769-829d-f5528a2beae7", "b2b4e0f1-8faa-4d94-b4d6-6edb453f3106", "User", "USER" },
                    { "fba2a7ce-114c-4146-8233-4efbdfc0a18c", "a0f8140d-a8c3-42b3-80c6-e20eb4d9c0fc", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a6ca1a1-94b2-4274-80b8-cd6d3fde4f72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7f0c1a1-4abf-4769-829d-f5528a2beae7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fba2a7ce-114c-4146-8233-4efbdfc0a18c");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6077ca34-ef3f-49bb-8659-0ee47bde4d72", "ef308c3a-4304-41e5-a7a8-ec19f5f02c33", "Editor", "EDITOR" },
                    { "77bf37a0-ea83-44e7-90f2-e86d573f351f", "4a9c10ca-a27d-45f8-b5ff-1618fe4ec3d3", "Admin", "ADMIN" },
                    { "99a4cbf0-d394-437c-a0ea-0508ce3313fd", "8f537d85-c219-423e-b90c-9fae45ee8760", "User", "USER" }
                });
        }
    }
}
