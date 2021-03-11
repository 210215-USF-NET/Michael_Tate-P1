using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreDL.Migrations
{
    public partial class RelationshipFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocID",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreLocations_Products_Id",
                table: "StoreLocations",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreLocations_Products_Id",
                table: "StoreLocations");

            migrationBuilder.AddColumn<int>(
                name: "LocID",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
