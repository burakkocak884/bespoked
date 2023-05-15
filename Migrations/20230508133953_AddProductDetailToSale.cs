using Microsoft.EntityFrameworkCore.Migrations;

namespace profisee_project.Migrations
{
    public partial class AddProductDetailToSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductDetail",
                table: "Sales",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductDetail",
                table: "Sales");
        }
    }
}
