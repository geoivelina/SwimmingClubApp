using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SomeSmallChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "SizeOptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "SizeOptions");

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3406));
        }
    }
}
