using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class Coaches2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CoachID",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    CoachID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.CoachID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CoachID",
                table: "Persons",
                column: "CoachID");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Coach_CoachID",
                table: "Persons",
                column: "CoachID",
                principalTable: "Coach",
                principalColumn: "CoachID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Coach_CoachID",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CoachID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CoachID",
                table: "Persons");
        }
    }
}
