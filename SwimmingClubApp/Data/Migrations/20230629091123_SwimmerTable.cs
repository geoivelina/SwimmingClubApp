using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SwimmerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Coaches",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "UserFullName",
                table: "AspNetUsers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Swimmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RelationshipToSwimmer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MedicalDatails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SwimmingExperience = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SquadId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swimmers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Desctioption" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 11, 23, 188, DateTimeKind.Local).AddTicks(3757), "Here are our athletes for the month of January. Begginer 1: Levi Miller & Lena Yang. Begginer 2: Leah Jin & Alex Xiao. Begginer 3: Karim Belal & Angela Xiao.  Fithness 1: Austin Ouyang & Ava Senn. Fithness 2: Brock Sever & Lucy Bojrab. 3: Flynn Keyser & Ella Harrity. Professional 1: Adam Smith & Maggie Welsh. Professional 2: Chis Martin & Nina Simone. Professionals 3: Sam Burg & Ava Max. " });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Desctioption" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 11, 23, 188, DateTimeKind.Local).AddTicks(3825), "Here are our athletes for the month of February. Begginer 1: Levi Miller & Lena Yang. Begginer 2: Leah Jin & Alex Xiao. Begginer 3: Karim Belal & Angela Xiao. Fithness 1: Austin Ouyang & Ava Senn. Fithness 2: Brock Sever & Lucy Bojrab. Fithness 3: Flynn Keyser & Ella Harrity. Professional 1: Adam Smith & Maggie Welsh. Professional 2: Chis Martin & Nina Simone. Professionals 3: Sam Burg & Ava Max. " });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Title" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 11, 23, 188, DateTimeKind.Local).AddTicks(3833), "Anual Fundrising Event" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Desctioption" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 11, 23, 188, DateTimeKind.Local).AddTicks(3844), "Here are our athletes for the month of March. Begginer 1: Levi Miller & Lena Yang. Begginer 2: Leah Jin & Alex Xiao. Begginer 3: Karim Belal & Angela Xiao. Fithness 1: Austin Ouyang & Ava Senn. Fithness 2:  Sever & Lucy Bojrab. Fithness 3: Flynn Keyser & Ella Harrity. Professional 1: Adam Smith & Maggie Welsh. Professional 2: Chis Martin & Nina Simone. Professionals 3: Sam Burg & Ava Max." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Swimmers");

            migrationBuilder.DropColumn(
                name: "UserFullName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Coaches",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Desctioption" },
                values: new object[] { new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2262), "Here are your athletes for the month of January.Begginer 1: Levi Miller & Lena YangBegginer 2: Leah Jin & Alex XiaoBegginer 3: Karim Belal & Angela XiaoFithness 1: Austin Ouyang & Ava SennFithness 2: Brock Sever & Lucy BojrabFithness 3: Flynn Keyser & Ella HarrityProfessional 1: Adam Smith & Maggie WelshProfessional 2: Chis Martin & Nina SimoneProfessionals 3: Sam Burg & Ava Max" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Desctioption" },
                values: new object[] { new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2309), "Here are your athletes for the month of February.Begginer 1: Levi Miller & Lena YangBegginer 2: Leah Jin & Alex XiaoBegginer 3: Karim Belal & Angela XiaoFithness 1: Austin Ouyang & Ava SennFithness 2: Brock Sever & Lucy BojrabFithness 3: Flynn Keyser & Ella HarrityProfessional 1: Adam Smith & Maggie WelshProfessional 2: Chis Martin & Nina SimoneProfessionals 3: Sam Burg & Ava Max" });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Title" },
                values: new object[] { new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2314), "Anual Fundrising Event." });

            migrationBuilder.UpdateData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Desctioption" },
                values: new object[] { new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2319), "Here are your athletes for the month of March.Begginer 1: Levi Miller & Lena YangBegginer 2: Leah Jin & Alex XiaoBegginer 3: Karim Belal & Angela XiaoFithness 1: Austin Ouyang & Ava SennFithness 2:  Sever & Lucy BojrabFithness 3: Flynn Keyser & Ella HarrityProfessional 1: Adam Smith & Maggie WelshProfessional 2: Chis Martin & Nina SimoneProfessionals 3: Sam Burg & Ava Max" });
        }
    }
}
