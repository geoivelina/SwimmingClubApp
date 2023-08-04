using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class AddedIsActiveColumnInSwimmerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Swimmers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c68d7d0c-e4a0-4bf7-a8e0-82c11f242145", "AQAAAAEAACcQAAAAEOcLxoWG1kbk/o1mdYvoei03d76gLQbEfSrVGWA48nb7v6jM7YDEGrjUFIi+8SRhjA==", "c28d8d45-912c-4f64-834e-039283c116bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d10867a-6cc5-4f69-8253-f1dd829ab5fa", "AQAAAAEAACcQAAAAEEmdov4KwL6tUalR9pbI9nB7wksO4DKi7+50Ei45m2luDq2/SH5GN4U1KDk/xdXNMg==", "b72b4f5b-7288-4a15-ab02-a7f94e65d4ee" });

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                column: "SquadId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                column: "SquadId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 26, 10, 22, 4, 211, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 26, 10, 22, 4, 211, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 26, 10, 22, 4, 211, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 26, 10, 22, 4, 211, DateTimeKind.Local).AddTicks(5724));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Swimmers");

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
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3,
                column: "SquadId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4,
                column: "SquadId",
                value: 2);

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
        }
    }
}
