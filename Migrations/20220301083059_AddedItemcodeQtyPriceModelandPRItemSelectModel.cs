using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorReportingTools.Migrations
{
    public partial class AddedItemcodeQtyPriceModelandPRItemSelectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PRItemSelectModels");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "PRItemSelectModels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "PRItemSelectModels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "PRItemSelectModels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine4",
                table: "PRItemSelectModels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Item",
                table: "PRItemSelectModels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PRItemSelectModels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ItemcodeQtyPriceModels",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemcodeQtyPriceModels", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemcodeQtyPriceModels");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "PRItemSelectModels");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "PRItemSelectModels");

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "PRItemSelectModels");

            migrationBuilder.DropColumn(
                name: "AddressLine4",
                table: "PRItemSelectModels");

            migrationBuilder.DropColumn(
                name: "Item",
                table: "PRItemSelectModels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PRItemSelectModels");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PRItemSelectModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
