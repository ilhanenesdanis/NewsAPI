using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixed_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(1083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Languages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(1552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Languages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(1389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 196, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 839, DateTimeKind.Local).AddTicks(7567)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 839, DateTimeKind.Local).AddTicks(7812)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConstantSeos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 839, DateTimeKind.Local).AddTicks(9401)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 839, DateTimeKind.Local).AddTicks(9681)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstantSeos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstantSeos_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SeoKeyword = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    SeoDescription = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    SeoTitle = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    SeoUrl = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(5459)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(5642)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(2774)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(3023)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsCategories_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(7467)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(7647)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsTags_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(1502), new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(1506), new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_LanguageId",
                table: "Categories",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstantSeos_LanguageId",
                table: "ConstantSeos",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_News_Title_Id",
                table: "News",
                columns: new[] { "Title", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategories_CategoryId",
                table: "NewsCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategories_NewsId_CategoryId",
                table: "NewsCategories",
                columns: new[] { "NewsId", "CategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsTags_NewsId_TagId",
                table: "NewsTags",
                columns: new[] { "NewsId", "TagId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsTags_TagId",
                table: "NewsTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstantSeos");

            migrationBuilder.DropTable(
                name: "NewsCategories");

            migrationBuilder.DropTable(
                name: "NewsTags");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(1980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(1777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 841, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Languages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Languages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 1, 3, 4, 50, 196, DateTimeKind.Local).AddTicks(9947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 2, 8, 49, 54, 840, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2409), new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2413), new DateTime(2022, 5, 1, 3, 4, 50, 197, DateTimeKind.Local).AddTicks(2413) });
        }
    }
}
