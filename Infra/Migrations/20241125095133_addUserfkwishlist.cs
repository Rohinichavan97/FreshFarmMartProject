using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class addUserfkwishlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishListTbl_UserOrderTbl_UserOrderID",
                table: "WishListTbl");

            migrationBuilder.RenameColumn(
                name: "UserOrderID",
                table: "WishListTbl",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_WishListTbl_UserOrderID",
                table: "WishListTbl",
                newName: "IX_WishListTbl_UserID");

            migrationBuilder.UpdateData(
                table: "TraderFarmerTbl",
                keyColumn: "TraderFarmerID",
                keyValue: 1L,
                column: "RegistrationDate",
                value: new DateTime(2024, 11, 25, 15, 21, 30, 305, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.AddForeignKey(
                name: "FK_WishListTbl_Users_UserID",
                table: "WishListTbl",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishListTbl_Users_UserID",
                table: "WishListTbl");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "WishListTbl",
                newName: "UserOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_WishListTbl_UserID",
                table: "WishListTbl",
                newName: "IX_WishListTbl_UserOrderID");

            migrationBuilder.UpdateData(
                table: "TraderFarmerTbl",
                keyColumn: "TraderFarmerID",
                keyValue: 1L,
                column: "RegistrationDate",
                value: new DateTime(2024, 11, 21, 15, 37, 19, 352, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.AddForeignKey(
                name: "FK_WishListTbl_UserOrderTbl_UserOrderID",
                table: "WishListTbl",
                column: "UserOrderID",
                principalTable: "UserOrderTbl",
                principalColumn: "UserOrderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
