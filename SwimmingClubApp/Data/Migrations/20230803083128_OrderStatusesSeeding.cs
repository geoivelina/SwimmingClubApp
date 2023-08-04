using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class OrderStatusesSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatus_StatusId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus");

            migrationBuilder.RenameTable(
                name: "OrderStatus",
                newName: "OrderStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70d387af-6042-4551-80eb-16efff86072b", "AQAAAAEAACcQAAAAEMnH/CF0SKbvxAfjlbkpj8nYSBWs6yMEOfBEEs9srPXFz4ru4+xEVXSu1iApgM8IuQ==", "2cc5189d-f6ea-4f68-85d1-a20e4ed99910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d8b464-04b9-41c0-b1ce-8826fc4d94fb", "AQAAAAEAACcQAAAAEPMbBspljISUBq5jOjqm7XU0/i3F7ENoOl0uyAC0WcY44E5oBGnOrZHT9/gGiPqUSg==", "91dd246f-d439-412c-996f-d109523856ec" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 3, 11, 31, 27, 472, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Active" },
                    { 2, "Complete" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_StatusId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses");

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "OrderStatuses",
                newName: "OrderStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1259a89-da2c-413d-94b9-fa5860faa017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43abf004-c67d-4051-91e1-e0fc9b557797", "AQAAAAEAACcQAAAAEJ6e/Mvdrz8Svz8pLpZNubKEwq2hboGDXX+Ciq0J/m53PhV7gNvQqoWxieRDK1L4Hw==", "a0e7ed4b-ef88-43c6-b44d-e42c31ce1647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e513e138-aaa3-4f35-85ec-787109b086bb", "AQAAAAEAACcQAAAAEHujl27cTpk4ynbj+8MM3HdcwkIKP/lr8zSYjL46KJDICKGp/xibkT6h7E1YNU9A3w==", "77abb47e-e780-4d49-8df8-5de15b24e2d3" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 8, 1, 23, 7, 44, 982, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatus_StatusId",
                table: "Orders",
                column: "StatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
