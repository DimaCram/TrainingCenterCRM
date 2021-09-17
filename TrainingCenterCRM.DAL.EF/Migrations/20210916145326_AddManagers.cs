using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddManagers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "344a913b-2e66-4feb-b33f-53376318ff54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "0ac0ce4b-336c-433c-93e9-20d0e573df1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "8c5fddc7-2504-43f6-8778-72b6d9e474c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d5aeb79-50ca-48db-91dc-3a72f06c978f", "ac503a98-08f4-4729-b262-a79559ee60a1", "manager", "manager" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0253327e-dcbd-432c-bc1a-8d149bddf304", "AQAAAAEAACcQAAAAEKqUGB3LwqRJgWrj51TOr20gDoSexdK8EYQAaIfRWi0AzXW1BHM7lRqg5e8ENZnBkg==", "1a358146-8a45-48f7-b21e-afb86bba7e5c" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9888c09b-2509-4cda-a82e-3dbea07d94eb", 0, "3657fb66-c8d8-4856-85ba-7e837769cc29", "manager@gmail.com", true, false, null, "manager@gmail.com", "manager@gmail.com", "AQAAAAEAACcQAAAAEKLTNf1JF+RAv/bIYTpVcevFaue+TC0Q9F62KLmcZdFc8t7pTSKRSCzO1bGgxVPOlQ==", null, false, "d5cc4898-23fa-4601-a406-5e6d98167dfd", false, "manager@gmail.com" });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Name", "Surname", "UserId" },
                values: new object[] { 1, "Dima", "Kramkov", "9888c09b-2509-4cda-a82e-3dbea07d94eb" });

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "6b042bd9-6471-4f63-aa39-73c4b8454dbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "e115b62b-01a9-4607-8d41-c0b0a5195d17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "1a15cc5f-041b-4a42-adbf-cbbcf012db68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893acb2e-7188-4f3d-ae5b-b1c83779e8db", "AQAAAAEAACcQAAAAEETvfSHV7qWiRn/HkGEHY19maS0KJLQEC2LAOVA0+VkJGTas7BeaFpDMQOC+hyrpag==", "bcc7fc4d-8c5e-4190-a1bb-280c990c2a7b" });
        }
    }
}
