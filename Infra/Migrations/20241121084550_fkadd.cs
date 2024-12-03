using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class fkadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_UserOrderTbl_ProductTbl_ProductID",
            //    table: "UserOrderTbl");

            //migrationBuilder.DropIndex(
            //    name: "IX_UserOrderTbl_ProductID",
            //    table: "UserOrderTbl");

            //migrationBuilder.DropColumn(
            //    name: "ProductID",
            //    table: "UserOrderTbl");

            //migrationBuilder.UpdateData(
            //    table: "TraderFarmerTbl",
            //    keyColumn: "TraderFarmerID",
            //    keyValue: 1L,
            //    column: "RegistrationDate",
            //    value: new DateTime(2024, 11, 21, 14, 15, 46, 888, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.CreateIndex(
                name: "IX_UserOrderDetTbl_ProductID",
                table: "UserOrderDetTbl",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrderDetTbl_ProductTbl_ProductID",
                table: "UserOrderDetTbl",
                column: "ProductID",
                principalTable: "ProductTbl",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrderDetTbl_ProductTbl_ProductID",
                table: "UserOrderDetTbl");

            migrationBuilder.DropIndex(
                name: "IX_UserOrderDetTbl_ProductID",
                table: "UserOrderDetTbl");

            migrationBuilder.AddColumn<long>(
                name: "ProductID",
                table: "UserOrderTbl",
                type: "bigint",
                nullable: true);

            //migrationBuilder.UpdateData(
            //    table: "TraderFarmerTbl",
            //    keyColumn: "TraderFarmerID",
            //    keyValue: 1L,
            //    column: "RegistrationDate",
            //    value: new DateTime(2024, 11, 15, 15, 6, 4, 47, DateTimeKind.Local).AddTicks(2471));

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserOrderTbl_ProductID",
            //    table: "UserOrderTbl",
            //    column: "ProductID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_UserOrderTbl_ProductTbl_ProductID",
            //    table: "UserOrderTbl",
            //    column: "ProductID",
            //    principalTable: "ProductTbl",
            //    principalColumn: "ProductID",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
