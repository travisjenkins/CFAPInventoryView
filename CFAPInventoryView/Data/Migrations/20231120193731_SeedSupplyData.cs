using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSupplyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "SupplyId", "Active", "Barcode", "CategoryId", "Description", "ExcludeCategoryId", "ExpirationDate", "Expires", "LastUpdateDateTime", "LastUpdateId", "Name", "OptionalCategoryId", "Price", "PurchaseDate", "Quantity" },
                values: new object[,]
                {
                    { new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"), true, null, new Guid("2fb04be4-3b23-42eb-9534-20d767654667"), "Koala baby girls' newborn blanket sleeper, 2 pack, take me home sleep n play pajamas (Newborn-6M)", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2649), "travis@mailsac.com", "Koala Baby Footed Sleeper (girl, 2 pk, NB-6M)", null, 10.58m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2645), 2 },
                    { new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"), true, null, new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"), "Gerber baby boy and girl unisex terry bootie wiggle-proof socks, 4-pack, newborn, 0-6 months.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2707), "travis@mailsac.com", "Baby socks (unisex, 4 pk, newborn, 0-6 months)", null, 4.00m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2703), 1 },
                    { new Guid("16f0b155-8127-4eab-99e1-65473bc89952"), true, null, new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"), "Johnson's head-to-toe gentle baby wash & shampoo, tear-free, sulfate-free & hypoallergenic wash for baby's sensitive skin & hair, 27.1 fl. oz.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2655), "travis@mailsac.com", "Gentle Baby Wash & Shampoo (tear-free, sulfate-free, hypoallergenic, 27.1 fl oz)", null, 11.95m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2652), 1 },
                    { new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"), true, null, new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"), "Desitin maximum strength baby diaper rash cream with zinc oxide, 4 oz", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2663), "travis@mailsac.com", "Desitin Diaper Cream (4 oz)", null, 7.78m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2659), 3 },
                    { new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"), true, null, new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"), "Pampers sensitive baby wipes, 8 flip-top packs, 672 wipes", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2676), "travis@mailsac.com", "Pampers Baby Wipes (sensitive, 8 pk, 672 wipes)", null, 23.47m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2674), 4 },
                    { new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"), true, null, new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), "Pampers baby-dry leakproof day & night diapers, size 2 (12-18 lb), 37 count, unisex.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2713), "travis@mailsac.com", "Pampers Baby Dry Diapers Size 2 (12-18 lb), 37 Count", null, 9.97m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2710), 1 },
                    { new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"), true, null, new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"), "NUK newborn orthodontic pacifiers, girl, 0-2 months, 2-pack.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2620), "travis@mailsac.com", "Orthodontic Pacifiers (2 pk, girl, 0-2 month)", null, 6.77m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2617), 4 },
                    { new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"), true, null, new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"), "Aveeno baby daily moisture body lotion for sensitive skin with natural colloidal oatmeal, suitable  for newborns, 18 FL oz", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2670), "travis@mailsac.com", "Aveeno Baby Daily Moisture Body Lotion (sensitive skin, 18 FL oz)", null, 11.38m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2666), 4 },
                    { new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"), true, null, new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"), "NUK smooth flow pro anti-colic baby bottle, 5 oz, blue, 3-pack", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2685), "travis@mailsac.com", "Anti-colic Baby Bottles (blue, 3 pk, 5 oz)", null, 14.97m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2681), 1 },
                    { new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"), true, null, new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), "Pampers swaddlers diapers, newborn (< 10 lb), 31 count, unisex", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2692), "travis@mailsac.com", "Pampers Diapers (NB, 31 count)", null, 14.5m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2689), 4 },
                    { new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"), true, null, new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"), "Huggies natural care refreshing baby wipes, scented, (3 pk, 168 ct)", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2641), "travis@mailsac.com", "Huggies Baby Wipes (scented, 3 pk, 168 ct)", null, 6.77m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2638), 5 },
                    { new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"), true, null, new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), "Pampers baby-dry leakproof day & night diapers, size 1 (8-14 lb), 44 count, unisex.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2612), "travis@mailsac.com", "Pampers Baby Dry Diapers Size 1 (8-14 lb), 44 Count", null, 9.97m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2605), 1 },
                    { new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"), true, null, new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"), "Amerteer 4 pcs foot finder socks & wrist rattles - newborn toys for baby boy or girl - brain development infant toys - hand and foot rattles suitable for 0-3, 3-6, 6-12 month babies.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2700), "travis@mailsac.com", "Foot Finder Socks & Wrist Rattles (NB, toys, 4 pcs)", null, 7.28m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2696), 3 },
                    { new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"), true, null, new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"), "Gilquen baby organic cotton swaddle blankets for 0-3 months infant boys girls, adjustable newborn swaddles, 3-pack wrap set, twinkle & rainbow.", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2634), "travis@mailsac.com", "Baby Cotton Swaddle Blankets (0-3 months, 3-pk)", null, 18.76m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2631), 1 },
                    { new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"), true, null, new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"), "The Very Hungry Caterpillar, Board Book, English, 0-3 yrs, Infant-Toddler", null, null, false, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2627), "travis@mailsac.com", "The Very Hungry Caterpillar (board book)", null, 8.78m, new DateTime(2023, 11, 20, 13, 37, 31, 444, DateTimeKind.Local).AddTicks(2624), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"));

            migrationBuilder.DeleteData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"));
        }
    }
}
