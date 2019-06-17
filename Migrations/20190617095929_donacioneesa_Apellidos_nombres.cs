using Microsoft.EntityFrameworkCore.Migrations;

namespace TRABAJOFINAL.Migrations
{
    public partial class donacioneesa_Apellidos_nombres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Donaciones",
                newName: "ApellidoNombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApellidoNombre",
                table: "Donaciones",
                newName: "Nombre");
        }
    }
}
