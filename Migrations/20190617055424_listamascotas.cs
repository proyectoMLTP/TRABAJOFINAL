using Microsoft.EntityFrameworkCore.Migrations;

namespace TRABAJOFINAL.Migrations
{
    public partial class listamascotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "usuarioId",
                table: "Mascota",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_usuarioId",
                table: "Mascota",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_AspNetUsers_usuarioId",
                table: "Mascota",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_AspNetUsers_usuarioId",
                table: "Mascota");

            migrationBuilder.DropIndex(
                name: "IX_Mascota_usuarioId",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Mascota");
        }
    }
}
