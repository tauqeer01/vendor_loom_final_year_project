using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalYearProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Addupadaetebl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Regdate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "City", "ConcurrencyStamp", "EarnedPoint", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "RefCode", "Regdate", "SecurityStamp", "SponsorId", "State", "StoreAddress", "StoreName", "StreetAddress", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[] { "885bae90-2ee1-4c18-949f-9ee6e88f9082", 0, 0m, null, "cbe81922-55b8-4252-aa14-ac1d607ede39", 0, "admin@vendorloom.com", true, "Super Admin", false, null, "ADMIN@VENDORLOOM.COM", "ADMIN", "AQAAAAIAAYagAAAAEI26v+E1ZptUNPia2sfi1udUz3tiaMKcaYNs7sniTxtypvCOmCSg1T7U4p046eixGw==", null, true, null, "n/a", new DateTime(2023, 8, 9, 21, 44, 39, 822, DateTimeKind.Local).AddTicks(2659), "39b6a992-b137-4d08-ab25-cbd08642bbcb", null, null, null, null, null, false, "Admin", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fd415ce-ca2c-400e-974a-bfff5dd47180", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0fd415ce-ca2c-400e-974a-bfff5dd47180", "885bae90-2ee1-4c18-949f-9ee6e88f9082" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0fd415ce-ca2c-400e-974a-bfff5dd47180", "885bae90-2ee1-4c18-949f-9ee6e88f9082" });

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: "885bae90-2ee1-4c18-949f-9ee6e88f9082");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0fd415ce-ca2c-400e-974a-bfff5dd47180");

            migrationBuilder.DropColumn(
                name: "Regdate",
                table: "Members");
        }
    }
}
