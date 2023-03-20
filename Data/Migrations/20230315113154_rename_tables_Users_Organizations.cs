using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class rename_tables_Users_Organizations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUser_Organization_OrganizationId",
                table: "OrganizationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUser_User_UserId",
                table: "OrganizationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Organization_OrganizationId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organization",
                table: "Organization");

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("9a9c991d-fe02-4552-bad7-f0a3fa6a17d2"), new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("51f6bc11-b0d4-411b-b40c-3f5696ca2547"), new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6"), new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1bf45408-2f6d-40b2-821c-fc755e5a5675"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("4251239a-0bf7-4b81-ad44-386b810f6e0e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("50626c64-3b74-425e-be8d-480f0f2363b2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("74c59b58-5232-4224-87a8-871041dee967"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("7f35eef5-c8b6-4c20-b64c-b99c85e49f1b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("be771b67-a084-4637-9a44-24f2e7955443"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f1a5d785-c061-4994-95ac-71500a0c3fc1"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("32aa8d33-0050-48c0-9f13-841fca2b2364"), new Guid("b9a387cd-9a6f-466a-86fa-8a4c8759c99e") });

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("51f6bc11-b0d4-411b-b40c-3f5696ca2547"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("9a9c991d-fe02-4552-bad7-f0a3fa6a17d2"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1"));

            migrationBuilder.DeleteData(
                keyColumnType: "uniqueidentifier",
                table: "Organization",
                keyColumn: "Id",
                keyValue: new Guid("32aa8d33-0050-48c0-9f13-841fca2b2364"));

            migrationBuilder.DeleteData(
                keyColumnType: "uniqueidentifier",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9a387cd-9a6f-466a-86fa-8a4c8759c99e"));

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Organization",
                newName: "Organizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("6dc9c350-bde8-401b-bdf4-c3aab1b99aac"), "Trailer", new Guid("1c4d77d4-6168-4fad-9683-6e1698fef434"), null },
                    { new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8"), "Description", new Guid("1c4d77d4-6168-4fad-9683-6e1698fef434"), null },
                    { new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5"), "Game", new Guid("1c4d77d4-6168-4fad-9683-6e1698fef434"), null },
                    { new Guid("fc36e77c-af66-4f47-8024-d48fc1add695"), "Publisher", new Guid("1c4d77d4-6168-4fad-9683-6e1698fef434"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("af3f728d-6c38-459c-8289-c4f1bc596bcb"), "Org1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[] { new Guid("9abb0452-f941-4afe-9332-311209a0bfac"), 0 });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("6dc9c350-bde8-401b-bdf4-c3aab1b99aac"), new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8") },
                    { new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8"), new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5") },
                    { new Guid("fc36e77c-af66-4f47-8024-d48fc1add695"), new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("233a472b-2b43-4717-ac6b-7f3c2b732d9f"), new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("2a3fd8b3-d9fb-4e61-8778-cc3e4494d837"), new Guid("6dc9c350-bde8-401b-bdf4-c3aab1b99aac"), "Creator", null, 0, "Regixx" },
                    { new Guid("3eb9fccc-f7a4-4325-8d33-20e4502c9e06"), new Guid("fc36e77c-af66-4f47-8024-d48fc1add695"), "Location", null, 0, "USA" },
                    { new Guid("46a91a6a-3ccd-473d-891d-fada5937ed24"), new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5"), "Name", null, 0, "Star Wars" },
                    { new Guid("54d77e54-ce5f-4d22-9389-15173fb09f75"), new Guid("fc36e77c-af66-4f47-8024-d48fc1add695"), "Name", null, 0, "Santa Monica" },
                    { new Guid("7b571446-7ec9-428b-94b6-dc096a2f2e25"), new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5"), "Year", null, 1, "2007" },
                    { new Guid("9aeb6a96-948b-4292-b9fa-caecfc6875d3"), new Guid("6dc9c350-bde8-401b-bdf4-c3aab1b99aac"), "TrailerVideo", null, 4, "http://" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[] { new Guid("af3f728d-6c38-459c-8289-c4f1bc596bcb"), new Guid("9abb0452-f941-4afe-9332-311209a0bfac") });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("1c4d77d4-6168-4fad-9683-6e1698fef434"), "Game shop", new Guid("af3f728d-6c38-459c-8289-c4f1bc596bcb") });

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUser_Organizations_OrganizationId",
                table: "OrganizationUser",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUser_Users_UserId",
                table: "OrganizationUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Organizations_OrganizationId",
                table: "Spaces",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUser_Organizations_OrganizationId",
                table: "OrganizationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUser_Users_UserId",
                table: "OrganizationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Organizations_OrganizationId",
                table: "Spaces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Organizations",
                table: "Organizations");

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("6dc9c350-bde8-401b-bdf4-c3aab1b99aac"), new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8"), new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("fc36e77c-af66-4f47-8024-d48fc1add695"), new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("233a472b-2b43-4717-ac6b-7f3c2b732d9f"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2a3fd8b3-d9fb-4e61-8778-cc3e4494d837"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3eb9fccc-f7a4-4325-8d33-20e4502c9e06"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("46a91a6a-3ccd-473d-891d-fada5937ed24"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("54d77e54-ce5f-4d22-9389-15173fb09f75"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("7b571446-7ec9-428b-94b6-dc096a2f2e25"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9aeb6a96-948b-4292-b9fa-caecfc6875d3"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("af3f728d-6c38-459c-8289-c4f1bc596bcb"), new Guid("9abb0452-f941-4afe-9332-311209a0bfac") });

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("1c4d77d4-6168-4fad-9683-6e1698fef434"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("6dc9c350-bde8-401b-bdf4-c3aab1b99aac"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("b550561f-2fbf-4c67-b2b5-3e97aa25aae8"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("bcdbc5db-e661-435f-97ca-420b805fd7a5"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc36e77c-af66-4f47-8024-d48fc1add695"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("af3f728d-6c38-459c-8289-c4f1bc596bcb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9abb0452-f941-4afe-9332-311209a0bfac"));

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Organizations",
                newName: "Organization");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Organization",
                table: "Organization",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("51f6bc11-b0d4-411b-b40c-3f5696ca2547"), "Publisher", new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"), null },
                    { new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6"), "Description", new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"), null },
                    { new Guid("9a9c991d-fe02-4552-bad7-f0a3fa6a17d2"), "Trailer", new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"), null },
                    { new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1"), "Game", new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"), null }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("32aa8d33-0050-48c0-9f13-841fca2b2364"), "Org1" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "UserRole" },
                values: new object[] { new Guid("b9a387cd-9a6f-466a-86fa-8a4c8759c99e"), 0 });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("9a9c991d-fe02-4552-bad7-f0a3fa6a17d2"), new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6") },
                    { new Guid("51f6bc11-b0d4-411b-b40c-3f5696ca2547"), new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1") },
                    { new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6"), new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("1bf45408-2f6d-40b2-821c-fc755e5a5675"), new Guid("51f6bc11-b0d4-411b-b40c-3f5696ca2547"), "Name", null, 0, "Santa Monica" },
                    { new Guid("4251239a-0bf7-4b81-ad44-386b810f6e0e"), new Guid("6bc81024-bd96-4626-96b1-fd15abe236e6"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("50626c64-3b74-425e-be8d-480f0f2363b2"), new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1"), "Name", null, 0, "Star Wars" },
                    { new Guid("74c59b58-5232-4224-87a8-871041dee967"), new Guid("ea8b8153-c091-4f05-9da7-ae07321015f1"), "Year", null, 1, "2007" },
                    { new Guid("7f35eef5-c8b6-4c20-b64c-b99c85e49f1b"), new Guid("51f6bc11-b0d4-411b-b40c-3f5696ca2547"), "Location", null, 0, "USA" },
                    { new Guid("be771b67-a084-4637-9a44-24f2e7955443"), new Guid("9a9c991d-fe02-4552-bad7-f0a3fa6a17d2"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("f1a5d785-c061-4994-95ac-71500a0c3fc1"), new Guid("9a9c991d-fe02-4552-bad7-f0a3fa6a17d2"), "Creator", null, 0, "Regixx" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[] { new Guid("32aa8d33-0050-48c0-9f13-841fca2b2364"), new Guid("b9a387cd-9a6f-466a-86fa-8a4c8759c99e") });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"), "Game shop", new Guid("32aa8d33-0050-48c0-9f13-841fca2b2364") });

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUser_Organization_OrganizationId",
                table: "OrganizationUser",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUser_User_UserId",
                table: "OrganizationUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Organization_OrganizationId",
                table: "Spaces",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
