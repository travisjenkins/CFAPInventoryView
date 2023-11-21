using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddQtyAndSafeStockToAllCategoryTypesRemoveSafeStockFromProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SafeStockLevel",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OptionalCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SafeStockLevel",
                table: "OptionalCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ExcludeCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SafeStockLevel",
                table: "ExcludeCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SafeStockLevel",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OptionalCategories");

            migrationBuilder.DropColumn(
                name: "SafeStockLevel",
                table: "OptionalCategories");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ExcludeCategories");

            migrationBuilder.DropColumn(
                name: "SafeStockLevel",
                table: "ExcludeCategories");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SafeStockLevel",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "SafeStockLevel",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
