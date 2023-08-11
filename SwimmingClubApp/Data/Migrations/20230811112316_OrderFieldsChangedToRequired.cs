using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class OrderFieldsChangedToRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbb34fa2-bdc5-407b-ae2a-1de07f488bbb", "AQAAAAEAACcQAAAAEBOHowHJTN082x02JJ0Veb3aF9cOGR8Ex4N55GXtmzQofBNup/YWszUhQ/NBeVjIXQ==", "483175a6-1f23-4644-af96-0ff37bb330b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7da5b3c-459d-4373-a29b-8b459f53ef53", "AQAAAAEAACcQAAAAEMPaePZ7lQHt4fKAEvMcPTO5ssRa3Y12LtCWiHeONhzGkd0mv8iLZGqBh0O5iUrmuQ==", "8c52c0d0-8cf1-4192-bc20-46568bf9215b" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 14, 23, 14, 893, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 14, 23, 14, 893, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 14, 23, 14, 893, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 11, 14, 23, 14, 893, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Completed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0a1f5e5-ef32-4a2e-a9c7-1caa334c9d77", "AQAAAAEAACcQAAAAENQMtdHha8k7YzVfL5oRi7YmQdllWSLHMnpkHoIkFiciley0MmUcrF2LGLV8KTunQA==", "1100269e-a86e-474e-b167-740364d1d88c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9453da74-e8c5-45f2-911e-2e64ad98bf1b", "AQAAAAEAACcQAAAAEGn8GRYlf+ffNquafs+DrYygnTtk8hCoXgJbkt89xZIQbheiHtdwyA91tcyuwl6DlQ==", "a270b642-9fc7-4d5f-ab0a-8ad6f7c7053e" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 15, 19, 0, 695, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 15, 19, 0, 695, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 15, 19, 0, 695, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 15, 19, 0, 695, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Complete");
        }
    }
}
