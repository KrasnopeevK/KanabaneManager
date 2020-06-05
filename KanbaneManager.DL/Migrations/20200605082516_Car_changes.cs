using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KanbaneManager.DL.Migrations
{
    public partial class Car_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastToDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "NextToDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WeightLift",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInformation",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Carrying",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalInformation",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Carrying",
                table: "Cars");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastToDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NextToDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "WeightLift",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
