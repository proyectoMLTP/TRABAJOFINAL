using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TRABAJOFINAL.Migrations
{
    public partial class donacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_AspNetUsers_NombreId",
                table: "Donaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_Tipo_TipoId",
                table: "Donaciones");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropIndex(
                name: "IX_Donaciones_TipoId",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Donaciones");

            migrationBuilder.RenameColumn(
                name: "NombreId",
                table: "Donaciones",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Donaciones_NombreId",
                table: "Donaciones",
                newName: "IX_Donaciones_UsuarioId");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Donaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Donaciones",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_AspNetUsers_UsuarioId",
                table: "Donaciones",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donaciones_AspNetUsers_UsuarioId",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Donaciones");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Donaciones");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Donaciones",
                newName: "NombreId");

            migrationBuilder.RenameIndex(
                name: "IX_Donaciones_UsuarioId",
                table: "Donaciones",
                newName: "IX_Donaciones_NombreId");

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Donaciones",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donaciones_TipoId",
                table: "Donaciones",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_AspNetUsers_NombreId",
                table: "Donaciones",
                column: "NombreId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donaciones_Tipo_TipoId",
                table: "Donaciones",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
