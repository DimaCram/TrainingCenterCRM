using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddPathToIconForTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ae1ce9d-9ca6-4cb9-a169-75078aafcca6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697e2b8b-4207-4cc6-9aed-67c1fdff5a7d");

            migrationBuilder.AddColumn<string>(
                name: "PathToIcon",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5aa53fa-f046-41d3-b9a7-d956d884ff88", "1d90dfc9-fe8d-4fb0-be4c-805c02233b3e", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "922bb7fd-a658-47a6-bb99-0fc0e3bf4db4", "ad351fec-37dc-40c2-92bc-0e20a38ba5fa", "admin", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "922bb7fd-a658-47a6-bb99-0fc0e3bf4db4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5aa53fa-f046-41d3-b9a7-d956d884ff88");

            migrationBuilder.DropColumn(
                name: "PathToIcon",
                table: "Teachers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ae1ce9d-9ca6-4cb9-a169-75078aafcca6", "d7e66810-fdf2-408e-bc1a-3eee90bc99c3", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "697e2b8b-4207-4cc6-9aed-67c1fdff5a7d", "0937abea-deae-4b73-ba98-ad8c88f7f36d", "admin", null });
        }
    }
}
