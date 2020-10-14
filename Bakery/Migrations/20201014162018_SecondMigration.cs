using Microsoft.EntityFrameworkCore.Migrations;

namespace Bakery.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Goods_GoodId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Shops_ShopId",
                table: "Inventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Stock");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_ShopId",
                table: "Stock",
                newName: "IX_Stock_ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_GoodId",
                table: "Stock",
                newName: "IX_Stock_GoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Goods_GoodId",
                table: "Stock",
                column: "GoodId",
                principalTable: "Goods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Shops_ShopId",
                table: "Stock",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Goods_GoodId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Shops_ShopId",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Inventory");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_ShopId",
                table: "Inventory",
                newName: "IX_Inventory_ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_GoodId",
                table: "Inventory",
                newName: "IX_Inventory_GoodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Goods_GoodId",
                table: "Inventory",
                column: "GoodId",
                principalTable: "Goods",
                principalColumn: "GoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Shops_ShopId",
                table: "Inventory",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
