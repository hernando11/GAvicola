using Microsoft.EntityFrameworkCore.Migrations;

namespace GAvicola.App.Persistencia.Migrations
{
    public partial class Version8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdGalpon",
                table: "GSugerencias");

            migrationBuilder.DropColumn(
                name: "IdVeterinario",
                table: "GSugerencias");

            migrationBuilder.DropColumn(
                name: "IdGalpon",
                table: "GAmbientes");

            migrationBuilder.DropColumn(
                name: "IdOperario",
                table: "GAmbientes");

            migrationBuilder.AddColumn<int>(
                name: "GalponId",
                table: "GSugerencias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "GSugerencias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GalponId",
                table: "GAmbientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperarioId",
                table: "GAmbientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GSugerencias_GalponId",
                table: "GSugerencias",
                column: "GalponId");

            migrationBuilder.CreateIndex(
                name: "IX_GSugerencias_VeterinarioId",
                table: "GSugerencias",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_GAmbientes_GalponId",
                table: "GAmbientes",
                column: "GalponId");

            migrationBuilder.CreateIndex(
                name: "IX_GAmbientes_OperarioId",
                table: "GAmbientes",
                column: "OperarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_GAmbientes_Galpones_GalponId",
                table: "GAmbientes",
                column: "GalponId",
                principalTable: "Galpones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GAmbientes_Galpones_OperarioId",
                table: "GAmbientes",
                column: "OperarioId",
                principalTable: "Galpones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GSugerencias_Galpones_GalponId",
                table: "GSugerencias",
                column: "GalponId",
                principalTable: "Galpones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GSugerencias_Personas_VeterinarioId",
                table: "GSugerencias",
                column: "VeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GAmbientes_Galpones_GalponId",
                table: "GAmbientes");

            migrationBuilder.DropForeignKey(
                name: "FK_GAmbientes_Galpones_OperarioId",
                table: "GAmbientes");

            migrationBuilder.DropForeignKey(
                name: "FK_GSugerencias_Galpones_GalponId",
                table: "GSugerencias");

            migrationBuilder.DropForeignKey(
                name: "FK_GSugerencias_Personas_VeterinarioId",
                table: "GSugerencias");

            migrationBuilder.DropIndex(
                name: "IX_GSugerencias_GalponId",
                table: "GSugerencias");

            migrationBuilder.DropIndex(
                name: "IX_GSugerencias_VeterinarioId",
                table: "GSugerencias");

            migrationBuilder.DropIndex(
                name: "IX_GAmbientes_GalponId",
                table: "GAmbientes");

            migrationBuilder.DropIndex(
                name: "IX_GAmbientes_OperarioId",
                table: "GAmbientes");

            migrationBuilder.DropColumn(
                name: "GalponId",
                table: "GSugerencias");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "GSugerencias");

            migrationBuilder.DropColumn(
                name: "GalponId",
                table: "GAmbientes");

            migrationBuilder.DropColumn(
                name: "OperarioId",
                table: "GAmbientes");

            migrationBuilder.AddColumn<int>(
                name: "IdGalpon",
                table: "GSugerencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVeterinario",
                table: "GSugerencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGalpon",
                table: "GAmbientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdOperario",
                table: "GAmbientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
