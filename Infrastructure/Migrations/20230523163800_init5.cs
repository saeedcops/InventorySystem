using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Vendors_VendorId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Vendors_VendorId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplyOrders_Vendors_VendorId",
                table: "SupplyOrders");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_SupplyOrders_VendorId",
                table: "SupplyOrders");

            migrationBuilder.DropIndex(
                name: "IX_Parts_VendorId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Items_VendorId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "SupplyOrders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "WarehouseCode",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "EngneerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WarehouseCode",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "PartNumber");

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartNumber",
                table: "Items",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "SupplyOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseCode",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EngneerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WarehouseCode",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrders_VendorId",
                table: "SupplyOrders",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_VendorId",
                table: "Parts",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_VendorId",
                table: "Items",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Vendors_VendorId",
                table: "Items",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Vendors_VendorId",
                table: "Parts",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplyOrders_Vendors_VendorId",
                table: "SupplyOrders",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
