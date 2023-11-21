using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFAPInventoryView.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddActiveLastUpdateIdAndDateTimeToDonorsAndParents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Parents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDateTime",
                table: "Parents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Donors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDateTime",
                table: "Donors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateId",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "LastUpdateDateTime",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "LastUpdateDateTime",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "LastUpdateId",
                table: "Donors");
        }
    }
}
