using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DIO.AvaCloud.Infra.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 9, 28, 21, 38, 34, 286, DateTimeKind.Local).AddTicks(2285));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2021, 9, 28, 21, 31, 22, 962, DateTimeKind.Local).AddTicks(3071));
        }
    }
}
