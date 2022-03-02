using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorReportingTools.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetYears",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetYears", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    UOM = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "PRItemSelectModels",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DocNumber = table.Column<int>(nullable: false),
                    Supplier = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRItemSelectModels", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: false),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetYears");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "PRItemSelectModels");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
