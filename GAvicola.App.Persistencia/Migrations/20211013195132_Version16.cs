using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnostico",
                table: "GSugerencias");

            migrationBuilder.DropColumn(
                name: "FechaDiagnostico",
                table: "GSugerencias");

            migrationBuilder.DropColumn(
                name: "Sugerencia",
                table: "GSugerencias");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "GSugerencias",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "FechaSugerencia",
                table: "GSugerencias",
                newName: "Fecha");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "GSugerencias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "GSugerencias");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "GSugerencias",
                newName: "FechaSugerencia");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "GSugerencias",
                newName: "tipo");

            migrationBuilder.AddColumn<string>(
                name: "Diagnostico",
                table: "GSugerencias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDiagnostico",
                table: "GSugerencias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Sugerencia",
                table: "GSugerencias",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
