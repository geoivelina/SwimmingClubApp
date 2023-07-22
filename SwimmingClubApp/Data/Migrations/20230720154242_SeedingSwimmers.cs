using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SeedingSwimmers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
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

            migrationBuilder.InsertData(
                table: "Swimmers",
                columns: new[] { "Id", "Address", "Age", "ContactPersonName", "FullName", "IsApproved", "MedicalDatails", "RelationshipToSwimmer", "SquadId", "SwimmingExperience" },
                values: new object[,]
                {
                    { 1, "SomeTown, SomeStreet, SomeNumber", 12, "Sam Miller", "Levi Miller", false, "None", "Mother", 1, "Some other swimming club" },
                    { 2, "SomeTown, SomeStreet, SomeNumber", 22, "Some Relative", "Austin Ouyang", false, "None", "Some", 3, "2 other swimming clubs" },
                    { 3, "SomeTown, SomeStreet, SomeNumber", 21, "Some Relative", "Ava Senn", false, "None", "Some", 3, "2 other swimming clubs" },
                    { 4, "SomeTown, SomeStreet, SomeNumber", 18, "Some Relative", "Adam Smith", false, "None", "Some", 2, "2 other swimming clubs" },
                    { 5, "SomeTown, SomeStreet, SomeNumber", 17, "Some Relative", "Maggie Welsh", false, "None", "Some", 2, "2 other swimming clubs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Swimmers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Swimmers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "204eb305-623d-421c-971d-eb260ae28104", "AQAAAAEAACcQAAAAECOm0tBNeDzxH9hC93F8m/HHsQQr0XmX4yC7H6gDNMfoWY01+etEg9Lb1ZxtpITlAw==", "4731d5d3-4107-4cf8-afc4-d3408b4f46a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0e25236-dc45-45b0-905c-71f0aa87af55", "AQAAAAEAACcQAAAAEI/xVITYknTpZnaRN+VHkWVs78IQC6buxXOgvNT3lwf5GSm9SyqW3YJZR1yKq7ZLPg==", "601a2e39-6f40-4508-9295-5037e4fbcaf8" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 20, 17, 8, 9, 967, DateTimeKind.Local).AddTicks(3832));
        }
    }
}
