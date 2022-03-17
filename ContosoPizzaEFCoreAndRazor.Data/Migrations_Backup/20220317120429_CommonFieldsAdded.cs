using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizzaEFCoreAndRazor.Data.Migrations
{
    public partial class CommonFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Pizzas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOnUTCDate",
                table: "Pizzas",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Pizzas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedOnUTCDate",
                table: "Pizzas",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "PizzaCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOnUTCDate",
                table: "PizzaCategories",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "PizzaCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedOnUTCDate",
                table: "PizzaCategories",
                type: "datetimeoffset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CreatedOnUTCDate",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "UpdatedOnUTCDate",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PizzaCategories");

            migrationBuilder.DropColumn(
                name: "CreatedOnUTCDate",
                table: "PizzaCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PizzaCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedOnUTCDate",
                table: "PizzaCategories");

        }
    }
}
