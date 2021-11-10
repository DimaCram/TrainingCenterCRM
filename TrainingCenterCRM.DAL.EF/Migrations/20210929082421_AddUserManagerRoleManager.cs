using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddUserManagerRoleManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d5aeb79-50ca-48db-91dc-3a72f06c978f", "9888c09b-2509-4cda-a82e-3dbea07d94eb" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d5aeb79-50ca-48db-91dc-3a72f06c978f", "9888c09b-2509-4cda-a82e-3dbea07d94eb" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "5accfecc-75bc-4943-89a0-f4e0b99f13d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "2aed1452-fe8c-49a6-a585-544e6775f76c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "afcd8dca-aacd-4b88-b217-264e1d0ef6c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "5ae22c6d-fdfc-4134-997b-464594a24b6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dc8a531-0d42-432a-8a34-8146dab23428", "AQAAAAEAACcQAAAAENhw5hFUWao3NE8Q+iUpZjHGZzgZzfB6Lk/3SjcL0hHNqHkczS4X7XMUun/2ddjUJg==", "b4d559bf-b8c8-4b27-8b5f-b0d0499c62c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7265b7a-9444-4629-a227-3215a040bc61", "AQAAAAEAACcQAAAAEKmyBoKqrwOnlr7Td5VDGS1pM08oriDhG+WtekW55LeGlHwy3vcWtpdwFwBwcKTY6A==", "1012aebe-1ece-4c5d-8a12-31272451aab0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c770bf3b-8ec2-47c6-bc63-eb4644686657", "AQAAAAEAACcQAAAAEPTS9azcysRfv1iNJhQS7EkUmfsVCrOgDva7BLtknbNhdthUD9RQI32VRNvUCWYuNw==", "5e45850f-ac80-4d2f-876c-3cded7ea082a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f50494ca-b305-41c4-bc95-e4eae595dc5a", "AQAAAAEAACcQAAAAEErmkNQY6DMppZu822Iu7Y4VJJurFTAFS1vHCUx1uh7wrn6+uF0gaww00urtB99Epg==", "9e8a7182-4310-4f89-a921-595066b1b388" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa4dfa6-98c2-4f0c-957c-007c0ef3eaa8", "AQAAAAEAACcQAAAAEIUOOtHoB2oNpzJgq5xpTsGn3Owx0fMAF2y7CgY8JtRbD8isq24db6LSYpOtG1S9zg==", "d942623a-b72f-4250-a2cc-1784e09f3fe2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfb7e32e-7bf3-488f-97e8-618837f11866", "AQAAAAEAACcQAAAAENDvKdVAZvh/0BwjjNMP6liP+2G0C00v7sTBsDFH7x1n8kE0kR+eSvTgkxOJtKN1YQ==", "5bf8e22c-2d77-44e6-adfc-af9a3dab2d1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa46743-590c-498f-8c7c-3f3a1e05d32f", "AQAAAAEAACcQAAAAEGvtzxXRHKSKJHt9JgNo+sjJgnJx9d1QDDIZymmGNsrqmjxgFSJi72fIWpsBWC104w==", "8c5e4053-007c-4133-9b54-333b2b9f5c90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebc549c-63c8-4e62-8968-a4efa6b9856b", "AQAAAAEAACcQAAAAECpTbFmUVUCBRuroOPANdUTIEz5kRZgXaKELKubO9tza8677FSzEQVLJnUWl1mu01Q==", "c8cf57e2-4d85-4ac1-a728-0582e1eb9bf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d7ef4a7-e5e1-4edf-98d5-8bfab314f7c7", "AQAAAAEAACcQAAAAEHRaxPcqKSJjb7NQWD/URWTli35REGz0CKEYfrXC84QEv+kOmOniEegfmvLiKlpoGQ==", "a501b016-2fd3-4867-8c28-2e8a3e1deb38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f13faba6-bc58-46ff-ae66-0a4e77074602", "AQAAAAEAACcQAAAAELmyGUgL/Qv3xImruqt4KsSZsn6eirc8SCdMEm+3TA5ra2QyehefQgY55o3PxTBujQ==", "01e647ed-a5a4-4f35-bbec-0d6dbc34c201" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7084992-a21e-4f45-ac31-a7b63a64b795", "AQAAAAEAACcQAAAAEGdIzXKOTM+fVU1TSmh5qXzceceFyJuLGm9Vu3Sym+2kudEcJomHwtAN2+fuwgK7Bw==", "4a6740f2-380d-4091-a5a3-81646be2341e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_AspNetUsers_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
