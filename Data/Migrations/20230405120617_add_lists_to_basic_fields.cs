using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class add_lists_to_basic_fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ListItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListItem_Fields_BasicFieldId",
                        column: x => x.BasicFieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Description", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"), null, "Trailer", new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), null },
                    { new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"), null, "Description", new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), null },
                    { new Guid("3b3a48dc-1aa0-4026-bd55-bfbe74ccd99d"), "Some other description", "independent 3", new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), null },
                    { new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"), "The game is ...", "Game", new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), null },
                    { new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"), "Best publisher game award for the previous year", "Publisher", new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), null },
                    { new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"), "Description for the independent type", "independen 2", new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"), "Org1" },
                    { new Guid("871494fd-1112-4f88-bd5a-c9daa8e6e650"), "Third oorg" },
                    { new Guid("b6207be1-cb0b-4298-b2a5-de950e2c339f"), "Organization 2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[,]
                {
                    { new Guid("04bcded5-2d24-4d24-abfc-47967ed34bc4"), 0 },
                    { new Guid("5d1d518e-a7e2-4918-9249-47620d173c38"), 1 },
                    { new Guid("5de99182-49cf-4e5b-963b-999788b017e7"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"), new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81") },
                    { new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"), new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa") },
                    { new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"), new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("09a06835-9c14-4d4c-a418-18c98080a4b5"), new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("2f13b251-1c10-4556-9bee-f65810d0d412"), new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"), "Creator", null, 0, "Regixx" },
                    { new Guid("39295625-2cde-42c5-9d73-792be629ba5b"), new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("416b9ccb-5e71-4b79-a640-8969cf091e55"), new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"), "Name", null, 0, "Star Wars" },
                    { new Guid("567cfad1-7b3f-4e40-bd03-24f0c5bbc910"), new Guid("3b3a48dc-1aa0-4026-bd55-bfbe74ccd99d"), "ind2Field", null, 0, "valueee1" },
                    { new Guid("8eb20398-a6b8-4d95-9a78-7bd1c36b1872"), new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"), "Year", null, 1, "2007" },
                    { new Guid("9053344d-51f8-44d0-90ca-9517d32aa9bf"), new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"), "indField2", null, 1, "4" },
                    { new Guid("ce07415d-9b1f-4869-b68e-f40c27172a48"), new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"), "Location", null, 0, "USA" },
                    { new Guid("dfc097d2-f322-4c85-bd06-025740e4be0e"), new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"), "Name", null, 0, "Santa Monica" },
                    { new Guid("f13a8351-1092-4e53-a43f-44dab8e326bb"), new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"), "indField1", null, 0, "value-1" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[,]
                {
                    { new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"), new Guid("04bcded5-2d24-4d24-abfc-47967ed34bc4") },
                    { new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"), new Guid("5d1d518e-a7e2-4918-9249-47620d173c38") }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("0e824164-c360-497b-bf71-e20b47282bbe"), "Game shop", new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d") });

            migrationBuilder.CreateIndex(
                name: "IX_ListItem_BasicFieldId",
                table: "ListItem",
                column: "BasicFieldId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListItem");

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"), new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"), new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"), new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("09a06835-9c14-4d4c-a418-18c98080a4b5"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2f13b251-1c10-4556-9bee-f65810d0d412"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("39295625-2cde-42c5-9d73-792be629ba5b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("416b9ccb-5e71-4b79-a640-8969cf091e55"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("567cfad1-7b3f-4e40-bd03-24f0c5bbc910"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("8eb20398-a6b8-4d95-9a78-7bd1c36b1872"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9053344d-51f8-44d0-90ca-9517d32aa9bf"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ce07415d-9b1f-4869-b68e-f40c27172a48"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("dfc097d2-f322-4c85-bd06-025740e4be0e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f13a8351-1092-4e53-a43f-44dab8e326bb"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"), new Guid("04bcded5-2d24-4d24-abfc-47967ed34bc4") });

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"), new Guid("5d1d518e-a7e2-4918-9249-47620d173c38") });

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("871494fd-1112-4f88-bd5a-c9daa8e6e650"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("b6207be1-cb0b-4298-b2a5-de950e2c339f"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("0e824164-c360-497b-bf71-e20b47282bbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5de99182-49cf-4e5b-963b-999788b017e7"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("11b39c09-0658-4fb8-bd98-08d6567722f9"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("145fb6b8-8416-4735-bbe6-60b9ad829f81"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b3a48dc-1aa0-4026-bd55-bfbe74ccd99d"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("509730d7-3b0c-4dc4-8173-98cce5e98afa"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("94fd58bc-90c8-4398-b9c0-f9878e652e0d"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("c3b18a44-3f0e-4b28-867c-fb46723094ee"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("44449bda-f8b9-44cd-b11a-ab47a417481d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04bcded5-2d24-4d24-abfc-47967ed34bc4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d1d518e-a7e2-4918-9249-47620d173c38"));

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
    }
}
