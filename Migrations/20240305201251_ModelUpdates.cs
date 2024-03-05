using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudKitchen.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderedItems",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "FoodItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_OrderId",
                table: "FoodItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Orders_OrderId",
                table: "FoodItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Orders_OrderId",
                table: "FoodItems");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_OrderId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "FoodItems");

            migrationBuilder.AddColumn<string>(
                name: "OrderedItems",
                table: "Orders",
                type: "TEXT",
                nullable: true);
        }
    }
}
