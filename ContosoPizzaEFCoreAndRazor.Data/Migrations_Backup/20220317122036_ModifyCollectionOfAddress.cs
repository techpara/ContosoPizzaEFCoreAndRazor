using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizzaEFCoreAndRazor.Data.Migrations
{
    public partial class ModifyCollectionOfAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersPizzasDeliveryAddress");

            migrationBuilder.CreateIndex(
                name: "IX_PizzasDeliveryAddress_CustomerId",
                table: "PizzasDeliveryAddress",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzasDeliveryAddress_Customers_CustomerId",
                table: "PizzasDeliveryAddress",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzasDeliveryAddress_Customers_CustomerId",
                table: "PizzasDeliveryAddress");

            migrationBuilder.DropIndex(
                name: "IX_PizzasDeliveryAddress_CustomerId",
                table: "PizzasDeliveryAddress");

            migrationBuilder.CreateTable(
                name: "CustomersPizzasDeliveryAddress",
                columns: table => new
                {
                    CustomersID = table.Column<int>(type: "int", nullable: false),
                    PizzasDeliveryAddressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersPizzasDeliveryAddress", x => new { x.CustomersID, x.PizzasDeliveryAddressID });
                    table.ForeignKey(
                        name: "FK_CustomersPizzasDeliveryAddress_Customers_CustomersID",
                        column: x => x.CustomersID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersPizzasDeliveryAddress_PizzasDeliveryAddress_PizzasDeliveryAddressID",
                        column: x => x.PizzasDeliveryAddressID,
                        principalTable: "PizzasDeliveryAddress",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersPizzasDeliveryAddress_PizzasDeliveryAddressID",
                table: "CustomersPizzasDeliveryAddress",
                column: "PizzasDeliveryAddressID");
        }
    }
}
