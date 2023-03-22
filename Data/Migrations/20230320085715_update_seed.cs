using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class update_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("060111b3-0c12-4559-ba21-cf8b3eb9e170"), "Publisher", new Guid("6c2521da-4e11-4dec-b01c-8d4d89e47eb9"), null },
                    { new Guid("0f0197f4-a460-4315-afbb-86180872a89b"), "Description", new Guid("6c2521da-4e11-4dec-b01c-8d4d89e47eb9"), null },
                    { new Guid("2aca0bee-c175-4d0f-8495-44d8be5eef25"), "Trailer", new Guid("6c2521da-4e11-4dec-b01c-8d4d89e47eb9"), null },
                    { new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984"), "Game", new Guid("6c2521da-4e11-4dec-b01c-8d4d89e47eb9"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2"), "Org1" },
                    { new Guid("32cc0321-3bba-4f7b-b1ce-5d5e146185c9"), "Third oorg" },
                    { new Guid("3b795dea-e3da-428a-aa59-3850a4382b18"), "Organization 2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[,]
                {
                    { new Guid("1b8b6c51-82ba-460a-8945-69d64c193827"), 1 },
                    { new Guid("35045e7d-6c48-41e6-abfe-5db698ad1151"), 0 },
                    { new Guid("b186191f-0c90-463a-86e5-76a308e139e5"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("2aca0bee-c175-4d0f-8495-44d8be5eef25"), new Guid("0f0197f4-a460-4315-afbb-86180872a89b") },
                    { new Guid("060111b3-0c12-4559-ba21-cf8b3eb9e170"), new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984") },
                    { new Guid("0f0197f4-a460-4315-afbb-86180872a89b"), new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("0e04bb7e-ae73-42ea-846d-4009fcaec7bb"), new Guid("060111b3-0c12-4559-ba21-cf8b3eb9e170"), "Name", null, 0, "Santa Monica" },
                    { new Guid("3cfc3654-925d-4b9c-b7a5-320e85b2cdac"), new Guid("0f0197f4-a460-4315-afbb-86180872a89b"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("42ad829a-1f18-4e7f-b855-6a1d722af24d"), new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984"), "Name", null, 0, "Star Wars" },
                    { new Guid("98b5bf32-0b90-4d40-861d-f94f03c7caa5"), new Guid("060111b3-0c12-4559-ba21-cf8b3eb9e170"), "Location", null, 0, "USA" },
                    { new Guid("b2b927bb-08a3-46d9-9a44-1100a839a819"), new Guid("2aca0bee-c175-4d0f-8495-44d8be5eef25"), "Creator", null, 0, "Regixx" },
                    { new Guid("c435f36d-3e16-49c8-b98a-7be4337f5dad"), new Guid("2aca0bee-c175-4d0f-8495-44d8be5eef25"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("f1973d16-0ea1-4497-b517-7c3abe4aebb5"), new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984"), "Year", null, 1, "2007" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[,]
                {
                    { new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2"), new Guid("1b8b6c51-82ba-460a-8945-69d64c193827") },
                    { new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2"), new Guid("b186191f-0c90-463a-86e5-76a308e139e5") }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("6c2521da-4e11-4dec-b01c-8d4d89e47eb9"), "Game shop", new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("2aca0bee-c175-4d0f-8495-44d8be5eef25"), new Guid("0f0197f4-a460-4315-afbb-86180872a89b") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("060111b3-0c12-4559-ba21-cf8b3eb9e170"), new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("0f0197f4-a460-4315-afbb-86180872a89b"), new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0e04bb7e-ae73-42ea-846d-4009fcaec7bb"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3cfc3654-925d-4b9c-b7a5-320e85b2cdac"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("42ad829a-1f18-4e7f-b855-6a1d722af24d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("98b5bf32-0b90-4d40-861d-f94f03c7caa5"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("b2b927bb-08a3-46d9-9a44-1100a839a819"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c435f36d-3e16-49c8-b98a-7be4337f5dad"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f1973d16-0ea1-4497-b517-7c3abe4aebb5"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2"), new Guid("1b8b6c51-82ba-460a-8945-69d64c193827") });

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2"), new Guid("b186191f-0c90-463a-86e5-76a308e139e5") });

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("32cc0321-3bba-4f7b-b1ce-5d5e146185c9"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("3b795dea-e3da-428a-aa59-3850a4382b18"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("6c2521da-4e11-4dec-b01c-8d4d89e47eb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35045e7d-6c48-41e6-abfe-5db698ad1151"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("060111b3-0c12-4559-ba21-cf8b3eb9e170"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("0f0197f4-a460-4315-afbb-86180872a89b"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("2aca0bee-c175-4d0f-8495-44d8be5eef25"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c33469c-f3f1-49c7-8808-1148eebcf984"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("229c238d-2fbd-47ae-a5b6-6be61cb8a9b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b8b6c51-82ba-460a-8945-69d64c193827"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b186191f-0c90-463a-86e5-76a308e139e5"));

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
        }
    }
}
