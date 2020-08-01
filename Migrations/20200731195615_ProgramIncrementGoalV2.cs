using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class ProgramIncrementGoalV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AcheivedValue",
                table: "ProgramIncrementGoal",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BusinessValue",
                table: "ProgramIncrementGoal",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "CommittedGoal",
                table: "ProgramIncrementGoal",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "TeamID",
                table: "ProgramIncrementGoal",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcheivedValue",
                table: "ProgramIncrementGoal");

            migrationBuilder.DropColumn(
                name: "BusinessValue",
                table: "ProgramIncrementGoal");

            migrationBuilder.DropColumn(
                name: "CommittedGoal",
                table: "ProgramIncrementGoal");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "ProgramIncrementGoal");
        }
    }
}
