using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class newup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TraderFarmerTbl",
                keyColumn: "TraderFarmerID",
                keyValue: 1L,
                column: "RegistrationDate",
                value: new DateTime(2024, 11, 21, 15, 37, 19, 352, DateTimeKind.Local).AddTicks(9175));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TraderFarmerTbl",
                keyColumn: "TraderFarmerID",
                keyValue: 1L,
                column: "RegistrationDate",
                value: new DateTime(2024, 11, 21, 14, 15, 46, 888, DateTimeKind.Local).AddTicks(3008));
        }
    }
}
