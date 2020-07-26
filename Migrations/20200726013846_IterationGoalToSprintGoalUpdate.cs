using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class IterationGoalToSprintGoalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IterationGoalID",
                table: "Iterations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Iterations_IterationGoalID",
                table: "Iterations",
                column: "IterationGoalID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Iterations_IterationGoal_IterationGoalID",
                table: "Iterations",
                column: "IterationGoalID",
                principalTable: "IterationGoal",
                principalColumn: "IterationGoalID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iterations_IterationGoal_IterationGoalID",
                table: "Iterations");

            migrationBuilder.DropIndex(
                name: "IX_Iterations_IterationGoalID",
                table: "Iterations");

            migrationBuilder.DropColumn(
                name: "IterationGoalID",
                table: "Iterations");
        }
    }
}
