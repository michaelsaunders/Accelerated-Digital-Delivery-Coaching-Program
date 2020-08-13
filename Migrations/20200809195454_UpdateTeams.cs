using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class UpdateTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TeamsTeamID",
                table: "ProgramIncrements",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProgramIncrements_TeamsTeamID",
                table: "ProgramIncrements",
                column: "TeamsTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramIncrements_Teams_TeamsTeamID",
                table: "ProgramIncrements",
                column: "TeamsTeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramIncrements_Teams_TeamsTeamID",
                table: "ProgramIncrements");

            migrationBuilder.DropIndex(
                name: "IX_ProgramIncrements_TeamsTeamID",
                table: "ProgramIncrements");

            migrationBuilder.DropColumn(
                name: "TeamsTeamID",
                table: "ProgramIncrements");
        }
    }
}
