using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Storage2.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price" },
                values: new object[,]
                {
                    { 1, 0, 320, "A dirt block. Can be tilled to grow seeds. Will grow grass or mycelium if placed next to source block", "Dirt", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 0, 320, "Smooth stone. Can be crafted into stone bricks or redstone components. Great for natural landscape builds", "Stone", new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 3, 0, 640, "Oak wood. Can be crafted into Oak Wood Planks or shaved to make Shaved Oak Wood", "Wood", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 4, 0, 200, "From the nether. Emits a yellow light. Can be crafted into redstone lamp.", "Glowstone", new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { 5, 3, 5, "Basic sword. Gread for beginners!", "Stone sword", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 6, 3, 1, "Bow with the Infinity Enchantment. Never run out of ammo again!", "Infinity Bow", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200 },
                    { 7, 2, 5, "The second best pickaxe. Great speed and durability! Can be crafted into a netherite pickaxe", "Diamond pickaxe", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
