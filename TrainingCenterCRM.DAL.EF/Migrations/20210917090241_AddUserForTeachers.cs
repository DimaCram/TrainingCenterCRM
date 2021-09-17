using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddUserForTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "86f6fb82-7fb8-467f-becc-c56a4aaff0f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "6cfdac54-1e40-4146-b1aa-060a3f6e8c9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "1dccd77f-5794-4308-88ab-7b4ff0c48ac3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "175333c8-44e0-469d-ad91-064955d1e7b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32553d9-e780-4cce-a559-a3370062a95c", "AQAAAAEAACcQAAAAEOtM8F6dX8R81stmecwthNc3q6oQyOLP5iLytZ2ePKd8YbBlxHPHZaYtOLdn523keA==", "dd240c7f-9570-485b-9088-afaeaaaa0b9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b877c2e-1bcb-4674-9d22-dec280ad4257", "AQAAAAEAACcQAAAAEMhRjo0Cn/pdlWQhBn1Mml3z+tmRHx9tEd6/0V5HwkLAZNSAUQBQUNCXs43UTxgIkQ==", "2fc752c7-e39a-42e2-82ea-c3067e96e3fe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8594cfc3-4252-4502-80e9-5c9dc3341595", 0, "fb297cf5-0ec3-4fcc-8909-de4df7daa0af", "astreiko@gmail.com", true, false, null, "astreiko@gmail.com", "astreiko@gmail.com", "AQAAAAEAACcQAAAAEBMNB9c/KMv+oIFQnhb1EvQnZBlDTUKJxU3yuDNxR2wr1IOtjAJ7SBR8etigHO+VBA==", null, false, "e323941e-70da-4390-8de0-ea0116e8ada3", false, "astreiko@gmail.com" },
                    { "da19a821-caca-4aa8-b544-45dc830b99d1", 0, "720bc843-6569-4e67-b310-919d12bac7d7", "morgun@gmail.com", true, false, null, "morgun@gmail.com", "morgun@gmail.com", "AQAAAAEAACcQAAAAEMuTHcpPGf2YMzGbXOhxJd3cI+atLKczNNSgUx7j8pwYyZKMsgJ17HLHPNZ2jsQbgw==", null, false, "661cf81d-5f10-483c-a666-0bf981a63ef0", false, "morgun@gmail.com" },
                    { "4188500e-87e7-4375-937c-2a1670a84418", 0, "3e99d1b7-7aeb-44ce-b0bd-46b01d87af6e", "pinyutin@gmail.com", true, false, null, "pinyutin@gmail.com", "pinyutin@gmail.com", "AQAAAAEAACcQAAAAEEtFX4c8u2HY8GOql+hiVkjYiGx1G4js35tGqBOmw2E3hA36m/F//fMloum4ST/seQ==", null, false, "4cf38485-8bc9-48d4-a412-f628d7bbd7e0", false, "pinyutin@gmail.com" },
                    { "6eca67d1-8174-46d9-9916-ed620e57e00d", 0, "7dbf0845-09d6-441f-b138-c0c55bffc0be", "samsonov@gmail.com", true, false, null, "samsonov@gmail.com", "samsonov@gmail.com", "AQAAAAEAACcQAAAAEHXEbi8G4bjz9UPhRosZFQ3k/QgvKBEQW5Upuerxnb734C/g7Fr48HqbixbUo/O8hA==", null, false, "1c397160-d82d-4cf6-a1b0-59199a92bd0a", false, "samsonov@gmail.com" },
                    { "c05565d8-eaa8-4411-9b72-4ad0decdd06d", 0, "cd71ee78-5fe2-4164-9894-6f7a560138ba", "belkevich@gmail.com", true, false, null, "belkevich@gmail.com", "belkevich@gmail.com", "AQAAAAEAACcQAAAAEAKqTaxAoWdZOX3uWwqbmQZ2lsqczeMCZ4SzQmZYYrDdVjBq7a14PCNLLB4g+uN/YQ==", null, false, "3cd70434-f101-4890-a65b-3559e9c749b1", false, "belkevich@gmail.com" },
                    { "6743e8d1-bb94-48ca-83ce-cd14ba74d17b", 0, "3d555fd4-a8c0-49b4-8a63-051b65a766bd", "mazgo@gmail.com", true, false, null, "mazgo@gmail.com", "mazgo@gmail.com", "AQAAAAEAACcQAAAAEJB0DFKbKm97xU7noecB8G3uyQloDl1Umf0NivqCg1XnXY/X9M/8qjVT/jUnH1/I0g==", null, false, "e2fa139c-c044-40ad-8923-d0d757c21d36", false, "mazgo@gmail.com" },
                    { "79301f3b-d0ed-4331-9af8-7c751bce2f9b", 0, "205367fa-5613-41dc-b9cc-ced34362c54c", "voitekhovich.com", true, false, null, "voitekhovich@gmail.com", "voitekhovich@gmail.com", "AQAAAAEAACcQAAAAEB4U4zuDQFioVa3nrL23qJGwWJZkVqLkGKUqeMLYw/q/M+rlHpnZdVth1lT4Okd82A==", null, false, "682ce789-21c4-4d08-8b85-31da60b3f3f4", false, "voitekhovich@gmail.com" },
                    { "13309c41-4a79-402e-a5e4-63645c9ce8dd", 0, "7f3e72d7-6413-4f03-b8cd-d4aace902460", "sokol@gmail.com", true, false, null, "sokol@gmail.com", "sokol@gmail.com", "AQAAAAEAACcQAAAAEGi6JxFcY+kaI9qDRn1GnqZMYjfW27XMzMmih9LcF88UhtrjcwBBzvNH7TOHMkndAg==", null, false, "50c240c3-9fa4-4b54-9600-36bcbbd46886", false, "sokol@gmail.com" },
                    { "9eb23459-2eaa-40a0-ad80-2f3288665d19", 0, "c66ddc39-9c39-49e1-9dc7-690bdc03495d", "martsinkevich@gmail.com", true, false, null, "martsinkevich@gmail.com", "martsinkevich@gmail.com", "AQAAAAEAACcQAAAAENsn16NjlCykGd9v1R8kzfXYy1A03FIUfcdMj/IQhNoHNnSskd4tFWuoQoThu3kE0Q==", null, false, "62e8d153-1ad9-4ea1-9f6c-e5db5a9af251", false, "martsinkevich@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "8594cfc3-4252-4502-80e9-5c9dc3341595");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "da19a821-caca-4aa8-b544-45dc830b99d1");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "4188500e-87e7-4375-937c-2a1670a84418");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "6eca67d1-8174-46d9-9916-ed620e57e00d");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "c05565d8-eaa8-4411-9b72-4ad0decdd06d");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: "79301f3b-d0ed-4331-9af8-7c751bce2f9b");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: "13309c41-4a79-402e-a5e4-63645c9ce8dd");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "9eb23459-2eaa-40a0-ad80-2f3288665d19");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1");

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
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "ac503a98-08f4-4729-b262-a79559ee60a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "8c5fddc7-2504-43f6-8778-72b6d9e474c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0253327e-dcbd-432c-bc1a-8d149bddf304", "AQAAAAEAACcQAAAAEKqUGB3LwqRJgWrj51TOr20gDoSexdK8EYQAaIfRWi0AzXW1BHM7lRqg5e8ENZnBkg==", "1a358146-8a45-48f7-b21e-afb86bba7e5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3657fb66-c8d8-4856-85ba-7e837769cc29", "AQAAAAEAACcQAAAAEKLTNf1JF+RAv/bIYTpVcevFaue+TC0Q9F62KLmcZdFc8t7pTSKRSCzO1bGgxVPOlQ==", "d5cc4898-23fa-4601-a406-5e6d98167dfd" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: null);
        }
    }
}
