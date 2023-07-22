using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Swimmers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserFullName", "UserName" },
                values: new object[,]
                {
                    { "a1259a89-da2c-413d-94b9-fa5860faa017", 0, "204eb305-623d-421c-971d-eb260ae28104", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECOm0tBNeDzxH9hC93F8m/HHsQQr0XmX4yC7H6gDNMfoWY01+etEg9Lb1ZxtpITlAw==", null, false, "4731d5d3-4107-4cf8-afc4-d3408b4f46a2", false, "Admin", "admin@mail.com" },
                    { "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3", 0, "c0e25236-dc45-45b0-905c-71f0aa87af55", "guest@mail.com", false, false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEI/xVITYknTpZnaRN+VHkWVs78IQC6buxXOgvNT3lwf5GSm9SyqW3YJZR1yKq7ZLPg==", null, false, "601a2e39-6f40-4508-9295-5037e4fbcaf8", false, "Guest User", "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3832));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Swimmers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1197));
        }
    }
}
