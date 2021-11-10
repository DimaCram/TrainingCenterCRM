using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddFileToMaterialAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileMaterial");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "1837c562-750c-4ea5-8e8f-0e3493f29f39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "df15cdcb-5fcd-4f2d-a7c5-6e2e781c9617");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "c3980da2-0888-4e45-ae9b-16c7e55755df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "594099a7-4aa2-4a9b-9c78-7317206662c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cddea1f-afbb-445f-9c28-24ed2dc1e50e", "AQAAAAEAACcQAAAAEPQ9KyocxiF6kxjYfQINhEWv+WfglXP6mJOLYtQqMdfnqSl50Aeqvx1LqTybhkgNGQ==", "173158e7-8eb4-4718-bfed-340e51ed824d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e690df-b3f1-46ea-8fbd-dffe34c8ca16", "AQAAAAEAACcQAAAAEPWflmk1u7Tb5g1+L27FYAVZC567RwptzV22l9Poq67EUbWK6YnGi308NWNCx3WO2w==", "90a8fc43-5da7-4a86-b972-cfb343ecb559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fc182b0-cc11-4531-8974-dde2b97efa54", "AQAAAAEAACcQAAAAEEKgy6/ARZbwAUotoLxZugE0IuWMzhUJMiduCpdHqsOUHH1PJpCpNX2rzU4GCcpjoQ==", "01cdd3db-4f65-4c27-9d09-cef510b4c5eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc3cee1e-ec56-4284-ab6d-ae2032516893", "AQAAAAEAACcQAAAAEGfSsyi393fO4PkfuCbabQUYDHgvbt2ejv8zl2rk0sE9Mihwf9yXxuZbZ5o9d1tBOw==", "4000651a-f121-47aa-a921-39de23676e93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7cdf668-6508-41a9-a8b5-b7dec80352ea", "AQAAAAEAACcQAAAAEH2RBICxC5WNVGSHsMR7QnbNQExl7tOtuj+UnCEZetZVfSxm2HGgnCi+CekgtRt6eA==", "59c0127a-8622-4a6f-89d2-38e98d05c9fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d290e58a-a994-4ee4-94ed-a0261cdf69f4", "AQAAAAEAACcQAAAAEMZfd96xaK7CIRY6S/iyuWaonBNOrgvixxQftJXByGwEr/inowZOx4gTB0kgdv35xQ==", "fb668365-8e9a-4ab0-a791-2f479e08e45b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f650ceab-5006-4b4d-a0c2-a00390f49fa7", "AQAAAAEAACcQAAAAEE1zuDTOkD45Frbu1rzhASps6pgNGh8FL8Qn09W9SmBQ7V2tSsLV2AvE7x1P0kQ+uw==", "7896d2fc-4fbb-426f-aea9-87e2bdec3d9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f60c98f1-558d-42cb-8b63-bf94b1354af5", "AQAAAAEAACcQAAAAEItZHCs7JYa+ztovTs1qB4U+NcUD9dNIZmD6YIEY/TqhtzSsXzpIebrUdVWXDkktOw==", "2328da6d-322d-4705-b545-f65867a6c07c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a48eabef-7050-4bb9-9c7b-2885842b362d", "AQAAAAEAACcQAAAAEGWIJliSwEAldytpcdAIbs/a6PJW1v4fOw5cDHCoTvF+UOcRxRWU0GKGmbPNwwDg1w==", "508c5dd6-d62d-483a-a7a4-b1de5259a60e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d04e9786-c22b-464b-bde0-0d6b634bf1e1", "AQAAAAEAACcQAAAAEEGfeflyXwFiXt0f62crHG7ejDKSl6xhNwQrGkmZtqXHRfKUldoJbVJk04E5V3UJHQ==", "1fcb9645-40ee-4425-ab61-04a0b13dc842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4541ad46-cc96-4536-aa4e-e4198f4215f2", "AQAAAAEAACcQAAAAEG6Y9y/Dizzr71KJda9TUXUlfbvQeZH8Qu748QbH4i1H/nXisaKDIcY3oJ+lo8mM1Q==", "18d8782a-f788-4e61-a718-a693d36583ff" });

            migrationBuilder.CreateIndex(
                name: "IX_FileMaterial_MaterialsId",
                table: "FileMaterial",
                column: "MaterialsId");
        }
    }
}
