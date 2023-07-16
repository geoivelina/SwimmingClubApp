using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class IsActiveFieldAddedInCoachNewsProductTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvtive",
                table: "Sponsors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvtive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvtive",
                table: "Newses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvtive",
                table: "Coaches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsAvtive" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1132), true });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsAvtive" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1185), true });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsAvtive" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1191), true });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsAvtive" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 4, 1, 831, DateTimeKind.Local).AddTicks(1197), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAvtive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsAvtive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvtive",
                table: "Sponsors");

            migrationBuilder.DropColumn(
                name: "IsAvtive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsAvtive",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "IsAvtive",
                table: "Coaches");

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8296));
        }
    }
}
