using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrbitaKey.Data.Migrations
{
    public partial class DiaVencimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MensalidadeDiaVencimento",
                table: "cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MensalidadeDiaVencimento",
                table: "cliente");
        }
    }
}
