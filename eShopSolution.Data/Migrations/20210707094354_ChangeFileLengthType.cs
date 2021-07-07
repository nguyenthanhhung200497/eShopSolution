using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c11e4d2c-de9d-4fb4-8d02-d7c79a79c053"),
                column: "ConcurrencyStamp",
                value: "f7d48ce1-17a3-4aa5-85a4-b4bfb82993d1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c9a54d6-5291-4563-ab38-8b22387b5ee5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03becdd9-c1a7-4003-9cd7-1623a51634d0", "AQAAAAEAACcQAAAAEI25jV9HeVQtDWUQuzncm2Obg3SwZxZTOqB04rrj7bgybqgMuxS5DOgXITCAhDUAVg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 7, 16, 43, 53, 520, DateTimeKind.Local).AddTicks(3163));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c11e4d2c-de9d-4fb4-8d02-d7c79a79c053"),
                column: "ConcurrencyStamp",
                value: "04227d1e-06d1-405c-9b1a-e73f17916f3b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c9a54d6-5291-4563-ab38-8b22387b5ee5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61813310-44f0-413a-97c4-c3e08c531e4d", "AQAAAAEAACcQAAAAEHBoi1mK/SIyYhysNC/9msMMjUFvodM8D6pXl2d2Y1/XPZ9gjfP8Fk7NHUkf5+rigw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 6, 16, 47, 23, 674, DateTimeKind.Local).AddTicks(5229));
        }
    }
}
