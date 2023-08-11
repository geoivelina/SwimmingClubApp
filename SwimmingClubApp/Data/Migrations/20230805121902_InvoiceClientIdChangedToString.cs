using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class InvoiceClientIdChangedToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_ClientId1",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ClientId1",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Invoices",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ClientId",
                table: "Invoices",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_ClientId",
                table: "Invoices",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_ClientId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ClientId",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Invoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ClientId1",
                table: "Invoices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d43fff0f-8d20-4336-8ad4-df4ab74029fc", "AQAAAAEAACcQAAAAECPQ4kDWMJHmzRP+KNIMv5V9ODA8dX22RofnwvNsLtX6PnGni9/q8plC2PnkoGQ+Og==", "b303a97f-4e25-4599-b4cf-67a32f623ad7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd67e812-5ab1-4489-9768-0f39e281cf0f", "AQAAAAEAACcQAAAAED0RWqYKkI/OiDMtDQxcGCDB0uOAGTL8m4GwPepofYfp2MlmW6Yy/jp2LSAthFjzUQ==", "d0088b9c-df9e-4ed2-8fbc-43e4450ede0c" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 13, 6, 19, 604, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 13, 6, 19, 604, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 13, 6, 19, 604, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 5, 13, 6, 19, 604, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ClientId1",
                table: "Invoices",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_ClientId1",
                table: "Invoices",
                column: "ClientId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
