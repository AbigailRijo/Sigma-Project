using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifyedDate" },
                values: new object[] { new DateTime(2019, 6, 1, 10, 32, 20, 911, DateTimeKind.Local).AddTicks(1438), new DateTime(2019, 6, 1, 10, 32, 20, 912, DateTimeKind.Local).AddTicks(6580) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModifyedDate" },
                values: new object[] { new DateTime(2019, 5, 31, 20, 40, 43, 337, DateTimeKind.Local).AddTicks(4105), new DateTime(2019, 5, 31, 20, 40, 43, 338, DateTimeKind.Local).AddTicks(8203) });
        }
    }
}
