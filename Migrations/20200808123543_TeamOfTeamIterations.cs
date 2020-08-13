using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class TeamOfTeamIterations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeamOfTeamIterationID",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TeamOfTeamIterationID",
                table: "IterationGoal",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeamOfTeamIteration",
                columns: table => new
                {
                    TeamOfTeamIterationID = table.Column<Guid>(nullable: false),
                    TeamOfTeamID = table.Column<Guid>(nullable: false),
                    TeamOfTeamIterationName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StopDate = table.Column<DateTime>(nullable: false),
                    ProgramIncrementID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamOfTeamIteration", x => x.TeamOfTeamIterationID);
                    table.ForeignKey(
                        name: "FK_TeamOfTeamIteration_ProgramIncrements_ProgramIncrementID",
                        column: x => x.ProgramIncrementID,
                        principalTable: "ProgramIncrements",
                        principalColumn: "ProgramIncrementID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamOfTeamIterationID",
                table: "Teams",
                column: "TeamOfTeamIterationID");

            migrationBuilder.CreateIndex(
                name: "IX_IterationGoal_TeamOfTeamIterationID",
                table: "IterationGoal",
                column: "TeamOfTeamIterationID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamOfTeamIteration_ProgramIncrementID",
                table: "TeamOfTeamIteration",
                column: "ProgramIncrementID");

            migrationBuilder.AddForeignKey(
                name: "FK_IterationGoal_TeamOfTeamIteration_TeamOfTeamIterationID",
                table: "IterationGoal",
                column: "TeamOfTeamIterationID",
                principalTable: "TeamOfTeamIteration",
                principalColumn: "TeamOfTeamIterationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_TeamOfTeamIteration_TeamOfTeamIterationID",
                table: "Teams",
                column: "TeamOfTeamIterationID",
                principalTable: "TeamOfTeamIteration",
                principalColumn: "TeamOfTeamIterationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IterationGoal_TeamOfTeamIteration_TeamOfTeamIterationID",
                table: "IterationGoal");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_TeamOfTeamIteration_TeamOfTeamIterationID",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "TeamOfTeamIteration");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamOfTeamIterationID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_IterationGoal_TeamOfTeamIterationID",
                table: "IterationGoal");

            migrationBuilder.DropColumn(
                name: "TeamOfTeamIterationID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamOfTeamIterationID",
                table: "IterationGoal");
        }
    }
}
