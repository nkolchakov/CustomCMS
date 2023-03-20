using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class user_organization_many2many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Organization_OrganizationId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_OrganizationId",
                table: "User");

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("743bfcb1-eea9-49a9-90d3-f8cbb966b46f"), new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("22539efa-196c-4c6c-b734-ab70d0622289"), new Guid("cba40273-e7a9-4997-b60f-bc209197afad") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d"), new Guid("cba40273-e7a9-4997-b60f-bc209197afad") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2059a7d3-7397-44db-b721-63fcaa3831a8"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("302f60d0-7844-4bb9-97c3-92f1545b2d6c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a0378342-9893-449b-827a-f5ccc398ac52"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c08d53af-ff91-4af2-843c-21ea9b60c256"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c10d27f6-0eb7-4d0a-9147-0b2628431a8c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c99e4033-e431-417c-982e-628e2b6fdd93"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e54ebe42-c373-497c-9ae7-7866172dbe33"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("b641fb17-bb04-4edb-b7fa-d615185b74ea"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8b9407df-056c-4472-8830-e3589ed6404a"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("22539efa-196c-4c6c-b734-ab70d0622289"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("743bfcb1-eea9-49a9-90d3-f8cbb966b46f"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("cba40273-e7a9-4997-b60f-bc209197afad"));

            migrationBuilder.DeleteData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: new Guid("9dc8d01c-55af-4a90-aaa5-c2970a11b00e"));

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "User");

            migrationBuilder.CreateTable(
                name: "OrganizationUser",
                columns: table => new
                {
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationUser", x => new { x.OrganizationId, x.UserId });
                    table.ForeignKey(
                        name: "FK_OrganizationUser_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrganizationUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationUser_UserId",
                table: "OrganizationUser",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationUser");

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
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("5bc61abe-3e4e-4e30-ab6e-ce05279c33fe"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9a387cd-9a6f-466a-86fa-8a4c8759c99e"));

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
                table: "Organization",
                keyColumn: "Id",
                keyValue: new Guid("32aa8d33-0050-48c0-9f13-841fca2b2364"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationId",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("22539efa-196c-4c6c-b734-ab70d0622289"), "Publisher", new Guid("b641fb17-bb04-4edb-b7fa-d615185b74ea"), null },
                    { new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d"), "Description", new Guid("b641fb17-bb04-4edb-b7fa-d615185b74ea"), null },
                    { new Guid("743bfcb1-eea9-49a9-90d3-f8cbb966b46f"), "Trailer", new Guid("b641fb17-bb04-4edb-b7fa-d615185b74ea"), null },
                    { new Guid("cba40273-e7a9-4997-b60f-bc209197afad"), "Game", new Guid("b641fb17-bb04-4edb-b7fa-d615185b74ea"), null }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9dc8d01c-55af-4a90-aaa5-c2970a11b00e"), "Org1" });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("743bfcb1-eea9-49a9-90d3-f8cbb966b46f"), new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d") },
                    { new Guid("22539efa-196c-4c6c-b734-ab70d0622289"), new Guid("cba40273-e7a9-4997-b60f-bc209197afad") },
                    { new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d"), new Guid("cba40273-e7a9-4997-b60f-bc209197afad") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("2059a7d3-7397-44db-b721-63fcaa3831a8"), new Guid("743bfcb1-eea9-49a9-90d3-f8cbb966b46f"), "Creator", null, 0, "Regixx" },
                    { new Guid("302f60d0-7844-4bb9-97c3-92f1545b2d6c"), new Guid("22539efa-196c-4c6c-b734-ab70d0622289"), "Location", null, 0, "USA" },
                    { new Guid("a0378342-9893-449b-827a-f5ccc398ac52"), new Guid("743bfcb1-eea9-49a9-90d3-f8cbb966b46f"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("c08d53af-ff91-4af2-843c-21ea9b60c256"), new Guid("22539efa-196c-4c6c-b734-ab70d0622289"), "Name", null, 0, "Santa Monica" },
                    { new Guid("c10d27f6-0eb7-4d0a-9147-0b2628431a8c"), new Guid("cba40273-e7a9-4997-b60f-bc209197afad"), "Name", null, 0, "Star Wars" },
                    { new Guid("c99e4033-e431-417c-982e-628e2b6fdd93"), new Guid("5c15c80f-a116-4e93-ba00-a5fdfc18316d"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("e54ebe42-c373-497c-9ae7-7866172dbe33"), new Guid("cba40273-e7a9-4997-b60f-bc209197afad"), "Year", null, 1, "2007" }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name", "OrganizationId" },
                values: new object[] { new Guid("b641fb17-bb04-4edb-b7fa-d615185b74ea"), "Game shop", new Guid("9dc8d01c-55af-4a90-aaa5-c2970a11b00e") });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "OrganizationId", "UserRole" },
                values: new object[] { new Guid("8b9407df-056c-4472-8830-e3589ed6404a"), new Guid("9dc8d01c-55af-4a90-aaa5-c2970a11b00e"), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_User_OrganizationId",
                table: "User",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Organization_OrganizationId",
                table: "User",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id");
        }
    }
}
