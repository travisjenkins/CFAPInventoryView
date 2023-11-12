using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddShelfDurationToBasketsAndProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateDistributed",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDistributed",
                table: "Baskets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7574), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7619), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7581), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7587), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7598), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7546), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7603), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7566), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7540), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7560), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "DateDistributed", "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { null, new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7552), new DateTime(2023, 11, 11, 10, 22, 52, 60, DateTimeKind.Local).AddTicks(7549) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateDistributed",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateDistributed",
                table: "Baskets");

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4822), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4747), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4798), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4759), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4816), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4729), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 11, 9, 12, 30, 10, 926, DateTimeKind.Local).AddTicks(4719) });
        }
    }
}
