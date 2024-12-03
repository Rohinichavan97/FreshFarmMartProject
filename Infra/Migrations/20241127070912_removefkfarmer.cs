using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class removefkfarmer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrderTbl_TraderFarmerTbl_TraderFarmerID",
                table: "UserOrderTbl");

            migrationBuilder.DropIndex(
                name: "IX_UserOrderTbl_TraderFarmerID",
                table: "UserOrderTbl");

            migrationBuilder.DropColumn(
                name: "TraderFarmerID",
                table: "UserOrderTbl");

            migrationBuilder.UpdateData(
                table: "TraderFarmerTbl",
                keyColumn: "TraderFarmerID",
                keyValue: 1L,
                column: "RegistrationDate",
                value: new DateTime(2024, 11, 27, 12, 39, 9, 585, DateTimeKind.Local).AddTicks(5259));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TraderFarmerID",
                table: "UserOrderTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "TraderFarmerTbl",
                keyColumn: "TraderFarmerID",
                keyValue: 1L,
                column: "RegistrationDate",
                value: new DateTime(2024, 11, 25, 15, 21, 30, 305, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.CreateIndex(
                name: "IX_UserOrderTbl_TraderFarmerID",
                table: "UserOrderTbl",
                column: "TraderFarmerID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrderTbl_TraderFarmerTbl_TraderFarmerID",
                table: "UserOrderTbl",
                column: "TraderFarmerID",
                principalTable: "TraderFarmerTbl",
                principalColumn: "TraderFarmerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
