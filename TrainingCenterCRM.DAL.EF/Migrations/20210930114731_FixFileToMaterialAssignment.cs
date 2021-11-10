using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class FixFileToMaterialAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileToMaterialAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileToMaterialAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileToMaterialAssignments_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileToMaterialAssignments_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileToMaterialAssignments_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "c9ae20ba-86ef-40d5-96a6-d5790824a6c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "356d94be-d3eb-4639-8815-734ae324246f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "16969cfb-ce44-4a85-86ea-5582f509f3a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "b74c64bf-fc26-432d-9487-e0d1d9fba638");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef5b5f71-0142-46ff-80fa-21cb6e1aeaaf", "AQAAAAEAACcQAAAAEGQ6vLL+lqO5Hx2UddO2VznvGXOINT1D2ayRf6rIzg7cQVUUixyRvL8hBNZ+izOl7A==", "c6dfd57f-abfb-40a5-b74a-eacbb81c9005" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58beccb0-48fe-4904-8dce-63cbd0da5390", "AQAAAAEAACcQAAAAEJuJmeraqt+gbWorKPErB7M4l6UI2cyBXU+qsFUFAiMiiHXwF1A64iWAbItq++x0JQ==", "c65d8409-c231-4177-a209-74885c80f070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46219475-660c-4855-a3ab-22df4b697c3b", "AQAAAAEAACcQAAAAEMXas594JbTO211XCPWjzOtBlu661y4JZhMw7tJ/aspKFtMGIBxmxJBrCWeBX5lGKw==", "739b6cb4-b4e5-4266-bac8-f9ed60c04339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca70326-f600-4a1f-b945-539237d06505", "AQAAAAEAACcQAAAAEFe59jxEH1+4JwA67R4yrIweOnzHQlCTctWfUtk6x+DwXW6q9/BdBljnfiBfW3dgDA==", "929ed1e3-bf16-4916-aab6-94c6e76ca8fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16dbe7a5-13f1-4685-bcfb-84e6cf360981", "AQAAAAEAACcQAAAAEM7NZaqcsPEfI6FkgpJ/AIcfetOua974KMojoW0yzBnv50vWxDTaghgW2+Etz2z5gw==", "d53f5170-b327-468b-9462-83d85246726b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb427e11-866a-4719-a0fe-efbf277eb5c6", "AQAAAAEAACcQAAAAEN2D8rvm7nI0KVkRLt4S7NHSTWWPs5M8b23apEnreUVn72qcH28i2nOWhJsVre/kzw==", "47d6942f-b8c1-4784-95a4-0b6588531ffc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354c1651-f500-4f48-8fad-f33f46255f61", "AQAAAAEAACcQAAAAEMeF3mSJlByvuuic0Hmrl0UhvMD/Uf/kI8yFzZXltE9C8YH4RrzmR/KPF2DP1ft/jg==", "ce08030c-4a46-4148-be46-59502a97189a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75abecac-5711-4e4c-b3ed-e8512d195e0b", "AQAAAAEAACcQAAAAEOr4fP6VIBzcgQno5XsOkjbSKbPCw5aVSzr6BO2z0dVHJEf8wqvXOnK6hT2crNPBSA==", "f45e6f5e-ee5d-4927-bccc-70d7f04076ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e9d8a2-8867-4940-9a1f-3b95393e98ea", "AQAAAAEAACcQAAAAEMBFu8pPxdhWn9JHkaigZYWoN+HrNEXTkYNJtx+PqlgZp+W01CIxFFhiP2xh9Kb4kQ==", "2de92068-e23f-4c80-878f-8198a7e9e06d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45eba2ff-7274-4b4b-a6a4-f7929b48fa12", "AQAAAAEAACcQAAAAEES/uJXKuTmjlBSz66xv4saPSRxFCf1vjrc9vOGCaPP5JDtXxCg8AWsAiUf6ar/xbA==", "e19a87c3-9afa-40f8-8504-67caef6a47d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b2ca0b-a6a7-4979-8ca5-52630e3989f8", "AQAAAAEAACcQAAAAENxqlwbu8PmJ5XS1Vvh51pPUcd1RzWfxjhJI/Z3LTsXLw2qcJ3X9dFXdT9kGxF2t9g==", "a6425e66-4ecb-4dd9-ab38-c8d290dc2bbd" });

            migrationBuilder.CreateIndex(
                name: "IX_FileToMaterialAssignments_FileId",
                table: "FileToMaterialAssignments",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToMaterialAssignments_MaterialId",
                table: "FileToMaterialAssignments",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_FileToMaterialAssignments_TeacherId",
                table: "FileToMaterialAssignments",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileToMaterialAssignments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "1db5800e-038a-4b95-b872-c23eda16364c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "c24b44fe-3291-4529-9b34-559ec9bba7a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "fe5680f2-0e46-4ed0-bc33-5fb8f0c033eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "0fbbb8df-5c1f-435e-922b-2626146348cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3e4b69a-d12f-4c06-b429-c209230579dc", "AQAAAAEAACcQAAAAEA0fI1dLuXF3Wm2Uowc6EV0d8JC5S6xUJ8C2ffLrNYal3smpYQpJ2Of/CcN6vUHVhw==", "38fe9d98-3a3e-40d4-b324-758d53957284" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4e51343-26ed-4395-9903-a989aac393da", "AQAAAAEAACcQAAAAEH1UYijIFWRT3h0eEb9z4qWoj6iW8Nhy5xN+2wBg15PaPuG27UKjRs1qLCVjl1WtWw==", "837736be-6bba-43cb-8c7a-88b35c732482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2def4ce0-1d33-47e3-ae82-07fcb0399672", "AQAAAAEAACcQAAAAEMq0CFyPxVRYEzih8WMHKDLSRgNPP0NQNBbK5/TAxXkdYlDDFJQD8rbJH/XplfviDg==", "18751598-13dd-4cd4-a9e9-e40820c80a1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f5cbab0-6e1f-4f20-9c70-534da046c670", "AQAAAAEAACcQAAAAELGE5Z6nH/N+T12095avvEtUFZq2PxxBA/TFqN29WKPbgKLZBOEIE01i/QEEcEbMEQ==", "ae24a6a4-7358-4352-bb02-417051b0eafd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06324deb-9b85-4eb9-ab59-111de31d9530", "AQAAAAEAACcQAAAAEDNGrf6q9GNQAMJw8WYJGY+g/lnozJuEQ4upQSf00n6WuKqLtSnNUDHossyVtrYVjg==", "9af8b5a6-a802-4e99-a269-2b9a1c48c572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2346253-5215-4e3f-af66-c08ebdee4378", "AQAAAAEAACcQAAAAEDw8Jl8UQolA8/56MhEAviuZENybDE3Ali3RJCKbpINvZXF1lZHu03py9uZOIK6QPQ==", "298690d6-e665-4e49-b633-8a6d4e3d2fbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e72dc982-1ba2-4b9a-9350-0ed0937fc30d", "AQAAAAEAACcQAAAAEGm5IQ6HaWQT5J6VolZNlUvDeEaHNPVfxL3ugmh6eXkCfF4J0uCSSeHd5xK20Uai5g==", "4600b89b-5755-4ff7-b571-008e84d5c88e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "980790ef-ce2e-4d07-bcc2-238d949069d2", "AQAAAAEAACcQAAAAEBEN2p8OKqq3xPTwQ/ytaeNEt29KPt4R8ezOMDoF/MsKUEtcD7+jSAR1tsdkfUNu3A==", "7a487d53-08e0-4602-9366-81533288edb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ff4e897-174f-44a9-9aaa-3a78ae47e030", "AQAAAAEAACcQAAAAEPDggTscLvg5gg29LKHhry9QGahGEpH8foifTsARsSIA5qtr/plYZXcaOh+JAqeM5A==", "e27747a0-e956-468b-9599-4016fbbcbf29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "953a5e9f-0738-4779-a182-0f38eb1ad7b1", "AQAAAAEAACcQAAAAELcSY9jYVp8Q8X91TGwbCGMHqS/dYEGf/s7vDiSZ/SoCUe3EA9q2t9PfIdFS/eOYYw==", "d9ffdf53-a558-4cb4-a5f0-076b2adb6453" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9dd4e10-7d0f-4610-a03c-1025ed64261e", "AQAAAAEAACcQAAAAEF+OdEqb+k1sTI+HiOI3POxT/l5Xs7oqdQO8KvBPPH9/z1bKGvNc5jLbJNwjEeoeuA==", "d16454a5-3a91-44a2-ac9d-6c7c9e607d14" });
        }
    }
}
