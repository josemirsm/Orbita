using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrbitaKey.Data.Migrations
{
    public partial class TipoFinanceiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoDocumentoId",
                table: "Financeiro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoFinanceiro",
                table: "Financeiro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<sbyte>(
                name: "Tef",
                table: "bi_pagamentos",
                type: "tinyint(4)",
                nullable: true,
                defaultValueSql: "'0'",
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)",
                oldDefaultValueSql: "'0'");

            migrationBuilder.AlterColumn<sbyte>(
                name: "Caixa",
                table: "bi_pagamentos",
                type: "tinyint(4)",
                nullable: true,
                defaultValueSql: "'1'",
                comment: "Para uso em casos que a venda fiscal não é lançada no caixa",
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)",
                oldDefaultValueSql: "'1'",
                oldComment: "Para uso em casos que a venda fiscal não é lançada no caixa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoDocumentoId",
                table: "Financeiro");

            migrationBuilder.DropColumn(
                name: "TipoFinanceiro",
                table: "Financeiro");

            migrationBuilder.AlterColumn<sbyte>(
                name: "Tef",
                table: "bi_pagamentos",
                type: "tinyint(4)",
                nullable: false,
                defaultValueSql: "'0'",
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)",
                oldNullable: true,
                oldDefaultValueSql: "'0'");

            migrationBuilder.AlterColumn<sbyte>(
                name: "Caixa",
                table: "bi_pagamentos",
                type: "tinyint(4)",
                nullable: false,
                defaultValueSql: "'1'",
                comment: "Para uso em casos que a venda fiscal não é lançada no caixa",
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)",
                oldNullable: true,
                oldDefaultValueSql: "'1'",
                oldComment: "Para uso em casos que a venda fiscal não é lançada no caixa");
        }
    }
}
