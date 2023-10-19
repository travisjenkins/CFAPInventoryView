using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductBasketManyToManyLinkTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Baskets_ExcludeBasketId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Baskets_IncludeBasketId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Baskets_OptionalBasketId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ExcludeBasketId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_IncludeBasketId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OptionalBasketId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ExcludeBasketId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IncludeBasketId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OptionalBasketId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalValue",
                table: "Baskets");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductBaskets",
                columns: table => new
                {
                    ProductBasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBaskets", x => x.ProductBasketId);
                    table.ForeignKey(
                        name: "FK_ProductBaskets_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductBaskets_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBaskets_BasketId",
                table: "ProductBaskets",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBaskets_ProductId",
                table: "ProductBaskets",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBaskets");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "ExcludeBasketId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IncludeBasketId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OptionalBasketId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalValue",
                table: "Baskets",
                type: "decimal(13,4)",
                precision: 13,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ExcludeBasketId",
                table: "Products",
                column: "ExcludeBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IncludeBasketId",
                table: "Products",
                column: "IncludeBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OptionalBasketId",
                table: "Products",
                column: "OptionalBasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Baskets_ExcludeBasketId",
                table: "Products",
                column: "ExcludeBasketId",
                principalTable: "Baskets",
                principalColumn: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Baskets_IncludeBasketId",
                table: "Products",
                column: "IncludeBasketId",
                principalTable: "Baskets",
                principalColumn: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Baskets_OptionalBasketId",
                table: "Products",
                column: "OptionalBasketId",
                principalTable: "Baskets",
                principalColumn: "BasketId");
        }
    }
}
