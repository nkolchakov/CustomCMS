using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class seed_additional_entitiesfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1ded9adf-ed3e-402d-85fd-21de7eb8d90f"), "independent 3", new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), null },
                    { new Guid("7042031c-f943-4bf1-8673-686bedb92229"), "Game", new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), null },
                    { new Guid("a0c540ec-790a-4e3d-9ec9-4adce47abdfe"), "independen 2", new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), null },
                    { new Guid("ab0b3f5a-63b1-40fc-ae2c-0ee9bb619f06"), "Trailer", new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), null },
                    { new Guid("cec02055-52a5-4850-93ba-021f270e202c"), "Description", new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), null },
                    { new Guid("dc876db0-fe50-4f46-995e-402534bf3429"), "Publisher", new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("90428e5a-3a8e-463b-bf27-71fdbedec17e"), "Third oorg" },
                    { new Guid("b706b43f-92b7-422d-8e28-35bd6bc01630"), "Organization 2" },
                    { new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd"), "Org1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[,]
                {
                    { new Guid("3b9648c6-cbb1-4a06-86ad-e8c69a8fff51"), 0 },
                    { new Guid("42502914-030d-49eb-bea6-26bdedc64aeb"), 1 },
                    { new Guid("f090c653-cb8b-402e-aa64-41e48aed5316"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("cec02055-52a5-4850-93ba-021f270e202c"), new Guid("7042031c-f943-4bf1-8673-686bedb92229") },
                    { new Guid("dc876db0-fe50-4f46-995e-402534bf3429"), new Guid("7042031c-f943-4bf1-8673-686bedb92229") },
                    { new Guid("ab0b3f5a-63b1-40fc-ae2c-0ee9bb619f06"), new Guid("cec02055-52a5-4850-93ba-021f270e202c") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("1dc06fdf-6cb3-404c-a496-90b3c174026d"), new Guid("a0c540ec-790a-4e3d-9ec9-4adce47abdfe"), "indField1", null, 0, "value-1" },
                    { new Guid("4dc7f691-f30a-4b39-97d9-eea4319785df"), new Guid("ab0b3f5a-63b1-40fc-ae2c-0ee9bb619f06"), "Creator", null, 0, "Regixx" },
                    { new Guid("54e15a5f-4ad6-4d3d-a2bd-b64c76bc53c5"), new Guid("ab0b3f5a-63b1-40fc-ae2c-0ee9bb619f06"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("5666d2d2-9629-4d33-838c-308a77ffc85d"), new Guid("1ded9adf-ed3e-402d-85fd-21de7eb8d90f"), "ind2Field", null, 0, "valueee1" },
                    { new Guid("779b36db-d0bf-448d-86d9-fcd5e8e4bf5b"), new Guid("cec02055-52a5-4850-93ba-021f270e202c"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("a72fe275-28eb-435a-88f0-da578bcb2640"), new Guid("dc876db0-fe50-4f46-995e-402534bf3429"), "Location", null, 0, "USA" },
                    { new Guid("bb810b03-c3ab-4c78-97d2-46334c2266a4"), new Guid("a0c540ec-790a-4e3d-9ec9-4adce47abdfe"), "indField2", null, 1, "4" },
                    { new Guid("deb9def5-a633-469a-b54e-0c6b3646cd8d"), new Guid("7042031c-f943-4bf1-8673-686bedb92229"), "Year", null, 1, "2007" },
                    { new Guid("f92cb2c2-ad9e-4569-808d-12e003bf856d"), new Guid("7042031c-f943-4bf1-8673-686bedb92229"), "Name", null, 0, "Star Wars" },
                    { new Guid("fd8e5afe-a3ec-4b2c-8842-dc7c5b44de0b"), new Guid("dc876db0-fe50-4f46-995e-402534bf3429"), "Name", null, 0, "Santa Monica" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd"), new Guid("3b9648c6-cbb1-4a06-86ad-e8c69a8fff51") },
                    { new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd"), new Guid("42502914-030d-49eb-bea6-26bdedc64aeb") }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"), "Game shop", new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("cec02055-52a5-4850-93ba-021f270e202c"), new Guid("7042031c-f943-4bf1-8673-686bedb92229") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("dc876db0-fe50-4f46-995e-402534bf3429"), new Guid("7042031c-f943-4bf1-8673-686bedb92229") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("ab0b3f5a-63b1-40fc-ae2c-0ee9bb619f06"), new Guid("cec02055-52a5-4850-93ba-021f270e202c") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1dc06fdf-6cb3-404c-a496-90b3c174026d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("4dc7f691-f30a-4b39-97d9-eea4319785df"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("54e15a5f-4ad6-4d3d-a2bd-b64c76bc53c5"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("5666d2d2-9629-4d33-838c-308a77ffc85d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("779b36db-d0bf-448d-86d9-fcd5e8e4bf5b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a72fe275-28eb-435a-88f0-da578bcb2640"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("bb810b03-c3ab-4c78-97d2-46334c2266a4"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("deb9def5-a633-469a-b54e-0c6b3646cd8d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f92cb2c2-ad9e-4569-808d-12e003bf856d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("fd8e5afe-a3ec-4b2c-8842-dc7c5b44de0b"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd"), new Guid("3b9648c6-cbb1-4a06-86ad-e8c69a8fff51") });

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd"), new Guid("42502914-030d-49eb-bea6-26bdedc64aeb") });

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("90428e5a-3a8e-463b-bf27-71fdbedec17e"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("b706b43f-92b7-422d-8e28-35bd6bc01630"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("81ceb55b-dd52-4a61-9251-f34d6803a8bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f090c653-cb8b-402e-aa64-41e48aed5316"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ded9adf-ed3e-402d-85fd-21de7eb8d90f"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("7042031c-f943-4bf1-8673-686bedb92229"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("a0c540ec-790a-4e3d-9ec9-4adce47abdfe"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("ab0b3f5a-63b1-40fc-ae2c-0ee9bb619f06"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("cec02055-52a5-4850-93ba-021f270e202c"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc876db0-fe50-4f46-995e-402534bf3429"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("b7f080b7-9749-4aaa-8d18-0ed036c89edd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b9648c6-cbb1-4a06-86ad-e8c69a8fff51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42502914-030d-49eb-bea6-26bdedc64aeb"));

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
    }
}
