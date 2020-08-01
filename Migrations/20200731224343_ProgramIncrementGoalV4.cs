using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class ProgramIncrementGoalV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentStatus",
                table: "IterationGoal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FistOfFive",
                table: "IterationGoal",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentStatus",
                table: "IterationGoal");

            migrationBuilder.DropColumn(
                name: "FistOfFive",
                table: "IterationGoal");
        }
    }
}
