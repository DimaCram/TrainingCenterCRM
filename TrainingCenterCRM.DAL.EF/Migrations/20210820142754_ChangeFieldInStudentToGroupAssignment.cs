using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.Migrations
{
    public partial class ChangeFieldInStudentToGroupAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentToGroupAssignments_Groups_GroupId",
                table: "StudentToGroupAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentToGroupAssignments_Students_StudentId",
                table: "StudentToGroupAssignments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a0089be-9086-489a-8715-7a5aef0de79f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5ed9eba-b8a5-4e44-a1fd-e7bed61a0336");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentToGroupAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "StudentToGroupAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b51c9e03-ebb6-4350-8942-fea22083019f", "cebc7f61-8630-473e-81d9-a9dc1e91ee61", "user", null },
                    { "27e4e434-6c1a-4192-81dd-877d3dd12a70", "61206317-a7e0-483b-9d7a-d5443526684f", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 20, 17, 27, 50, 954, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 20, 17, 27, 50, 955, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 20, 17, 27, 50, 955, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 20, 17, 27, 50, 955, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.AddForeignKey(
                name: "FK_StudentToGroupAssignments_Groups_GroupId",
                table: "StudentToGroupAssignments",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentToGroupAssignments_Students_StudentId",
                table: "StudentToGroupAssignments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentToGroupAssignments_Groups_GroupId",
                table: "StudentToGroupAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentToGroupAssignments_Students_StudentId",
                table: "StudentToGroupAssignments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27e4e434-6c1a-4192-81dd-877d3dd12a70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b51c9e03-ebb6-4350-8942-fea22083019f");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentToGroupAssignments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "StudentToGroupAssignments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c5ed9eba-b8a5-4e44-a1fd-e7bed61a0336", "deb285db-3c22-4760-898f-939219d428da", "user", null },
                    { "6a0089be-9086-489a-8715-7a5aef0de79f", "f6b48a83-2644-4eb2-a0eb-eb404c0b84b1", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 19, 20, 47, 32, 164, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 19, 20, 47, 32, 166, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 19, 20, 47, 32, 166, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 19, 20, 47, 32, 166, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.AddForeignKey(
                name: "FK_StudentToGroupAssignments_Groups_GroupId",
                table: "StudentToGroupAssignments",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentToGroupAssignments_Students_StudentId",
                table: "StudentToGroupAssignments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
