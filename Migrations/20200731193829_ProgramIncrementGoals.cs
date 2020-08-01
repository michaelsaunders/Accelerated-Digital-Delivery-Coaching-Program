using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class ProgramIncrementGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramIncrementGoal",
                columns: table => new
                {
                    ProgramIncrementGoalID = table.Column<Guid>(nullable: false),
                    Goal = table.Column<string>(nullable: true),
                    Measure = table.Column<string>(nullable: true),
                    Specific = table.Column<bool>(nullable: false),
                    Measurable = table.Column<bool>(nullable: false),
                    Achievable = table.Column<bool>(nullable: false),
                    Realistic = table.Column<bool>(nullable: false),
                    Timebound = table.Column<bool>(nullable: false),
                    TiedToOKR = table.Column<bool>(nullable: false),
                    ProgramIncrementID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramIncrementGoal", x => x.ProgramIncrementGoalID);
                    table.ForeignKey(
                        name: "FK_ProgramIncrementGoal_ProgramIncrements_ProgramIncrementID",
                        column: x => x.ProgramIncrementID,
                        principalTable: "ProgramIncrements",
                        principalColumn: "ProgramIncrementID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramIncrementGoal_ProgramIncrementID",
                table: "ProgramIncrementGoal",
                column: "ProgramIncrementID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramIncrementGoal");
        }
    }
}
