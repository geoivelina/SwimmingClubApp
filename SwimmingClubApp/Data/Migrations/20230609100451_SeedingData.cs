using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Coaches",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "Email", "FullName", "Image", "JobPosition", "SquadId" },
                values: new object[,]
                {
                    { 1, "e.harris@mail.com", "Emma Harris", "https://tse4.mm.bing.net/th?id=OIP.6Ue-IdphavC3AxW8adedCAHaHa&pid=Api", "Coach", 1 },
                    { 2, "sam.smith@mail.com", "Sam Smith", "https://tse2.mm.bing.net/th?id=OIP.5cla8U39A4eNC8xzRCMDiQHaHa&pid=Api", "Junior Head Coach", 2 },
                    { 3, "justin.robin@mail.com", "Justin Robin", "https://tse2.mm.bing.net/th?id=OIP.5cla8U39A4eNC8xzRCMDiQHaHa&pid=Api", "Senior Swimming Instructor", 2 },
                    { 4, "cindy.somerton@mail.com", "Cindy Somerton", "https://tse4.mm.bing.net/th?id=OIP.6Ue-IdphavC3AxW8adedCAHaHa&pid=Api", "General Manager", 2 }
                });

            migrationBuilder.InsertData(
                table: "Newses",
                columns: new[] { "Id", "DateCreated", "Desctioption", "Image", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2262), "Here are your athletes for the month of January.Begginer 1: Levi Miller & Lena YangBegginer 2: Leah Jin & Alex XiaoBegginer 3: Karim Belal & Angela XiaoFithness 1: Austin Ouyang & Ava SennFithness 2: Brock Sever & Lucy BojrabFithness 3: Flynn Keyser & Ella HarrityProfessional 1: Adam Smith & Maggie WelshProfessional 2: Chis Martin & Nina SimoneProfessionals 3: Sam Burg & Ava Max", "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg", "January Swimmers of the Month" },
                    { 2, new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2309), "Here are your athletes for the month of February.Begginer 1: Levi Miller & Lena YangBegginer 2: Leah Jin & Alex XiaoBegginer 3: Karim Belal & Angela XiaoFithness 1: Austin Ouyang & Ava SennFithness 2: Brock Sever & Lucy BojrabFithness 3: Flynn Keyser & Ella HarrityProfessional 1: Adam Smith & Maggie WelshProfessional 2: Chis Martin & Nina SimoneProfessionals 3: Sam Burg & Ava Max", "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg", "February Swimmers of the Month" },
                    { 3, new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2314), "Join us on 24th of July 2023 in SemmerSet Venue at 20:00 h for our Anual Fundrising gathering. You can meet our athleats, their coaches and see their result. Tickets for the event could be found at the receprion desk. If you need more information or would like to join organisation team contact the coordinators: event@mail.com. ", "https://s3.amazonaws.com/images.ecwid.com/images/16075414/1126948529.jpg", "Anual Fundrising Event." },
                    { 4, new DateTime(2023, 6, 9, 13, 4, 50, 607, DateTimeKind.Local).AddTicks(2319), "Here are your athletes for the month of March.Begginer 1: Levi Miller & Lena YangBegginer 2: Leah Jin & Alex XiaoBegginer 3: Karim Belal & Angela XiaoFithness 1: Austin Ouyang & Ava SennFithness 2:  Sever & Lucy BojrabFithness 3: Flynn Keyser & Ella HarrityProfessional 1: Adam Smith & Maggie WelshProfessional 2: Chis Martin & Nina SimoneProfessionals 3: Sam Burg & Ava Max", "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg", "March Swimmers of the Month" }
                });

            migrationBuilder.InsertData(
                table: "Sponsors",
                columns: new[] { "Id", "Link", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "https://www.speedo.com/", "https://tse3.mm.bing.net/th?id=OIP.-89jNjevESq6UU7GNDD6ywHaER&pid=Api", "Speedo" },
                    { 2, "https://www.arenasport.com/en_uk/", "https://tse2.mm.bing.net/th?id=OIP.L9mMbV_HUGSUrCUZfDW8RQHaE-&pid=Api", "Arena" },
                    { 3, "https://www.finisswim.com/", "https://tse2.mm.bing.net/th?id=OIP.YyCM6JJqMvSDO_OtmAmCiwHaEo&pid=Api", "Finis" },
                    { 4, "https://www.zoggs.com/en_GB/", "https://tse1.mm.bing.net/th?id=OIP.CZ6BOVZa1BgrQKmQ7ojKoQHaDu&pid=Api", "Zoggs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Newses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Coaches",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
