using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CloudKitchen.Migrations
{
    /// <inheritdoc />
    public partial class AddModelRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KitchenId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FoodItemId",
                table: "FoodReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DriverId",
                table: "Orders",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_KitchenId",
                table: "Orders",
                column: "KitchenId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodReviews_FoodItemId",
                table: "FoodReviews",
                column: "FoodItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodReviews_FoodItems_FoodItemId",
                table: "FoodReviews",
                column: "FoodItemId",
                principalTable: "FoodItems",
                principalColumn: "FoodItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drivers_DriverId",
                table: "Orders",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Kitchens_KitchenId",
                table: "Orders",
                column: "KitchenId",
                principalTable: "Kitchens",
                principalColumn: "KitchenId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodReviews_FoodItems_FoodItemId",
                table: "FoodReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drivers_DriverId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Kitchens_KitchenId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DriverId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_KitchenId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_FoodReviews_FoodItemId",
                table: "FoodReviews");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "KitchenId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FoodItemId",
                table: "FoodReviews");
        }
    }
}
