using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b15d5dd-943e-4723-a639-8820d30a6219");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c545245e-2f70-4f27-89e9-e07e29622330");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Teachers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41679fa6-ff15-4d72-8668-d87abb7c1bb5", "b291a340-a166-4537-a390-9551df8d95ea", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce1c5004-6500-42da-8bf0-72361d8b1b51", "61de413d-357c-451f-8c6d-fda22ed879b9", "admin", null });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41679fa6-ff15-4d72-8668-d87abb7c1bb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce1c5004-6500-42da-8bf0-72361d8b1b51");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Students");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c545245e-2f70-4f27-89e9-e07e29622330", "4bcf7a9d-0911-47f0-8056-4a9842fc8aca", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b15d5dd-943e-4723-a639-8820d30a6219", "a9666d79-affe-42ab-9242-6c5f61d854b8", "admin", null });
        }
    }
}
