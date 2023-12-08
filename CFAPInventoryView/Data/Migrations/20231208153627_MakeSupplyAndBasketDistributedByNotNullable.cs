using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeSupplyAndBasketDistributedByNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DistributedBy",
                table: "SupplyTransactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DistributedBy",
                table: "BasketTransactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7847), new DateTime(2023, 12, 8, 9, 36, 26, 824, DateTimeKind.Local).AddTicks(7844) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DistributedBy",
                table: "SupplyTransactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DistributedBy",
                table: "BasketTransactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3969), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3907), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3990), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4011), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3962), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3897), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4019), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3955), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Supplies",
                keyColumn: "SupplyId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3914), new DateTime(2023, 12, 1, 21, 50, 54, 68, DateTimeKind.Local).AddTicks(3911) });
        }
    }
}
