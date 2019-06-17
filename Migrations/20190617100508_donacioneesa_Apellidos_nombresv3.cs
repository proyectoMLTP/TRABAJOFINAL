using Microsoft.EntityFrameworkCore.Migrations;

namespace TRABAJOFINAL.Migrations
{
    public partial class donacioneesa_Apellidos_nombresv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_AspNetUsers_UsuarioId",
                table: "Donaciones");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_UsuarioId",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "Apodo",
                table: "Donaciones");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Donaciones",
                newName: "Nombre");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Donaciones",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Donaciones",
                newName: "UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Donaciones",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apodo",
                table: "Donaciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_UsuarioId",
                table: "Donaciones",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_AspNetUsers_UsuarioId",
                table: "Donaciones",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
