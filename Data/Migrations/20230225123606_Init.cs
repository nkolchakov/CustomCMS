using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstPublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SysId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentTypes_Sys_SysId",
                        column: x => x.SysId,
                        principalTable: "Sys",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContentTypeReferences",
                columns: table => new
                {
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypeReferences", x => new { x.ParentId, x.ChildId });
                    table.ForeignKey(
                        name: "FK_ContentTypeReferences_ContentTypes_ChildId",
                        column: x => x.ChildId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentTypeReferences_ContentTypes_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: true),
                    ContentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ContentTypeReferences_ChildId",
                table: "ContentTypeReferences",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTypes_SysId",
                table: "ContentTypes",
                column: "SysId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_ContentTypeId",
                table: "Fields",
                column: "ContentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContentTypeReferences");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Spaces");

            migrationBuilder.DropTable(
                name: "ContentTypes");

            migrationBuilder.DropTable(
                name: "Sys");
        }
    }
}
