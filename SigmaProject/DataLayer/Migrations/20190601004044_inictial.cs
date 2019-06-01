using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class inictial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifyedDate = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifyedByUser = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedByUser = table.Column<string>(maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByUser", "CreationDate", "FirstName", "IsDeleted", "LastName", "ModifyedByUser", "ModifyedDate", "Password", "Username" },
                values: new object[] { 1, null, new DateTime(2019, 5, 31, 20, 40, 43, 337, DateTimeKind.Local).AddTicks(4105), "Admin", false, "Admin", null, new DateTime(2019, 5, 31, 20, 40, 43, 338, DateTimeKind.Local).AddTicks(8203), "LY2TluXFMaUK7hjiqR+E+VQjU43eWO0v7Pl6wXvrNOc=", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
