using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SizeNameColumnAddedInOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SizeName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b9fe054-7ab5-4244-a9b8-1c7dca00059b", "AQAAAAEAACcQAAAAEAVzdtt+C1XGrjKPqvcQZ0YHT0wcL9Xrq+wZ4xRA05Yq6a9q1UA0OdxHtVtUSHLvGQ==", "49f26407-988f-4784-b2f9-d87536a27191" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aab5d127-60b5-4929-bec7-183c75cff8ab", "AQAAAAEAACcQAAAAEA4NFTSjb6zlm2S7qhA3bjTNsBIFybRErCf+CaPMjS/zCQi66E+lpBdCsFQQ5Q+9ZA==", "0f158cd1-8238-4f81-92e4-2afdc6b7e62e" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 14, 18, 18, 944, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 14, 18, 18, 945, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 14, 18, 18, 945, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 14, 18, 18, 945, DateTimeKind.Local).AddTicks(44));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeName",
                table: "Orders");

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
        }
    }
}
