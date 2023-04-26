using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace profisee_project.Migrations
{
    public partial class AddSaleCommisionToSaleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TerminationDate",
                table: "SalesPeople",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "SalesPeople",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleDate",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<double>(
                name: "SaleCommission",
                table: "Sales",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "SalePrice",
                table: "Products",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuantityOnHand",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PurchasePrice",
                table: "Products",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CommissionPercentage",
                table: "Products",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Discounts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Discounts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SalesInDetails",
                columns: table => new
                {
                    salesInDetailsId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    salesInDetailsDate = table.Column<DateTime>(nullable: false),
                    salesPersonId = table.Column<int>(nullable: false),
                    salesInDetailsSalesPersonName = table.Column<string>(nullable: true),
                    salesInDetailsCustomerId = table.Column<int>(nullable: false),
                    salesInDetailsCustomerName = table.Column<string>(nullable: true),
                    salesInDetailsProductId = table.Column<int>(nullable: false),
                    salesProductName = table.Column<string>(nullable: true),
                    salePersonCommission = table.Column<double>(nullable: false),
                    salePrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInDetails", x => x.salesInDetailsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInDetails");

            migrationBuilder.DropColumn(
                name: "SaleCommission",
                table: "Sales");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TerminationDate",
                table: "SalesPeople",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "SalesPeople",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SaleDate",
                table: "Sales",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<double>(
                name: "SalePrice",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "QuantityOnHand",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "PurchasePrice",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "CommissionPercentage",
                table: "Products",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Discounts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginDate",
                table: "Discounts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
