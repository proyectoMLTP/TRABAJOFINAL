using Microsoft.EntityFrameworkCore.Migrations;

namespace TRABAJOFINAL.Migrations
{
    public partial class quitandonombrealertas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Alertas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Alertas",
                nullable: true);
        }
    }
}
