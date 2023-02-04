using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "17254286-f148-41d9-a159-95ea39ed0c0b");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "6467f250-5047-4d0b-af44-6ef068b9ca69");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "686b192f-6c31-405a-8645-98155a903d0c", "Calle 8 con 23", "Bodega Central" },
                    { "f4274f7f-d095-499b-82a4-2063a44e41b5", "1191 Wildwood Street", "Bodega US" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "686b192f-6c31-405a-8645-98155a903d0c");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "f4274f7f-d095-499b-82a4-2063a44e41b5");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "17254286-f148-41d9-a159-95ea39ed0c0b", "Calle 8 con 23", "Bodega Central" },
                    { "6467f250-5047-4d0b-af44-6ef068b9ca69", "1191 Wildwood Street", "Bodega US" }
                });
        }
    }
}
