using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class TeamOfTeamIterationYesterdaysWeather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IterationGoal_TeamOfTeamIteration_TeamOfTeamIterationID",
                table: "IterationGoal");

            migrationBuilder.DropIndex(
                name: "IX_IterationGoal_TeamOfTeamIterationID",
                table: "IterationGoal");

            migrationBuilder.DropColumn(
                name: "TeamOfTeamIterationID",
                table: "IterationGoal");

            migrationBuilder.AddColumn<long>(
                name: "YesterdaysWeather",
                table: "TeamOfTeamIteration",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TeamOfTeamIteration_TeamOfTeamID",
                table: "TeamOfTeamIteration",
                column: "TeamOfTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamOfTeamIteration_TeamOfTeams_TeamOfTeamID",
                table: "TeamOfTeamIteration",
                column: "TeamOfTeamID",
                principalTable: "TeamOfTeams",
                principalColumn: "TeamOfTeamID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamOfTeamIteration_TeamOfTeams_TeamOfTeamID",
                table: "TeamOfTeamIteration");

            migrationBuilder.DropIndex(
                name: "IX_TeamOfTeamIteration_TeamOfTeamID",
                table: "TeamOfTeamIteration");

            migrationBuilder.DropColumn(
                name: "YesterdaysWeather",
                table: "TeamOfTeamIteration");

            migrationBuilder.AddColumn<Guid>(
                name: "TeamOfTeamIterationID",
                table: "IterationGoal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IterationGoal_TeamOfTeamIterationID",
                table: "IterationGoal",
                column: "TeamOfTeamIterationID");

            migrationBuilder.AddForeignKey(
                name: "FK_IterationGoal_TeamOfTeamIteration_TeamOfTeamIterationID",
                table: "IterationGoal",
                column: "TeamOfTeamIterationID",
                principalTable: "TeamOfTeamIteration",
                principalColumn: "TeamOfTeamIterationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
