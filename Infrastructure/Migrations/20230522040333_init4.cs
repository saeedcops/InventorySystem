using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Part_Brands_BrandId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_Customers_CustomerId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_Engineers_EngineerId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_Orders_OrderId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_SupplyOrders_SupplyOrderId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_Vendors_VendorId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Part_Warehouses_WarehouseId",
                table: "Part");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Part",
                table: "Part");

            migrationBuilder.RenameTable(
                name: "Part",
                newName: "Parts");

            migrationBuilder.RenameIndex(
                name: "IX_Part_WarehouseId",
                table: "Parts",
                newName: "IX_Parts_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Part_VendorId",
                table: "Parts",
                newName: "IX_Parts_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Part_SupplyOrderId",
                table: "Parts",
                newName: "IX_Parts_SupplyOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Part_OrderId",
                table: "Parts",
                newName: "IX_Parts_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Part_EngineerId",
                table: "Parts",
                newName: "IX_Parts_EngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_Part_CustomerId",
                table: "Parts",
                newName: "IX_Parts_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Part_BrandId",
                table: "Parts",
                newName: "IX_Parts_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Brands_BrandId",
                table: "Parts",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Customers_CustomerId",
                table: "Parts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Engineers_EngineerId",
                table: "Parts",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Orders_OrderId",
                table: "Parts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_SupplyOrders_SupplyOrderId",
                table: "Parts",
                column: "SupplyOrderId",
                principalTable: "SupplyOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Vendors_VendorId",
                table: "Parts",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Warehouses_WarehouseId",
                table: "Parts",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Brands_BrandId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Customers_CustomerId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Engineers_EngineerId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Orders_OrderId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_SupplyOrders_SupplyOrderId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Vendors_VendorId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Warehouses_WarehouseId",
                table: "Parts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.RenameTable(
                name: "Parts",
                newName: "Part");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_WarehouseId",
                table: "Part",
                newName: "IX_Part_WarehouseId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_VendorId",
                table: "Part",
                newName: "IX_Part_VendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_SupplyOrderId",
                table: "Part",
                newName: "IX_Part_SupplyOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_OrderId",
                table: "Part",
                newName: "IX_Part_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_EngineerId",
                table: "Part",
                newName: "IX_Part_EngineerId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_CustomerId",
                table: "Part",
                newName: "IX_Part_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_BrandId",
                table: "Part",
                newName: "IX_Part_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Part",
                table: "Part",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Brands_BrandId",
                table: "Part",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Customers_CustomerId",
                table: "Part",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Engineers_EngineerId",
                table: "Part",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Orders_OrderId",
                table: "Part",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_SupplyOrders_SupplyOrderId",
                table: "Part",
                column: "SupplyOrderId",
                principalTable: "SupplyOrders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Vendors_VendorId",
                table: "Part",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Warehouses_WarehouseId",
                table: "Part",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
