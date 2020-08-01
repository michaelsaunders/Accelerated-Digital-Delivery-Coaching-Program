using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class ProgramIncrementGoalV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentStatus",
                table: "ProgramIncrementGoal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FistOfFive",
                table: "ProgramIncrementGoal",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentStatus",
                table: "ProgramIncrementGoal");

            migrationBuilder.DropColumn(
                name: "FistOfFive",
                table: "ProgramIncrementGoal");
        }
    }
}
