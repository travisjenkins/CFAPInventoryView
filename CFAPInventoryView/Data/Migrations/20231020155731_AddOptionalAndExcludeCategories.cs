using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOptionalAndExcludeCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExcludeCategoryId",
                table: "CategoryBaskets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OptionalCategoryId",
                table: "CategoryBaskets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExcludeCategories",
                columns: table => new
                {
                    ExcludeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcludeCategories", x => x.ExcludeCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "OptionalCategories",
                columns: table => new
                {
                    OptionalCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalCategories", x => x.OptionalCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_BasketId",
                table: "CategoryBaskets",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_ExcludeCategoryId",
                table: "CategoryBaskets",
                column: "ExcludeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_OptionalCategoryId",
                table: "CategoryBaskets",
                column: "OptionalCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBaskets_Baskets_BasketId",
                table: "CategoryBaskets",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "BasketId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBaskets_ExcludeCategories_ExcludeCategoryId",
                table: "CategoryBaskets",
                column: "ExcludeCategoryId",
                principalTable: "ExcludeCategories",
                principalColumn: "ExcludeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBaskets_OptionalCategories_OptionalCategoryId",
                table: "CategoryBaskets",
                column: "OptionalCategoryId",
                principalTable: "OptionalCategories",
                principalColumn: "OptionalCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBaskets_Baskets_BasketId",
                table: "CategoryBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBaskets_ExcludeCategories_ExcludeCategoryId",
                table: "CategoryBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBaskets_OptionalCategories_OptionalCategoryId",
                table: "CategoryBaskets");

            migrationBuilder.DropTable(
                name: "ExcludeCategories");

            migrationBuilder.DropTable(
                name: "OptionalCategories");

            migrationBuilder.DropIndex(
                name: "IX_CategoryBaskets_BasketId",
                table: "CategoryBaskets");

            migrationBuilder.DropIndex(
                name: "IX_CategoryBaskets_ExcludeCategoryId",
                table: "CategoryBaskets");

            migrationBuilder.DropIndex(
                name: "IX_CategoryBaskets_OptionalCategoryId",
                table: "CategoryBaskets");

            migrationBuilder.DropColumn(
                name: "ExcludeCategoryId",
                table: "CategoryBaskets");

            migrationBuilder.DropColumn(
                name: "OptionalCategoryId",
                table: "CategoryBaskets");
        }
    }
}
