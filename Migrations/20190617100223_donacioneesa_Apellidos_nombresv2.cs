using Microsoft.EntityFrameworkCore.Migrations;

namespace TRABAJOFINAL.Migrations
{
    public partial class donacioneesa_Apellidos_nombresv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApellidoNombre",
                table: "Donaciones",
                newName: "Apodo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apodo",
                table: "Donaciones",
                newName: "ApellidoNombre");
        }
    }
}
