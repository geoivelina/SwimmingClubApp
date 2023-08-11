using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SizeNameColumnInOrderDropped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeName",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28ef19f5-81e5-42c3-bad5-37e2b658ee28", "AQAAAAEAACcQAAAAEBWPauNVyzZPEV2U2b4/GOMr7WO7lDEUkOjCUDIEBorDWdEhALnPqRbELcbpZ2aTAA==", "60108187-4919-40c3-a349-e80d1eef1862" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e65af409-b2b9-4df0-8964-57d2db609874", "AQAAAAEAACcQAAAAEI4hd8RAoVqec05tGdbIdSNVEjmkUaOgWqTq9aP2Q+SKtIdklpQRH5BULIobGC0eog==", "821d1fe2-2937-4080-968a-bcb3b627fedd" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 15, 8, 59, 79, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 15, 8, 59, 79, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 15, 8, 59, 79, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 4, 15, 8, 59, 79, DateTimeKind.Local).AddTicks(9554));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
