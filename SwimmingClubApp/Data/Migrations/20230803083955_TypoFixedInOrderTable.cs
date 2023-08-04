using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class TypoFixedInOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "IssuerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_IssuerId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2e7e149-b2cb-429e-8829-f307c63ad644", "AQAAAAEAACcQAAAAEAp8G6ABiab3HdZBIahkq9HuSL3pP7mAmGflqusCApVzRGiGXow4JFb2mk5K/ELn9A==", "f0f4854e-526b-42db-baa7-3f0be3887175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b857c345-cf3b-460a-aa0d-ab65612590a1", "AQAAAAEAACcQAAAAEIENyhFwOAdXokNFdnM8qKTOgPmDkqHWgI1zieT2OXf1q1YMU0oIR7ItbScdTMxLyA==", "9ead9d26-a5cd-47c6-9029-598ef8d46bc4" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 39, 54, 43, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 39, 54, 43, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 39, 54, 43, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 39, 54, 43, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_IssuerId",
                table: "Orders",
                column: "IssuerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_IssuerId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "IssuerId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_IssuerId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70d387af-6042-4551-80eb-16efff86072b", "AQAAAAEAACcQAAAAEMnH/CF0SKbvxAfjlbkpj8nYSBWs6yMEOfBEEs9srPXFz4ru4+xEVXSu1iApgM8IuQ==", "2cc5189d-f6ea-4f68-85d1-a20e4ed99910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d8b464-04b9-41c0-b1ce-8826fc4d94fb", "AQAAAAEAACcQAAAAEPMbBspljISUBq5jOjqm7XU0/i3F7ENoOl0uyAC0WcY44E5oBGnOrZHT9/gGiPqUSg==", "91dd246f-d439-412c-996f-d109523856ec" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
