using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SomeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4651));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 2, 16, 30, 32, 144, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 2, 16, 30, 32, 144, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 2, 16, 30, 32, 144, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 2, 16, 30, 32, 144, DateTimeKind.Local).AddTicks(9122));
        }
    }
}
