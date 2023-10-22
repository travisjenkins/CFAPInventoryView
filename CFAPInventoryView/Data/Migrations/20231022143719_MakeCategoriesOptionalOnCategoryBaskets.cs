using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeCategoriesOptionalOnCategoryBaskets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBaskets_Categories_CategoryId",
                table: "CategoryBaskets");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "CategoryBaskets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AgeGroups",
                columns: new[] { "AgeGroupId", "Active", "Description", "LastUpdateDateTime", "LastUpdateId", "SortOrder" },
                values: new object[,]
                {
                    { new Guid("290c1063-f288-46ef-8377-3113586b7c62"), true, "12-18", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1281), "travis@mailsac.com", 5 },
                    { new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"), true, "1-2", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1271), "travis@mailsac.com", 2 },
                    { new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"), true, "3-6", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1274), "travis@mailsac.com", 3 },
                    { new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"), true, "6-12 months", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1266), "travis@mailsac.com", 1 },
                    { new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"), true, "0-6 months", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1220), "travis@mailsac.com", 0 },
                    { new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"), true, "7-11", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1278), "travis@mailsac.com", 4 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Active", "LastUpdateDateTime", "LastUpdateId", "Name" },
                values: new object[,]
                {
                    { new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2356), "travis@mailsac.com", "Body lotion" },
                    { new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2327), "travis@mailsac.com", "Baby brush/comb" },
                    { new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2322), "travis@mailsac.com", "Leak-proof water bottle" },
                    { new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2262), "travis@mailsac.com", "Body wash or mild soap (unscented)" },
                    { new Guid("0c2c3738-e62e-4875-b786-46246636769b"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2310), "travis@mailsac.com", "Baby blanket or sleep sack" },
                    { new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2340), "travis@mailsac.com", "Satin bonnet or hair scarf" },
                    { new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2354), "travis@mailsac.com", "Twin sheet set" },
                    { new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2406), "travis@mailsac.com", "Detangling comb" },
                    { new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2317), "travis@mailsac.com", "Stuffed animal" },
                    { new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2273), "travis@mailsac.com", "Deck of cards" },
                    { new Guid("280a00c3-05b5-415e-876d-9e74d723b175"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2371), "travis@mailsac.com", "Bar soap" },
                    { new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2305), "travis@mailsac.com", "Baby lotion" },
                    { new Guid("2fb04be4-3b23-42eb-9534-20d767654667"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2286), "travis@mailsac.com", "Footed sleeper" },
                    { new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2384), "travis@mailsac.com", "Toddler toothbrush and toothpaste (fluoride-free)" },
                    { new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2416), "travis@mailsac.com", "Pacifier (for age 6+ months)" },
                    { new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2281), "travis@mailsac.com", "Wide tooth comb" },
                    { new Guid("377311f0-f434-46c1-ac21-b05b82413e41"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2389), "travis@mailsac.com", "Composition book and pens" },
                    { new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2408), "travis@mailsac.com", "Aluminum-free deodorant" },
                    { new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2315), "travis@mailsac.com", "Large throw" },
                    { new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2413), "travis@mailsac.com", "Towel and wash cloth" },
                    { new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2403), "travis@mailsac.com", "Head-to-toe body wash" },
                    { new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2295), "travis@mailsac.com", "Sketch or composition book and pencils" },
                    { new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2387), "travis@mailsac.com", "Water bottle" },
                    { new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2332), "travis@mailsac.com", "Soft throw" },
                    { new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2302), "travis@mailsac.com", "Black hair care products (sulfate-free shampoo, leave-in conditioner, SheaMoisture, Cantu or Dream Kids brands)" },
                    { new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2437), "travis@mailsac.com", "Gentle baby wash and shampoo (sulfate-free)" },
                    { new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2313), "travis@mailsac.com", "Bottles (for age 6+ months)" },
                    { new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2376), "travis@mailsac.com", "Toothbrush and toothpaste" },
                    { new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2424), "travis@mailsac.com", "Swaddle wrap" },
                    { new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2271), "travis@mailsac.com", "Package of socks (size youth small)" },
                    { new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2429), "travis@mailsac.com", "Shampoo" },
                    { new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2432), "travis@mailsac.com", "Deodorant" },
                    { new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2379), "travis@mailsac.com", "Body wash or bar soap" },
                    { new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2443), "travis@mailsac.com", "Anti-colic bottles" },
                    { new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2284), "travis@mailsac.com", "Package of socks (size woman's)" },
                    { new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2348), "travis@mailsac.com", "Nerf or stress ball" },
                    { new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2350), "travis@mailsac.com", "Shampoo/Conditioner 2-in-1" },
                    { new Guid("9441220a-15ea-40e5-b452-9d5406794978"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2368), "travis@mailsac.com", "Hair brush" },
                    { new Guid("a6760763-1106-426c-aeb9-05142aba7f57"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2257), "travis@mailsac.com", "Maxi pads or tampons" },
                    { new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2325), "travis@mailsac.com", "Board book" },
                    { new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2289), "travis@mailsac.com", "Night light" },
                    { new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2419), "travis@mailsac.com", "Pillow (travel or child sized)" },
                    { new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2445), "travis@mailsac.com", "Kids 3-in-1 soap (shampoo/conditioner/body wash)" },
                    { new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2364), "travis@mailsac.com", "Gift card for diapers (Walmart/Target/Amazon)" },
                    { new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2361), "travis@mailsac.com", "Crib sheet" },
                    { new Guid("b8409915-46fb-408b-9070-a1bc72240000"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2374), "travis@mailsac.com", "Baby bottle (for ages 12+ months)" },
                    { new Guid("badafee8-1c62-46be-98c9-e83c89f06322"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2434), "travis@mailsac.com", "Package of socks" },
                    { new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2335), "travis@mailsac.com", "Gentle body wash (unscented)" },
                    { new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2300), "travis@mailsac.com", "Diaper cream" },
                    { new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2330), "travis@mailsac.com", "Package of socks (size youth medium)" },
                    { new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2276), "travis@mailsac.com", "Deodorant (non-aerosol preferred)" },
                    { new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2308), "travis@mailsac.com", "Body lotion for sensitive skin (unscented)" },
                    { new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2268), "travis@mailsac.com", "Infant toy (0-6 months)" },
                    { new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2439), "travis@mailsac.com", "Plastic hair pick" },
                    { new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2343), "travis@mailsac.com", "Baby lotion for sensitive skin" },
                    { new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2400), "travis@mailsac.com", "Body lotion (unscented: Jergens, Vaseline with Cocoa or Shea butter)" },
                    { new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2278), "travis@mailsac.com", "Baby wipes" },
                    { new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2394), "travis@mailsac.com", "Pacifier (newborn/up to 6 months)" },
                    { new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2265), "travis@mailsac.com", "Hair brush or comb" },
                    { new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2345), "travis@mailsac.com", "Infant toy or stuffed animal (6+ months)" },
                    { new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2397), "travis@mailsac.com", "Pillow" },
                    { new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2366), "travis@mailsac.com", "Soft throw (crib/toddler sized)" },
                    { new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2392), "travis@mailsac.com", "Flashlight" },
                    { new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2422), "travis@mailsac.com", "Package of socks (size youth large)" },
                    { new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2359), "travis@mailsac.com", "Package of socks (size men's)" },
                    { new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2411), "travis@mailsac.com", "Clear/invisible deodorant (non-aerosol preferred)" },
                    { new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2292), "travis@mailsac.com", "Pillow case" },
                    { new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2427), "travis@mailsac.com", "Conditioner" },
                    { new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2297), "travis@mailsac.com", "Twin blanket" },
                    { new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2382), "travis@mailsac.com", "Package of diapers (size NB, 1, or 2)" },
                    { new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2320), "travis@mailsac.com", "Socks" },
                    { new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2337), "travis@mailsac.com", "Coloring book and washable crayons" }
                });

            migrationBuilder.InsertData(
                table: "Ethnicities",
                columns: new[] { "EthnicityId", "Active", "Description", "LastUpdateDateTime", "LastUpdateId" },
                values: new object[,]
                {
                    { new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"), true, "Black/Mixed Race", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1915), "travis@mailsac.com" },
                    { new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"), true, "White/Hispanic", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1923), "travis@mailsac.com" }
                });

            migrationBuilder.InsertData(
                table: "ExcludeCategories",
                columns: new[] { "ExcludeCategoryId", "Active", "LastUpdateDateTime", "LastUpdateId", "Name" },
                values: new object[,]
                {
                    { new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1985), "travis@mailsac.com", "Baby food or formula" },
                    { new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1995), "travis@mailsac.com", "Food or beverages" },
                    { new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1983), "travis@mailsac.com", "Items with spiral binding" },
                    { new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1980), "travis@mailsac.com", "Items requiring batteries" },
                    { new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1990), "travis@mailsac.com", "Used items" },
                    { new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1992), "travis@mailsac.com", "Sharp objects such as razors or manicure sets" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "Active", "Description", "LastUpdateDateTime", "LastUpdateId" },
                values: new object[,]
                {
                    { new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"), true, "Boy", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1953), "travis@mailsac.com" },
                    { new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"), true, "Girl", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1950), "travis@mailsac.com" },
                    { new Guid("aedb28bc-17de-436e-8348-217802299584"), true, "Neutral", new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(1956), "travis@mailsac.com" }
                });

            migrationBuilder.InsertData(
                table: "OptionalCategories",
                columns: new[] { "OptionalCategoryId", "Active", "LastUpdateDateTime", "LastUpdateId", "Name" },
                values: new object[,]
                {
                    { new Guid("010a1cc4-259b-4198-a841-92a5b784787d"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2072), "travis@mailsac.com", "Gift card (Walmart/Target)" },
                    { new Guid("02561934-85a8-4ef0-a890-82092b240fb4"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2067), "travis@mailsac.com", "Burp cloths" },
                    { new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2103), "travis@mailsac.com", "Baby brush/comb" },
                    { new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2054), "travis@mailsac.com", "Baby towel and washcloths" },
                    { new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2035), "travis@mailsac.com", "Small toy" },
                    { new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2124), "travis@mailsac.com", "Bulb aspirator" },
                    { new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2062), "travis@mailsac.com", "Themed adhesive band-aids" },
                    { new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2116), "travis@mailsac.com", "Activity book and crayons/pencils" },
                    { new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2108), "travis@mailsac.com", "Hair lotion, oil, or gel" },
                    { new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2088), "travis@mailsac.com", "Crib Sheet" },
                    { new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2032), "travis@mailsac.com", "Adhesive bandages/band-aids" },
                    { new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2069), "travis@mailsac.com", "Aquaphor healing ointment" },
                    { new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2105), "travis@mailsac.com", "Body lotion" },
                    { new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2059), "travis@mailsac.com", "Nerf ball or fidget toy" },
                    { new Guid("741217d0-a963-489a-863d-2570bb91c4e5"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2038), "travis@mailsac.com", "Hair gel" },
                    { new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2077), "travis@mailsac.com", "Kids satin night cap/bonnet" },
                    { new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2048), "travis@mailsac.com", "Wave brush or Denman brush" },
                    { new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2121), "travis@mailsac.com", "Shower cap" },
                    { new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2094), "travis@mailsac.com", "Toy (e.g. chunky puzzle, baby doll, toy car)" },
                    { new Guid("84f608e3-e046-4cfc-9525-56677374cce9"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2056), "travis@mailsac.com", "Children's book" },
                    { new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2111), "travis@mailsac.com", "Face wipes or face wash" },
                    { new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2080), "travis@mailsac.com", "Coloring or sketch book, and colored pencils" },
                    { new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2043), "travis@mailsac.com", "Small backpack" },
                    { new Guid("a2197138-9321-473e-891f-1507671d43d7"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2028), "travis@mailsac.com", "Satin bonnet or hair scarf" },
                    { new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2118), "travis@mailsac.com", "Wave cap or satin hair tie" },
                    { new Guid("a698b945-513b-4379-a13c-398f31e47bb6"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2051), "travis@mailsac.com", "Backpack or drawstring bag" },
                    { new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2064), "travis@mailsac.com", "Infant nail clippers" },
                    { new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2086), "travis@mailsac.com", "Toiletry bag" },
                    { new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2082), "travis@mailsac.com", "Hair accessories" },
                    { new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2091), "travis@mailsac.com", "Diaper cream" },
                    { new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2045), "travis@mailsac.com", "Sleep sack" },
                    { new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2113), "travis@mailsac.com", "Thermometer" },
                    { new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2040), "travis@mailsac.com", "Oil/cream moisturizer for curly hair" },
                    { new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2096), "travis@mailsac.com", "Chapstick" },
                    { new Guid("e58de252-2495-4a19-94b4-9641320fa900"), true, new DateTime(2023, 10, 22, 9, 37, 18, 967, DateTimeKind.Local).AddTicks(2075), "travis@mailsac.com", "Soft bristle brush" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBaskets_Categories_CategoryId",
                table: "CategoryBaskets",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryBaskets_Categories_CategoryId",
                table: "CategoryBaskets");

            migrationBuilder.DeleteData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"));

            migrationBuilder.DeleteData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"));

            migrationBuilder.DeleteData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"));

            migrationBuilder.DeleteData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"));

            migrationBuilder.DeleteData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"));

            migrationBuilder.DeleteData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"));

            migrationBuilder.DeleteData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"));

            migrationBuilder.DeleteData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"));

            migrationBuilder.DeleteData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"));

            migrationBuilder.DeleteData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"));

            migrationBuilder.DeleteData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"));

            migrationBuilder.DeleteData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"));

            migrationBuilder.DeleteData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"));

            migrationBuilder.DeleteData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"));

            migrationBuilder.DeleteData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "CategoryBaskets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryBaskets_Categories_CategoryId",
                table: "CategoryBaskets",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
