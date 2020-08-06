using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class PersonalAssessmentTemplateToPersonalAssessmentTemplate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "PersonalAssessmentTemplateID",
                table: "PersonalAssessment",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalAssessment_PersonalAssessmentTemplateID",
                table: "PersonalAssessment",
                column: "PersonalAssessmentTemplateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonalAssessment_PersonalAssessmentTemplateID",
                table: "PersonalAssessment");

            migrationBuilder.AlterColumn<Guid>(
                name: "PersonalAssessmentTemplateID",
                table: "PersonalAssessment",
                nullable: true,
                oldClrType: typeof(Guid));
        }
    }
}
