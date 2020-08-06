using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class AddedAssessment5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalAssessment",
                columns: table => new
                {
                    PersonalAssessmentID = table.Column<Guid>(nullable: false),
                    PersonID = table.Column<long>(nullable: false),
                    AssessmentName = table.Column<string>(nullable: true),
                    DateOfAssessment = table.Column<DateTime>(nullable: false),
                    AreaCoaching = table.Column<int>(nullable: false),
                    NotesForAssessment = table.Column<string>(nullable: true),
                    SummaryResult = table.Column<string>(nullable: true),
                    NextAsessmentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAssessment", x => x.PersonalAssessmentID);
                    table.ForeignKey(
                        name: "FK_PersonalAssessment_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAssessment_PersonID",
                table: "PersonalAssessment",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalAssessment");
        }
    }
}
