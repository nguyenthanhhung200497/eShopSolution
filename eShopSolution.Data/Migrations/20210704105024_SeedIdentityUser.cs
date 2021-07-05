using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c11e4d2c-de9d-4fb4-8d02-d7c79a79c053"), "9b66d1bf-2220-4f28-8533-d4bcf06442ca", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c11e4d2c-de9d-4fb4-8d02-d7c79a79c053"), new Guid("4c9a54d6-5291-4563-ab38-8b22387b5ee5") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4c9a54d6-5291-4563-ab38-8b22387b5ee5"), 0, "558318f7-e473-43df-88e1-dc078f64ce98", new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhhung200497@gmail.com", true, "Hung", "Thanh", false, null, "nguyenthanhhung200497@gmail.com", "admin", "AQAAAAEAACcQAAAAEBK/mM+TaMwslMkvaQ6B34eA9ZIRR9afrvaV1+M+jv3gMRa2SrF9ej1NE28FBesBng==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 4, 17, 50, 24, 37, DateTimeKind.Local).AddTicks(3416));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c11e4d2c-de9d-4fb4-8d02-d7c79a79c053"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c11e4d2c-de9d-4fb4-8d02-d7c79a79c053"), new Guid("4c9a54d6-5291-4563-ab38-8b22387b5ee5") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c9a54d6-5291-4563-ab38-8b22387b5ee5"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 4, 17, 33, 16, 682, DateTimeKind.Local).AddTicks(5622));
        }
    }
}
