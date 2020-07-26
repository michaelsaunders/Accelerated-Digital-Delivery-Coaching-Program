using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class MigrateIteration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TeamID",
                table: "Iterations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Iterations_TeamID",
                table: "Iterations",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Iterations_Teams_TeamID",
                table: "Iterations",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iterations_Teams_TeamID",
                table: "Iterations");

            migrationBuilder.DropIndex(
                name: "IX_Iterations_TeamID",
                table: "Iterations");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "Iterations");
        }
    }
}
