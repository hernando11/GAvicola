using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdVeterinario",
                table: "Galpones");

            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "Galpones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Galpones_VeterinarioId",
                table: "Galpones",
                column: "VeterinarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galpones_Personas_VeterinarioId",
                table: "Galpones",
                column: "VeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galpones_Personas_VeterinarioId",
                table: "Galpones");

            migrationBuilder.DropIndex(
                name: "IX_Galpones_VeterinarioId",
                table: "Galpones");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "Galpones");

            migrationBuilder.AddColumn<int>(
                name: "IdVeterinario",
                table: "Galpones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
