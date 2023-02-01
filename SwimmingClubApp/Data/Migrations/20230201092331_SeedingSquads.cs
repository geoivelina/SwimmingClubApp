using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SeedingSquads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "Id", "SquadName" },
                values: new object[] { 1, "Beginner" });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "Id", "SquadName" },
                values: new object[] { 2, "Professional" });

            migrationBuilder.InsertData(
                table: "Squads",
                columns: new[] { "Id", "SquadName" },
                values: new object[] { 3, "Fithness" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Squads",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
