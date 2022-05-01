using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 196, DateTimeKind.Local).AddTicks(9947)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(156)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(1777)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(1980)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateDate", "IsActive", "Name", "UpdateDate" },
                values: new object[] { 1, new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2409), true, "Türkçe", new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateDate", "IsActive", "Name", "UpdateDate" },
                values: new object[] { 2, new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2413), true, "İngilizce", new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Id",
                table: "Languages",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_Id",
                table: "Tags",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_LanguageId",
                table: "Tags",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
