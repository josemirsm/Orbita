using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OrbitaKey.Data.Models;

namespace OrbitaKey.Data
{
    public partial class MyContext : DbContext
    {

        public static bool isMigration = true;
        public static string bancoHost { get; set; }
        public static string bancoPort { get; set; }
        public static string bancoUser { get; set; }
        public static string bancoSchema { get; set; }
        public static string bancoPass { get; set; }

        public MyContext()
        {

        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }

        public virtual DbSet<AuxCep> AuxCep { get; set; } = null!;
        public virtual DbSet<AuxCest> AuxCest { get; set; } = null!;
        public virtual DbSet<AuxCodigomunicipio> AuxCodigomunicipio { get; set; } = null!;
        public virtual DbSet<AuxIbpt> AuxIbpt { get; set; } = null!;
        public virtual DbSet<AuxNcm> AuxNcm { get; set; } = null!;
        public virtual DbSet<Backup> Backup { get; set; } = null!;
        public virtual DbSet<BiPagamento> BiPagamento { get; set; } = null!;
        public virtual DbSet<BiVenda> BiVendas { get; set; } = null!;
        public virtual DbSet<CashCliente> CashCliente { get; set; } = null!;
        public virtual DbSet<CashConfig> CashConfig { get; set; } = null!;
        public virtual DbSet<Certificado> Certificado { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<Clientelog> Clientelog { get; set; } = null!;
        public virtual DbSet<Colaborador> Colaborador { get; set; } = null!;
        public virtual DbSet<Config> Configs { get; set; } = null!;
        public virtual DbSet<Contato> Contato { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Endereco> Endereco { get; set; } = null!;
        public virtual DbSet<Financeiro> Financeiro { get; set; } = null!;
        public virtual DbSet<Fornecedor> Fornecedor { get; set; } = null!;
        public virtual DbSet<Licenca> Licenca { get; set; } = null!;
        public virtual DbSet<Maquina> Maquina { get; set; } = null!;
        public virtual DbSet<Suporte> Suporte { get; set; } = null!;
        public virtual DbSet<SuporteVideo> SuporteVideo { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
        public virtual DbSet<Versao> Versao { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {;

                if (isMigration)
                {
                    var con = $@"Server=66.94.109.0;
                    Database=hospedai_testedb;
                    User=hospedai_teste;
                    Password=@userTeste;
                    TreatTinyAsBoolean=true;
                    port=3306;CharSet=utf8;";

                    optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));
                }
                else 
                {
                    var con = $@"Server={bancoHost};
                    Database={bancoSchema};
                    User={bancoUser};
                    Password={bancoPass};
                    TreatTinyAsBoolean=true;
                    port={bancoPort};CharSet=utf8;";

                    optionsBuilder.UseMySql(con, ServerVersion.AutoDetect(con));
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<AuxCep>(entity =>
            {
                entity.ToTable("aux_cep");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Bairro).HasColumnType("text");

                entity.Property(e => e.CMun)
                    .HasMaxLength(11)
                    .HasColumnName("cMun");

                entity.Property(e => e.CUf)
                    .HasColumnType("int(11)")
                    .HasColumnName("cUF");

                entity.Property(e => e.Cep)
                    .HasMaxLength(45)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cidade).HasColumnType("text");

                entity.Property(e => e.Estado).HasColumnType("text");

                entity.Property(e => e.Logradouro).HasColumnType("text");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .HasColumnName("UF");
            });

            modelBuilder.Entity<AuxCest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aux_cest");

                entity.Property(e => e.Cest)
                    .HasColumnType("text")
                    .HasColumnName("CEST");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Ncm)
                    .HasColumnType("int(11)")
                    .HasColumnName("NCM");

                entity.Property(e => e.Segmento).HasColumnType("text");
            });

            modelBuilder.Entity<AuxCodigomunicipio>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PRIMARY");

                entity.ToTable("aux_codigomunicipios");

                entity.Property(e => e.Codigo).HasMaxLength(7);

