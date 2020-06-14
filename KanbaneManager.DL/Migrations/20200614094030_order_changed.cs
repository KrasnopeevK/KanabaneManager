using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KanbaneManager.DL.Migrations
{
    public partial class order_changed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TradePointId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TradePointId",
                table: "Orders",
                column: "TradePointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TradePoint_TradePointId",
                table: "Orders",
                column: "TradePointId",
                principalTable: "TradePoint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TradePoint_TradePointId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TradePointId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TradePointId",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
