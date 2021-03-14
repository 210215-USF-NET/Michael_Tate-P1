using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StoreDL.Migrations
{
    public partial class RelationshipFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProd_Product_ProductID",
                table: "CartProd");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_ProIDProductID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Product_ProductID",
                table: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropIndex(
                name: "IX_OrderProducts_ProductID",
                table: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_Order_ProIDProductID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_CartProd_ProductID",
                table: "CartProd");

            migrationBuilder.DropColumn(
                name: "ProIDProductID",
                table: "Order");

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Categoryid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryCode = table.Column<string>(type: "text", nullable: true),
                    CategoryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Categoryid);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Itemid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Categoryid = table.Column<int>(type: "integer", nullable: false),
                    ItemCode = table.Column<string>(type: "text", nullable: true),
                    ItemName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ItemPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Itemid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.AddColumn<int>(
                name: "ProIDProductID",
                table: "Order",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    UnitPrice = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductID",
                table: "OrderProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProIDProductID",
                table: "Order",
                column: "ProIDProductID");

            migrationBuilder.CreateIndex(
                name: "IX_CartProd_ProductID",
                table: "CartProd",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProd_Product_ProductID",
                table: "CartProd",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_ProIDProductID",
                table: "Order",
                column: "ProIDProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Product_ProductID",
                table: "OrderProducts",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
