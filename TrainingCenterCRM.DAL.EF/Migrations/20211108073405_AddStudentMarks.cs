using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddStudentMarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "StudentMarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<byte>(type: "tinyint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentMarks_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentMarks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f0d93b3-02a9-482b-b6d9-9ecbfcfb3e56",
                column: "ConcurrencyStamp",
                value: "df3b14f9-a67e-4b8c-b70e-0a2baf0f2c63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "15d999e0-727a-4f08-99c8-f889da900b7b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "9d2b8684-3202-4217-8ae6-6d703f01f7a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "06ce99fc-e1f7-4416-b759-19312bb36714");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57432256-f34e-4a2d-ac72-118c2ee0e1da", "AQAAAAEAACcQAAAAEFSD70/dEDale/Yh/WSxUWjU1ST/cpP6bdIDWDADxWADqHdTdeDvfcUaUoXHSFChyA==", "ba64f502-532a-4708-9869-78a9ec1e25d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20141624-04de-4fc2-aaf7-3154609f66f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c01a368-070c-4c3b-a30f-52cb7a100bbd", "AQAAAAEAACcQAAAAEJB8Wx3DCf8zQfb7K9SXrsobMg2OJsXNeZQodCamO8niNi/UDl4r+Ocgnb3uA3k1nw==", "136aee40-25ce-465d-bb0c-e8f405697c3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e566f077-00bb-40f1-8be7-ef7d5ed34d3b", "AQAAAAEAACcQAAAAEMPKAk/Hb8GU2cPvjt6MN1Z1A6lUHrnmRXVGpaP3uEQTf9yuGnoYoavn25TXuhKO7Q==", "742a79a6-22de-4ccc-9be2-6cf515a74eca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4abc1ef-ef59-449b-911e-75d4cef3fe6e", "AQAAAAEAACcQAAAAEAmyhU+wg5gUT354/R8pkfvY0/A7pj1Bxd6jMNuCH/NogzpLi3az9TStI8Z/0iyqUA==", "70927cf4-5a08-4bf3-afaa-ce2cc0939323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8e40fd2-c6e9-41c0-83c0-d7274682853b", "AQAAAAEAACcQAAAAEErnCv02KywXXi4+EiGTOVnoUFPIzQSzCqaevMKWCNUeCtj89aAMoVzWM5GdDbGIcQ==", "b3122473-b037-45c9-bb31-29bae469ea30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41d6061b-1dee-48c9-bf50-52762cc547ff", "AQAAAAEAACcQAAAAEON0mTUPDof90PkXDlfGxGWFybdlelTCyIU4st5VzegJ+VvQok+6CWmD7IW8/ujUPg==", "e4e484f8-5eca-4bf9-ae0c-312245740809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fe5a77-29cc-4dea-8633-dbdd2b75104a", "AQAAAAEAACcQAAAAEK80YTm1IwsFiZj6sJy8NKlyV/lrcwiF3MIATejBMvCtDPqrT1GD8B391YX8Zto6YQ==", "a6b5fe61-db46-4145-be89-cecb7cb785eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee7498d-f78e-4f23-9af1-6eba1e563424", "AQAAAAEAACcQAAAAEFvFjne3bbTQE4Qzk6tpJJwPCTdbChNSi1q/2ksy9rmwb/fS9u816ZzllQq7L677qg==", "08ccfb26-5166-4a6e-a647-fab6e6394def" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03af19d4-0e3d-4795-bbff-24c58ea37f26", "AQAAAAEAACcQAAAAEBuGr2JVcItIlPXODCtgGHY8U1+OfcJXqMjYQf70E4wizSA/ATi0ZRCHHkFP7d2pGg==", "334ab019-b20f-48b9-b844-f3c0b9c0daec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19bab30d-e76d-46cf-9457-9e9907279cbc", "AQAAAAEAACcQAAAAECh4dbGUKnKuHhZHzX6ToXAFxag1BJDhon/0wF7ZVFruNCyKt5oGmTA2UM0p4ZVAxQ==", "640e504d-7ee8-4050-82fc-fc42228b1c3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040924c8-6971-4c9d-acb2-5e12d068d293", "AQAAAAEAACcQAAAAEDUIcAl56VzOqspu6a7ErWJ/OYs2/ppW/d97I1U2k7JwRjTPPze2Q4GCnUh/iFpmJg==", "941d8165-d7ca-4989-b531-420172623b3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca4a20f5-5d29-4cf9-8e10-7e74eb77e1ba", "AQAAAAEAACcQAAAAEKyUh3Z5KyfyQh/LhPOA0U5M/RqXsCIQUWYUG2RggqRmCCEs/FCcnckhBR6SlJBH0w==", "8dc5fc19-3707-46bb-a9c8-6b2012aa0f08" });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 30,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 31,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 53,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 54,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 55,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 76,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 81,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 85,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 91,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 103,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 106,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 108,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 117,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 119,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 123,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 126,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 131,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 2, 3.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 2, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 2, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 158,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 161,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 162,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 163,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 164,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 167,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 170,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 173,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 174,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 181,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 182,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 192,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 195,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 201,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 209,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 217,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 218,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 223,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 224,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 227,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 252,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 255,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 258,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 260,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 264,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 268,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

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
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 272,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 274,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 279,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 282,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 284,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 285,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 287,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 288,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 291,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 299,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 303,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 304,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 312,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 313,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 314,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 317,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 318,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 4, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 357,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 359,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 360,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 361,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 364,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 367,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 369,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 371,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 373,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 396,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 401,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 402,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 404,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 408,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 410,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 415,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 432,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 440,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 441,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 443,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 448,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 449,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 450,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 451,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 452,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 454,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 455,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 457,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 459,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 460,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 470,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 478,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 479,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 481,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 483,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 487,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 488,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 506,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 512,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 515,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 516,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 519,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 531,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 532,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 536,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 537,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 7, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 549,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 562,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 566,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 580,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 583,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 589,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 591,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 592,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 599,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 600,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 606,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 608,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 618,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 619,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 623,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 624,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 630,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 635,
                column: "CourseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 8, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 649,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 652,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 656,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 659,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 663,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 664,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 665,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 670,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 679,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 682,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 688,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 689,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 691,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 692,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 693,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 694,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 696,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 9, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 726,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 732,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 737,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 744,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 748,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 750,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 754,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 764,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 769,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 778,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 779,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 782,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 784,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 788,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 790,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 792,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 793,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 795,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 796,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 798,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 11, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 11, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 807,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 809,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 815,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 818,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 820,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 821,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 828,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 833,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 836,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 845,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 847,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 851,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 854,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 858,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 859,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 861,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 863,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 864,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 865,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 867,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 868,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_StudentMarks_MaterialId",
                table: "StudentMarks",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMarks_StudentId",
                table: "StudentMarks",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentMarks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f0d93b3-02a9-482b-b6d9-9ecbfcfb3e56",
                column: "ConcurrencyStamp",
                value: "acfc2326-21ea-4cd3-a8f8-f175072f8a92");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0646980b-85d7-4e0a-845a-6ee9d69f8f62", "AQAAAAEAACcQAAAAEEjK+rIdIMM7xXh1YYKZ3bf2GR7r3fs+yIqtsrmRblv2lwDm7V5m3tQzABjYjYr89A==", "cafa0ffe-c598-4ec8-8880-f936a6461ea9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20141624-04de-4fc2-aaf7-3154609f66f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cc1cd8f-7ef7-492c-a90d-d18bdd31427d", "AQAAAAEAACcQAAAAEIwNiQbG/hEhNHklsK/fEUfr8ndLjBvy51TK9+yexYHinJljOCNqFBc2vN9JHFoXQQ==", "9a1f7b6e-229a-41c8-8c20-050ad9847477" });

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

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 3 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

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
                column: "StudentId",
                value: 6);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

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
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 32,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 34,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 35,
                column: "Rating",
                value: 1.0);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 43,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 48,
                column: "StudentId",
                value: 4);

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
                column: "Rating",
                value: 4.0);

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
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 60,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 62,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 64,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 65,
                column: "StudentId",
                value: 1);

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
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 1, 16 });

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
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 1, 1.0, 11 });

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
                column: "StudentId",
                value: 2);

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
                column: "StudentId",
                value: 12);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 96,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

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
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

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
                column: "Rating",
                value: 3.0);

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
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 114,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 115,
                column: "StudentId",
                value: 8);

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
                column: "StudentId",
                value: 5);

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
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 120,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

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
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 124,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 125,
                column: "StudentId",
                value: 7);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 128,
                column: "StudentId",
                value: 15);

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
                column: "StudentId",
                value: 3);

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
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 3, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 18 });

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
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 3, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 3, 3.0, 6 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 161,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 162,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 163,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 164,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 170,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 173,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 174,
                column: "StudentId",
                value: 9);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

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
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 182,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

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
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

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
                column: "Rating",
                value: 4.0);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

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
                column: "StudentId",
                value: 15);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

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
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 217,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 218,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 223,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 224,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 227,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 4.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 4, 1.0, 19 });

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
                column: "Rating",
                value: 1.0);

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
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 260,
                column: "StudentId",
                value: 9);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 264,
                column: "Rating",
                value: 4.0);

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
                column: "Rating",
                value: 1.0);

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
                column: "StudentId",
                value: 3);

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
                column: "StudentId",
                value: 7);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

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
                column: "Rating",
                value: 2.0);

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
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 288,
                column: "StudentId",
                value: 8);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 291,
                column: "StudentId",
                value: 9);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 299,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 303,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 304,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 312,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 313,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 314,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 317,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 318,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 5, 1.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 5, 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 17 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 357,
                column: "Rating",
                value: 2.0);

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
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 360,
                column: "Rating",
                value: 2.0);

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
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

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
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 369,
                column: "StudentId",
                value: 13);

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
                column: "StudentId",
                value: 16);

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
                column: "StudentId",
                value: 5);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 396,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 401,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 402,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 404,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 408,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 410,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 415,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 6, 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 6, 17 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

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
                column: "StudentId",
                value: 2);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 440,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 441,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 443,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 448,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 449,
                column: "StudentId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 450,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 451,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 452,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 454,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 455,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 457,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 459,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 460,
                column: "StudentId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 470,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 7, 4.0, 4 });

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
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 481,
                column: "Rating",
                value: 4.0);

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
                column: "Rating",
                value: 2.0);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 487,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 488,
                column: "StudentId",
                value: 11);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 18 });

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
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

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
                column: "StudentId",
                value: 12);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 515,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 516,
                column: "StudentId",
                value: 17);

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
                column: "Rating",
                value: 3.0);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 531,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 532,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 536,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 537,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 8, 2.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 8, 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 1 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

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
                column: "StudentId",
                value: 11);

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
                column: "StudentId",
                value: 17);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

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
                keyValue: 580,
                column: "StudentId",
                value: 10);

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
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 589,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 591,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 592,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 599,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 600,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 606,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 608,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 618,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 619,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 623,
                column: "StudentId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 624,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 630,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 635,
                column: "CourseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 9, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 3.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 9, 1.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

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
                column: "StudentId",
                value: 1);

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
                column: "StudentId",
                value: 1);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 2 });

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
                column: "StudentId",
                value: 1);

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
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 664,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 665,
                column: "StudentId",
                value: 13);

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
                column: "Rating",
                value: 2.0);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 679,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 682,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 688,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 689,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 691,
                column: "StudentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 692,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 693,
                column: "StudentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 694,
                column: "StudentId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 696,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 10, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 3.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 8 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 732,
                column: "StudentId",
                value: 17);

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

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
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 744,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 748,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 750,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 754,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 764,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 769,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 778,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 779,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 782,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 784,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 788,
                column: "StudentId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 790,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 792,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 793,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 795,
                column: "StudentId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 796,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 798,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CourseId", "Rating" },
                values: new object[] { 10, 4.0 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 1.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CourseId", "Rating", "StudentId" },
                values: new object[] { 10, 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 807,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 809,
                column: "StudentId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 815,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 818,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 820,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 821,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 3 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 828,
                column: "StudentId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 12 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 833,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 13 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 836,
                column: "StudentId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 17 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 15 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 7 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 845,
                column: "StudentId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 8 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 847,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 4 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 9 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 851,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 18 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 19 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 854,
                column: "StudentId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 1 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 10 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 858,
                column: "StudentId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 859,
                column: "StudentId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 2.0, 2 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 861,
                column: "StudentId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 16 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 863,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 864,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 865,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 11 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 867,
                column: "StudentId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 868,
                column: "Rating",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 14 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 3.0, 5 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 1.0, 6 });

            migrationBuilder.UpdateData(
                table: "CourseReviews",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Rating", "StudentId" },
                values: new object[] { 4.0, 18 });

            migrationBuilder.InsertData(
                table: "CourseReviews",
                columns: new[] { "Id", "Comment", "CourseId", "Rating", "StudentId" },
                values: new object[,]
                {
                    { 880, null, 11, 1.0, 14 },
                    { 879, null, 11, 1.0, 10 },
                    { 874, null, 11, 3.0, 5 },
                    { 875, null, 11, 1.0, 16 },
                    { 876, null, 11, 2.0, 14 },
                    { 877, null, 11, 4.0, 17 },
                    { 878, null, 11, 1.0, 11 },
                    { 881, null, 11, 2.0, 18 },
                    { 889, null, 11, 4.0, 1 },
                    { 883, null, 11, 3.0, 17 },
                    { 890, null, 11, 2.0, 4 },
                    { 884, null, 11, 1.0, 4 },
                    { 885, null, 11, 1.0, 3 },
                    { 886, null, 11, 4.0, 11 },
                    { 887, null, 11, 3.0, 3 },
                    { 888, null, 11, 1.0, 2 },
                    { 882, null, 11, 2.0, 18 },
                    { 873, null, 11, 3.0, 14 }
                });
        }
    }
}
