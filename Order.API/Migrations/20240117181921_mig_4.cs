using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Order.API.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderOutboxes",
                table: "OrderOutboxes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderOutboxes");

            migrationBuilder.AddColumn<Guid>(
                name: "IdempotentToken",
                table: "OrderOutboxes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderOutboxes",
                table: "OrderOutboxes",
                column: "IdempotentToken");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderOutboxes",
                table: "OrderOutboxes");

            migrationBuilder.DropColumn(
                name: "IdempotentToken",
                table: "OrderOutboxes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderOutboxes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderOutboxes",
                table: "OrderOutboxes",
                column: "Id");
        }
    }
}
