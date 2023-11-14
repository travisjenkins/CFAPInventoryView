using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIfParentIsFosterOrAdoptive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdoptiveParent",
                table: "Parent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFosterParent",
                table: "Parent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7086), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7142), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7093), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7148), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7058), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7106), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7120), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7126), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7046), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7136), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7072), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7065), new DateTime(2023, 11, 13, 12, 25, 35, 653, DateTimeKind.Local).AddTicks(7062) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdoptiveParent",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "IsFosterParent",
                table: "Parent");

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("290c1063-f288-46ef-8377-3113586b7c62"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("39d9931f-e6a6-449d-aa69-d7aad053e298"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("75200021-5b2f-4079-96be-7e38a1ad1adb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("e7581e8f-e2ac-4550-aac7-d4ff7fe778e1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("ed2da6d8-a312-489d-b7d0-253d75c6c820"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "AgeGroups",
                keyColumn: "AgeGroupId",
                keyValue: new Guid("f574f025-f5c3-4611-96d7-ad679e6b1467"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("027ea222-f944-41b8-8dea-7f922c43c8a3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("039c1f4e-7a2c-4b4a-9aee-53f4957a7b01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("067ac574-c50a-4f2c-b8d7-52877ea217d4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("07ebd8cf-f55b-47a9-bf52-072a1f89e16f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0c2c3738-e62e-4875-b786-46246636769b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0dda4f68-adc2-4136-b8cd-5efff84ae6ce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("17d0900f-c48d-4059-8caa-7697af8efbe0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("18b0b2a3-3163-463d-b8a1-c6314aee6766"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1aa58da2-d195-4ffc-9bb7-51920ea8fde4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("1db3a928-231f-48f2-acaf-16747cfdd4ad"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("280a00c3-05b5-415e-876d-9e74d723b175"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2be28886-7e2e-41c6-886b-3a30ef4cf378"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fb04be4-3b23-42eb-9534-20d767654667"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2fcbd4e6-479f-4c55-858e-ac69aeab01b1"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("305f2292-4230-403c-8e78-ccab2b7faf66"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3186795c-ec04-4bf2-b31d-1d0caf80cb24"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("377311f0-f434-46c1-ac21-b05b82413e41"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3c7975d7-283f-4876-bf2c-c6c4a885d6ca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("44726539-9806-46a9-99b6-4bdb7dfd7363"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("483c2687-b6cc-4132-a386-c8351a3ce03c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4a7c2d02-c39a-48c9-9e81-c6198f87a2ed"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4b223b2e-f4fe-4640-9dd0-2aa7f0263dee"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("4edacb15-8c72-4361-911e-add9c1ef26af"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("51d50f02-b916-4824-a9f0-59008d6bb8f8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618dbc0d-a9b0-4be2-9a87-3442e309f746"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("61da1441-6b0e-4d1a-88a2-ec632d01906d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("620b66ed-e341-4a14-b89c-48fd30632d5d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65d5ca12-de4b-4f4b-b57b-a28f14f4fd42"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("65ea10fe-b443-4233-a48a-d8bd7896d244"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6eb9d0bb-c37f-4ba0-a911-0f76be2fb119"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("70feab08-d33a-409b-af35-dee1c37fe46b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("726ccf14-58b8-4878-b3ea-e58504bb71b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7665e398-50b4-4e36-a8fc-a6368f192946"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7ac8c99f-aaca-4883-ab1f-fb94fbaa9fca"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7fab58da-a415-40d1-8fd7-1dc1fcdbb729"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("802350c7-e12b-4ac2-a57e-6f394d67cc0c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("86921bfc-74e7-47f8-a3eb-72928e5e2a8c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9441220a-15ea-40e5-b452-9d5406794978"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a6760763-1106-426c-aeb9-05142aba7f57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a809dfba-5e21-491e-ab19-5374a141fe88"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("a8aae37c-e94b-4099-96a7-23bc27b9bdce"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b0a6921d-55fd-40ff-b7e4-cef32e093c21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b2488733-9e8d-47a5-b1a4-fe6ffe3da0d5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b396c541-ffc3-4231-86fb-8cfed6eae3a4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b43b17b3-b34d-4efb-a07e-8c00e6e7aab0"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("b8409915-46fb-408b-9070-a1bc72240000"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("badafee8-1c62-46be-98c9-e83c89f06322"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bb8f1f6e-57d7-4537-8b66-59aa04728add"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf225467-4b08-4da0-a1e5-2ef0ff6e2f96"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("bf4a75e5-825c-4fed-a4c4-57ea77f21473"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c37a088f-7112-424b-a187-1b295d2b3cbc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c4878700-862c-4748-a0f5-43b1ef4d0655"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c50504d5-a7ec-4aab-acae-0ed0a39d1578"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c915d086-e1cb-4a9c-a8f4-ef7d6331eb1d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("cdfc6b7f-31fb-4bd1-a246-6b8efc241dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d0083f7a-cf78-4223-8328-c5fcac9a8639"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d07d2c78-acbb-4d73-806d-1b5c67914554"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d11d87e7-126c-4a3c-8125-b6a656d64fcc"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d24a4561-f64b-4371-943c-0d4ac6e9be57"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d2d503a2-f55c-4f44-87e1-6c4464a5f16b"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d5f318f9-d031-416f-b61d-bff6eb3ddc21"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d69feee3-f0ae-456b-b000-9b8fb301dad2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("d8ac84a3-afff-485b-8949-b0c2c6272e85"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dce8a93b-66c4-4d10-a5c5-d72ae5add07f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dd47744e-3eb3-4cdc-a697-8a707bf8ab3c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("dfa15e75-56e9-4fd9-8abe-c7ce9c28a6d8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e0f5c01d-a72a-4e59-abba-24c7309e9d37"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e90c0353-dd59-4a87-9897-da2ba2070999"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("e9800b98-0e56-4260-ae26-2e2939230c01"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("ec00957f-aa3b-4c34-8554-aa2aaf10335f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("f27211ee-28cb-42a1-b487-51aa7456ccd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("fceef0f8-c4d3-4ba3-ba6b-5c3288d794b2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("0040e5c2-0d7f-4db8-a7e8-28c5efa6cf4f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Ethnicities",
                keyColumn: "EthnicityId",
                keyValue: new Guid("b5c934b6-c7e0-493f-8726-c3fd5ff2141f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("5cef1269-2589-4a6f-a150-5ed172d16a1a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("695b89cf-9c4d-4ad4-af45-e9d0422d41ef"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("9fe23dd1-3946-4456-8c5d-5808458eafd3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("bb0c0779-5261-4d14-8a96-12ff3e0d8dff"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("ebfef241-8abb-4b02-89a1-9a5d19893c11"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "ExcludeCategories",
                keyColumn: "ExcludeCategoryId",
                keyValue: new Guid("f77cbfaa-11cd-44e7-abb7-e3e0f030e212"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("629f93b9-15d1-4aab-a0a6-9ab22e6ac159"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("78cc56f2-717b-45cb-b025-09c0cca68f27"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: new Guid("aedb28bc-17de-436e-8348-217802299584"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("010a1cc4-259b-4198-a841-92a5b784787d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("02561934-85a8-4ef0-a890-82092b240fb4"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("15423c38-cbd8-4b49-bbb8-ba74804189e2"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("18db181a-39c7-4ff6-aa5f-504c9fd42495"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("1d6ad3d8-d44c-4982-a912-24454286fead"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("2d024344-dd8e-49bb-a069-ef59a2625d34"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("337e6455-6bcb-4241-a3b8-58c7a6f2200c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("34f51fd8-5e64-46df-beb9-d3caad869f22"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("355cfdc5-4ef5-4ef1-b881-c5cede5d6270"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("373ffcaf-8c96-4dc5-b7fd-a5247e1a62cd"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("4a0e060b-e159-49af-9ecd-1790f8d7a0b3"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("678425c7-3b3e-4f23-b073-8268f4ce273a"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c1f919d-8b90-43f0-9bf4-c4d69ed6537d"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("6c31ed18-3271-4434-af24-5697a341ed6e"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("741217d0-a963-489a-863d-2570bb91c4e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("743c8970-b53d-496c-9ee9-96c0be328f55"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7c65fb61-080a-4ff7-9d27-37904280e926"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("7e95c73e-2251-4680-b71a-ed86f3951efb"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("811f6a9a-0845-4116-a3f6-b1c0cd3a5912"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("84f608e3-e046-4cfc-9525-56677374cce9"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("85bcb30f-f902-485d-a82f-c9544d435df5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("86eecf1b-d8bb-4526-a9c1-9b3d511ec50f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("989a01f0-8f0e-468c-ab51-2c6501348672"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a2197138-9321-473e-891f-1507671d43d7"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a31f289e-a7b7-4b51-ae96-d742a3dbf460"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("a698b945-513b-4379-a13c-398f31e47bb6"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("aa154101-bce0-4973-b9aa-7291f06b571c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b88a0b8b-0460-4fa6-b5cf-9f94261fd823"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("b9a71948-1ac2-4e86-bda7-9dde074be330"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("bf55fcfc-ce99-436c-8127-aa6898af039f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d0193bc7-1a7f-48a2-bee5-2d5402a2c66f"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d03154ff-da79-4b02-b231-cd0d8494c2e5"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("d9caf847-0312-4808-979b-25b5bffc4fb8"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("de8bbea2-fffe-4073-9acc-b91c45a05a2c"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "OptionalCategories",
                keyColumn: "OptionalCategoryId",
                keyValue: new Guid("e58de252-2495-4a19-94b4-9641320fa900"),
                column: "LastUpdateDateTime",
                value: new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("06f703f4-dfbf-4fd0-b0a6-5c75bc8fe17a"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("07979a90-bab9-47cf-befd-f0b16999ee00"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16f0b155-8127-4eab-99e1-65473bc89952"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1ec27cd4-58a3-49d3-8395-8d83536a4305"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("331d83d3-04e4-41ca-9527-8ebcc1316090"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8013), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3a13f50b-b57f-44ae-ba14-f65e4e27cd54"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3e2d5eee-ebfc-4a86-9c9c-18049eccaeed"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5aa553c8-f564-4755-9d2a-8e5a66f884d1"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d59f00f-d7d8-48e3-ab36-9d96de8b09d0"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7604aea7-96b0-4096-8bbb-bbef00fdc221"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9e0ef560-c184-46bb-9f57-45e295bf57b2"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4913d87-9305-4a4f-981f-09b0a226f753"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a864cd79-d226-441d-9f23-db77c2b9bd85"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d5b42185-f6f5-4d33-9c7d-392eadb5b1e6"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd6d4bec-20f1-4149-8f14-2141bad77e9b"),
                columns: new[] { "LastUpdateDateTime", "PurchaseDate" },
                values: new object[] { new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 11, 13, 12, 21, 20, 712, DateTimeKind.Local).AddTicks(7965) });
        }
    }
}
