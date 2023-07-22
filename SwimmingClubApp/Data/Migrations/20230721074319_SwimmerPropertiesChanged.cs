using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SwimmerPropertiesChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Swimmers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Swimmers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a683ebd-c12f-43f6-bc11-eaa18e787499", "AQAAAAEAACcQAAAAEHSOu3Jz3c/uYG07Y9dkxYXMzsM9TgnoC3K0Xwr8F/MFbyC+7faHtx1bFBRK/qpsbg==", "4dba79e8-e667-42a3-85b9-ab3ca845d91a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed9d62b-bb06-470d-b8e0-af089eb96b6e", "AQAAAAEAACcQAAAAEKgwZf2cLfJR45uBc2OhXBOjkvaJ4KRiH/TbuKkWGzJpwYEwNanQ7JyTdajtg7CAng==", "75c2daa3-9f8d-424d-8e12-85f0d744468d" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 21, 10, 43, 18, 325, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 21, 10, 43, 18, 325, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 21, 10, 43, 18, 325, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 21, 10, 43, 18, 325, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "levi@mail.com", "+000111222333" });

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "austin@mail.com", "+000111222333" });

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "ava@mail.com", "+000111222333" });

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "adam@mail.com", "+000111222333" });

            migrationBuilder.UpdateData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "PhoneNumber" },
                values: new object[] { "maggie@mail.com", "+000111222333" });

            migrationBuilder.CreateIndex(
                name: "IX_Swimmers_SquadId",
                table: "Swimmers",
                column: "SquadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Swimmers_Squads_SquadId",
                table: "Swimmers",
                column: "SquadId",
                principalTable: "Squads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swimmers_Squads_SquadId",
                table: "Swimmers");

            migrationBuilder.DropIndex(
                name: "IX_Swimmers_SquadId",
                table: "Swimmers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Swimmers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Swimmers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "715f6e8b-51fa-4246-90b9-d516cbd1c2de", "AQAAAAEAACcQAAAAEKpj6HPKiULnl+sY7U4inWWGXM1VNunBcXdjqMiFH+hnSZi6bWOGPa4L48t1sP3hyw==", "23aa6e43-759a-4b2c-8c5e-d3831aac7d0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b599fd4-73ff-4d24-be3f-fab81fa6c789", "AQAAAAEAACcQAAAAECWVGvPnuphxsjlSciUZ9TwZbryuQ+r9KENcJm2wVzbHZe7qJFGk2s/zdY7U/OGr7w==", "3f7a3e65-58a3-48b2-a188-be3911b63c1c" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 18, 42, 41, 558, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 18, 42, 41, 558, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 18, 42, 41, 558, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 18, 42, 41, 558, DateTimeKind.Local).AddTicks(3370));
        }
    }
}
