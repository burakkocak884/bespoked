using Microsoft.EntityFrameworkCore.Migrations;

namespace profisee_project.Migrations
{
    public partial class AddproductDecriptionToDiscountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "salesInDetailsCustomerName",
                table: "SalesInDetails");

            migrationBuilder.DropColumn(
                name: "salesInDetailsSalesPersonName",
                table: "SalesInDetails");

            migrationBuilder.AddColumn<string>(
                name: "SaleCustomerName",
                table: "SalesInDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalePersonName",
                table: "SalesInDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "Discounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleCustomerName",
                table: "SalesInDetails");

            migrationBuilder.DropColumn(
                name: "SalePersonName",
                table: "SalesInDetails");

            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "Discounts");

            migrationBuilder.AddColumn<string>(
                name: "salesInDetailsCustomerName",
                table: "SalesInDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "salesInDetailsSalesPersonName",
                table: "SalesInDetails",
                type: "text",
                nullable: true);
        }
    }
}
