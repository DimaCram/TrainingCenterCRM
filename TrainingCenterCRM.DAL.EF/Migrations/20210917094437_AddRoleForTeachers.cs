using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddRoleForTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "9eb23459-2eaa-40a0-ad80-2f3288665d19" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "13309c41-4a79-402e-a5e4-63645c9ce8dd" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "8594cfc3-4252-4502-80e9-5c9dc3341595" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "6743e8d1-bb94-48ca-83ce-cd14ba74d17b" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "c05565d8-eaa8-4411-9b72-4ad0decdd06d" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "6eca67d1-8174-46d9-9916-ed620e57e00d" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "4188500e-87e7-4375-937c-2a1670a84418" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "da19a821-caca-4aa8-b544-45dc830b99d1" },
                    { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "79301f3b-d0ed-4331-9af8-7c751bce2f9b" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "13309c41-4a79-402e-a5e4-63645c9ce8dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "4188500e-87e7-4375-937c-2a1670a84418" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "6743e8d1-bb94-48ca-83ce-cd14ba74d17b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "6eca67d1-8174-46d9-9916-ed620e57e00d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "79301f3b-d0ed-4331-9af8-7c751bce2f9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "8594cfc3-4252-4502-80e9-5c9dc3341595" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "9eb23459-2eaa-40a0-ad80-2f3288665d19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "c05565d8-eaa8-4411-9b72-4ad0decdd06d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc580e4d-92ba-47a9-bb31-62b0afb85445", "da19a821-caca-4aa8-b544-45dc830b99d1" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "86f6fb82-7fb8-467f-becc-c56a4aaff0f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "6cfdac54-1e40-4146-b1aa-060a3f6e8c9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "1dccd77f-5794-4308-88ab-7b4ff0c48ac3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "175333c8-44e0-469d-ad91-064955d1e7b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f3e72d7-6413-4f03-b8cd-d4aace902460", "AQAAAAEAACcQAAAAEGi6JxFcY+kaI9qDRn1GnqZMYjfW27XMzMmih9LcF88UhtrjcwBBzvNH7TOHMkndAg==", "50c240c3-9fa4-4b54-9600-36bcbbd46886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e99d1b7-7aeb-44ce-b0bd-46b01d87af6e", "AQAAAAEAACcQAAAAEEtFX4c8u2HY8GOql+hiVkjYiGx1G4js35tGqBOmw2E3hA36m/F//fMloum4ST/seQ==", "4cf38485-8bc9-48d4-a412-f628d7bbd7e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d555fd4-a8c0-49b4-8a63-051b65a766bd", "AQAAAAEAACcQAAAAEJB0DFKbKm97xU7noecB8G3uyQloDl1Umf0NivqCg1XnXY/X9M/8qjVT/jUnH1/I0g==", "e2fa139c-c044-40ad-8923-d0d757c21d36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dbf0845-09d6-441f-b138-c0c55bffc0be", "AQAAAAEAACcQAAAAEHXEbi8G4bjz9UPhRosZFQ3k/QgvKBEQW5Upuerxnb734C/g7Fr48HqbixbUo/O8hA==", "1c397160-d82d-4cf6-a1b0-59199a92bd0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "205367fa-5613-41dc-b9cc-ced34362c54c", "AQAAAAEAACcQAAAAEB4U4zuDQFioVa3nrL23qJGwWJZkVqLkGKUqeMLYw/q/M+rlHpnZdVth1lT4Okd82A==", "682ce789-21c4-4d08-8b85-31da60b3f3f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb297cf5-0ec3-4fcc-8909-de4df7daa0af", "AQAAAAEAACcQAAAAEBMNB9c/KMv+oIFQnhb1EvQnZBlDTUKJxU3yuDNxR2wr1IOtjAJ7SBR8etigHO+VBA==", "e323941e-70da-4390-8de0-ea0116e8ada3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b32553d9-e780-4cce-a559-a3370062a95c", "AQAAAAEAACcQAAAAEOtM8F6dX8R81stmecwthNc3q6oQyOLP5iLytZ2ePKd8YbBlxHPHZaYtOLdn523keA==", "dd240c7f-9570-485b-9088-afaeaaaa0b9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b877c2e-1bcb-4674-9d22-dec280ad4257", "AQAAAAEAACcQAAAAEMhRjo0Cn/pdlWQhBn1Mml3z+tmRHx9tEd6/0V5HwkLAZNSAUQBQUNCXs43UTxgIkQ==", "2fc752c7-e39a-42e2-82ea-c3067e96e3fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c66ddc39-9c39-49e1-9dc7-690bdc03495d", "AQAAAAEAACcQAAAAENsn16NjlCykGd9v1R8kzfXYy1A03FIUfcdMj/IQhNoHNnSskd4tFWuoQoThu3kE0Q==", "62e8d153-1ad9-4ea1-9f6c-e5db5a9af251" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd71ee78-5fe2-4164-9894-6f7a560138ba", "AQAAAAEAACcQAAAAEAKqTaxAoWdZOX3uWwqbmQZ2lsqczeMCZ4SzQmZYYrDdVjBq7a14PCNLLB4g+uN/YQ==", "3cd70434-f101-4890-a65b-3559e9c749b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "720bc843-6569-4e67-b310-919d12bac7d7", "AQAAAAEAACcQAAAAEMuTHcpPGf2YMzGbXOhxJd3cI+atLKczNNSgUx7j8pwYyZKMsgJ17HLHPNZ2jsQbgw==", "661cf81d-5f10-483c-a666-0bf981a63ef0" });
        }
    }
}
