using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddPathToIconForCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "922bb7fd-a658-47a6-bb99-0fc0e3bf4db4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5aa53fa-f046-41d3-b9a7-d956d884ff88");

            migrationBuilder.AddColumn<string>(
                name: "PathToIcon",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c545245e-2f70-4f27-89e9-e07e29622330", "4bcf7a9d-0911-47f0-8056-4a9842fc8aca", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b15d5dd-943e-4723-a639-8820d30a6219", "a9666d79-affe-42ab-9242-6c5f61d854b8", "admin", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b15d5dd-943e-4723-a639-8820d30a6219");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c545245e-2f70-4f27-89e9-e07e29622330");

            migrationBuilder.DropColumn(
                name: "PathToIcon",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5aa53fa-f046-41d3-b9a7-d956d884ff88", "1d90dfc9-fe8d-4fb0-be4c-805c02233b3e", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "922bb7fd-a658-47a6-bb99-0fc0e3bf4db4", "ad351fec-37dc-40c2-92bc-0e20a38ba5fa", "admin", null });
        }
    }
}
