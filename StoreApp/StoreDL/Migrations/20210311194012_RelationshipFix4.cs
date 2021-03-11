using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StoreDL.Migrations
{
    public partial class RelationshipFix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustIDId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProIDId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_StoreLocations_LocIDId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StoreLocations_LocationIDId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreLocations",
                table: "StoreLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "StoreLocations",
                newName: "StoreLocation");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Products_LocationIDId",
                table: "Product",
                newName: "IX_Product_LocationIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ProIDId",
                table: "Order",
                newName: "IX_Order_ProIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_LocIDId",
                table: "Order",
                newName: "IX_Order_LocIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustIDId",
                table: "Order",
                newName: "IX_Order_CustIDId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreLocation",
                table: "StoreLocation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    LocationID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cart_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_StoreLocation_LocationID",
                        column: x => x.LocationID,
                        principalTable: "StoreLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartProd",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartID = table.Column<int>(type: "integer", nullable: false),
                    ProductID = table.Column<int>(type: "integer", nullable: false),
                    ProductCount = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProd", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartProd_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProd_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_LocationID",
                table: "Cart",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_CartProd_CartID",
                table: "CartProd",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartProd_ProductID",
                table: "CartProd",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustIDId",
                table: "Order",
                column: "CustIDId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_ProIDId",
                table: "Order",
                column: "ProIDId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_StoreLocation_LocIDId",
                table: "Order",
                column: "LocIDId",
                principalTable: "StoreLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_StoreLocation_LocationIDId",
                table: "Product",
                column: "LocationIDId",
                principalTable: "StoreLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustIDId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_ProIDId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_StoreLocation_LocIDId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_StoreLocation_LocationIDId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "CartProd");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreLocation",
                table: "StoreLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "StoreLocation",
                newName: "StoreLocations");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Product_LocationIDId",
                table: "Products",
                newName: "IX_Products_LocationIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ProIDId",
                table: "Orders",
                newName: "IX_Orders_ProIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_LocIDId",
                table: "Orders",
                newName: "IX_Orders_LocIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustIDId",
                table: "Orders",
                newName: "IX_Orders_CustIDId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreLocations",
                table: "StoreLocations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustIDId",
                table: "Orders",
                column: "CustIDId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProIDId",
                table: "Orders",
                column: "ProIDId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_StoreLocations_LocIDId",
                table: "Orders",
                column: "LocIDId",
                principalTable: "StoreLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StoreLocations_LocationIDId",
                table: "Products",
                column: "LocationIDId",
                principalTable: "StoreLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
