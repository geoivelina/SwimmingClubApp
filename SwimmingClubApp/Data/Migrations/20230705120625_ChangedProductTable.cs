using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class ChangedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SizeOptions_SizeOptionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeOptionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeOptionId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    SizeOptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSize_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_SizeOptions_SizeOptionId",
                        column: x => x.SizeOptionId,
                        principalTable: "SizeOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 6, 24, 444, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 6, 24, 444, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 6, 24, 444, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 6, 24, 444, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductId",
                table: "ProductSize",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizeOptionId",
                table: "ProductSize",
                column: "SizeOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.AddColumn<int>(
                name: "SizeOptionId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 3, 9, 50, 55, 659, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "SizeOptionId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "SizeOptionId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "SizeOptionId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "SizeOptionId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "SizeOptionId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "SizeOptionId",
                value: 13);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeOptionId",
                table: "Products",
                column: "SizeOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SizeOptions_SizeOptionId",
                table: "Products",
                column: "SizeOptionId",
                principalTable: "SizeOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
