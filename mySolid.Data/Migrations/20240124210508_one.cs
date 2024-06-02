using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mySolid.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomersList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsList_CustomersList_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomersList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    DateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersList_ProductsList_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersList_OrderId",
                table: "CustomersList",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersList_ProductId",
                table: "OrdersList",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsList_CustomerId",
                table: "ProductsList",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersList_OrdersList_OrderId",
                table: "CustomersList",
                column: "OrderId",
                principalTable: "OrdersList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersList_OrdersList_OrderId",
                table: "CustomersList");

            migrationBuilder.DropTable(
                name: "OrdersList");

            migrationBuilder.DropTable(
                name: "ProductsList");

            migrationBuilder.DropTable(
                name: "CustomersList");
        }
    }
}
