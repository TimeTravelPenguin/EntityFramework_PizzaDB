using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaDB.Migrations
{
    public partial class MovedOrderDateTimesFromPaymentToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeOrderDue",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DateTimeOrderFulfilled",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DateTimeOrderPlaced",
                table: "Payments");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOrderDue",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOrderFulfilled",
                table: "Orders",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOrderPlaced",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeOrderDue",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateTimeOrderFulfilled",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateTimeOrderPlaced",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOrderDue",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOrderFulfilled",
                table: "Payments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOrderPlaced",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
