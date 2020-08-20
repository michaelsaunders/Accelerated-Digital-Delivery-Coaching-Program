using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class ScrumMaster1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScrumMaster",
                columns: table => new
                {
                    ScrumMasterID = table.Column<Guid>(nullable: false),
                    PersonID = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TeamID = table.Column<long>(nullable: true),
                    Coaching = table.Column<string>(nullable: true),
                    Velocity = table.Column<bool>(nullable: false),
                    TeamHappiness = table.Column<bool>(nullable: false),
                    Quality = table.Column<bool>(nullable: false),
                    ProcessEfficiency = table.Column<bool>(nullable: false),
                    BusinessValuePerStoryPoint = table.Column<bool>(nullable: false),
                    NextAppointment = table.Column<DateTime>(nullable: false),
                    PersonalImprovement = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrumMaster", x => x.ScrumMasterID);
                    table.ForeignKey(
                        name: "FK_ScrumMaster_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScrumMaster_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScrumMaster_PersonID",
                table: "ScrumMaster",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_ScrumMaster_TeamID",
                table: "ScrumMaster",
                column: "TeamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScrumMaster");
        }
    }
}
