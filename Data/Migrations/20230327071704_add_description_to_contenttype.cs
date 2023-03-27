using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class add_description_to_contenttype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ContentTypes",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Description", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114"), "The game is ...", "Game", new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), null },
                    { new Guid("8be3a1e5-30b9-4e1d-9937-5d8b0752ad29"), "Description for the independent type", "independen 2", new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), null },
                    { new Guid("932d939d-2d2a-435c-b8b0-0c56f00c333b"), "Best publisher game award for the previous year", "Publisher", new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), null },
                    { new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a"), null, "Description", new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), null },
                    { new Guid("eafed2b0-f4ed-4330-b1f2-9e63e7f91a98"), "Some other description", "independent 3", new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), null },
                    { new Guid("fe6839fd-e72b-4114-a18e-3d4eadf399a9"), null, "Trailer", new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8849baac-20eb-4e24-a9ea-b92b204f8795"), "Organization 2" },
                    { new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f"), "Org1" },
                    { new Guid("f79e5473-fe94-4de0-891e-1a23af37dcf0"), "Third oorg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[,]
                {
                    { new Guid("b82c1a52-0220-455a-84b2-92f266a36cf3"), 0 },
                    { new Guid("b8a8d8a2-2e03-4bb0-84e5-72133610c860"), 1 },
                    { new Guid("dbff476f-295c-4b69-b3e5-b89461245a86"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("932d939d-2d2a-435c-b8b0-0c56f00c333b"), new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114") },
                    { new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a"), new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114") },
                    { new Guid("fe6839fd-e72b-4114-a18e-3d4eadf399a9"), new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("0a6c795c-e6b6-4248-a2ef-e61a01e37a52"), new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("254a16bb-4299-4602-8ab1-12d19f50a522"), new Guid("fe6839fd-e72b-4114-a18e-3d4eadf399a9"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("37ede976-7f54-4757-bb87-78d717fc028c"), new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114"), "Name", null, 0, "Star Wars" },
                    { new Guid("615066af-038e-4553-a578-b618a78ed7f5"), new Guid("932d939d-2d2a-435c-b8b0-0c56f00c333b"), "Location", null, 0, "USA" },
                    { new Guid("66fcdf6d-f417-4099-a29c-2825aaf7518a"), new Guid("932d939d-2d2a-435c-b8b0-0c56f00c333b"), "Name", null, 0, "Santa Monica" },
                    { new Guid("67f01731-ab80-4095-b32e-a6e1f9760f01"), new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114"), "Year", null, 1, "2007" },
                    { new Guid("924db144-6737-4b6b-a520-4590aaf1527c"), new Guid("eafed2b0-f4ed-4330-b1f2-9e63e7f91a98"), "ind2Field", null, 0, "valueee1" },
                    { new Guid("e738ce61-a220-4f71-ade8-bacaa9909960"), new Guid("8be3a1e5-30b9-4e1d-9937-5d8b0752ad29"), "indField1", null, 0, "value-1" },
                    { new Guid("ee5f3ec1-0e40-4f2e-8d71-e6a95995ab89"), new Guid("8be3a1e5-30b9-4e1d-9937-5d8b0752ad29"), "indField2", null, 1, "4" },
                    { new Guid("ef935913-3d49-454a-895f-ba13b7f7595c"), new Guid("fe6839fd-e72b-4114-a18e-3d4eadf399a9"), "Creator", null, 0, "Regixx" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f"), new Guid("b8a8d8a2-2e03-4bb0-84e5-72133610c860") },
                    { new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f"), new Guid("dbff476f-295c-4b69-b3e5-b89461245a86") }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"), "Game shop", new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("932d939d-2d2a-435c-b8b0-0c56f00c333b"), new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a"), new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("fe6839fd-e72b-4114-a18e-3d4eadf399a9"), new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0a6c795c-e6b6-4248-a2ef-e61a01e37a52"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("254a16bb-4299-4602-8ab1-12d19f50a522"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("37ede976-7f54-4757-bb87-78d717fc028c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("615066af-038e-4553-a578-b618a78ed7f5"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("66fcdf6d-f417-4099-a29c-2825aaf7518a"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("67f01731-ab80-4095-b32e-a6e1f9760f01"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("924db144-6737-4b6b-a520-4590aaf1527c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e738ce61-a220-4f71-ade8-bacaa9909960"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ee5f3ec1-0e40-4f2e-8d71-e6a95995ab89"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ef935913-3d49-454a-895f-ba13b7f7595c"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f"), new Guid("b8a8d8a2-2e03-4bb0-84e5-72133610c860") });

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f"), new Guid("dbff476f-295c-4b69-b3e5-b89461245a86") });

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("8849baac-20eb-4e24-a9ea-b92b204f8795"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("f79e5473-fe94-4de0-891e-1a23af37dcf0"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("bba73054-8ed1-4e89-b0a1-df79de052184"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b82c1a52-0220-455a-84b2-92f266a36cf3"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("0bdea8ca-293e-4445-b3af-cacf951d1114"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("8be3a1e5-30b9-4e1d-9937-5d8b0752ad29"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("932d939d-2d2a-435c-b8b0-0c56f00c333b"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("ab098d4d-7f46-4b29-9cd3-94fa57e0688a"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("eafed2b0-f4ed-4330-b1f2-9e63e7f91a98"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("fe6839fd-e72b-4114-a18e-3d4eadf399a9"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("ea478b4f-6786-4378-b05f-01a0beaa7e0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8a8d8a2-2e03-4bb0-84e5-72133610c860"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbff476f-295c-4b69-b3e5-b89461245a86"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ContentTypes");

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
    }
}
