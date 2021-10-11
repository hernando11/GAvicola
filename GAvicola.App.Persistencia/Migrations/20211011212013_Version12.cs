using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GAmbientes_Galpones_OperarioId",
                table: "GAmbientes");

            migrationBuilder.AddForeignKey(
                name: "FK_GAmbientes_Personas_OperarioId",
                table: "GAmbientes",
                column: "OperarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GAmbientes_Personas_OperarioId",
                table: "GAmbientes");

            migrationBuilder.AddForeignKey(
                name: "FK_GAmbientes_Galpones_OperarioId",
                table: "GAmbientes",
                column: "OperarioId",
                principalTable: "Galpones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
