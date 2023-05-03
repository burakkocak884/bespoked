using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace profisee_project.Migrations
{
    public partial class AddSalePersonAndCustomerToSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "salesInDetailsDate",
                table: "SalesInDetails",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<string>(
                name: "SaleCustomerName",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalePersonName",
                table: "Sales",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommisionReports",
                columns: table => new
                {
                    comissionReportId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    salespersonname = table.Column<string>(nullable: true),
                    SalesPersonPhoneNumber = table.Column<string>(nullable: true),
                    quarterlycommission = table.Column<double>(nullable: false),
                    quarterDescription = table.Column<string>(nullable: true),
                    NumberOfSales = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommisionReports", x => x.comissionReportId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommisionReports");

            migrationBuilder.DropColumn(
                name: "SaleCustomerName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SalePersonName",
                table: "Sales");

            migrationBuilder.AlterColumn<DateTime>(
                name: "salesInDetailsDate",
                table: "SalesInDetails",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
