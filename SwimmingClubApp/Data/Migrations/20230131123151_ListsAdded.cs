using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingClubApp.Data.Migrations
{
    public partial class ListsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachSquadViewModel");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_SquadId",
                table: "Coaches",
                column: "SquadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_Squads_SquadId",
                table: "Coaches",
                column: "SquadId",
                principalTable: "Squads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_Squads_SquadId",
                table: "Coaches");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_SquadId",
                table: "Coaches");

            migrationBuilder.CreateTable(
                name: "CoachSquadViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    SquadName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CoachSquadViewModel_CoachId",
                table: "CoachSquadViewModel",
                column: "CoachId");
        }
    }
}
