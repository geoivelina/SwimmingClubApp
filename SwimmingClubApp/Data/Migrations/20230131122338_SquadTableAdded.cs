using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class SquadTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Squad",
                table: "Coaches",
                newName: "SquadId");

            migrationBuilder.CreateTable(
                name: "CoachSquadViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SquadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachSquadViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoachSquadViewModel_Coaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coaches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Squads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SquadName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squads", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoachSquadViewModel_CoachId",
                table: "CoachSquadViewModel",
                column: "CoachId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachSquadViewModel");

            migrationBuilder.DropTable(
                name: "Squads");

            migrationBuilder.RenameColumn(
                name: "SquadId",
                table: "Coaches",
                newName: "Squad");
        }
    }
}
