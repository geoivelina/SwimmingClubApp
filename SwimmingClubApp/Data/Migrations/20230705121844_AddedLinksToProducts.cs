using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class AddedLinksToProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 7, 5, 15, 18, 44, 98, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://thumbs.dreamstime.com/b/sports-bottle-silhouette-icon-black-simple-illustration-plastic-container-scale-handle-water-contour-isolated-230479543.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://tse3.mm.bing.net/th?id=OIP.V3pt_Mlm8RMFF51PfXO8qQHaHa&pid=Api");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://tse1.mm.bing.net/th?id=OIP.SJjMXsjJV7NIePPD-UDjEAHaHa&pid=Api");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://dejpknyizje2n.cloudfront.net/svgcustom/clipart/preview/a5921c08923f404586ef252ada57626a.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://tse2.mm.bing.net/th?id=OIP._Rm-iwyJeCelyO1zNt4WygHaHa&pid=Api");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://tse4.mm.bing.net/th?id=OIP.GzxZvy7xMdsGgEYBh8QeEAAAAA&pid=Api");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/wwwroot/img/Eshop/bottle.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/wwwroot/img/Eshop/Fins.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/wwwroot/img/Eshop/googles.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "/wwwroot/img/Eshop/Hat.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "/wwwroot/img/Eshop/KickBoard.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "/wwwroot/img/Eshop/towel.jpg");
        }
    }
}
