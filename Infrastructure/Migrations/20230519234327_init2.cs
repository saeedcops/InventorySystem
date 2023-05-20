using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_SupplyOrders_SupplyOrderId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "SupplyOrderId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SupplyOrders_SupplyOrderId",
                table: "Items",
                column: "SupplyOrderId",
                principalTable: "SupplyOrders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_SupplyOrders_SupplyOrderId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "SupplyOrderId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SupplyOrders_SupplyOrderId",
                table: "Items",
                column: "SupplyOrderId",
                principalTable: "SupplyOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
