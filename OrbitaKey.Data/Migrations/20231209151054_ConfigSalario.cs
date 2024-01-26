using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrbitaKey.Data.Migrations
{
    public partial class ConfigSalario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SalarioAtual",
                table: "config",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalarioAtual",
                table: "config");
        }
    }
}
