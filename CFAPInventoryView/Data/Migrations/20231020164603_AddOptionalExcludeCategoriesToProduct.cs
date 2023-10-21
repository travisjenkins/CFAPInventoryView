using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOptionalExcludeCategoriesToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ExcludeCategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OptionalCategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ExcludeCategoryId",
                table: "Products",
                column: "ExcludeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OptionalCategoryId",
                table: "Products",
                column: "OptionalCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ExcludeCategories_ExcludeCategoryId",
                table: "Products",
                column: "ExcludeCategoryId",
                principalTable: "ExcludeCategories",
                principalColumn: "ExcludeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OptionalCategories_OptionalCategoryId",
                table: "Products",
                column: "OptionalCategoryId",
                principalTable: "OptionalCategories",
                principalColumn: "OptionalCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ExcludeCategories_ExcludeCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OptionalCategories_OptionalCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ExcludeCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OptionalCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ExcludeCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OptionalCategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
