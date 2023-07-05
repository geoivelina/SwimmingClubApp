using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SeedingProductsCategoriesAndSizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SizeOptions_SizeOptionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.AlterColumn<int>(
                name: "SizeOptionId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 14, 59, 21, 429, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Junior" },
                    { 2, "Women" },
                    { 3, "Men" },
                    { 4, "Traning Aids" }
                });

            migrationBuilder.InsertData(
                table: "SizeOptions",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Kids M" },
                    { 2, "Kids L" },
                    { 3, "Kids XL" },
                    { 4, "Adult XS" },
                    { 5, "Adult S" },
                    { 6, "Adult M" },
                    { 7, "Adult L" },
                    { 8, "Adult XL" },
                    { 9, "Age 7 - 8" },
                    { 10, "Age 9 - 11" },
                    { 11, "Age 12 - 13" },
                    { 12, "Junior" },
                    { 13, "None" },
                    { 14, "Adult" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Image", "Name", "Price", "ProductCategoryId", "SizeOptionId" },
                values: new object[,]
                {
                    { 1, "/wwwroot/img/Eshop/bottle.jpg", "Star Swimming Club Bottle", 7.00m, 4, 13 },
                    { 2, "/wwwroot/img/Eshop/Fins.jpg", "Fins", 30.00m, 4, 13 },
                    { 3, "/wwwroot/img/Eshop/googles.jpg", "Adult Googles", 11.00m, 4, 14 },
                    { 4, "/wwwroot/img/Eshop/Hat.jpg", "Star Swimming Club Hat", 5.00m, 4, 13 },
                    { 5, "/wwwroot/img/Eshop/KickBoard.jpg", "Kickboard", 15.00m, 4, 13 },
                    { 6, "/wwwroot/img/Eshop/towel.jpg", "Star Swimming Club Towel", 15.00m, 4, 13 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SizeOptions_SizeOptionId",
                table: "Products",
                column: "SizeOptionId",
                principalTable: "SizeOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SizeOptions_SizeOptionId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SizeOptions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.AlterColumn<int>(
                name: "SizeOptionId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductCategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeOptionId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizes_SizeOptions_SizeOptionId",
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
                value: new DateTime(2023, 6, 30, 13, 47, 18, 900, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 13, 47, 18, 900, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 13, 47, 18, 900, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 6, 30, 13, 47, 18, 900, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizeOptionId",
                table: "ProductSizes",
                column: "SizeOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SizeOptions_SizeOptionId",
                table: "Products",
                column: "SizeOptionId",
                principalTable: "SizeOptions",
                principalColumn: "Id");
        }
    }
}
