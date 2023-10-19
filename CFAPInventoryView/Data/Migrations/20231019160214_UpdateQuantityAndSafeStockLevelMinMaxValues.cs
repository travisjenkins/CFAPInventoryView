using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuantityAndSafeStockLevelMinMaxValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductBaskets");

            migrationBuilder.DropColumn(
                name: "SafeStockLevel",
                table: "ProductBaskets");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SafeStockLevel",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "SafeStockLevel",
                table: "Baskets");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SafeStockLevel",
                table: "ProductBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
