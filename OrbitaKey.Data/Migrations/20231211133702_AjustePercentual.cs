using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrbitaKey.Data.Migrations
{
    public partial class AjustePercentual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MensalidadePercentual",
                table: "cliente",
                type: "decimal(13,4)",
                precision: 13,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "MensalidadePercentual",
                table: "cliente",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(13,4)",
                oldPrecision: 13,
                oldScale: 4);
        }
    }
}
