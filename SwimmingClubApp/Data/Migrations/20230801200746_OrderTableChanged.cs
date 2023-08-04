using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class OrderTableChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43abf004-c67d-4051-91e1-e0fc9b557797", "AQAAAAEAACcQAAAAEJ6e/Mvdrz8Svz8pLpZNubKEwq2hboGDXX+Ciq0J/m53PhV7gNvQqoWxieRDK1L4Hw==", "a0e7ed4b-ef88-43c6-b44d-e42c31ce1647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e513e138-aaa3-4f35-85ec-787109b086bb", "AQAAAAEAACcQAAAAEHujl27cTpk4ynbj+8MM3HdcwkIKP/lr8zSYjL46KJDICKGp/xibkT6h7E1YNU9A3w==", "77abb47e-e780-4d49-8df8-5de15b24e2d3" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8362));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9809351b-da8c-481b-9710-b0ca48b7cbe0", "AQAAAAEAACcQAAAAEImyhOxtiEjZzbQdr1oR7Q7Q0yGaVNjYHxZaP5Q78RK+dQ1v6rUm9ydQ/WHExTfaZw==", "ba35f8b1-52f7-4246-aea7-502989a81a05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a35b8c5d-01f1-4b25-98f0-c5686edfaac2", "AQAAAAEAACcQAAAAEFIdlA+04EG6sIzV80y5C+fsKoaEbX/HuDhOfSp0XK7YSNUvarnllIFHX2XFvsUtxA==", "0e3b3a83-f1c8-4fd7-bc2a-9b8c85e8f2c9" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 12, 35, 57, 898, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 12, 35, 57, 898, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 12, 35, 57, 898, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 12, 35, 57, 898, DateTimeKind.Local).AddTicks(395));
        }
    }
}
