using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41679fa6-ff15-4d72-8668-d87abb7c1bb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce1c5004-6500-42da-8bf0-72361d8b1b51");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61732d5c-0d57-4657-a68b-949aa3254313", "bfc4c303-587f-4ff7-9a7f-e6633c1d8faf", "user", null },
                    { "019e6e91-7fb4-4c8f-881d-96123b1fa282", "f2f505eb-0e64-4e2e-ae25-190554653c77", "admin", null },
                    { "74039d94-9b6e-4682-a271-d5dff1f659c5", "459ae805-ffd0-4161-854b-7ffc75a8692d", "teacher", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94", 0, "9b93285c-6150-403f-b119-5c9f6c05a1e9", "rukavichnikova@gmail.com", true, false, null, null, "rukavichnikova@gmail.com", "AQAAAAEAACcQAAAAEDCASrnrf95Jzne0M/VgI0LhTsdIezLbkdY5jK4OIBaWkR2gcjRhMwpRVwL5V01EHw==", null, false, "73072bf5-bf86-424d-bc41-570520a4f2ae", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74039d94-9b6e-4682-a271-d5dff1f659c5", "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UserId" },
                values: new object[] { "Elena", "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41679fa6-ff15-4d72-8668-d87abb7c1bb5", "b291a340-a166-4537-a390-9551df8d95ea", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce1c5004-6500-42da-8bf0-72361d8b1b51", "61de413d-357c-451f-8c6d-fda22ed879b9", "admin", null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UserId" },
                values: new object[] { "Elena ", null });
        }
    }
}
