using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mySolid.Data.Migrations
{
    public partial class EF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ProductsList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "CustomersList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CustomersList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsList_CustomerId",
                table: "ProductsList",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersList_OrderId",
                table: "CustomersList",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersList_OrdersList_OrderId",
                table: "CustomersList",
                column: "OrderId",
                principalTable: "OrdersList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsList_CustomersList_CustomerId",
                table: "ProductsList",
                column: "CustomerId",
                principalTable: "CustomersList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersList_OrdersList_OrderId",
                table: "CustomersList");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsList_CustomersList_CustomerId",
                table: "ProductsList");

            migrationBuilder.DropIndex(
                name: "IX_ProductsList_CustomerId",
                table: "ProductsList");

            migrationBuilder.DropIndex(
                name: "IX_CustomersList_OrderId",
                table: "CustomersList");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ProductsList");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "CustomersList");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CustomersList");
        }
    }
}
