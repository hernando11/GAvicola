using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOperario",
                table: "Galpones");

            migrationBuilder.AddColumn<int>(
                name: "OperarioId",
                table: "Galpones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Galpones_OperarioId",
                table: "Galpones",
                column: "OperarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galpones_Personas_OperarioId",
                table: "Galpones",
                column: "OperarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galpones_Personas_OperarioId",
                table: "Galpones");

            migrationBuilder.DropIndex(
                name: "IX_Galpones_OperarioId",
                table: "Galpones");

            migrationBuilder.DropColumn(
                name: "OperarioId",
                table: "Galpones");

            migrationBuilder.AddColumn<int>(
                name: "IdOperario",
                table: "Galpones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
