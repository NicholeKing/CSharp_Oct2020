using Microsoft.EntityFrameworkCore.Migrations;

namespace GigSite.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gig_Users_UserId",
                table: "Gig");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistory_Gig_GigId",
                table: "OrderHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHistory_Users_UserId",
                table: "OrderHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderHistory",
                table: "OrderHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gig",
                table: "Gig");

            migrationBuilder.RenameTable(
                name: "OrderHistory",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Gig",
                newName: "Gigs");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHistory_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHistory_GigId",
                table: "Orders",
                newName: "IX_Orders_GigId");

            migrationBuilder.RenameIndex(
                name: "IX_Gig_UserId",
                table: "Gigs",
                newName: "IX_Gigs_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gigs",
                table: "Gigs",
                column: "GigId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_Users_UserId",
                table: "Gigs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Gigs_GigId",
                table: "Orders",
                column: "GigId",
                principalTable: "Gigs",
                principalColumn: "GigId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_Users_UserId",
                table: "Gigs");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Gigs_GigId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gigs",
                table: "Gigs");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrderHistory");

            migrationBuilder.RenameTable(
                name: "Gigs",
                newName: "Gig");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "OrderHistory",
                newName: "IX_OrderHistory_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_GigId",
                table: "OrderHistory",
                newName: "IX_OrderHistory_GigId");

            migrationBuilder.RenameIndex(
                name: "IX_Gigs_UserId",
                table: "Gig",
                newName: "IX_Gig_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderHistory",
                table: "OrderHistory",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gig",
                table: "Gig",
                column: "GigId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gig_Users_UserId",
                table: "Gig",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistory_Gig_GigId",
                table: "OrderHistory",
                column: "GigId",
                principalTable: "Gig",
                principalColumn: "GigId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHistory_Users_UserId",
                table: "OrderHistory",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
