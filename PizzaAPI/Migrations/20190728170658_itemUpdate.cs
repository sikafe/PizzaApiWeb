using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaAPI.Migrations
{
    public partial class itemUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ItemId",
                table: "Products",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProductId",
                table: "Items",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductId",
                table: "Items",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Items_ItemId",
                table: "Products",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Items_ItemId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ItemId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Items_ProductId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Products");
        }
    }
}
