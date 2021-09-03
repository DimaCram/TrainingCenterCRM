using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddMaterials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31098333-d1d3-49e0-9276-406ae8ac6f4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0829c95-2b4f-46a2-bc71-b0cf35ebc51b");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileMaterial",
                columns: table => new
                {
                    FilesId = table.Column<int>(type: "int", nullable: false),
                    MaterialsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileMaterial", x => new { x.FilesId, x.MaterialsId });
                    table.ForeignKey(
                        name: "FK_FileMaterial_Files_FilesId",
                        column: x => x.FilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileMaterial_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FileMaterial_MaterialsId",
                table: "FileMaterial",
                column: "MaterialsId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_GroupId",
                table: "Materials",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileMaterial");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94e550b8-e394-4fb8-938e-5fb6fd33139d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1eb5cfd-1ac9-437d-9e5a-0de3ef57a421");

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
    }
}