                entity.Property(e => e.Nome).HasMaxLength(60);
            });

            modelBuilder.Entity<AuxIbpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aux_ibpt");

                entity.Property(e => e.Chave)
                    .HasMaxLength(255)
                    .HasColumnName("chave");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(255)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasColumnType("text")
                    .HasColumnName("descricao");

                entity.Property(e => e.Estadual)
                    .HasMaxLength(255)
                    .HasColumnName("estadual");

                entity.Property(e => e.Ex)
                    .HasMaxLength(255)
                    .HasColumnName("ex");

                entity.Property(e => e.Fonte)
                    .HasMaxLength(255)
                    .HasColumnName("fonte");

                entity.Property(e => e.Importadosfederal)
                    .HasMaxLength(255)
                    .HasColumnName("importadosfederal");

                entity.Property(e => e.Municipal)
                    .HasMaxLength(255)
                    .HasColumnName("municipal");

                entity.Property(e => e.Nacionalfederal)
                    .HasMaxLength(255)
                    .HasColumnName("nacionalfederal");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(255)
                    .HasColumnName("tipo");

                entity.Property(e => e.Versao)
                    .HasMaxLength(255)
                    .HasColumnName("versao");

                entity.Property(e => e.Vigenciafim)
                    .HasMaxLength(255)
                    .HasColumnName("vigenciafim");

                entity.Property(e => e.Vigenciainicio)
                    .HasMaxLength(255)
                    .HasColumnName("vigenciainicio");
            });

            modelBuilder.Entity<AuxNcm>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PRIMARY");

                entity.ToTable("aux_ncm");

                entity.Property(e => e.Codigo)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descricao).HasMaxLength(200);
            });

            modelBuilder.Entity<Backup>(entity =>
            {
                entity.HasKey(e => e.Idbackup)
                    .HasName("PRIMARY");

                entity.ToTable("backup");

                entity.Property(e => e.Idbackup)
                    .HasColumnType("int(11)")
                    .HasColumnName("idbackup");

                entity.Property(e => e.DataFim).HasColumnType("datetime");

                entity.Property(e => e.DataInicio).HasColumnType("datetime");

                entity.Property(e => e.Maquina).HasMaxLength(45);
            });

            modelBuilder.Entity<BiPagamento>(entity =>
            {
                entity.ToTable("bi_pagamentos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Caixa)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Para uso em casos que a venda fiscal não é lançada no caixa");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(45)
                    .HasColumnName("CNPJ")
                    .HasComment("CNPJ do cliente");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasComment("Data em que o laçamento foi criado");

                entity.Property(e => e.DataCompetencia)
                    .HasColumnType("datetime")
                    .HasComment("Mês a que se refere a movimentação");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Guid).HasMaxLength(45);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(45)
                    .HasComment("Modelo da nota");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("int(11)")
                    .HasComment("QUantidade de paamentos no apurados no lançamento");

                entity.Property(e => e.QuantidadeNotas)
                    .HasColumnType("int(11)")
                    .HasComment("Quantidade de notas que tem em cada lançamento");

                entity.Property(e => e.RepresentanteId)
                    .HasMaxLength(45)
                    .HasComment("Id do representante que atende o cliente");

                entity.Property(e => e.Tef)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TipoSefaz)
                    .HasMaxLength(45)
                    .HasComment("Descrição da forma de pagamento na sefaz");

                entity.Property(e => e.Valor)
                    .HasMaxLength(45)
                    .HasComment("Valor total da aputação");
            });

            modelBuilder.Entity<BiVenda>(entity =>
            {
                entity.ToTable("bi_vendas");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(45)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DataCompetencia).HasColumnType("datetime");

                entity.Property(e => e.FiscalCaixa)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("define se a venda fiscal é lançada no caixa");

                entity.Property(e => e.Guid).HasColumnType("text");

                entity.Property(e => e.Modelo).HasMaxLength(45);

                entity.Property(e => e.Quantidade).HasColumnType("int(11)");

                entity.Property(e => e.RepresentanteId).HasColumnType("int(11)");

                entity.Property(e => e.Valor)
                    .HasPrecision(13, 2)
                    .HasDefaultValueSql("'0.00'");
            });
            
            modelBuilder.Entity<CashCliente>(entity =>
            {
                entity.ToTable("Cash_Cliente");

                entity.HasKey(e => e.Id);

            });

            modelBuilder.Entity<CashConfig>(entity =>
            {
                entity.ToTable("Cash_Config");

                entity.HasKey(e => e.Id);

            });

            modelBuilder.Entity<Certificado>(entity =>
            {
                entity.ToTable("certificados");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Certificado1).HasColumnName("Certificado");

                entity.Property(e => e.Chave).HasColumnType("text");

                entity.Property(e => e.Cnpj).HasMaxLength(45);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");


                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.Razao).HasMaxLength(200);

                entity.Property(e => e.Senha).HasMaxLength(100);

                entity.Property(e => e.Vencimento).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.Ativo).HasDefaultValueSql("'1'");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.Cnpj).HasMaxLength(45);

                entity.Property(e => e.Codigo).HasColumnType("int(11)");

                entity.Property(e => e.ContratoAssinado)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataCadastro)
                .HasColumnType("DATETIME");

                entity.Property(e => e.Excluido).HasDefaultValueSql("'0'");

                entity.Property(e => e.Fantasia).HasMaxLength(200);

                entity.Property(e => e.IdContato).HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.IdEndereco).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Iestadual)
                    .HasMaxLength(45)
                    .HasColumnName("IEstadual");

                entity.Property(e => e.Mensalidade).HasPrecision(13, 2);

                entity.Property(e => e.Observacao).HasMaxLength(600);

                entity.Property(e => e.Preposto).HasMaxLength(100);

                entity.Property(e => e.Razao).HasMaxLength(200);

                entity.Property(e => e.Regime)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'Simples'");

                entity.Property(e => e.Responsavel).HasMaxLength(100);

                entity.Property(e => e.MensalidadePercentual)
                .HasPrecision(13, 4);

                entity.Property(e => e.TaxaInstalacao)
                .HasPrecision(13, 2);
            });

            modelBuilder.Entity<Clientelog>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("clientelog");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.Ativo).HasDefaultValueSql("'1'");

                entity.Property(e => e.Cnpj).HasMaxLength(45);

                entity.Property(e => e.Codigo).HasColumnType("int(11)");

                entity.Property(e => e.ContratoAssinado)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.Excluido).HasDefaultValueSql("'0'");

                entity.Property(e => e.Fantasia).HasMaxLength(200);

                entity.Property(e => e.IdContato).HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.IdEndereco).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Iestadual)
                    .HasMaxLength(45)
                    .HasColumnName("IEstadual");

                entity.Property(e => e.Mensalidade).HasPrecision(13, 2);

                entity.Property(e => e.Observacao).HasMaxLength(600);

                entity.Property(e => e.Preposto).HasMaxLength(100);

                entity.Property(e => e.Razao).HasMaxLength(200);

                entity.Property(e => e.Regime)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'Simples'");

                entity.Property(e => e.Responsavel).HasMaxLength(100);

                entity.Property(e => e.TaxaInstalacao).HasPrecision(13, 2);
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.HasKey(e => e.Idcolaborador)
                    .HasName("PRIMARY");

                entity.ToTable("colaborador");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Idcolaborador)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcolaborador");

                entity.Property(e => e.Ativo)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime");
                    

                entity.Property(e => e.Funcao).HasMaxLength(50);

                entity.Property(e => e.Nome).HasMaxLength(50);

                entity.Property(e => e.Sobrenome).HasMaxLength(50);
            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasKey(e => e.Idconfig)
                    .HasName("PRIMARY");

                entity.ToTable("config");

                entity.Property(e => e.Idconfig)
                    .HasColumnType("int(11)")
                    .HasColumnName("idconfig");

                entity.Property(e => e.ContagemDocumento)
                    .HasColumnType("int(11)")
                    .HasColumnName("contagemDocumento");

                entity.Property(e => e.DiretorioBackup).HasMaxLength(200);

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.Idcontato)
                    .HasName("PRIMARY");

                entity.ToTable("contato");

                entity.Property(e => e.Idcontato)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcontato");

                entity.Property(e => e.Celular).HasMaxLength(45);

                entity.Property(e => e.Celular2).HasMaxLength(45);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Email2)
                    .HasMaxLength(100)
                    .HasColumnName("email2");

                entity.Property(e => e.Excluido)
                    .HasColumnType("int(1)")
                    .HasColumnName("excluido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NomeRepresentante).HasMaxLength(100);

                entity.Property(e => e.Ramal).HasMaxLength(45);

                entity.Property(e => e.Site).HasMaxLength(200);

                entity.Property(e => e.Telefone).HasMaxLength(45);

                entity.Property(e => e.Telefone2).HasMaxLength(45);

                entity.Property(e => e.TelefoneRepresentante).HasMaxLength(20);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PRIMARY");

                entity.ToTable("empresa");

                entity.HasIndex(e => e.IdContato, "fk_empresa_contato1_idx");

                entity.HasIndex(e => e.IdEndereco, "fk_empresa_endereco1_idx");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.Ativo)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Cnpj).HasMaxLength(45);

                entity.Property(e => e.Cor1).HasMaxLength(45);

                entity.Property(e => e.Cor2).HasMaxLength(45);

                entity.Property(e => e.Cor3).HasMaxLength(45);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.Excluido)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fantasia).HasMaxLength(200);

                entity.Property(e => e.IdContato).HasColumnType("int(11)");

                entity.Property(e => e.IdEndereco).HasColumnType("int(11)");

                entity.Property(e => e.Iestadual)
                    .HasMaxLength(45)
                    .HasColumnName("IEstadual");

                entity.Property(e => e.Observacao).HasMaxLength(100);

                entity.Property(e => e.Razao).HasMaxLength(200);

                entity.Property(e => e.Responsavel).HasMaxLength(100);

                entity.Property(e => e.SchemaPadrao)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'orbitadb'");

                entity.Property(e => e.SenhaPadrao)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'dbakjx25642'");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.Idendereco)
                    .HasName("PRIMARY");

                entity.ToTable("endereco");

                entity.Property(e => e.Idendereco)
                    .HasColumnType("int(11)")
                    .HasColumnName("idendereco");

                entity.Property(e => e.Bairro).HasMaxLength(150);

                entity.Property(e => e.Cep).HasMaxLength(45);

                entity.Property(e => e.Cidade).HasMaxLength(150);

                entity.Property(e => e.CodigoMunicipio).HasMaxLength(45);

                entity.Property(e => e.Complemento).HasMaxLength(100);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.Excluido)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Latitude).HasMaxLength(100);

                entity.Property(e => e.Logradouro).HasMaxLength(150);

                entity.Property(e => e.Longitude).HasMaxLength(100);

                entity.Property(e => e.Numero).HasMaxLength(45);

                entity.Property(e => e.Uf).HasMaxLength(2);
            });

            modelBuilder.Entity<Financeiro>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.Property(e => e.Valor)
                    .HasPrecision(13, 2);

                entity.Property(e => e.SalarioReferencia)
                    .HasPrecision(13, 2);

                entity.Property(e => e.PercentualNegocioado)
                    .HasPrecision(13, 4);
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor)
                    .HasName("PRIMARY");

                entity.ToTable("fornecedor");

                entity.HasIndex(e => e.IdContato, "fk_fornecedor_contato1_idx");

                entity.HasIndex(e => e.IdEndereco, "fk_fornecedor_endereco1_idx");

                entity.Property(e => e.IdFornecedor)
                    .HasColumnType("int(11)")
                    .HasColumnName("idFornecedor");

                entity.Property(e => e.Ativo)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Cnpj).HasMaxLength(45);

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.Excluido)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fantasia).HasMaxLength(200);

                entity.Property(e => e.IdContato).HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.IdEndereco).HasColumnType("int(11)");

                entity.Property(e => e.Iestadual)
                    .HasMaxLength(45)
                    .HasColumnName("IEstadual");

                entity.Property(e => e.Razao).HasMaxLength(200);

                entity.HasOne(d => d.IdContatoNavigation)
                    .WithMany(p => p.Fornecedors)
                    .HasForeignKey(d => d.IdContato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornecedor_contato1");

                entity.HasOne(d => d.IdEnderecoNavigation)
                    .WithMany(p => p.Fornecedors)
                    .HasForeignKey(d => d.IdEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fornecedor_endereco1");
            });

            modelBuilder.Entity<Licenca>(entity =>
            {
                entity.ToTable("licenca");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ativa)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BloqueioAdm)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BloqueioAutomatico)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BloqueioManual)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BloqueioPdv)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chave).HasMaxLength(45);

                entity.Property(e => e.CodigoLicenca).HasColumnType("int(11)");

                entity.Property(e => e.Comanda)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DataBloqueio).HasColumnType("datetime");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.Financeiro)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdCliente).HasColumnType("int(11) unsigned");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuarioAtivacao).HasColumnType("int(11)");

                entity.Property(e => e.IdUsuarioDesativacao).HasColumnType("int(11)");

                entity.Property(e => e.Maquinas)
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.MotivoBloqueio).HasMaxLength(200);

                entity.Property(e => e.Nfce)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("NFCe")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nfe)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Os)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("OS")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Pdv)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Plano)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RelatorioEntradas)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RelatorioVendas)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RemessaMes)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Temporaria)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UsuarioBloqueio).HasColumnType("int(11)");

                entity.Property(e => e.VendaExterna)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Maquina>(entity =>
            {
                entity.HasKey(e => e.Idmaquina)
                    .HasName("PRIMARY");

                entity.ToTable("maquinas");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Idmaquina)
                    .HasColumnType("int(11)")
                    .HasColumnName("idmaquina");

                entity.Property(e => e.AnyDesk).HasMaxLength(45);

                entity.Property(e => e.AnyDeskSenha).HasMaxLength(45);

                entity.Property(e => e.Chave).HasColumnType("text");

                entity.Property(e => e.Cnpj).HasMaxLength(45);

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.Ip).HasMaxLength(40);

                entity.Property(e => e.Mac).HasMaxLength(45);

                entity.Property(e => e.Nome).HasMaxLength(100);

                entity.Property(e => e.PrimeiroAcesso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Sistema).HasMaxLength(45);

                entity.Property(e => e.TeamViewer).HasMaxLength(45);

                entity.Property(e => e.TeamViewerSenha).HasMaxLength(45);

                entity.Property(e => e.UltimoAcesso).HasMaxLength(45);

                entity.Property(e => e.Usuario).HasMaxLength(45);

                entity.Property(e => e.Versao).HasMaxLength(45);
            });

            modelBuilder.Entity<Suporte>(entity =>
            {
                entity.HasKey(e => e.Idsuporte)
                    .HasName("PRIMARY");

                entity.ToTable("suporte");

                entity.Property(e => e.Idsuporte)
                    .HasColumnType("int(11)")
                    .HasColumnName("idsuporte");

                entity.Property(e => e.Celular).HasMaxLength(45);

                entity.Property(e => e.Celular2).HasMaxLength(45);

                entity.Property(e => e.CodigoAcesso).HasMaxLength(45);

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DataFinalizacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasMaxLength(100);

                entity.Property(e => e.Detalhamento).HasMaxLength(1000);

                entity.Property(e => e.Finalizado)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FormaAtendimento).HasMaxLength(45);

                entity.Property(e => e.HoraMarcada).HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.IdColaborador).HasColumnType("int(11)");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.Iniciado)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InicioAtendimento).HasColumnType("datetime");

                entity.Property(e => e.Prioridade).HasMaxLength(45);

                entity.Property(e => e.SenhaAcesso).HasMaxLength(45);

                entity.Property(e => e.Setor).HasMaxLength(45);

                entity.Property(e => e.Solicitante).HasMaxLength(100);

                entity.Property(e => e.Telefone).HasMaxLength(45);

                entity.Property(e => e.Tipo).HasMaxLength(45);
            });

            modelBuilder.Entity<SuporteVideo>(entity =>
            {
                entity.ToTable("suporte_video");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Avaliacao)
                    .HasPrecision(5, 2)
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Avaliacoes).HasColumnType("int(6)");

                entity.Property(e => e.Descricao).HasMaxLength(400);

                entity.Property(e => e.IdEmpresa)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Link)
                    .HasMaxLength(400)
                    .HasColumnName("link");

                entity.Property(e => e.Ordem).HasColumnType("int(3)");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ativo)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Excluido)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IdEmpresa).HasColumnType("int(11)");

                entity.Property(e => e.Logado)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.Maquina).HasMaxLength(60);

                entity.Property(e => e.Nome).HasMaxLength(100);

                entity.Property(e => e.Perfil).HasMaxLength(45);

                entity.Property(e => e.Senha)
                    .HasMaxLength(45)
                    .HasColumnName("senha");

                entity.Property(e => e.Sobrenome).HasMaxLength(100);

                entity.Property(e => e.UltimoAcesso).HasColumnType("DATETIME");;

                entity.Property(e => e.Versao).HasColumnType("text");
            });

            modelBuilder.Entity<Versao>(entity =>
            {
                entity.HasKey(e => e.Idversao)
                    .HasName("PRIMARY");

                entity.ToTable("versao");

                entity.Property(e => e.Idversao)
                    .HasColumnType("int(11)")
                    .HasColumnName("idversao");

                entity.Property(e => e.DataPrimeiroAcesso)
                    .HasColumnType("DATETIME");
                    

                entity.Property(e => e.DataUltimoAcesso).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasMaxLength(45);

                entity.Property(e => e.Mac).HasMaxLength(45);

                entity.Property(e => e.Nome).HasMaxLength(45);

                entity.Property(e => e.Sistema).HasMaxLength(45);

                entity.Property(e => e.VSistema)
                    .HasMaxLength(45)
                    .HasColumnName("vSistema");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
