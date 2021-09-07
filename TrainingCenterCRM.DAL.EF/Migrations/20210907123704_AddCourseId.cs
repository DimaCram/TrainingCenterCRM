using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddCourseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94e550b8-e394-4fb8-938e-5fb6fd33139d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1eb5cfd-1ac9-437d-9e5a-0de3ef57a421");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46464004-d096-4f56-a4f2-42444c0502cf", "7bf31bb8-39a0-4016-b24c-90fb914f9784", "user", null },
                    { "a62dcd21-f8d1-4f2b-befa-71520eb1d48e", "7e9f849b-0ed5-44a2-ae3e-643fc79b1f85", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 7, 15, 37, 3, 958, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 7, 15, 37, 3, 959, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 7, 15, 37, 3, 959, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 7, 15, 37, 3, 959, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.CreateIndex(
                name: "IX_Files_CourseId",
                table: "Files",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Courses_CourseId",
                table: "Files",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Courses_CourseId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_CourseId",
                table: "Files");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46464004-d096-4f56-a4f2-42444c0502cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a62dcd21-f8d1-4f2b-befa-71520eb1d48e");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Files");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c1eb5cfd-1ac9-437d-9e5a-0de3ef57a421", "4920aa46-5128-4264-ac42-0ed31dbc9fcd", "user", null },
                    { "94e550b8-e394-4fb8-938e-5fb6fd33139d", "ab1bea25-d1e0-493a-bb99-57318b20a6e4", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 3, 12, 25, 49, 139, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 3, 12, 25, 49, 140, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 3, 12, 25, 49, 140, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 9, 3, 12, 25, 49, 140, DateTimeKind.Local).AddTicks(3957));
        }
    }
}
