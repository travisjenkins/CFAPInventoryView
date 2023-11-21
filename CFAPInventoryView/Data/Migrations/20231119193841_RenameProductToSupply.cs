using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameProductToSupply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketTransactions_Donors_DonorId",
                table: "BasketTransactions");

            migrationBuilder.DropTable(
                name: "ProductBaskets");

            migrationBuilder.DropTable(
                name: "ProductTransactions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "DonorId",
                table: "BasketTransactions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    SupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OptionalCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcludeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<bool>(type: "bit", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(13,4)", precision: 13, scale: 4, nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.SupplyId);
                    table.ForeignKey(
                        name: "FK_Supplies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Supplies_ExcludeCategories_ExcludeCategoryId",
                        column: x => x.ExcludeCategoryId,
                        principalTable: "ExcludeCategories",
                        principalColumn: "ExcludeCategoryId");
                    table.ForeignKey(
                        name: "FK_Supplies_OptionalCategories_OptionalCategoryId",
                        column: x => x.OptionalCategoryId,
                        principalTable: "OptionalCategories",
                        principalColumn: "OptionalCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "SupplyBaskets",
                columns: table => new
                {
                    SupplyBasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyBaskets", x => x.SupplyBasketId);
                    table.ForeignKey(
                        name: "FK_SupplyBaskets_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyBaskets_Supplies_SupplyId",
                        column: x => x.SupplyId,
                        principalTable: "Supplies",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyTransactions",
                columns: table => new
                {
                    SupplyTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDistributed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DistributedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyTransactions", x => x.SupplyTransactionId);
                    table.ForeignKey(
                        name: "FK_SupplyTransactions_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "DonorId");
                    table.ForeignKey(
                        name: "FK_SupplyTransactions_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "RecipientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyTransactions_Supplies_SupplyId",
                        column: x => x.SupplyId,
                        principalTable: "Supplies",
                        principalColumn: "SupplyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_CategoryId",
                table: "Supplies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_ExcludeCategoryId",
                table: "Supplies",
                column: "ExcludeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Supplies_OptionalCategoryId",
                table: "Supplies",
                column: "OptionalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyBaskets_BasketId",
                table: "SupplyBaskets",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyBaskets_SupplyId",
                table: "SupplyBaskets",
                column: "SupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyTransactions_DonorId",
                table: "SupplyTransactions",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyTransactions_RecipientId",
                table: "SupplyTransactions",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyTransactions_SupplyId",
                table: "SupplyTransactions",
                column: "SupplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketTransactions_Donors_DonorId",
                table: "BasketTransactions",
                column: "DonorId",
                principalTable: "Donors",
                principalColumn: "DonorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketTransactions_Donors_DonorId",
                table: "BasketTransactions");

            migrationBuilder.DropTable(
                name: "SupplyBaskets");

            migrationBuilder.DropTable(
                name: "SupplyTransactions");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.AlterColumn<Guid>(
                name: "DonorId",
                table: "BasketTransactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcludeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OptionalCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Expires = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(13,4)", precision: 13, scale: 4, nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Products_ExcludeCategories_ExcludeCategoryId",
                        column: x => x.ExcludeCategoryId,
                        principalTable: "ExcludeCategories",
                        principalColumn: "ExcludeCategoryId");
                    table.ForeignKey(
                        name: "FK_Products_OptionalCategories_OptionalCategoryId",
                        column: x => x.OptionalCategoryId,
                        principalTable: "OptionalCategories",
                        principalColumn: "OptionalCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "ProductBaskets",
                columns: table => new
                {
                    ProductBasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ProductTransactions",
                columns: table => new
                {
                    ProductTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDistributed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DistributedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTransactions", x => x.ProductTransactionId);
                    table.ForeignKey(
                        name: "FK_ProductTransactions_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTransactions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTransactions_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "RecipientId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ExcludeCategoryId",
                table: "Products",
                column: "ExcludeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OptionalCategoryId",
                table: "Products",
                column: "OptionalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransactions_DonorId",
                table: "ProductTransactions",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransactions_ProductId",
                table: "ProductTransactions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTransactions_RecipientId",
                table: "ProductTransactions",
                column: "RecipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketTransactions_Donors_DonorId",
                table: "BasketTransactions",
                column: "DonorId",
                principalTable: "Donors",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
