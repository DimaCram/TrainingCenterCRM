using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddRequestStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2673a85-6975-4c17-b61a-9e2fd9f1b9ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8757ad3-0237-4717-991d-92bdcd43420d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31098333-d1d3-49e0-9276-406ae8ac6f4e", "5ea2a7ae-8f58-436a-b6d4-78167ddd4763", "user", null },
                    { "d0829c95-2b4f-46a2-bc71-b0cf35ebc51b", "ccf78208-faf4-4f1a-8b5f-dfef6afbdf3b", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 6, 24, 847, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 6, 24, 848, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 6, 24, 848, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 6, 24, 848, DateTimeKind.Local).AddTicks(8769));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31098333-d1d3-49e0-9276-406ae8ac6f4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0829c95-2b4f-46a2-bc71-b0cf35ebc51b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8757ad3-0237-4717-991d-92bdcd43420d", "5cc90029-5a13-46bb-9111-2ab2f220340f", "user", null },
                    { "b2673a85-6975-4c17-b61a-9e2fd9f1b9ef", "bdf26d82-cfcc-48a4-9468-936e80b27142", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 3, 23, 854, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 3, 23, 856, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 3, 23, 856, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 3, 23, 856, DateTimeKind.Local).AddTicks(1128));
        }
    }
}
