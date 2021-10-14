using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sugenrecia",
                table: "GSugerencias",
                newName: "Sugerencia");

            migrationBuilder.RenameColumn(
                name: "FechaSugenrecia",
                table: "GSugerencias",
                newName: "FechaSugerencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sugerencia",
                table: "GSugerencias",
                newName: "Sugenrecia");

            migrationBuilder.RenameColumn(
                name: "FechaSugerencia",
                table: "GSugerencias",
                newName: "FechaSugenrecia");
        }
    }
}
