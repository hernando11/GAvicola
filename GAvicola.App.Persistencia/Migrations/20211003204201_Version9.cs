using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Veterinario_TajetaProfesional",
                table: "Personas",
                newName: "TajetaProfesionalV");

            migrationBuilder.RenameColumn(
                name: "TajetaProfesional",
                table: "Personas",
                newName: "TajetaProfesionalO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TajetaProfesionalV",
                table: "Personas",
                newName: "Veterinario_TajetaProfesional");

            migrationBuilder.RenameColumn(
                name: "TajetaProfesionalO",
                table: "Personas",
                newName: "TajetaProfesional");
        }
    }
}
