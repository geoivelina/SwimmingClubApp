using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class OrderTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssuedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderStatus");

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
    }
}
