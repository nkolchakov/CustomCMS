using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class Add_Organizations_Users_Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("0d513b47-e6de-4904-a9bb-406d3e9aee64"), new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("1716251e-a55a-43d6-b347-dcec5194f10b"), new Guid("30e192bc-0551-46e2-8582-ca61a99c5593") });

            migrationBuilder.DeleteData(
                table: "ContentTypeReferences",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f"), new Guid("30e192bc-0551-46e2-8582-ca61a99c5593") });

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("19ec003e-b9f7-4dbf-b5f3-d9da0d45a4ad"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1a8522dc-f1cc-4198-b8e9-4cf645bcf21e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("57edbac4-cf73-4921-8659-df7d7e3dd4d5"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("5a7b35b8-8a50-4ebe-bd45-6fcc898310cb"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("86e63aa5-7c6f-44fc-9f4e-751db94d1de8"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("988b904f-5c11-49a5-b79a-ffcb1e74ae16"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("be9d2b26-075a-45dd-a990-7e7accb8d0ce"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "Id",
                keyValue: new Guid("03c637a2-1965-4fc5-9992-7a0e921faf0d"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d513b47-e6de-4904-a9bb-406d3e9aee64"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("1716251e-a55a-43d6-b347-dcec5194f10b"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("30e192bc-0551-46e2-8582-ca61a99c5593"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrganizationId",
                table: "Spaces",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ContentTypes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                });

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
                name: "IX_Spaces_OrganizationId",
                table: "Spaces",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_OrganizationId",
                table: "User",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spaces_Organization_OrganizationId",
                table: "Spaces",
                column: "OrganizationId",
                principalTable: "Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spaces_Organization_OrganizationId",
                table: "Spaces");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropIndex(
                name: "IX_Spaces_OrganizationId",
                table: "Spaces");

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

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Spaces");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ContentTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name", "SpaceId", "SysId" },
                values: new object[,]
                {
                    { new Guid("0d513b47-e6de-4904-a9bb-406d3e9aee64"), "Trailer", new Guid("03c637a2-1965-4fc5-9992-7a0e921faf0d"), null },
                    { new Guid("1716251e-a55a-43d6-b347-dcec5194f10b"), "Publisher", new Guid("03c637a2-1965-4fc5-9992-7a0e921faf0d"), null },
                    { new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f"), "Description", new Guid("03c637a2-1965-4fc5-9992-7a0e921faf0d"), null },
                    { new Guid("30e192bc-0551-46e2-8582-ca61a99c5593"), "Game", new Guid("03c637a2-1965-4fc5-9992-7a0e921faf0d"), null }
                });

            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("03c637a2-1965-4fc5-9992-7a0e921faf0d"), "Game shop" });

            migrationBuilder.InsertData(
                table: "ContentTypeReferences",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { new Guid("0d513b47-e6de-4904-a9bb-406d3e9aee64"), new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f") },
                    { new Guid("1716251e-a55a-43d6-b347-dcec5194f10b"), new Guid("30e192bc-0551-46e2-8582-ca61a99c5593") },
                    { new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f"), new Guid("30e192bc-0551-46e2-8582-ca61a99c5593") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "ContentTypeId", "Name", "Required", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("19ec003e-b9f7-4dbf-b5f3-d9da0d45a4ad"), new Guid("30e192bc-0551-46e2-8582-ca61a99c5593"), "Name", null, 0, "Star Wars" },
                    { new Guid("1a8522dc-f1cc-4198-b8e9-4cf645bcf21e"), new Guid("30e192bc-0551-46e2-8582-ca61a99c5593"), "Year", null, 1, "2007" },
                    { new Guid("57edbac4-cf73-4921-8659-df7d7e3dd4d5"), new Guid("1f9fc060-33a5-4366-8737-f2e780ea636f"), "DescriptionText", null, 0, "Best game ever" },
                    { new Guid("5a7b35b8-8a50-4ebe-bd45-6fcc898310cb"), new Guid("0d513b47-e6de-4904-a9bb-406d3e9aee64"), "TrailerVideo", null, 4, "http://" },
                    { new Guid("86e63aa5-7c6f-44fc-9f4e-751db94d1de8"), new Guid("0d513b47-e6de-4904-a9bb-406d3e9aee64"), "Creator", null, 0, "Regixx" },
                    { new Guid("988b904f-5c11-49a5-b79a-ffcb1e74ae16"), new Guid("1716251e-a55a-43d6-b347-dcec5194f10b"), "Location", null, 0, "USA" },
                    { new Guid("be9d2b26-075a-45dd-a990-7e7accb8d0ce"), new Guid("1716251e-a55a-43d6-b347-dcec5194f10b"), "Name", null, 0, "Santa Monica" }
                });
        }
    }
}
