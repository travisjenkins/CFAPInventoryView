using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveActiveColumnFromAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "SupplyBaskets");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Supplies");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Recipients");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "OptionalCategories");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ExcludeCategories");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Ethnicities");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "CategoryBaskets");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "AgeGroups");

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4041), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4038), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4098), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4048), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4052), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4069), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4067), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4104), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4012), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4009), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4063), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4060), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4076), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4083), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4080), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4034), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4031), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4091), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4088), 1 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4027), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 11, 20, 15, 39, 33, 982, DateTimeKind.Local).AddTicks(4016), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "SupplyBaskets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Supplies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Recipients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "OptionalCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Genders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ExcludeCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Ethnicities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Donors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "CategoryBaskets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Baskets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "AgeGroups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2645), 2 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2659), 3 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2674), 4 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2620), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2617), 4 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2666), 4 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2685), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2689), 4 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2638), 5 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2696), 3 });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "Active", "LastUpdateDateTime", "PurchaseDate", "Quantity" },
                values: new object[] { true, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2624), 2 });
        }
    }
}
