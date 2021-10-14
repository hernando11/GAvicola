using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sugerencia_FechaInicial",
                table: "GSugerencias",
                newName: "FechaInicialS");

            migrationBuilder.RenameColumn(
                name: "FechaInicial",
                table: "GSugerencias",
                newName: "FechaInicialD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaInicialS",
                table: "GSugerencias",
                newName: "Sugerencia_FechaInicial");

            migrationBuilder.RenameColumn(
                name: "FechaInicialD",
                table: "GSugerencias",
                newName: "FechaInicial");
        }
    }
}
