using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OKRs",
                columns: table => new
                {
                    OkrID = table.Column<Guid>(nullable: false),
                    Objective = table.Column<string>(nullable: true),
                    Measure1 = table.Column<string>(nullable: true),
                    Measure2 = table.Column<string>(nullable: true),
                    Measure3 = table.Column<string>(nullable: true),
                    Measure4 = table.Column<string>(nullable: true),
                    Measure5 = table.Column<string>(nullable: true),
                    MetricMeasure1 = table.Column<long>(nullable: false),
                    MetricMeasure2 = table.Column<long>(nullable: false),
                    MetricMeasure3 = table.Column<long>(nullable: false),
                    MetricMeasure4 = table.Column<long>(nullable: false),
                    MetricMeasure5 = table.Column<long>(nullable: false),
                    ConfidenceScoreMeasure1 = table.Column<int>(nullable: false),
                    ConfidenceScoreMeasure2 = table.Column<int>(nullable: false),
                    ConfidenceScoreMeasure3 = table.Column<int>(nullable: false),
                    ConfidenceScoreMeasure4 = table.Column<int>(nullable: false),
                    ConfidenceScoreMeasure5 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OKRs", x => x.OkrID);
                });

            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    PatternID = table.Column<Guid>(nullable: false),
                    PatternName = table.Column<string>(nullable: true),
                    InputToPattern = table.Column<string>(nullable: true),
                    OutToPattern = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.PatternID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "ProductBacklog",
                columns: table => new
                {
                    ProductBacklogID = table.Column<Guid>(nullable: false),
                    ProductBacklogName = table.Column<string>(nullable: true),
                    ProductDefintionOfDone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBacklog", x => x.ProductBacklogID);
                });

            migrationBuilder.CreateTable(
                name: "Sequences",
                columns: table => new
                {
                    SequenceID = table.Column<Guid>(nullable: false),
                    SequenceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sequences", x => x.SequenceID);
                });

            migrationBuilder.CreateTable(
                name: "TaskItem",
                columns: table => new
                {
                    TaskItemID = table.Column<Guid>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    Occurence = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItem", x => x.TaskItemID);
                });

            migrationBuilder.CreateTable(
                name: "TeamOfTeams",
                columns: table => new
                {
                    TeamOfTeamID = table.Column<Guid>(nullable: false),
                    TeamOfTeamsName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamOfTeams", x => x.TeamOfTeamID);
                });

            migrationBuilder.CreateTable(
                name: "TeamSequences",
                columns: table => new
                {
                    TeamSequenceID = table.Column<Guid>(nullable: false),
                    TeamSequenceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamSequences", x => x.TeamSequenceID);
                });

            migrationBuilder.CreateTable(
                name: "TeamSprint",
                columns: table => new
                {
                    TeamSprintID = table.Column<Guid>(nullable: false),
                    SprintID = table.Column<Guid>(nullable: false),
                    TeamID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamSprint", x => x.TeamSprintID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    YesterdaysWeather = table.Column<int>(nullable: false),
                    LastYesterdaysWeatherUpdate = table.Column<DateTime>(nullable: false),
                    TeamLeadPersonID = table.Column<long>(nullable: true),
                    TeamCoachPersonID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_Persons_TeamCoachPersonID",
                        column: x => x.TeamCoachPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Persons_TeamLeadPersonID",
                        column: x => x.TeamLeadPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductBacklogItem",
                columns: table => new
                {
                    ProductBacklogItemId = table.Column<Guid>(nullable: false),
                    ProductBacklogItemName = table.Column<string>(nullable: true),
                    AcceptanceCriteria = table.Column<string>(nullable: true),
                    ComparativePoints = table.Column<int>(nullable: false),
                    ProductBacklogId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBacklogItem", x => x.ProductBacklogItemId);
                    table.ForeignKey(
                        name: "FK_ProductBacklogItem_ProductBacklog_ProductBacklogId",
                        column: x => x.ProductBacklogId,
                        principalTable: "ProductBacklog",
                        principalColumn: "ProductBacklogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramIncrements",
                columns: table => new
                {
                    ProgramIncrementID = table.Column<Guid>(nullable: false),
                    IncrementID = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    TeamOfTeamsTeamOfTeamID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramIncrements", x => x.ProgramIncrementID);
                    table.ForeignKey(
                        name: "FK_ProgramIncrements_TeamOfTeams_TeamOfTeamsTeamOfTeamID",
                        column: x => x.TeamOfTeamsTeamOfTeamID,
                        principalTable: "TeamOfTeams",
                        principalColumn: "TeamOfTeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Iterations",
                columns: table => new
                {
                    IterationID = table.Column<Guid>(nullable: false),
                    IterationName = table.Column<string>(nullable: true),
                    InterationNumber = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StopDate = table.Column<DateTime>(nullable: false),
                    ProgramIncrementID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iterations", x => x.IterationID);
                    table.ForeignKey(
                        name: "FK_Iterations_ProgramIncrements_ProgramIncrementID",
                        column: x => x.ProgramIncrementID,
                        principalTable: "ProgramIncrements",
                        principalColumn: "ProgramIncrementID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iterations_ProgramIncrementID",
                table: "Iterations",
                column: "ProgramIncrementID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBacklogItem_ProductBacklogId",
                table: "ProductBacklogItem",
                column: "ProductBacklogId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramIncrements_TeamOfTeamsTeamOfTeamID",
                table: "ProgramIncrements",
                column: "TeamOfTeamsTeamOfTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamCoachPersonID",
                table: "Teams",
                column: "TeamCoachPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamLeadPersonID",
                table: "Teams",
                column: "TeamLeadPersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iterations");

            migrationBuilder.DropTable(
                name: "OKRs");

            migrationBuilder.DropTable(
                name: "Patterns");

            migrationBuilder.DropTable(
                name: "ProductBacklogItem");

            migrationBuilder.DropTable(
                name: "Sequences");

            migrationBuilder.DropTable(
                name: "TaskItem");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TeamSequences");

            migrationBuilder.DropTable(
                name: "TeamSprint");

            migrationBuilder.DropTable(
                name: "ProgramIncrements");

            migrationBuilder.DropTable(
                name: "ProductBacklog");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "TeamOfTeams");
        }
    }
}
