using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddStudentRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f030192-8ac7-4a60-942c-b8996d92fe3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "619eb7b5-463d-4466-b7ed-785830e22aec");

            migrationBuilder.CreateTable(
                name: "StudentRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadyToStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentRequests_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentRequests_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06b0e429-bd54-4957-957a-83fc2f0fb70f", "c847d61f-5f08-42ab-a0da-e285b444567f", "user", null },
                    { "331fe8a8-4d5f-4960-b737-f78e2c0841c9", "aef96fac-3872-4e3a-b01a-54987c7aad73", "admin", null }
                });

            migrationBuilder.InsertData(
                table: "StudentRequests",
                columns: new[] { "Id", "Comments", "CourseId", "ReadyToStartDate", "RequestStatus", "StudentId" },
                values: new object[,]
                {
                    { 1, "Хочу быть программистом!!!", 1, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 2, "", 2, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2 },
                    { 3, "", 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 4, "", 2, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentRequests_CourseId",
                table: "StudentRequests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentRequests_StudentId",
                table: "StudentRequests",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentRequests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06b0e429-bd54-4957-957a-83fc2f0fb70f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "331fe8a8-4d5f-4960-b737-f78e2c0841c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "619eb7b5-463d-4466-b7ed-785830e22aec", "2a9988bb-94f6-4db5-ac63-93e35c4d2ab0", "user", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f030192-8ac7-4a60-942c-b8996d92fe3f", "36e44561-4f5d-45f4-a003-15b426470ed6", "admin", null });
        }
    }
}
