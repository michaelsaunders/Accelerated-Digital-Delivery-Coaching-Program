using Microsoft.EntityFrameworkCore.Migrations;

namespace Accelerated_Digital_Delivery_Coaching_Program.Migrations
{
    public partial class ScrumMaster2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScrumMaster_Persons_PersonID",
                table: "ScrumMaster");

            migrationBuilder.AlterColumn<long>(
                name: "PersonID",
                table: "ScrumMaster",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumMaster_Persons_PersonID",
                table: "ScrumMaster",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScrumMaster_Persons_PersonID",
                table: "ScrumMaster");

            migrationBuilder.AlterColumn<long>(
                name: "PersonID",
                table: "ScrumMaster",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_ScrumMaster_Persons_PersonID",
                table: "ScrumMaster",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
