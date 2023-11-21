using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAgeGroupCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketTransactions_Parents_ParentId",
                table: "BasketTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTransactions_Parents_ParentId",
                table: "ProductTransactions");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "ProductTransactions",
                newName: "RecipientId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTransactions_ParentId",
                table: "ProductTransactions",
                newName: "IX_ProductTransactions_RecipientId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "BasketTransactions",
                newName: "RecipientId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketTransactions_ParentId",
                table: "BasketTransactions",
                newName: "IX_BasketTransactions_RecipientId");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDateTime",
                table: "BasketTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "BasketTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BasketNumber",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AgeGroupCategories",
                columns: table => new
                {
                    AgeGroupCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OptionalCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcludeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroupCategories", x => x.AgeGroupCategoryId);
                    table.ForeignKey(
                        name: "FK_AgeGroupCategories_AgeGroups_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "AgeGroups",
                        principalColumn: "AgeGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgeGroupCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_AgeGroupCategories_ExcludeCategories_ExcludeCategoryId",
                        column: x => x.ExcludeCategoryId,
                        principalTable: "ExcludeCategories",
                        principalColumn: "ExcludeCategoryId");
                    table.ForeignKey(
                        name: "FK_AgeGroupCategories_OptionalCategories_OptionalCategoryId",
                        column: x => x.OptionalCategoryId,
                        principalTable: "OptionalCategories",
                        principalColumn: "OptionalCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Recipients",
                columns: table => new
                {
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsFosterParent = table.Column<bool>(type: "bit", nullable: false),
                    IsAdoptiveParent = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipients", x => x.RecipientId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgeGroupCategories_AgeGroupId",
                table: "AgeGroupCategories",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AgeGroupCategories_CategoryId",
                table: "AgeGroupCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AgeGroupCategories_ExcludeCategoryId",
                table: "AgeGroupCategories",
                column: "ExcludeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AgeGroupCategories_OptionalCategoryId",
                table: "AgeGroupCategories",
                column: "OptionalCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketTransactions_Recipients_RecipientId",
                table: "BasketTransactions",
                column: "RecipientId",
                principalTable: "Recipients",
                principalColumn: "RecipientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTransactions_Recipients_RecipientId",
                table: "ProductTransactions",
                column: "RecipientId",
                principalTable: "Recipients",
                principalColumn: "RecipientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketTransactions_Recipients_RecipientId",
                table: "BasketTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTransactions_Recipients_RecipientId",
                table: "ProductTransactions");

            migrationBuilder.DropTable(
                name: "AgeGroupCategories");

            migrationBuilder.DropTable(
                name: "Recipients");

            migrationBuilder.DropColumn(
                name: "LastUpdateDateTime",
                table: "BasketTransactions");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "BasketTransactions");

            migrationBuilder.DropColumn(
                name: "BasketNumber",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "ProductTransactions",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTransactions_RecipientId",
                table: "ProductTransactions",
                newName: "IX_ProductTransactions_ParentId");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "BasketTransactions",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketTransactions_RecipientId",
                table: "BasketTransactions",
                newName: "IX_BasketTransactions_ParentId");

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdoptiveParent = table.Column<bool>(type: "bit", nullable: false),
                    IsFosterParent = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BasketTransactions_Parents_ParentId",
                table: "BasketTransactions",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "ParentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTransactions_Parents_ParentId",
                table: "ProductTransactions",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "ParentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
