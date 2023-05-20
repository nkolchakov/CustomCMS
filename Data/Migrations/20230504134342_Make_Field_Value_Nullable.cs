using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class Make_Field_Value_Nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("c3097f6b-5aea-40ef-ba72-a0637c5e94a1"), new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d"), new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("9f204e3a-b737-42d9-a9e1-972845a85fac"), new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0fb3c2be-305a-4ea5-8e54-ba6f4001415d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("12b21e9b-7f1d-4949-826b-b1677292c0d6"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2e007b33-d1a8-4e5a-8a3e-198d596e9461"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("75186859-d83e-4570-b396-119926d27254"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("82790aa2-9e5a-4b3c-971b-29d80cb7bd47"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("96ccac4e-a000-40fc-be39-4204635fe1e7"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a5da4bf9-ffe3-4d4d-8361-eab9549eb34d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("aca319a0-1d27-4fee-856f-36d228d5308e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d7cbe156-5b9f-433d-bc0d-c014c7a0c205"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f68a33d2-acb5-4156-8705-6ec8058a3f00"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18"), new Guid("43a8fdfd-dd68-4ece-9e6e-cc9595b56bf4") });

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18"), new Guid("fbfd6cb2-28a0-4d8b-a2af-848b3a04bcc0") });

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("5b1d7fc5-d2e9-47a8-9617-022cf5b5222e"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("7e1f2104-ad81-4019-8ad5-7ff358d77ed7"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f1a195c-c817-4ff1-9c17-eeee634e4cf9"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d12ed5d-7b33-411f-aac0-b71effb34c56"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("9f204e3a-b737-42d9-a9e1-972845a85fac"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("c3097f6b-5aea-40ef-ba72-a0637c5e94a1"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("c796e743-a61c-4541-92e5-c4c32898c245"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43a8fdfd-dd68-4ece-9e6e-cc9595b56bf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbfd6cb2-28a0-4d8b-a2af-848b3a04bcc0"));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Description", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16"), null, "Description", new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), null },
                    { new Guid("0d2f8f62-724a-4745-8fdf-efdd8b2ee358"), "Some other description", "independent 3", new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), null },
                    { new Guid("1e496d97-85e3-4023-93b3-a74950251a16"), "Description for the independent type", "independen 2", new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), null },
                    { new Guid("6b6dac15-b310-477d-be00-76c0633b1a3a"), "Best publisher game award for the previous year", "Publisher", new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), null },
                    { new Guid("750d40c2-4312-4d4c-924b-97e84baa9abd"), null, "Trailer", new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), null },
                    { new Guid("d45ea086-acd6-4789-807e-8c45951f0f17"), "The game is ...", "Game", new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("060b40d8-285b-43fe-90d6-cb625179e5ff"), "Organization 2" },
                    { new Guid("2d872867-151b-4517-bf36-a59ac5122c48"), "Org1" },
                    { new Guid("907c000c-3aff-44de-838a-8a3b819ce201"), "Third oorg" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[,]
                {
                    { new Guid("0f00f8af-1748-42af-a4f3-255c5a581c33"), 1 },
                    { new Guid("1f6e5c76-60e6-4408-a53e-27ac7b917830"), 0 },
                    { new Guid("c3a1a6f8-9742-4367-8031-498b52b00b3f"), 0 }
                });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("750d40c2-4312-4d4c-924b-97e84baa9abd"), new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16") },
                    { new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16"), new Guid("d45ea086-acd6-4789-807e-8c45951f0f17") },
                    { new Guid("6b6dac15-b310-477d-be00-76c0633b1a3a"), new Guid("d45ea086-acd6-4789-807e-8c45951f0f17") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("0aa1356c-7475-46cf-a8eb-1d64174f0bcd"), new Guid("1e496d97-85e3-4023-93b3-a74950251a16"), "indField2", null, 1, "4" },
                    { new Guid("0d0aa401-142a-4c6e-91d6-3564d85bfcad"), new Guid("1e496d97-85e3-4023-93b3-a74950251a16"), "indField1", null, 0, "value-1" },
                    { new Guid("0e532d73-2326-4cdb-a3e3-7f1f0818b88e"), new Guid("750d40c2-4312-4d4c-924b-97e84baa9abd"), "Creator", null, 0, "Regixx" },
                    { new Guid("28289c6d-9c12-4ea1-844c-e02c1b828fad"), new Guid("6b6dac15-b310-477d-be00-76c0633b1a3a"), "Name", null, 0, "Santa Monica" },
                    { new Guid("32ab1054-4d16-4e62-b49c-d584df2700ba"), new Guid("d45ea086-acd6-4789-807e-8c45951f0f17"), "Name", null, 0, "Star Wars" },
                    { new Guid("5c2bb8c1-d2bd-475f-ab3e-7b67bb373c2d"), new Guid("0d2f8f62-724a-4745-8fdf-efdd8b2ee358"), "ind2Field", null, 0, "valueee1" },
                    { new Guid("74fca307-7475-4f9c-bdcd-1aa803fb9a5b"), new Guid("6b6dac15-b310-477d-be00-76c0633b1a3a"), "Location", null, 0, "USA" },
                    { new Guid("87a5d331-7534-4dd1-8918-f346f8b85353"), new Guid("d45ea086-acd6-4789-807e-8c45951f0f17"), "Year", null, 1, "2007" },
                    { new Guid("ce6beb9d-2348-4ba5-af17-d413e3b648fd"), new Guid("750d40c2-4312-4d4c-924b-97e84baa9abd"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("f180d1a5-d8db-4bbe-96c8-b5da9b044f5b"), new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16"), "DescriptionText", null, 0, "Best game ever" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d872867-151b-4517-bf36-a59ac5122c48"), new Guid("0f00f8af-1748-42af-a4f3-255c5a581c33") },
                    { new Guid("2d872867-151b-4517-bf36-a59ac5122c48"), new Guid("1f6e5c76-60e6-4408-a53e-27ac7b917830") }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"), "Game shop", new Guid("2d872867-151b-4517-bf36-a59ac5122c48") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("750d40c2-4312-4d4c-924b-97e84baa9abd"), new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16"), new Guid("d45ea086-acd6-4789-807e-8c45951f0f17") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("6b6dac15-b310-477d-be00-76c0633b1a3a"), new Guid("d45ea086-acd6-4789-807e-8c45951f0f17") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0aa1356c-7475-46cf-a8eb-1d64174f0bcd"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0d0aa401-142a-4c6e-91d6-3564d85bfcad"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0e532d73-2326-4cdb-a3e3-7f1f0818b88e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("28289c6d-9c12-4ea1-844c-e02c1b828fad"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("32ab1054-4d16-4e62-b49c-d584df2700ba"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("5c2bb8c1-d2bd-475f-ab3e-7b67bb373c2d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("74fca307-7475-4f9c-bdcd-1aa803fb9a5b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("87a5d331-7534-4dd1-8918-f346f8b85353"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ce6beb9d-2348-4ba5-af17-d413e3b648fd"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f180d1a5-d8db-4bbe-96c8-b5da9b044f5b"));

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("2d872867-151b-4517-bf36-a59ac5122c48"), new Guid("0f00f8af-1748-42af-a4f3-255c5a581c33") });

            migrationBuilder.DeleteData(
                table: "OrganizationUser",
                keyColumns: new[] { "OrganizationId", "UserId" },
                keyValues: new object[] { new Guid("2d872867-151b-4517-bf36-a59ac5122c48"), new Guid("1f6e5c76-60e6-4408-a53e-27ac7b917830") });

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("060b40d8-285b-43fe-90d6-cb625179e5ff"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("907c000c-3aff-44de-838a-8a3b819ce201"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("ebce5f4a-f21a-4118-b67e-e936371604e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3a1a6f8-9742-4367-8031-498b52b00b3f"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("033f4fb4-5800-4caf-8d1f-08e38ff9aa16"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d2f8f62-724a-4745-8fdf-efdd8b2ee358"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("1e496d97-85e3-4023-93b3-a74950251a16"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("6b6dac15-b310-477d-be00-76c0633b1a3a"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("750d40c2-4312-4d4c-924b-97e84baa9abd"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("d45ea086-acd6-4789-807e-8c45951f0f17"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("2d872867-151b-4517-bf36-a59ac5122c48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f00f8af-1748-42af-a4f3-255c5a581c33"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1f6e5c76-60e6-4408-a53e-27ac7b917830"));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Description", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5"), "The game is ...", "Game", new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), null },
                    { new Guid("3d12ed5d-7b33-411f-aac0-b71effb34c56"), "Some other description", "independent 3", new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), null },
                    { new Guid("9f204e3a-b737-42d9-a9e1-972845a85fac"), null, "Trailer", new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), null },
                    { new Guid("c3097f6b-5aea-40ef-ba72-a0637c5e94a1"), "Best publisher game award for the previous year", "Publisher", new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), null },
                    { new Guid("c796e743-a61c-4541-92e5-c4c32898c245"), "Description for the independent type", "independen 2", new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), null },
                    { new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d"), null, "Description", new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), null }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18"), "Org1" },
                    { new Guid("5b1d7fc5-d2e9-47a8-9617-022cf5b5222e"), "Third oorg" },
                    { new Guid("7e1f2104-ad81-4019-8ad5-7ff358d77ed7"), "Organization 2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserRole" },
                values: new object[,]
                {
                    { new Guid("0f1a195c-c817-4ff1-9c17-eeee634e4cf9"), 0 },
                    { new Guid("43a8fdfd-dd68-4ece-9e6e-cc9595b56bf4"), 0 },
                    { new Guid("fbfd6cb2-28a0-4d8b-a2af-848b3a04bcc0"), 1 }
                });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("c3097f6b-5aea-40ef-ba72-a0637c5e94a1"), new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5") },
                    { new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d"), new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5") },
                    { new Guid("9f204e3a-b737-42d9-a9e1-972845a85fac"), new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("0fb3c2be-305a-4ea5-8e54-ba6f4001415d"), new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5"), "Year", null, 1, "2007" },
                    { new Guid("12b21e9b-7f1d-4949-826b-b1677292c0d6"), new Guid("c796e743-a61c-4541-92e5-c4c32898c245"), "indField1", null, 0, "value-1" },
                    { new Guid("2e007b33-d1a8-4e5a-8a3e-198d596e9461"), new Guid("9f204e3a-b737-42d9-a9e1-972845a85fac"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("75186859-d83e-4570-b396-119926d27254"), new Guid("c3097f6b-5aea-40ef-ba72-a0637c5e94a1"), "Location", null, 0, "USA" },
                    { new Guid("82790aa2-9e5a-4b3c-971b-29d80cb7bd47"), new Guid("c3097f6b-5aea-40ef-ba72-a0637c5e94a1"), "Name", null, 0, "Santa Monica" },
                    { new Guid("96ccac4e-a000-40fc-be39-4204635fe1e7"), new Guid("3d12ed5d-7b33-411f-aac0-b71effb34c56"), "ind2Field", null, 0, "valueee1" },
                    { new Guid("a5da4bf9-ffe3-4d4d-8361-eab9549eb34d"), new Guid("154c9c4f-6980-4609-9255-5cb4f61bbbf5"), "Name", null, 0, "Star Wars" },
                    { new Guid("aca319a0-1d27-4fee-856f-36d228d5308e"), new Guid("9f204e3a-b737-42d9-a9e1-972845a85fac"), "Creator", null, 0, "Regixx" },
                    { new Guid("d7cbe156-5b9f-433d-bc0d-c014c7a0c205"), new Guid("f7fa54a6-8cce-4f1e-808c-f06c0b545d9d"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("f68a33d2-acb5-4156-8705-6ec8058a3f00"), new Guid("c796e743-a61c-4541-92e5-c4c32898c245"), "indField2", null, 1, "4" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationUser",
                columns: new[] { "OrganizationId", "UserId" },
                values: new object[,]
                {
                    { new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18"), new Guid("43a8fdfd-dd68-4ece-9e6e-cc9595b56bf4") },
                    { new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18"), new Guid("fbfd6cb2-28a0-4d8b-a2af-848b3a04bcc0") }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("de874adf-136d-4d45-9f0a-c0e8c52e55a5"), "Game shop", new Guid("22f5d4e1-1c8b-4020-93cc-4056c1992e18") });
        }
    }
}
