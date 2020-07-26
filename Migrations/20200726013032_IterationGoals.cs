using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class IterationGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IterationGoal",
                columns: table => new
                {
                    IterationGoalID = table.Column<Guid>(nullable: false),
                    Goal = table.Column<string>(nullable: true),
                    Specific = table.Column<bool>(nullable: false),
                    Measurable = table.Column<bool>(nullable: false),
                    Achievable = table.Column<bool>(nullable: false),
                    Realistic = table.Column<bool>(nullable: false),
                    Timebound = table.Column<bool>(nullable: false),
                    TiedToOKR = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IterationGoal", x => x.IterationGoalID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IterationGoal");
        }
    }
}
