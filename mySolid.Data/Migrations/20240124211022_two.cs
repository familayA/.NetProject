using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mySolid.Data.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersList_ProductsList_ProductId",
                table: "OrdersList");

            migrationBuilder.DropIndex(
                name: "IX_OrdersList_ProductId",
                table: "OrdersList");

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_OrdersList_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "OrdersList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_ProductsList_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersList_ProductId",
                table: "OrdersList",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersList_ProductsList_ProductId",
                table: "OrdersList",
                column: "ProductId",
                principalTable: "ProductsList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
