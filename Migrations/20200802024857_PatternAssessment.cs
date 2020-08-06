using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class PatternAssessment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PatternID",
                table: "Teams",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PatternName",
                table: "Patterns",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BriefDescription",
                table: "Patterns",
                maxLength: 160,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "InterestingSalesFacts",
                columns: table => new
                {
                    InterestingSalesFactsID = table.Column<Guid>(nullable: false),
                    Fact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestingSalesFacts", x => x.InterestingSalesFactsID);
                });

            migrationBuilder.CreateTable(
                name: "PatternAssessment",
                columns: table => new
                {
                    PatternAssessmentID = table.Column<Guid>(nullable: false),
                    TeamID = table.Column<long>(nullable: false),
                    PatternID = table.Column<Guid>(nullable: false),
                    Implemented = table.Column<bool>(nullable: false),
                    WithIntent = table.Column<bool>(nullable: false),
                    RatingOfAssessment = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    AssessmentDate = table.Column<DateTime>(nullable: false),
                    NextAssessmentDate = table.Column<DateTime>(nullable: false),
                    FollowUpCompleted = table.Column<bool>(nullable: false),
                    RecordActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternAssessment", x => x.PatternAssessmentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PatternID",
                table: "Teams",
                column: "PatternID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Patterns_PatternID",
                table: "Teams",
                column: "PatternID",
                principalTable: "Patterns",
                principalColumn: "PatternID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Patterns_PatternID",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "InterestingSalesFacts");

            migrationBuilder.DropTable(
                name: "PatternAssessment");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PatternID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PatternID",
                table: "Teams");

            migrationBuilder.AlterColumn<string>(
                name: "PatternName",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BriefDescription",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 160,
                oldNullable: true);
        }
    }
}
