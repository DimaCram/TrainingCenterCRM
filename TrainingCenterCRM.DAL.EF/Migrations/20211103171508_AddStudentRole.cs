using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddStudentRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "ff0a55f7-69c0-4009-a0ec-cae90dbf49f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "46fbb711-0223-4779-a784-01dce71e94ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "61cdbc51-3a61-4713-b79a-e7db8ec9eea0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f0d93b3-02a9-482b-b6d9-9ecbfcfb3e56", "acfc2326-21ea-4cd3-a8f8-f175072f8a92", "student", "student" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0646980b-85d7-4e0a-845a-6ee9d69f8f62", "AQAAAAEAACcQAAAAEEjK+rIdIMM7xXh1YYKZ3bf2GR7r3fs+yIqtsrmRblv2lwDm7V5m3tQzABjYjYr89A==", "cafa0ffe-c598-4ec8-8880-f936a6461ea9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daea1e55-7bfc-4e1b-b7b1-fd039ddefc21", "AQAAAAEAACcQAAAAEOfSQmxVRMG4cQdjzFoIE06enmYyuSfI972fEjabBgMw/xOkunLYxbI/nE4oLyLw1A==", "a0145ac8-40a3-43d4-bc31-bb884c8c14ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21a18355-a791-4c56-9512-f5565597d937", "AQAAAAEAACcQAAAAEA7qLDKCKz8e43cxqmRQG5Wlm7M+BuKpETXggC1tgB+aVR1aThCK4J0SiDu3MHxVQA==", "ed1a1fd9-32f3-467f-ba0e-1e3a9ee05b70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb654c1e-85c2-495c-ae66-b4fb0b2e9da7", "AQAAAAEAACcQAAAAEMRT+iZpNIsJf6E/Fj6VWCtxgv9Nd9v42rFJTV5JKN8lenT0oBfOWez5Zq/wGfEYeg==", "04b757e2-c5a5-4380-aaec-834a3da3dc34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2279415a-b91c-4c76-be06-168964eadf39", "AQAAAAEAACcQAAAAEAR8N8cwas329pcHzZvgFShukg4Wel94WdE59GxupYtE3adTNMHB7RK/0LBXhI/w2w==", "80e99ca7-ab54-4132-b4f0-fafe13fb7dd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dbd1059-2774-4dcd-bb80-01a8f45ddefe", "AQAAAAEAACcQAAAAEAE2rxJBWinQ8w8M28Eb1P8Gk7+q08tlkNQlylunNXLpssypnrBn4b0+PxjjpiyaUA==", "6cba5006-0df5-4e07-9ae3-2ae1662cece6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae2cbac0-874b-4cad-99e7-33bc77e133ff", "AQAAAAEAACcQAAAAEGExpei5olaLXQdtA/wpFm88pGZEVImLrHtThaVPqNbOd1ZuItb5fyENRQTj+NbABw==", "efa7b636-0042-4226-93d8-5a5e105c758b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b105619-b609-4cdb-94be-055813fe3523", "AQAAAAEAACcQAAAAEH1+yxjfPnpas/2NK9DuMwhVq5y513EQyvtIZFpGzqz62rm+4wlDYNMMW5RS3uB1pw==", "da314e8d-d585-4f1c-88e6-331ab456625b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f3d4b49-03a0-49b2-a2f3-b21463a06642", "AQAAAAEAACcQAAAAEJ2IqFWyzAHgjaJ6EN7jk3fPvNexQr3Oe0NRj1oZJe2lb8c7NH0P9vEQ1ghzQh9BmQ==", "3e4560f9-5d3b-47cd-9935-ef4d6bb49bc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c32f271e-5310-4142-be4c-8d1dcc47b1d6", "AQAAAAEAACcQAAAAEOdQtNfTllV9AOMWeAlzGcqFDLEH+l0rd/9FX7tM3qrNBnDx6Ag666qgvlJwxA6RrA==", "3f21c35f-b644-4afa-8332-2c3d779b4b8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd3aa926-232d-4d3a-b6ec-b3c50dc57d7a", "AQAAAAEAACcQAAAAEOY8xUU+YppMTO+p2KvhoD1uEtGLOEwZYQcPt6XFPhvUbLYSAMoBygLVbsyLaSoe7Q==", "84ffb868-ba4b-4fc6-9fa5-adeb11ab3f52" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20141624-04de-4fc2-aaf7-3154609f66f1", 0, "4cc1cd8f-7ef7-492c-a90d-d18bdd31427d", "fedorova@gmail.com", true, false, null, "fedorova@gmail.com", "fedorova@gmail.com", "AQAAAAEAACcQAAAAEIwNiQbG/hEhNHklsK/fEUfr8ndLjBvy51TK9+yexYHinJljOCNqFBc2vN9JHFoXQQ==", null, false, "9a1f7b6e-229a-41c8-8c20-050ad9847477", false, "fedorova@gmail.com" });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 1, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "CourseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 3, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 153,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 154,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 157,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 158,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 159,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 160,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 165,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 167,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 169,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 177,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 183,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 187,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 199,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 204,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 210,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 212,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 216,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 219,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 230,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 231,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 233,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 236,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 242,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 243,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 246,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 247,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 248,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 249,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 252,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 259,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 263,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 271,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 278,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 279,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 282,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 283,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 284,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 285,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 290,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 4, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 321,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 322,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 324,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 326,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 329,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 330,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 334,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 340,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 341,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 344,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 348,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 353,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 354,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 356,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 357,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 361,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 365,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 368,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 376,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 377,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 382,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 5, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 5, 3.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 418,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 420,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 421,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 423,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 429,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 6, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 6, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 6, 3.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 6, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 476,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 478,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 480,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 481,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 486,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 492,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 497,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 498,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 507,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 514,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 527,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 7, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 543,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 545,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 547,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 566,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 569,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 577,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 588,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 8, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 632,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 633,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 643,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 645,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 656,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 657,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 689,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 707,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 709,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 711,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 713,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 714,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 715,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 716,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 724,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 726,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 728,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 731,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 734,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 737,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 776,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 4 });

            migrationBuilder.InsertData(
                table: "CourseReviews",
                columns: new[] { "Id", "Comment", "CourseId", "Rating", "StudentId" },
                values: new object[,]
                {
                    { 797, null, 10, 1.0, 4 },
                    { 798, null, 10, 4.0, 10 },
                    { 809, null, 11, 2.0, 10 },
                    { 795, null, 10, 4.0, 14 },
                    { 800, null, 10, 2.0, 17 },
                    { 801, null, 10, 4.0, 13 },
                    { 796, null, 10, 3.0, 7 },
                    { 799, null, 10, 3.0, 19 },
                    { 808, null, 11, 2.0, 3 },
                    { 804, null, 11, 1.0, 15 },
                    { 806, null, 11, 4.0, 17 },
                    { 869, null, 11, 1.0, 14 },
                    { 868, null, 11, 2.0, 5 },
                    { 867, null, 11, 1.0, 11 },
                    { 866, null, 11, 3.0, 11 },
                    { 865, null, 11, 1.0, 10 },
                    { 864, null, 11, 3.0, 1 },
                    { 863, null, 11, 4.0, 12 },
                    { 862, null, 11, 4.0, 16 },
                    { 861, null, 11, 2.0, 15 },
                    { 860, null, 11, 2.0, 2 },
                    { 859, null, 11, 2.0, 7 },
                    { 858, null, 11, 2.0, 17 },
                    { 857, null, 11, 3.0, 10 },
                    { 856, null, 11, 2.0, 1 },
                    { 855, null, 11, 2.0, 5 },
                    { 854, null, 11, 4.0, 13 },
                    { 853, null, 11, 2.0, 19 },
                    { 870, null, 11, 3.0, 5 },
                    { 871, null, 11, 1.0, 6 },
                    { 872, null, 11, 4.0, 18 },
                    { 873, null, 11, 3.0, 14 },
                    { 805, null, 11, 1.0, 12 },
                    { 890, null, 11, 2.0, 4 },
                    { 889, null, 11, 4.0, 1 },
                    { 888, null, 11, 1.0, 2 },
                    { 887, null, 11, 3.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "CourseReviews",
                columns: new[] { "Id", "Comment", "CourseId", "Rating", "StudentId" },
                values: new object[,]
                {
                    { 886, null, 11, 4.0, 11 },
                    { 885, null, 11, 1.0, 3 },
                    { 884, null, 11, 1.0, 4 },
                    { 852, null, 11, 2.0, 18 },
                    { 883, null, 11, 3.0, 17 },
                    { 881, null, 11, 2.0, 18 },
                    { 880, null, 11, 1.0, 14 },
                    { 879, null, 11, 1.0, 10 },
                    { 878, null, 11, 1.0, 11 },
                    { 877, null, 11, 4.0, 17 },
                    { 876, null, 11, 2.0, 14 },
                    { 875, null, 11, 1.0, 16 },
                    { 874, null, 11, 3.0, 5 },
                    { 882, null, 11, 2.0, 18 },
                    { 851, null, 11, 2.0, 1 },
                    { 850, null, 11, 4.0, 9 },
                    { 849, null, 11, 1.0, 4 },
                    { 826, null, 11, 2.0, 9 },
                    { 825, null, 11, 3.0, 7 },
                    { 824, null, 11, 1.0, 4 },
                    { 823, null, 11, 4.0, 9 },
                    { 822, null, 11, 4.0, 3 },
                    { 821, null, 11, 2.0, 8 },
                    { 820, null, 11, 1.0, 17 },
                    { 819, null, 11, 1.0, 19 },
                    { 827, null, 11, 3.0, 8 },
                    { 818, null, 11, 1.0, 15 },
                    { 816, null, 11, 2.0, 11 },
                    { 815, null, 11, 2.0, 11 },
                    { 802, null, 10, 1.0, 10 },
                    { 814, null, 11, 3.0, 4 },
                    { 813, null, 11, 1.0, 7 },
                    { 812, null, 11, 1.0, 15 },
                    { 811, null, 11, 4.0, 10 },
                    { 810, null, 11, 4.0, 9 },
                    { 817, null, 11, 4.0, 19 },
                    { 803, null, 10, 2.0, 18 },
                    { 828, null, 11, 4.0, 4 },
                    { 830, null, 11, 2.0, 12 },
                    { 848, null, 11, 3.0, 11 },
                    { 847, null, 11, 3.0, 9 },
                    { 846, null, 11, 4.0, 8 }
                });

            migrationBuilder.InsertData(
                table: "CourseReviews",
                columns: new[] { "Id", "Comment", "CourseId", "Rating", "StudentId" },
                values: new object[,]
                {
                    { 845, null, 11, 1.0, 19 },
                    { 844, null, 11, 4.0, 8 },
                    { 843, null, 11, 1.0, 1 },
                    { 842, null, 11, 3.0, 1 },
                    { 841, null, 11, 1.0, 7 },
                    { 829, null, 11, 1.0, 14 },
                    { 840, null, 11, 4.0, 15 },
                    { 838, null, 11, 1.0, 11 },
                    { 837, null, 11, 2.0, 17 },
                    { 836, null, 11, 1.0, 8 },
                    { 835, null, 11, 4.0, 13 },
                    { 834, null, 11, 1.0, 2 },
                    { 833, null, 11, 1.0, 7 },
                    { 832, null, 11, 2.0, 12 },
                    { 831, null, 11, 1.0, 18 },
                    { 839, null, 11, 3.0, 19 },
                    { 807, null, 11, 1.0, 19 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3f0d93b3-02a9-482b-b6d9-9ecbfcfb3e56", "20141624-04de-4fc2-aaf7-3154609f66f1" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "20141624-04de-4fc2-aaf7-3154609f66f1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f0d93b3-02a9-482b-b6d9-9ecbfcfb3e56", "20141624-04de-4fc2-aaf7-3154609f66f1" });

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f0d93b3-02a9-482b-b6d9-9ecbfcfb3e56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20141624-04de-4fc2-aaf7-3154609f66f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "0d7b72a9-0dc3-4f5c-bc57-89e4dbb3ce1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "5f724b63-87a8-4992-af47-62dacdbb1554");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "e9bbcdce-cb58-49d9-ba5e-f4f057725f83");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "021cb353-a049-404c-b2f6-b067a48a3b9a", "b87b698d-d8ff-482b-8436-14432514389a", "user", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5903b30-a98a-48c9-9753-27ace8ce103c", "AQAAAAEAACcQAAAAEGEMNRJtWpvAeB2HhVFUYcacSQf2Pz30PUV2tQDZa4618KgBx5JTzZKbcaUqw7NqgQ==", "c3ceadbe-0b73-4a06-ac9a-65ff7c3db459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76c45adb-9491-45a2-9af9-64dba355c15b", "AQAAAAEAACcQAAAAEAVt6gtyD6rTtzyLSJ5SKKVyvDNJ4vXNyut1r8heyDzu3gOLM0cBTwf7xMcA+5sAxg==", "41cc9337-4d10-40b2-ae6d-c84c358bf15a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1e91c27-eb71-4bd2-9a84-c4312117f693", "AQAAAAEAACcQAAAAELdSuIlXSB+hogF5hf7UZ6DXoO+Roeij6KBq+MJRmbglihXwIKrgfc74UO8BmLqdHA==", "0d9750e0-2d5a-4736-aba0-c6a64c97e788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14eb92c8-dabd-436d-96e5-8ae0b09a7a47", "AQAAAAEAACcQAAAAEAl/vLbkou89lbOoukJziN4aVgGjnQzW+f0GQgHq9rvWxkWWDVwyzFRwbV3nBszWww==", "5f560622-550a-4c6b-a78d-5ebcbe58796f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af6fa14e-1418-4ed5-91f0-7da1c5f4e0b4", "AQAAAAEAACcQAAAAENR0HNrFCf3r9tay76u7N0glD7NhJRTtzbmFO5jZmDUTRuBs489S/Er3jT2/UGzg5Q==", "1ce44884-f469-42d8-a61d-142e3bf6f6a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a48f9aed-800b-42d5-a870-ebd8606ef13a", "AQAAAAEAACcQAAAAEKKG/QqFg15dBNzW45RmqkkqoDej4ehYxDYihqshg1tKIFB2k3B9JnoSXiMKnUwNxQ==", "30f8dd82-a434-4170-bf90-4e2e5fd65867" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18533449-b24b-43d6-a417-59d8773e9f17", "AQAAAAEAACcQAAAAEPzC60unepz7I+LPzOtiHiSSOPqER7DmZh9zDZDsx4beydOy0ukNNCoJCAjQDBTngw==", "a302c842-991e-41ee-951c-f002948ea9cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9993ac8-7820-4783-875a-c1ab14e0a839", "AQAAAAEAACcQAAAAEOgIkoMNuBymNuXwRKo23dHacLg9NlpfG6rhW9hfI90KoPAOegbqnoQy7/P/HJ2Xrg==", "a5d3392d-cf4a-4924-b523-5f83f0adc03a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "444543a8-fa9a-4628-9ef6-9a962fcbac80", "AQAAAAEAACcQAAAAEPs95SszSxmPF0aMeefsXzJwPmBgPZxDha86IuUtTiGxtGc1GqdSV+VkgRXtpTdU9A==", "a2e48503-433f-4e95-a05e-d0af32926238" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf118726-7ff8-4d6b-8098-8684fc1e37d4", "AQAAAAEAACcQAAAAEKZyOCChYB6mCEbp+zbH7286wbHwzOoZTfzzSTB7QxlMRzipzB/SQLDyIU3JQwciBg==", "85e362a9-56af-4f39-ad7b-40a46c9dec56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48c7619f-8259-4178-8726-2c76915d4589", "AQAAAAEAACcQAAAAEOK8hQGay00QQKfT1aCHTbmEebyoaAGzBQVsX8uKtKy+0T9dvOHGN2tCMmmwCYDWww==", "46400892-eb26-4b85-9da4-770b00424530" });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 27,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 33,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 38,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 39,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 41,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 42,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 44,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 46,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 2, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 74,
                column: "CourseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 87,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 93,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 95,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 98,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 104,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 109,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 112,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 113,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 121,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 127,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 2, 3.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 145,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 148,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 151,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 153,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 154,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 157,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 158,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 159,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 160,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 165,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 167,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 169,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 177,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 183,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 187,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 199,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 204,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 210,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 212,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 216,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 219,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 230,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 231,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 233,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 236,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 242,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 243,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 246,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 247,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 248,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 249,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 252,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 259,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 263,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 271,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 278,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 279,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 282,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 283,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 284,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 285,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 290,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 5, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 321,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 322,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 324,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 326,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 329,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 330,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 334,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 340,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 341,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 344,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 348,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 353,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 354,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 356,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 357,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 361,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 365,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 368,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 376,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 377,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 382,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 6, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 6, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 418,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 420,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 421,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 423,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 429,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 7, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 7, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 7, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 7, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 7, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 476,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 478,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 480,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 481,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 486,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 492,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 497,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 498,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 507,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 514,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 527,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 8, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 543,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 545,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 547,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 566,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 569,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 577,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 588,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 9, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 632,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 633,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 643,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 645,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 656,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 657,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 689,
                column: "CourseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 707,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 709,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 711,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 713,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 714,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 715,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 716,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 724,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 726,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 728,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 731,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 734,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 737,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 776,
                column: "CourseId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 11, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: null);
        }
    }
}
