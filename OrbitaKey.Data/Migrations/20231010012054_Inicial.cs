using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrbitaKey.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8");

            migrationBuilder.CreateTable(
                name: "aux_cep",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cidade = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Bairro = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Logradouro = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    CEP = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    cMun = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    cUF = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aux_cep", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "aux_cest",
                columns: table => new
                {
                    Segmento = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    CEST = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    NCM = table.Column<int>(type: "int(11)", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "aux_codigomunicipios",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "aux_ibpt",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    ex = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    tipo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    descricao = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    nacionalfederal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    importadosfederal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    estadual = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    municipal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    vigenciainicio = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    vigenciafim = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    chave = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    versao = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    fonte = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "aux_ncm",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int(10)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "backup",
                columns: table => new
                {
                    idbackup = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Maquina = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataInicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataFim = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idbackup);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "bi_pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    CNPJ = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "CNPJ do cliente", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    RepresentanteId = table.Column<int>(type: "int", maxLength: 45, nullable: false, comment: "Id do representante que atende o cliente"),
                    Modelo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "Modelo da nota", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", maxLength: 45, nullable: false, comment: "Valor total da aputação"),
                    Quantidade = table.Column<int>(type: "int(11)", nullable: false, comment: "QUantidade de paamentos no apurados no lançamento"),
                    TipoSefaz = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, comment: "Descrição da forma de pagamento na sefaz", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Data em que o laçamento foi criado"),
                    DataCompetencia = table.Column<DateTime>(type: "datetime", nullable: false, comment: "Mês a que se refere a movimentação"),
                    QuantidadeNotas = table.Column<int>(type: "int(11)", nullable: false, comment: "Quantidade de notas que tem em cada lançamento"),
                    Caixa = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValueSql: "'1'", comment: "Para uso em casos que a venda fiscal não é lançada no caixa"),
                    Tef = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValueSql: "'0'"),
                    Descricao = table.Column<string>(type: "text", nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bi_pagamentos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "bi_vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    CNPJ = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    RepresentanteId = table.Column<int>(type: "int(11)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataCompetencia = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modelo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Quantidade = table.Column<int>(type: "int(11)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(13,2)", precision: 13, scale: 2, nullable: true, defaultValueSql: "'0.00'"),
                    FiscalCaixa = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'", comment: "define se a venda fiscal é lançada no caixa")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bi_vendas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "certificados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cnpj = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Certificado = table.Column<byte[]>(type: "longblob", nullable: true),
                    Vencimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Emissao = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: true),
                    Chave = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Razao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Senha = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificados", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<int>(type: "int(11)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Razao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cnpj = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IEstadual = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    Excluido = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Regime = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'Simples'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdContato = table.Column<int>(type: "int(11)", nullable: true),
                    IdEndereco = table.Column<int>(type: "int(11)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Responsavel = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TaxaInstalacao = table.Column<decimal>(type: "decimal(13,2)", precision: 13, scale: 2, nullable: true),
                    Mensalidade = table.Column<decimal>(type: "decimal(13,2)", precision: 13, scale: 2, nullable: true),
                    Preposto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: true),
                    DataInstalacao = table.Column<DateOnly>(type: "date", nullable: true),
                    ContratoAssinado = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    Atualizacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdUsuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.IdCliente);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "clientelog",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<int>(type: "int(11)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Razao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cnpj = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IEstadual = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'"),
                    Excluido = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Regime = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'Simples'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdContato = table.Column<int>(type: "int(11)", nullable: true),
                    IdEndereco = table.Column<int>(type: "int(11)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Responsavel = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TaxaInstalacao = table.Column<decimal>(type: "decimal(13,2)", precision: 13, scale: 2, nullable: true),
                    Mensalidade = table.Column<decimal>(type: "decimal(13,2)", precision: 13, scale: 2, nullable: true),
                    Preposto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: true),
                    DataInstalacao = table.Column<DateOnly>(type: "date", nullable: true),
                    ContratoAssinado = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    IdUsuario = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.IdCliente);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "colaborador",
                columns: table => new
                {
                    idcolaborador = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Sobrenome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Funcao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: true),
                    Ativo = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'1'"),
                    DataDesligamento = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcolaborador);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "config",
                columns: table => new
                {
                    idconfig = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    contagemDocumento = table.Column<int>(type: "int(11)", nullable: false),
                    DiretorioBackup = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idconfig);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "contato",
                columns: table => new
                {
                    idcontato = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    email2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Telefone = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Telefone2 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Celular = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Celular2 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ramal = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    NomeRepresentante = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    TelefoneRepresentante = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    excluido = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    Site = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcontato);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEndereco = table.Column<int>(type: "int(11)", nullable: false),
                    IdContato = table.Column<int>(type: "int(11)", nullable: false),
                    Fantasia = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Razao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IEstadual = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cnpj = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ativo = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'1'"),
                    Excluido = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Responsavel = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Observacao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    LogoAdm = table.Column<byte[]>(type: "longblob", nullable: true),
                    LogoPdv = table.Column<byte[]>(type: "longblob", nullable: true),
                    FundoAdm = table.Column<byte[]>(type: "longblob", nullable: true),
                    Cor1 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cor2 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cor3 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    SchemaPadrao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, defaultValueSql: "'orbitadb'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    SenhaPadrao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, defaultValueSql: "'dbakjx25642'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.IdEmpresa);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    idendereco = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cidade = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Logradouro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Complemento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Numero = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cep = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    CodigoMunicipio = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Bairro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Excluido = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'0'", collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Longitude = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Latitude = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idendereco);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "licenca",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoLicenca = table.Column<int>(type: "int(11)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: true),
                    IdCliente = table.Column<uint>(type: "int(11) unsigned", nullable: true),
                    DataAtivacao = table.Column<DateOnly>(type: "date", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    BloqueioAutomatico = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    BloqueioManual = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    BloqueioAdm = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'0'"),
                    BloqueioPdv = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'0'"),
                    MotivoBloqueio = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataVencimento = table.Column<DateOnly>(type: "date", nullable: true),
                    Ativa = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'"),
                    Pdv = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'"),
                    Financeiro = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'"),
                    Nfe = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'"),
                    RelatorioVendas = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'0'"),
                    RemessaMes = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'0'"),
                    Chave = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataDesativacao = table.Column<DateOnly>(type: "date", nullable: true),
                    IdUsuarioAtivacao = table.Column<int>(type: "int(11)", nullable: true),
                    IdUsuarioDesativacao = table.Column<int>(type: "int(11)", nullable: true),
                    Temporaria = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'0'"),
                    UsuarioBloqueio = table.Column<int>(type: "int(11)", nullable: true),
                    DataBloqueio = table.Column<DateTime>(type: "datetime", nullable: true),
                    Plano = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'1'"),
                    Comanda = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'1'"),
                    VendaExterna = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'1'"),
                    Maquinas = table.Column<int>(type: "int(3)", nullable: true, defaultValueSql: "'5'"),
                    OS = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'"),
                    NFCe = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'"),
                    RelatorioEntradas = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licenca", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "maquinas",
                columns: table => new
                {
                    idmaquina = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Mac = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Ip = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    PrimeiroAcesso = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UltimoAcesso = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Sistema = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Versao = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Usuario = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Cnpj = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    AnyDesk = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    AnyDeskSenha = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    TeamViewer = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    TeamViewerSenha = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: true),
                    Chave = table.Column<string>(type: "text", nullable: true, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idmaquina);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "suporte",
                columns: table => new
                {
                    idsuporte = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: true),
                    IdCliente = table.Column<int>(type: "int(11)", nullable: true),
                    IdColaborador = table.Column<int>(type: "int(11)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Celular = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Celular2 = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Setor = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Tipo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Prioridade = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    HoraMarcada = table.Column<DateTime>(type: "datetime", nullable: true),
                    FormaAtendimento = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Solicitante = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    CodigoAcesso = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Detalhamento = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataCriacao = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Iniciado = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    Finalizado = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    InicioAtendimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    SenhaAcesso = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idsuporte);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "suporte_video",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    link = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false, collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1"),
                    Avaliacao = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true, defaultValueSql: "'0.00'"),
                    Avaliacoes = table.Column<int>(type: "int(6)", nullable: true),
                    Ordem = table.Column<int>(type: "int(3)", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suporte_video", x => x.id);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    senha = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ativo = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'1'"),
                    Sobrenome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Excluido = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: false),
                    UltimoAcesso = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Maquina = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Logado = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    Perfil = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Versao = table.Column<string>(type: "text", nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "versao",
                columns: table => new
                {
                    idversao = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Mac = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ip = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    DataUltimoAcesso = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataPrimeiroAcesso = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Sistema = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    vSistema = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idversao);
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fantasia = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Razao = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Cnpj = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    IEstadual = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    Ativo = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'1'"),
                    Excluido = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IdEndereco = table.Column<int>(type: "int(11)", nullable: false),
                    IdContato = table.Column<int>(type: "int(11)", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idFornecedor);
                    table.ForeignKey(
                        name: "fk_fornecedor_contato1",
                        column: x => x.IdContato,
                        principalTable: "contato",
                        principalColumn: "idcontato");
                    table.ForeignKey(
                        name: "fk_fornecedor_endereco1",
                        column: x => x.IdEndereco,
                        principalTable: "endereco",
                        principalColumn: "idendereco");
                })
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("Relational:Collation", "utf8_general_ci");

            migrationBuilder.CreateIndex(
                name: "fk_empresa_contato1_idx",
                table: "empresa",
                column: "IdContato");

            migrationBuilder.CreateIndex(
                name: "fk_empresa_endereco1_idx",
                table: "empresa",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "fk_fornecedor_contato1_idx",
                table: "fornecedor",
                column: "IdContato");

            migrationBuilder.CreateIndex(
                name: "fk_fornecedor_endereco1_idx",
                table: "fornecedor",
                column: "IdEndereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aux_cep");

            migrationBuilder.DropTable(
                name: "aux_cest");

            migrationBuilder.DropTable(
                name: "aux_codigomunicipios");

            migrationBuilder.DropTable(
                name: "aux_ibpt");

            migrationBuilder.DropTable(
                name: "aux_ncm");

            migrationBuilder.DropTable(
                name: "backup");

            migrationBuilder.DropTable(
                name: "bi_pagamentos");

            migrationBuilder.DropTable(
                name: "bi_vendas");

            migrationBuilder.DropTable(
                name: "certificados");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "clientelog");

            migrationBuilder.DropTable(
                name: "colaborador");

            migrationBuilder.DropTable(
                name: "config");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "licenca");

            migrationBuilder.DropTable(
                name: "maquinas");

            migrationBuilder.DropTable(
                name: "suporte");

            migrationBuilder.DropTable(
                name: "suporte_video");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "versao");

            migrationBuilder.DropTable(
                name: "contato");

            migrationBuilder.DropTable(
                name: "endereco");
        }
    }
}
