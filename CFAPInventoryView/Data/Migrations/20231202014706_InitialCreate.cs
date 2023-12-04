using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AgeGroups",
                columns: table => new
                {
                    AgeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroups", x => x.AgeGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SafeStockLevel = table.Column<int>(type: "int", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    DonorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.DonorId);
                });

            migrationBuilder.CreateTable(
                name: "Ethnicities",
                columns: table => new
                {
                    EthnicityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ethnicities", x => x.EthnicityId);
                });

            migrationBuilder.CreateTable(
                name: "ExcludeCategories",
                columns: table => new
                {
                    ExcludeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcludeCategories", x => x.ExcludeCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "OptionalCategories",
                columns: table => new
                {
                    OptionalCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SafeStockLevel = table.Column<int>(type: "int", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalCategories", x => x.OptionalCategoryId);
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
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipients", x => x.RecipientId);
                });

            migrationBuilder.CreateTable(
                name: "StorageLocations",
                columns: table => new
                {
                    StorageLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Shelf = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Row = table.Column<int>(type: "int", nullable: true),
                    Column = table.Column<int>(type: "int", nullable: true),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageLocations", x => x.StorageLocationId);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketNumber = table.Column<int>(type: "int", nullable: true),
                    AgeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EthnicityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateAssembled = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SafeStockLevel = table.Column<int>(type: "int", nullable: true),
                    IsShoppingListItem = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.BasketId);
                    table.ForeignKey(
                        name: "FK_Baskets_AgeGroups_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "AgeGroups",
                        principalColumn: "AgeGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Ethnicities_EthnicityId",
                        column: x => x.EthnicityId,
                        principalTable: "Ethnicities",
                        principalColumn: "EthnicityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "BasketTransactions",
                columns: table => new
                {
                    BasketTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateDistributed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DistributedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketTransactions", x => x.BasketTransactionId);
                    table.ForeignKey(
                        name: "FK_BasketTransactions_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketTransactions_Donors_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donors",
                        principalColumn: "DonorId");
                    table.ForeignKey(
                        name: "FK_BasketTransactions_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "RecipientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryBaskets",
                columns: table => new
                {
                    CategoryBasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OptionalCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ExcludeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdateId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBaskets", x => x.CategoryBasketId);
                    table.ForeignKey(
                        name: "FK_CategoryBaskets_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryBaskets_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_CategoryBaskets_ExcludeCategories_ExcludeCategoryId",
                        column: x => x.ExcludeCategoryId,
                        principalTable: "ExcludeCategories",
                        principalColumn: "ExcludeCategoryId");
                    table.ForeignKey(
                        name: "FK_CategoryBaskets_OptionalCategories_OptionalCategoryId",
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

            migrationBuilder.InsertData(
                table: "AgeGroups",
                columns: new[] { "AgeGroupId", "Description", "LastUpdateDateTime", "LastUpdateId", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("290c1063-f288-46ef-8377-3113586b7c62"), "12-18", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(6925), "travis@mailsac.com", 5 },
                    { new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"), "1-2", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(6914), "travis@mailsac.com", 2 },
                    { new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"), "3-6", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(6920), "travis@mailsac.com", 3 },
                    { new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"), "6-12 months", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(6911), "travis@mailsac.com", 1 },
                    { new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"), "0-6 months", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(6865), "travis@mailsac.com", 0 },
                    { new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"), "7-11", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(6923), "travis@mailsac.com", 4 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "LastUpdateDateTime", "LastUpdateId", "Name", "Quantity", "SafeStockLevel" },
                values: new object[,]
                {
                    { new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7520), "travis@mailsac.com", "Body lotion", 5, 3 },
                    { new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7489), "travis@mailsac.com", "Baby brush/comb", 5, 3 },
                    { new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7484), "travis@mailsac.com", "Leak-proof water bottle", 5, 3 },
                    { new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7379), "travis@mailsac.com", "Body wash or mild soap (unscented)", 5, 3 },
                    { new Guid("0c2c3738-e62e-4875-b786-46246636769b"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7470), "travis@mailsac.com", "Baby blanket or sleep sack", 5, 3 },
                    { new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7503), "travis@mailsac.com", "Satin bonnet or hair scarf", 5, 3 },
                    { new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7517), "travis@mailsac.com", "Twin sheet set", 5, 3 },
                    { new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7573), "travis@mailsac.com", "Detangling comb", 5, 3 },
                    { new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7479), "travis@mailsac.com", "Stuffed animal", 5, 3 },
                    { new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7391), "travis@mailsac.com", "Deck of cards", 5, 3 },
                    { new Guid("280a00c3-05b5-415e-876d-9e74d723b175"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7536), "travis@mailsac.com", "Bar soap", 5, 3 },
                    { new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7464), "travis@mailsac.com", "Baby lotion", 5, 3 },
                    { new Guid("2fb04be4-3b23-42eb-9534-20d767654667"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7445), "travis@mailsac.com", "Footed sleeper", 5, 3 },
                    { new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7550), "travis@mailsac.com", "Toddler toothbrush and toothpaste (fluoride-free)", 5, 3 },
                    { new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7585), "travis@mailsac.com", "Pacifier (for age 6+ months)", 5, 3 },
                    { new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7439), "travis@mailsac.com", "Wide tooth comb", 5, 3 },
                    { new Guid("377311f0-f434-46c1-ac21-b05b82413e41"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7556), "travis@mailsac.com", "Composition book and pens", 5, 3 },
                    { new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7576), "travis@mailsac.com", "Aluminum-free deodorant", 3, 3 },
                    { new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7476), "travis@mailsac.com", "Large throw", 5, 3 },
                    { new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7582), "travis@mailsac.com", "Towel and wash cloth", 5, 3 },
                    { new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7569), "travis@mailsac.com", "Head-to-toe body wash", 2, 3 },
                    { new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7453), "travis@mailsac.com", "Sketch or composition book and pencils", 5, 3 },
                    { new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7553), "travis@mailsac.com", "Water bottle", 1, 3 },
                    { new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7495), "travis@mailsac.com", "Soft throw", 5, 3 },
                    { new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7461), "travis@mailsac.com", "Black hair care products (sulfate-free shampoo, leave-in conditioner, SheaMoisture, Cantu or Dream Kids brands)", 5, 3 },
                    { new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7606), "travis@mailsac.com", "Gentle baby wash and shampoo (sulfate-free)", 5, 3 },
                    { new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7473), "travis@mailsac.com", "Bottles (for age 6+ months)", 5, 3 },
                    { new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7541), "travis@mailsac.com", "Toothbrush and toothpaste", 2, 3 },
                    { new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7593), "travis@mailsac.com", "Swaddle wrap", 5, 3 },
                    { new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7388), "travis@mailsac.com", "Package of socks (size youth small)", 5, 3 },
                    { new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7598), "travis@mailsac.com", "Shampoo", 1, 3 },
                    { new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7601), "travis@mailsac.com", "Deodorant", 5, 3 },
                    { new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7545), "travis@mailsac.com", "Body wash or bar soap", 5, 3 },
                    { new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7611), "travis@mailsac.com", "Anti-colic bottles", 5, 3 },
                    { new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7442), "travis@mailsac.com", "Package of socks (size woman's)", 5, 3 },
                    { new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7512), "travis@mailsac.com", "Nerf or stress ball", 5, 3 },
                    { new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7514), "travis@mailsac.com", "Shampoo/Conditioner 2-in-1", 5, 3 },
                    { new Guid("9441220a-15ea-40e5-b452-9d5406794978"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7533), "travis@mailsac.com", "Hair brush", 5, 3 },
                    { new Guid("a6760763-1106-426c-aeb9-05142aba7f57"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7376), "travis@mailsac.com", "Maxi pads or tampons", 5, 3 },
                    { new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7487), "travis@mailsac.com", "Board book", 5, 3 },
                    { new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7448), "travis@mailsac.com", "Night light", 5, 3 },
                    { new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7587), "travis@mailsac.com", "Pillow (travel or child sized)", 2, 3 },
                    { new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7614), "travis@mailsac.com", "Kids 3-in-1 soap (shampoo/conditioner/body wash)", 2, 3 },
                    { new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7528), "travis@mailsac.com", "Gift card for diapers (Walmart/Target/Amazon)", 5, 3 },
                    { new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7525), "travis@mailsac.com", "Crib sheet", 5, 3 },
                    { new Guid("b8409915-46fb-408b-9070-a1bc72240000"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7539), "travis@mailsac.com", "Baby bottle (for ages 12+ months)", 5, 3 },
                    { new Guid("badafee8-1c62-46be-98c9-e83c89f06322"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7603), "travis@mailsac.com", "Package of socks", 5, 3 },
                    { new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7497), "travis@mailsac.com", "Gentle body wash (unscented)", 5, 3 },
                    { new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7459), "travis@mailsac.com", "Diaper cream", 5, 3 },
                    { new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7492), "travis@mailsac.com", "Package of socks (size youth medium)", 5, 3 },
                    { new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7393), "travis@mailsac.com", "Deodorant (non-aerosol preferred)", 5, 3 },
                    { new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7468), "travis@mailsac.com", "Body lotion for sensitive skin (unscented)", 5, 3 },
                    { new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7385), "travis@mailsac.com", "Infant toy (0-6 months)", 5, 3 },
                    { new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7609), "travis@mailsac.com", "Plastic hair pick", 5, 3 },
                    { new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7506), "travis@mailsac.com", "Baby lotion for sensitive skin", 5, 3 },
                    { new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7567), "travis@mailsac.com", "Body lotion (unscented: Jergens, Vaseline with Cocoa or Shea butter)", 5, 3 },
                    { new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7436), "travis@mailsac.com", "Baby wipes", 5, 3 },
                    { new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7562), "travis@mailsac.com", "Pacifier (newborn/up to 6 months)", 5, 3 },
                    { new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7382), "travis@mailsac.com", "Hair brush or comb", 5, 3 },
                    { new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7509), "travis@mailsac.com", "Infant toy or stuffed animal (6+ months)", 5, 3 },
                    { new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7564), "travis@mailsac.com", "Pillow", 2, 3 },
                    { new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7531), "travis@mailsac.com", "Soft throw (crib/toddler sized)", 5, 3 },
                    { new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7559), "travis@mailsac.com", "Flashlight", 5, 3 },
                    { new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7590), "travis@mailsac.com", "Package of socks (size youth large)", 5, 3 },
                    { new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7523), "travis@mailsac.com", "Package of socks (size men's)", 5, 3 },
                    { new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7579), "travis@mailsac.com", "Clear/invisible deodorant (non-aerosol preferred)", 5, 3 },
                    { new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7450), "travis@mailsac.com", "Pillow case", 5, 3 },
                    { new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7595), "travis@mailsac.com", "Conditioner", 5, 3 },
                    { new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7456), "travis@mailsac.com", "Twin blanket", 5, 3 },
                    { new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7548), "travis@mailsac.com", "Package of diapers (size NB, 1, or 2)", 3, 3 },
                    { new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7481), "travis@mailsac.com", "Socks", 5, 3 },
                    { new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7500), "travis@mailsac.com", "Coloring book and washable crayons", 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ethnicities",
                columns: new[] { "EthnicityId", "Description", "LastUpdateDateTime", "LastUpdateId" },
                values: new object[,]
                {
                    { new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"), "Black/Mixed Race", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7103), "travis@mailsac.com" },
                    { new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"), "White/Hispanic", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7107), "travis@mailsac.com" }
                });

            migrationBuilder.InsertData(
                table: "ExcludeCategories",
                columns: new[] { "ExcludeCategoryId", "LastUpdateDateTime", "LastUpdateId", "Name", "Quantity" },
                values: new object[,]
                {
                    { new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7214), "travis@mailsac.com", "Baby food or formula", 0 },
                    { new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7222), "travis@mailsac.com", "Food or beverages", 0 },
                    { new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7211), "travis@mailsac.com", "Items with spiral binding", 0 },
                    { new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7207), "travis@mailsac.com", "Items requiring batteries", 0 },
                    { new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7217), "travis@mailsac.com", "Used items", 0 },
                    { new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7219), "travis@mailsac.com", "Sharp objects such as razors or manicure sets", 0 }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "Description", "LastUpdateDateTime", "LastUpdateId" },
                values: new object[,]
                {
                    { new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"), "Boy", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7179), "travis@mailsac.com" },
                    { new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"), "Girl", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7174), "travis@mailsac.com" },
                    { new Guid("aedb28bc-17de-436e-8348-217802299584"), "Neutral", new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7182), "travis@mailsac.com" }
                });

            migrationBuilder.InsertData(
                table: "OptionalCategories",
                columns: new[] { "OptionalCategoryId", "LastUpdateDateTime", "LastUpdateId", "Name", "Quantity", "SafeStockLevel" },
                values: new object[,]
                {
                    { new Guid("010a1cc4-259b-4198-a841-92a5b784787d"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7291), "travis@mailsac.com", "Gift card (Walmart/Target)", 5, 3 },
                    { new Guid("02561934-85a8-4ef0-a890-82092b240fb4"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7286), "travis@mailsac.com", "Burp cloths", 5, 3 },
                    { new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7321), "travis@mailsac.com", "Baby brush/comb", 5, 3 },
                    { new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7272), "travis@mailsac.com", "Baby towel and washcloths", 5, 3 },
                    { new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7251), "travis@mailsac.com", "Small toy", 5, 5 },
                    { new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7343), "travis@mailsac.com", "Bulb aspirator", 5, 3 },
                    { new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7280), "travis@mailsac.com", "Themed adhesive band-aids", 5, 10 },
                    { new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7335), "travis@mailsac.com", "Activity book and crayons/pencils", 5, 3 },
                    { new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7327), "travis@mailsac.com", "Hair lotion, oil, or gel", 5, 3 },
                    { new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7310), "travis@mailsac.com", "Crib Sheet", 5, 3 },
                    { new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7248), "travis@mailsac.com", "Adhesive bandages/band-aids", 5, 10 },
                    { new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7288), "travis@mailsac.com", "Aquaphor healing ointment", 5, 3 },
                    { new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7324), "travis@mailsac.com", "Body lotion", 5, 3 },
                    { new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7277), "travis@mailsac.com", "Nerf ball or fidget toy", 5, 3 },
                    { new Guid("741217d0-a963-489a-863d-2570bb91c4e5"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7254), "travis@mailsac.com", "Hair gel", 3, 4 },
                    { new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7299), "travis@mailsac.com", "Kids satin night cap/bonnet", 5, 3 },
                    { new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7266), "travis@mailsac.com", "Wave brush or Denman brush", 5, 3 },
                    { new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7340), "travis@mailsac.com", "Shower cap", 5, 3 },
                    { new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7316), "travis@mailsac.com", "Toy (e.g. chunky puzzle, baby doll, toy car)", 5, 3 },
                    { new Guid("84f608e3-e046-4cfc-9525-56677374cce9"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7274), "travis@mailsac.com", "Children's book", 5, 3 },
                    { new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7329), "travis@mailsac.com", "Face wipes or face wash", 5, 3 },
                    { new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7302), "travis@mailsac.com", "Coloring or sketch book, and colored pencils", 5, 3 },
                    { new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7259), "travis@mailsac.com", "Small backpack", 3, 3 },
                    { new Guid("a2197138-9321-473e-891f-1507671d43d7"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7244), "travis@mailsac.com", "Satin bonnet or hair scarf", 3, 4 },
                    { new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7338), "travis@mailsac.com", "Wave cap or satin hair tie", 5, 3 },
                    { new Guid("a698b945-513b-4379-a13c-398f31e47bb6"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7269), "travis@mailsac.com", "Backpack or drawstring bag", 5, 3 },
                    { new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7283), "travis@mailsac.com", "Infant nail clippers", 5, 10 },
                    { new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7307), "travis@mailsac.com", "Toiletry bag", 5, 3 },
                    { new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7305), "travis@mailsac.com", "Hair accessories", 5, 3 },
                    { new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7313), "travis@mailsac.com", "Diaper cream", 5, 3 },
                    { new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7263), "travis@mailsac.com", "Sleep sack", 4, 2 },
                    { new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7332), "travis@mailsac.com", "Thermometer", 5, 3 },
                    { new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7257), "travis@mailsac.com", "Oil/cream moisturizer for curly hair", 4, 3 },
                    { new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7318), "travis@mailsac.com", "Chapstick", 5, 3 },
                    { new Guid("e58de252-2495-4a19-94b4-9641320fa900"), new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7295), "travis@mailsac.com", "Soft bristle brush", 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "SupplyId", "Barcode", "CategoryId", "Description", "ExcludeCategoryId", "ExpirationDate", "Expires", "LastUpdateDateTime", "LastUpdateId", "Name", "OptionalCategoryId", "Price", "PurchaseDate", "Quantity" },
                values: new object[,]
                {
                    { new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"), null, new Guid("2fb04be4-3b23-42eb-9534-20d767654667"), "Koala baby girls' newborn blanket sleeper, 2 pack, take me home sleep n play pajamas (Newborn-6M)", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7739), "travis@mailsac.com", "Koala Baby Footed Sleeper (girl, 2 pk, NB-6M)", null, 10.58m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7736), 1 },
                    { new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"), null, new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"), "Gerber baby boy and girl unisex terry bootie wiggle-proof socks, 4-pack, newborn, 0-6 months.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7795), "travis@mailsac.com", "Baby socks (unisex, 4 pk, newborn, 0-6 months)", null, 4.00m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7792), 1 },
                    { new Guid("16f0b155-8127-4eab-99e1-65473bc89952"), null, new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"), "Johnson's head-to-toe gentle baby wash & shampoo, tear-free, sulfate-free & hypoallergenic wash for baby's sensitive skin & hair, 27.1 fl. oz.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7746), "travis@mailsac.com", "Gentle Baby Wash & Shampoo (tear-free, sulfate-free, hypoallergenic, 27.1 fl oz)", null, 11.95m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7742), 1 },
                    { new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"), null, new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"), "Desitin maximum strength baby diaper rash cream with zinc oxide, 4 oz", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7752), "travis@mailsac.com", "Desitin Diaper Cream (4 oz)", null, 7.78m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7749), 1 },
                    { new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"), null, new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"), "Pampers sensitive baby wipes, 8 flip-top packs, 672 wipes", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7765), "travis@mailsac.com", "Pampers Baby Wipes (sensitive, 8 pk, 672 wipes)", null, 23.47m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7763), 1 },
                    { new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"), null, new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), "Pampers baby-dry leakproof day & night diapers, size 2 (12-18 lb), 37 count, unisex.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7802), "travis@mailsac.com", "Pampers Baby Dry Diapers Size 2 (12-18 lb), 37 Count", null, 9.97m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7799), 1 },
                    { new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"), null, new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"), "NUK newborn orthodontic pacifiers, girl, 0-2 months, 2-pack.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7711), "travis@mailsac.com", "Orthodontic Pacifiers (2 pk, girl, 0-2 month)", null, 6.77m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7708), 1 },
                    { new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"), null, new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"), "Aveeno baby daily moisture body lotion for sensitive skin with natural colloidal oatmeal, suitable  for newborns, 18 FL oz", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7759), "travis@mailsac.com", "Aveeno Baby Daily Moisture Body Lotion (sensitive skin, 18 FL oz)", null, 11.38m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7756), 1 },
                    { new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"), null, new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"), "NUK smooth flow pro anti-colic baby bottle, 5 oz, blue, 3-pack", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7773), "travis@mailsac.com", "Anti-colic Baby Bottles (blue, 3 pk, 5 oz)", null, 14.97m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7769), 1 },
                    { new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"), null, new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), "Pampers swaddlers diapers, newborn (< 10 lb), 31 count, unisex", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7779), "travis@mailsac.com", "Pampers Diapers (NB, 31 count)", null, 14.5m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7777), 1 },
                    { new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"), null, new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"), "Huggies natural care refreshing baby wipes, scented, (3 pk, 168 ct)", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7732), "travis@mailsac.com", "Huggies Baby Wipes (scented, 3 pk, 168 ct)", null, 6.77m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7729), 1 },
                    { new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"), null, new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), "Pampers baby-dry leakproof day & night diapers, size 1 (8-14 lb), 44 count, unisex.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7704), "travis@mailsac.com", "Pampers Baby Dry Diapers Size 1 (8-14 lb), 44 Count", null, 9.97m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7697), 1 },
                    { new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"), null, new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"), "Amerteer 4 pcs foot finder socks & wrist rattles - newborn toys for baby boy or girl - brain development infant toys - hand and foot rattles suitable for 0-3, 3-6, 6-12 month babies.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7787), "travis@mailsac.com", "Foot Finder Socks & Wrist Rattles (NB, toys, 4 pcs)", null, 7.28m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7783), 1 },
                    { new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"), null, new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"), "Gilquen baby organic cotton swaddle blankets for 0-3 months infant boys girls, adjustable newborn swaddles, 3-pack wrap set, twinkle & rainbow.", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7725), "travis@mailsac.com", "Baby Cotton Swaddle Blankets (0-3 months, 3-pk)", null, 18.76m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7722), 1 },
                    { new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"), null, new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"), "The Very Hungry Caterpillar, Board Book, English, 0-3 yrs, Infant-Toddler", null, null, false, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7718), "travis@mailsac.com", "The Very Hungry Caterpillar (board book)", null, 8.78m, new DateTime(2023, 12, 1, 19, 47, 5, 879, DateTimeKind.Local).AddTicks(7715), 1 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_AgeGroupId",
                table: "Baskets",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_EthnicityId",
                table: "Baskets",
                column: "EthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_GenderId",
                table: "Baskets",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketTransactions_BasketId",
                table: "BasketTransactions",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketTransactions_DonorId",
                table: "BasketTransactions",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketTransactions_RecipientId",
                table: "BasketTransactions",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_BasketId",
                table: "CategoryBaskets",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_CategoryId",
                table: "CategoryBaskets",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_ExcludeCategoryId",
                table: "CategoryBaskets",
                column: "ExcludeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBaskets_OptionalCategoryId",
                table: "CategoryBaskets",
                column: "OptionalCategoryId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeGroupCategories");

            migrationBuilder.DropTable(
                name: "BasketTransactions");

            migrationBuilder.DropTable(
                name: "CategoryBaskets");

            migrationBuilder.DropTable(
                name: "StorageLocations");

            migrationBuilder.DropTable(
                name: "SupplyBaskets");

            migrationBuilder.DropTable(
                name: "SupplyTransactions");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Recipients");

            migrationBuilder.DropTable(
                name: "Supplies");

            migrationBuilder.DropTable(
                name: "AgeGroups");

            migrationBuilder.DropTable(
                name: "Ethnicities");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ExcludeCategories");

            migrationBuilder.DropTable(
                name: "OptionalCategories");

            migrationBuilder.DropColumn(
                name: "Address1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegisteredOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "AspNetUsers");
        }
    }
}
