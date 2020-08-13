using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class AddedIncrementDeliveredVelocity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IncrementCommittedVelocity",
                table: "TeamOfTeamIteration",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "IncrementDeliveredVelocity",
                table: "TeamOfTeamIteration",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncrementCommittedVelocity",
                table: "TeamOfTeamIteration");

            migrationBuilder.DropColumn(
                name: "IncrementDeliveredVelocity",
                table: "TeamOfTeamIteration");
        }
    }
}
