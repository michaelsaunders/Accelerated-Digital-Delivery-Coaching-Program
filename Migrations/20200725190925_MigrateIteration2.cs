using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class MigrateIteration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iterations_Teams_TeamID",
                table: "Iterations");

            migrationBuilder.DropColumn(
                name: "InterationNumber",
                table: "Iterations");

            migrationBuilder.AlterColumn<long>(
                name: "TeamID",
                table: "Iterations",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommittedWork",
                table: "Iterations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompletedWork",
                table: "Iterations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Iterations_Teams_TeamID",
                table: "Iterations",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iterations_Teams_TeamID",
                table: "Iterations");

            migrationBuilder.DropColumn(
                name: "CommittedWork",
                table: "Iterations");

            migrationBuilder.DropColumn(
                name: "CompletedWork",
                table: "Iterations");

            migrationBuilder.AlterColumn<long>(
                name: "TeamID",
                table: "Iterations",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<int>(
                name: "InterationNumber",
                table: "Iterations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Iterations_Teams_TeamID",
                table: "Iterations",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "TeamID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
