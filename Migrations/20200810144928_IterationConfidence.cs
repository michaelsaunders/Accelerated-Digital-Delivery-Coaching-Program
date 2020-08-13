using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class IterationConfidence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncrementConfidence",
                table: "TeamOfTeamIteration");

            migrationBuilder.AddColumn<int>(
                name: "IterationConfidence",
                table: "TeamOfTeamIteration",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IterationConfidence",
                table: "TeamOfTeamIteration");

            migrationBuilder.AddColumn<int>(
                name: "IncrementConfidence",
                table: "TeamOfTeamIteration",
                type: "int",
                nullable: true);
        }
    }
}
