using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrbitaKey.Data.Migrations
{
    public partial class AjusteCanclamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CanceladoId",
                table: "Financeiro",
                newName: "Cancelado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cancelado",
                table: "Financeiro",
                newName: "CanceladoId");
        }
    }
}
