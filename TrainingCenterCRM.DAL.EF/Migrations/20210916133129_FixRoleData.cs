using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class FixRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "6b042bd9-6471-4f63-aa39-73c4b8454dbd", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "e115b62b-01a9-4607-8d41-c0b0a5195d17", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1a15cc5f-041b-4a42-adbf-cbbcf012db68", "teacher" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "893acb2e-7188-4f3d-ae5b-b1c83779e8db", "AQAAAAEAACcQAAAAEETvfSHV7qWiRn/HkGEHY19maS0KJLQEC2LAOVA0+VkJGTas7BeaFpDMQOC+hyrpag==", "bcc7fc4d-8c5e-4190-a1bb-280c990c2a7b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "ae7934fd-7ae5-4a04-84c0-37dd6c66db62", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "9bd903a7-b8d3-4aa8-947e-a3ce8bffa451", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "00886498-12b1-4d26-9267-8469fc5516db", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df7a980a-af26-4507-9431-e19fdc32cb14", "AQAAAAEAACcQAAAAEBCSfce/DM5QBhYPDxrtefzHB+9yFbeWNY2r54HcEg0MDZJ01csld1EK/Fhba9NNmw==", "7e009511-4a00-41aa-be37-e6cc508aa974" });
        }
    }
}
