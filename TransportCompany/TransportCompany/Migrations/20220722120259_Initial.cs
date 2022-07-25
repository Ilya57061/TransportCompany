using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportCompany.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Authorization",
                value: new DateTime(2022, 7, 22, 15, 2, 58, 916, DateTimeKind.Local).AddTicks(5672));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Authorization",
                value: new DateTime(2022, 7, 22, 14, 58, 32, 782, DateTimeKind.Local).AddTicks(5551));
        }
    }
}
