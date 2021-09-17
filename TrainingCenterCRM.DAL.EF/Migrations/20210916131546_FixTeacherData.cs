using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class FixTeacherData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "019e6e91-7fb4-4c8f-881d-96123b1fa282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61732d5c-0d57-4657-a68b-949aa3254313");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74039d94-9b6e-4682-a271-d5dff1f659c5", "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74039d94-9b6e-4682-a271-d5dff1f659c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "021cb353-a049-404c-b2f6-b067a48a3b9a", "ae7934fd-7ae5-4a04-84c0-37dd6c66db62", "user", null },
                    { "800ac90f-e24c-485a-8be4-5869972e12a7", "9bd903a7-b8d3-4aa8-947e-a3ce8bffa451", "admin", null },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "00886498-12b1-4d26-9267-8469fc5516db", "teacher", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "df7a980a-af26-4507-9431-e19fdc32cb14", "rukavichnikova@gmail.com", "AQAAAAEAACcQAAAAEBCSfce/DM5QBhYPDxrtefzHB+9yFbeWNY2r54HcEg0MDZJ01csld1EK/Fhba9NNmw==", "7e009511-4a00-41aa-be37-e6cc508aa974", "rukavichnikova@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61732d5c-0d57-4657-a68b-949aa3254313", "bfc4c303-587f-4ff7-9a7f-e6633c1d8faf", "user", null },
                    { "019e6e91-7fb4-4c8f-881d-96123b1fa282", "f2f505eb-0e64-4e2e-ae25-190554653c77", "admin", null },
                    { "74039d94-9b6e-4682-a271-d5dff1f659c5", "459ae805-ffd0-4161-854b-7ffc75a8692d", "teacher", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9b93285c-6150-403f-b119-5c9f6c05a1e9", null, "AQAAAAEAACcQAAAAEDCASrnrf95Jzne0M/VgI0LhTsdIezLbkdY5jK4OIBaWkR2gcjRhMwpRVwL5V01EHw==", "73072bf5-bf86-424d-bc41-570520a4f2ae", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74039d94-9b6e-4682-a271-d5dff1f659c5", "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94" });
        }
    }
}
