using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizzaEFCoreAndRazor.Data.Migrations
{
    public partial class AddedCategoryIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceCategoryId",
                table: "Pizzas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceCategoryId",
                table: "Pizzas");
        }
    }
}
