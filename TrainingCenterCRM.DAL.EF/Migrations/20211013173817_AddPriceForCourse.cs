using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.EF.Migrations
{
    public partial class AddPriceForCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Courses",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "021cb353-a049-404c-b2f6-b067a48a3b9a",
                column: "ConcurrencyStamp",
                value: "cf900ee9-2ac7-4e11-a2f8-697478924702");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "800ac90f-e24c-485a-8be4-5869972e12a7",
                column: "ConcurrencyStamp",
                value: "f3e8e5f2-d74a-4e58-9f73-804b0aad1303");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5aeb79-50ca-48db-91dc-3a72f06c978f",
                column: "ConcurrencyStamp",
                value: "09237eb1-7e02-4de6-9ece-a233651e654a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc580e4d-92ba-47a9-bb31-62b0afb85445",
                column: "ConcurrencyStamp",
                value: "d3983f65-8f24-4939-a7ea-5da8a8ce9d75");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13309c41-4a79-402e-a5e4-63645c9ce8dd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ed105d4-f054-49a9-a2b9-5209a1f183be", "AQAAAAEAACcQAAAAEDcFdpU4CixFgjBEEvOlLLwz65iRFM0ohwyMSLuEpNLz2K/zf2qJUItCkkDXZMYIJQ==", "7d4d2f94-25e3-4e9e-9163-8be9fc62c659" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4188500e-87e7-4375-937c-2a1670a84418",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac066713-e9fb-4bbb-ba5f-1ae637ab3001", "AQAAAAEAACcQAAAAEM0ON9IuODVmmK61C92/kEJzaF446Mxqwal4SK4c2GyjsGQeZLgYJyApZPcuFc4Rxw==", "33327dc7-1d93-4a6e-af2f-f958d08272c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6743e8d1-bb94-48ca-83ce-cd14ba74d17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c64666d-53f8-47b7-b315-3605b4247678", "AQAAAAEAACcQAAAAEFkj2LMgSz0psswpX21uHjTfS4xYxAkoz3UQYfO3qhFh7lSbvMkkyMet7dfrb0YVYg==", "9d8b44f9-7892-4622-b91e-1cc7956da064" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eca67d1-8174-46d9-9916-ed620e57e00d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be1cb36b-5f42-4be0-aa27-97390d6c8be4", "AQAAAAEAACcQAAAAEBUJIVKnLnIIo9v+CkZf9QKh1+0da88UbBGfV0VECEXMN6kIRMNqywb/qIRsxh3gFA==", "3d7a286b-d93e-4c33-804d-5b19f91309af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79301f3b-d0ed-4331-9af8-7c751bce2f9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d290025e-c958-4095-82ba-5e71d996455b", "AQAAAAEAACcQAAAAEPEcqFMxoavT5gnuF87e6fKEPBEd4QTqm+PI47Zy1JQeyYw8CTir+1UGYUyOxGySYg==", "4ed3efe4-c912-497f-a88c-d92663e0ab3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8594cfc3-4252-4502-80e9-5c9dc3341595",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8fda093-3bba-484f-b57c-7e7fc473cb9c", "AQAAAAEAACcQAAAAEPVPJHsFUeouL9U+uq++2SwP68MEDy1nDTYtxC5L132dsckuIgHB2Et7ii4N8AXwMQ==", "8e13df29-32a6-4bfa-836e-61756a477fd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cccb2bc-95ed-4b5c-b72a-a2ee25bb6f94",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02ba43f4-fad3-4720-bb5f-0286b95e99fb", "AQAAAAEAACcQAAAAEPKpsnKo04Vqv5wdxNFfmv8DDnvdf/piwEAcGYktWG/jz+YSENvt6WIt3KuFpkrcXQ==", "5efcf3bd-7163-4a6f-9814-52075ecad721" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9888c09b-2509-4cda-a82e-3dbea07d94eb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3eaf447-f4a9-497f-804d-0b35897ee218", "AQAAAAEAACcQAAAAEM8hZ7bKBKgzSBOIMnS+2mCVMS4Rw266loTm/VIXlZ5G4kQ/VcRwz1JZHi5WkRqShw==", "1065a9ff-293c-4c13-ae33-d165cb531381" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb23459-2eaa-40a0-ad80-2f3288665d19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee9ab617-b524-4adb-8586-0f4fe8407140", "AQAAAAEAACcQAAAAECLQy5NghawKVtBO/DZhARqTAH7MZqL3LJFokmZh18K0E0uDuF58NPZT4HD88mTN1Q==", "fd0f9100-0acd-4bae-a152-84c440e37219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05565d8-eaa8-4411-9b72-4ad0decdd06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e58ae9-b029-41f1-bfc2-768233769cdd", "AQAAAAEAACcQAAAAECsOGLvjl7dGrBh9eCOgpkfxAQGfCAeXIgreBOJBb7+anoQIqBPggnXzupxvnKF0Kg==", "d77d1ca2-286f-45da-aded-477947c44aae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da19a821-caca-4aa8-b544-45dc830b99d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca85bb0f-a268-43e0-b6ef-1e7b57cd1783", "AQAAAAEAACcQAAAAEBxkHL8bRvMk0HUor/ooqRY7cqW5ZcH6bUMaXeYloTwRYWwEGlnBFK7ljiaqTo/wqQ==", "9b180904-5ea7-4ee3-ba44-2839504b080f" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 499.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 755.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 699.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 499.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 710.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 755.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 610.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 729.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 699.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 599.0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 719.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Courses");

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
        }
    }
}
