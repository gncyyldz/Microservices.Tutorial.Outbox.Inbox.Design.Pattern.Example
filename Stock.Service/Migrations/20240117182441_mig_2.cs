using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock.Service.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderInboxes",
                table: "OrderInboxes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderInboxes");

            migrationBuilder.AddColumn<Guid>(
                name: "IdempotentToken",
                table: "OrderInboxes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderInboxes",
                table: "OrderInboxes",
                column: "IdempotentToken");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderInboxes",
                table: "OrderInboxes");

            migrationBuilder.DropColumn(
                name: "IdempotentToken",
                table: "OrderInboxes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderInboxes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderInboxes",
                table: "OrderInboxes",
                column: "Id");
        }
    }
}
