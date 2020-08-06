using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class PersonalAssessmentTemplate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalAssessmentTemplate",
                columns: table => new
                {
                    PersonalAssessmentTemplateID = table.Column<Guid>(nullable: false),
                    PersonalAssessmentTemplateName = table.Column<string>(nullable: true),
                    AreaOfCoaching = table.Column<int>(nullable: false),
                    LinkToPDF = table.Column<string>(nullable: true),
                    BriefDescription = table.Column<string>(nullable: true),
                    DetailedDescription = table.Column<string>(nullable: true),
                    LinkToImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalAssessmentTemplate", x => x.PersonalAssessmentTemplateID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalAssessmentTemplate");
        }
    }
}
