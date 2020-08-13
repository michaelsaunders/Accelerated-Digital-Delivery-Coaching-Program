using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class UpdateEPICs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Epic",
                columns: table => new
                {
                    EpicID = table.Column<Guid>(nullable: false),
                    EpicName = table.Column<string>(nullable: true),
                    CustomerIdentifierID = table.Column<string>(nullable: true),
                    EstimatedStoryPoints = table.Column<int>(nullable: false),
                    ActualStoryPoints = table.Column<int>(nullable: false),
                    TeamofTeamID = table.Column<Guid>(nullable: true),
                    TeamID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epic", x => x.EpicID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Epic");
        }
    }
}
