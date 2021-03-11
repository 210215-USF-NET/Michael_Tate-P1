using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace StoreDL.Migrations
{
    public partial class RelationshipFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Orders_Id",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreLocations_Orders_Id",
                table: "StoreLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreLocations_Products_Id",
                table: "StoreLocations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StoreLocations",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "LocationIDId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustIDId",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocIDId",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProIDId",
                table: "Orders",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Products_LocationIDId",
                table: "Products",
                column: "LocationIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustIDId",
                table: "Orders",
                column: "CustIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LocIDId",
                table: "Orders",
                column: "LocIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProIDId",
                table: "Orders",
                column: "ProIDId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Products_LocationIDId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustIDId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LocIDId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProIDId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LocationIDId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CustIDId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LocIDId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProIDId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StoreLocations",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Orders_Id",
                table: "Customers",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_Id",
                table: "Products",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreLocations_Orders_Id",
                table: "StoreLocations",
                column: "Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreLocations_Products_Id",
                table: "StoreLocations",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}