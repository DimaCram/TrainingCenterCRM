using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1480f33c-7e18-472e-905e-bd46bfbe51fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b511907a-fbe1-4bde-822f-18a37649bc36");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b511907a-fbe1-4bde-822f-18a37649bc36", "e7234648-dec3-4247-abf9-407c300fcc5c", "user", null },
                    { "1480f33c-7e18-472e-905e-bd46bfbe51fa", "4c6f093f-dbda-4e7a-aa83-473629423eac", "admin", null }
                });

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 1, 15, 730, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 1, 15, 731, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 1, 15, 731, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "StudentRequests",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReadyToStartDate",
                value: new DateTime(2021, 8, 29, 14, 1, 15, 731, DateTimeKind.Local).AddTicks(2696));
        }
    }
}
