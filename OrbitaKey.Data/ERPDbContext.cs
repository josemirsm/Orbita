using Microsoft.EntityFrameworkCore;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data
{
    public partial class ERPDbContext : DbContext
    {
        #region Tables

        public virtual DbSet<Adiantamento> Adiantamento { get; set; }
        public virtual DbSet<Adquirente> Adquirente { get; set; }
        public virtual DbSet<Atualizacao> Atualizacao { get; set; }
        public virtual DbSet<BoletoConfig> BoletoConfig { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cobrador> Cobrador { get; set; }
        public virtual DbSet<Codigos> Codigos { get; set; }
        public virtual DbSet<Comanda> Comanda { get; set; }
        public virtual DbSet<ComandaItem> ComandaItem { get; set; }
        public virtual DbSet<ComandaItemGrade> ComandaItemGrade { get; set; }
        public virtual DbSet<ComandaPagamento> ComandaPagamento { get; set; }
        public virtual DbSet<Comissao> Comissao { get; set; }
        public virtual DbSet<ConfigApp> ConfigApp { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<ConfigTef> ConfigTef { get; set; }
        public virtual DbSet<TefControle> TefControle { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<Contagem> Contagem { get; set; }
        public virtual DbSet<Contabilidade> Contabilidade { get; set; }
        public virtual DbSet<ContaMovimentacao> ContaMovimentacao { get; set; }
        public virtual DbSet<Contato> Contato { get; set; }
        public virtual DbSet<Controlador> Controlador { get; set; }
        public virtual DbSet<ControleSerie> ControleSerie { get; set; }
        public virtual DbSet<Credito> Credito { get; set; }
        public virtual DbSet<Customedio> Customedio { get; set; }
        public virtual DbSet<Despesa> Despesa { get; set; }
        public virtual DbSet<Dispositivos> Dispositivos { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresaAtividade> EmpresaAtividade { get; set; }
        public virtual DbSet<EmpresaCnae> EmpresaCnae { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Entradaitem> Entradaitem { get; set; }
        public virtual DbSet<Entradanota> Entradanota { get; set; }
        public virtual DbSet<Estabelecimento> Estabelecimento { get; set; }
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Etiqueta> Etiqueta { get; set; }
        public virtual DbSet<Eventonota> Eventonota { get; set; }
        public virtual DbSet<Faturanota> Faturanota { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<GradeX> GradeX { get; set; }
        public virtual DbSet<GradeY> GradeY { get; set; }
        public virtual DbSet<GradeZ> GradeZ { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Impressora> Impressora { get; set; }
        public virtual DbSet<ImpressoraItem> ImpressoraItem { get; set; }
        public virtual DbSet<Inutilizacao> Inutilizacao { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<InventarioItens> InventarioItens { get; set; }
        public virtual DbSet<Localizacao> Localizacao { get; set; }
        public virtual DbSet<LocalizacaoProduto> LocalizacaoProduto { get; set; }
        public virtual DbSet<LocalizacaoSaldo> LocalizacaoSaldo { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<MDFe> MDFe { get; set; }
        public virtual DbSet<MDFeVeiculo> MDFeVeiculo { get; set; }
        public virtual DbSet<MDFeNFe> MDFeNFe { get; set; }
        public virtual DbSet<MDFeConfig> MDFeConfig { get; set; }
        public virtual DbSet<MDFeXml> MDFeXml { get; set; }
        public virtual DbSet<Metas> Metas { get; set; }
        public virtual DbSet<Movimentoitens> Movimentoitens { get; set; }
        public virtual DbSet<NfReferenciamento> NfReferenciamento { get; set; }
        public virtual DbSet<NfVolume> NfVolume { get; set; }
        public virtual DbSet<Nfse> Nfse { get; set; }
        public virtual DbSet<NfseConfig> NfseConfig { get; set; }
        public virtual DbSet<NfseServico> NfseServico { get; set; }
        public virtual DbSet<NfseTomador> NfseTomador { get; set; }
        public virtual DbSet<NotaMonitor> NotaMonitor { get; set; }
        public virtual DbSet<Oe> Oe { get; set; }
        public virtual DbSet<OeItens> OeItens { get; set; }
        public virtual DbSet<Os> Os { get; set; }
        public virtual DbSet<OsItem> OsItem { get; set; }
        public virtual DbSet<OsVeiculo> OsVeiculo { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Pagamentovenda> Pagamentovenda { get; set; }
        public virtual DbSet<Parametriza> Parametriza { get; set; }
        public virtual DbSet<Pc1> Pc1 { get; set; }
        public virtual DbSet<Pc2> Pc2 { get; set; }
        public virtual DbSet<Pc3> Pc3 { get; set; }
        public virtual DbSet<Pc4> Pc4 { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoItem> PedidoItem { get; set; }
        public virtual DbSet<PedidoPagamento> PedidoPagamento { get; set; }
        public virtual DbSet<Perdas> Perdas { get; set; }
        public virtual DbSet<Precomedio> Precomedio { get; set; }
        public virtual DbSet<ProdMateriaprima> ProdMateriaprima { get; set; }
        public virtual DbSet<ProdNota> ProdNota { get; set; }
        public virtual DbSet<ProdNotamateriaprima> ProdNotamateriaprima { get; set; }
        public virtual DbSet<ProdNotaprodutos> ProdNotaprodutos { get; set; }
        public virtual DbSet<ProdProdutos> ProdProdutos { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<ProdutoEspecifico> ProdutoEspecifico { get; set; }
        public virtual DbSet<ProdutoPromocao> ProdutoPromocao { get; set; }
        public virtual DbSet<Produtoinventario> Produtoinventario { get; set; }
        public virtual DbSet<PedidoCompra> PedidoCompra { get; set; }
        public virtual DbSet<PedidoCompraItem> PedidoCompraItem { get; set; }
        public virtual DbSet<Recebimento> Recebimento { get; set; }
        public virtual DbSet<Recebimento_Prevenda> Recebimento_Prevenda { get; set; }
        public virtual DbSet<Relacionamentoitens> Relacionamentoitens { get; set; }
        public virtual DbSet<Remessa> Remessa { get; set; }
        public virtual DbSet<RemessaItens> RemessaItens { get; set; }
        public virtual DbSet<RemessaPedidos> RemessaPedidos { get; set; }
        public virtual DbSet<RemessaPedidosItens> RemessaPedidosItens { get; set; }
        public virtual DbSet<Rota> Rota { get; set; }
        public virtual DbSet<Saidaitem> Saidaitem { get; set; }
        public virtual DbSet<SaidaItemProdutoEspecifico> SaidaItemProdutoEspecifico { get; set; }
        public virtual DbSet<Saidanota> Saidanota { get; set; }
        public virtual DbSet<Saidas> Saidas { get; set; }
        public virtual DbSet<SincControle> SincControle { get; set; }
        public virtual DbSet<SpedConfig> SpedConfig { get; set; }
        public virtual DbSet<Subgrupo> Subgrupo { get; set; }
        public virtual DbSet<TabelaPreco> TabelaPreco { get; set; }
        public virtual DbSet<TabelaPrecoItem> TabelaPrecoItem { get; set; }
        public virtual DbSet<Tecnico> Tecnico { get; set; }
        public virtual DbSet<TempEntradaitem> TempEntradaitem { get; set; }
        public virtual DbSet<TempEntradanota> TempEntradanota { get; set; }
        public virtual DbSet<Tipodocumento> Tipodocumento { get; set; }
        public virtual DbSet<Unidademedida> Unidademedida { get; set; }
        public virtual DbSet<Xmlnota> Xmlnota { get; set; }



        #endregion

        private string ConnectionString { get; }

        public ERPDbContext()
        {

        }

        public ERPDbContext(DbContextOptions<ERPDbContext> options) : base(options)
        {

        }

        public ERPDbContext(string connectionString)
        {
            ConnectionString = connectionString ??
                throw new System.ArgumentNullException(nameof(connectionString));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adiantamento>(entity =>
            {
                entity.ToTable("adiantamento");

                entity.Property(e => e.IdDocumento)
                .HasDefaultValue(0);

                entity.Property(e => e.IdOs)
                .HasDefaultValue(0);

                entity.Property(e => e.IdPreproducao)
                .HasDefaultValue(0);

                entity.Property(e => e.Valor)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<Adquirente>(entity =>
            {
                entity.ToTable("adquirente");
                entity.Property(e => e.Logo).HasColumnType("mediumblob");
            });

            modelBuilder.Entity<GradeSaldo>(entity =>
            {
                entity.Property(e => e.Saldo).HasColumnType("decimal(13,3)");
                entity.Property(e => e.Custo).HasColumnType("decimal(13,3)");
            });

            modelBuilder.Entity<SpedConfig>(entity =>
            {
                entity.ToTable("spedconfig");
                entity.Property(e => e.IndAtiv)
                .HasDefaultValue(1);
                entity.Property(e => e.IndPerfil)
                .HasDefaultValue(1);
                entity.Property(e => e.CodigoVersao)
                .HasDefaultValue(15);
                entity.Property(e => e.DataImposto)
                .HasDefaultValue(9);
            });

            modelBuilder.Entity<EtiquetaModelo>(entity =>
            {
                entity.Property(e => e.Imagem).HasColumnType("longblob");
                entity.Property(e => e.Imagem2).HasColumnType("longblob");
                entity.Property(e => e.Modelo).HasColumnType("longblob");
            });

            modelBuilder.Entity<PreProducao>(entity =>
            {
                entity.Property(e => e.Finalizado).HasDefaultValue(false);
                entity.Property(e => e.Cancelada).HasDefaultValue(false);
                entity.Property(e => e.Prioridade).HasDefaultValue(0);
                entity.Property(e => e.CodigoCliente)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<PreProducaoProduto>(entity =>
            {
                entity.Property(e => e.Quantidade).HasColumnType("decimal(13,3)");
                entity.Property(e => e.Finalizado).HasDefaultValue(false);
                entity.Property(e => e.Prioridade).HasDefaultValue(0);
                entity.Property(e => e.CodigoCliente)
                .HasDefaultValue(0);

            });

            modelBuilder.Entity<ProdutoImagem>(entity =>
            {
                entity.ToTable("produtoimagem");
                entity.Property(e => e.Codigo).IsRequired();
                entity.Property(e => e.Imagem).HasColumnType("longblob");
            });

            modelBuilder.Entity<AudCancelamento>(entity =>
            {
                entity.ToTable("aud_cancelamento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Detalhamento).HasColumnType("varchar(200)");

                entity.Property(e => e.NomeUsuario).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<AudProduto>(entity =>
            {
                entity.ToTable("aud_produto");

                entity.Property(e => e.Barras).HasColumnType("varchar(45)");

                entity.Property(e => e.Cest)
                    .HasColumnName("CEST")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CustoManual)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CustoMedio)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DescValor).HasDefaultValueSql("0");

                entity.Property(e => e.DescontoMaximo).HasColumnType("decimal(12,2)");

                entity.Property(e => e.Descri).HasDefaultValueSql("0");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Grupo).HasColumnType("varchar(100)");

                entity.Property(e => e.Marca).HasColumnType("varchar(100)");

                entity.Property(e => e.Ncm)
                    .HasColumnName("NCM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Parametriza).HasDefaultValueSql("0");

                entity.Property(e => e.Preco1)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Preco2)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Preco3)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Preco4)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Preco5)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Preco6)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Referencia1).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia2).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia3).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia4).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia5).HasColumnType("varchar(100)");

                entity.Property(e => e.UltimoCusto)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Unidade).HasColumnType("varchar(45)");

                entity.Property(e => e.Usuario).HasColumnType("varchar(100)");

                entity.Property(e => e.Valor).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AudVendas>(entity =>
            {
                entity.HasKey(e => e.IdaudVendas)
                    .HasName("PK_aud_vendas");

                entity.ToTable("aud_vendas");

                entity.Property(e => e.IdaudVendas).HasColumnName("idaud_vendas");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<AuxCep>(entity =>
            {
                entity.ToTable("aux_cep");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bairro).HasColumnType("text");

                entity.Property(e => e.CMun).HasColumnName("cMun");

                entity.Property(e => e.CUf).HasColumnName("cUF");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Cidade).HasColumnType("text");

                entity.Property(e => e.Estado).HasColumnType("text");

                entity.Property(e => e.Logradouro).HasColumnType("text");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<AuxCest>(entity =>
            {
                entity.ToTable("aux_cest");

                entity.Property(e => e.Cest)
                    .HasColumnName("CEST")
                    .HasColumnType("text");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Ncm).HasColumnName("NCM");

                entity.Property(e => e.Segmento).HasColumnType("text");
            });

            modelBuilder.Entity<AuxCodigomunicipio>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_aux_codigomunicipio");

                entity.ToTable("aux_codigomunicipio");

                entity.Property(e => e.Codigo).HasColumnType("varchar(10)");

                entity.Property(e => e.Nome).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<AuxIbpt>(entity =>
            {
                entity.ToTable("aux_ibpt");

                entity.Property(e => e.Chave)
                    .HasColumnName("chave")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Estadual)
                    .HasColumnName("estadual")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Ex)
                    .HasColumnName("ex")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Fonte)
                    .HasColumnName("fonte")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Importadosfederal)
                    .HasColumnName("importadosfederal")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Municipal)
                    .HasColumnName("municipal")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nacionalfederal)
                    .HasColumnName("nacionalfederal")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Versao)
                    .HasColumnName("versao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Vigenciafim)
                    .HasColumnName("vigenciafim")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Vigenciainicio)
                    .HasColumnName("vigenciainicio")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<AuxNcm>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_aux_ncm");

                entity.ToTable("aux_ncm");

                entity.Property(e => e.Codigo).HasColumnType("varchar(10)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Backup>(entity =>
            {
                entity.HasKey(e => e.Idbackup)
                    .HasName("PK_backup");

                entity.ToTable("backup");

                entity.Property(e => e.Idbackup).HasColumnName("idbackup");

                entity.Property(e => e.DataFim).HasColumnType("datetime");

                entity.Property(e => e.DataInicio).HasColumnType("datetime");

                entity.Property(e => e.Maquina).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Balanco>(entity =>
            {
                entity.HasKey(e => e.Idbalanco)
                    .HasName("PK_balanco");

                entity.ToTable("balanco");

                entity.Property(e => e.Idbalanco).HasColumnName("idbalanco");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinalizacao).HasColumnType("datetime");

                entity.Property(e => e.Liberada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CaApp>(entity =>
            {
                entity.ToTable("CaApp");

                entity.Property(e => e.CmdEditarProdutoEntregue)
                .HasDefaultValue(false);

                entity.Property(e => e.CmdEditarProdutoProducao)
                .HasDefaultValue(false);

                entity.Property(e => e.CmdRemoverProdutoEntregue)
                .HasDefaultValue(false);

                entity.Property(e => e.CmdRemoverProdutoProducao)
                .HasDefaultValue(false);

                entity.Property(e => e.CmdFinalizarComanda)
                .HasDefaultValue(false);

                entity.Property(e => e.VexControleRota)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<BalancoItem>(entity =>
            {
                entity.HasKey(e => e.IdItemBalanco)
                    .HasName("PK_balanco_item");

                entity.ToTable("balanco_item");

                entity.Property(e => e.IdItemBalanco).HasColumnName("idItemBalanco");

                entity.Property(e => e.CustoTotal).HasColumnType("decimal(15,3)");

                entity.Property(e => e.CustoUnitario).HasColumnType("decimal(15,3)");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(15,3)");

                entity.Property(e => e.IdLocalizacaoProduto)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<BoletoConfig>(entity =>
            {
                entity.ToTable("boleto_config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Agencia).HasColumnType("varchar(45)");

                entity.Property(e => e.AgenciaDigito).HasColumnType("varchar(45)");

                entity.Property(e => e.Banco).HasColumnType("varchar(100)");

                entity.Property(e => e.Carteira).HasColumnType("varchar(45)");

                entity.Property(e => e.Cnab).HasDefaultValueSql("0");

                entity.Property(e => e.CodigoCedente).HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoTransmissao).HasColumnType("varchar(45)");

                entity.Property(e => e.Conta).HasColumnType("varchar(45)");

                entity.Property(e => e.ContaDigito).HasColumnType("varchar(45)");

                entity.Property(e => e.Contrato).HasColumnType("varchar(45)");

                entity.Property(e => e.Convenio).HasColumnType("varchar(45)");

                entity.Property(e => e.DigitoAgenciaConta).HasColumnType("varchar(45)");

                entity.Property(e => e.EnviarObs).HasDefaultValueSql("0");

                entity.Property(e => e.LocalPagamento).HasColumnType("text");

                entity.Property(e => e.Mensagem1).HasColumnType("text");

                entity.Property(e => e.Mensagem2).HasColumnType("text");

                entity.Property(e => e.Modalidade).HasColumnType("varchar(45)");

                entity.Property(e => e.TipoCarteira).HasDefaultValueSql("1");

                entity.Property(e => e.TipoCobranca).HasDefaultValueSql("0");

                entity.Property(e => e.TipoDocumento).HasDefaultValueSql("0");

                entity.Property(e => e.Variacao).HasColumnType("varchar(45)");

                entity.Property(e => e.Sequencia)
                .HasDefaultValue(0);

                entity.Property(e => e.SequenciaRemessa)
                .HasDefaultValue(0);

                entity.Property(e => e.DiasLimitePagamento)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<ConfigProducao>(entity =>
            {
                entity.Property(e => e.DecimaisQuantidade)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'000'");

                entity.Property(e => e.DecimaisCusto)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'000'");
            });

            modelBuilder.Entity<CaGeral>(entity =>
            {
                entity.HasKey(e => e.IdcaGeral)
                    .HasName("PK_ca_geral");

                entity.ToTable("ca_geral");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("fk_usuario_idx");

                entity.Property(e => e.IdcaGeral).HasColumnName("idca_geral");

                entity.Property(e => e.FinBloquearCliente)
                .HasDefaultValue(true);

                entity.Property(e => e.OsCancelar)
                .HasDefaultValue(true);

                entity.Property(e => e.AdmDashboard)
                .HasDefaultValue(true);


                entity.Property(e => e.PdvVendasTodosUsuario)
                .HasDefaultValue(true);

                entity.Property(e => e.PdvDavDetalhar)
                .HasDefaultValue(true);

                entity.Property(e => e.PdvDavReimprimir)
                .HasDefaultValue(true);

                entity.Property(e => e.PdvDavImportar)
                .HasDefaultValue(true);

                entity.Property(e => e.PdvImportarNFCe)
                .HasDefaultValue(true);

                entity.Property(e => e.FinBaixaCaixaFechado).HasDefaultValue(true);

                entity.Property(e => e.AdmAlterarRemessa).HasDefaultValueSql("1");

                entity.Property(e => e.AdmApenasNfe).HasDefaultValueSql("0");

                entity.Property(e => e.AdmLogin).HasDefaultValueSql("1");

                entity.Property(e => e.CadClientes).HasDefaultValueSql("1");

                entity.Property(e => e.CadEmpresa).HasDefaultValueSql("1");

                entity.Property(e => e.CadFormaPagamento).HasDefaultValueSql("1");

                entity.Property(e => e.CadProdutos).HasDefaultValueSql("1");

                entity.Property(e => e.CadUsuarios).HasDefaultValueSql("1");

                entity.Property(e => e.EstAjustarEstoque).HasDefaultValueSql("0");

                entity.Property(e => e.EstCancelarNotaEntrada).HasDefaultValueSql("1");

                entity.Property(e => e.EstExcluirNotaEntrada).HasDefaultValueSql("1");

                entity.Property(e => e.FinAgruparRecebimento).HasDefaultValueSql("0");

                entity.Property(e => e.FinBaixaPagamentos).HasDefaultValueSql("1");

                entity.Property(e => e.FinBaixaRecebimentos).HasDefaultValueSql("1");

                entity.Property(e => e.FinCaixa).HasDefaultValueSql("1");

                entity.Property(e => e.FinCriarPagamento).HasDefaultValueSql("1");

                entity.Property(e => e.FinCriarRecebimento).HasDefaultValueSql("1");

                entity.Property(e => e.FinExcluirPagamento).HasDefaultValueSql("0");

                entity.Property(e => e.FinExcluirRecebimento).HasDefaultValueSql("0");

                entity.Property(e => e.FinPagResumo).HasDefaultValueSql("1");

                entity.Property(e => e.FinPagamentos).HasDefaultValueSql("1");

                entity.Property(e => e.FinRecDescontoMaximo)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("20.00");

                entity.Property(e => e.FinRecResumo).HasDefaultValueSql("1");

                entity.Property(e => e.FinRecebimentos).HasDefaultValueSql("1");

                entity.Property(e => e.FinRestaurarPagamento).HasDefaultValueSql("0");

                entity.Property(e => e.FinRestaurarRecebimento).HasDefaultValueSql("0");

                entity.Property(e => e.FinTelaBaixaRecebimento).HasDefaultValueSql("1");

                entity.Property(e => e.FinZerarMultaJuros).HasDefaultValueSql("0");

                entity.Property(e => e.PdvAlterarAdicionalParcelamento).HasDefaultValueSql("0");

                entity.Property(e => e.PdvAlterarPrecoProduto).HasDefaultValueSql("0");

                entity.Property(e => e.PdvAlterarQuantidade).HasDefaultValueSql("1");

                entity.Property(e => e.PdvCaixaCego).HasDefaultValueSql("0");

                entity.Property(e => e.PdvCaixaOutrasDatas).HasDefaultValueSql("0");

                entity.Property(e => e.PdvCaixaTodos).HasDefaultValueSql("0");

                entity.Property(e => e.PdvCancelarDav).HasDefaultValueSql("1");

                entity.Property(e => e.PdvCancelarItem).HasDefaultValueSql("1");

                entity.Property(e => e.PdvCancelarNfce).HasDefaultValueSql("1");

                entity.Property(e => e.PdvCancelarVendaAberta).HasDefaultValueSql("1");

                entity.Property(e => e.PdvClienteInadimplente).HasDefaultValueSql("0");

                entity.Property(e => e.PdvConfiguracoes).HasDefaultValueSql("1");

                entity.Property(e => e.PdvControlarCaixa).HasDefaultValueSql("1");

                entity.Property(e => e.PdvCusto).HasDefaultValueSql("0");

                entity.Property(e => e.PdvDescontoMaximo)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("20.00");

                entity.Property(e => e.PdvEditarPrecoProdutoInserido).HasDefaultValueSql("0");

                entity.Property(e => e.PdvEmitirDav).HasDefaultValueSql("1");

                entity.Property(e => e.PdvEmitirNfce).HasDefaultValueSql("1");

                entity.Property(e => e.PdvEmitirOrcamento).HasDefaultValueSql("1");

                entity.Property(e => e.PdvExcederDescontoItem).HasDefaultValueSql("0");

                entity.Property(e => e.PdvExcederLimiteCliente).HasDefaultValueSql("0");

                entity.Property(e => e.PdvListaNotasData).HasDefaultValueSql("1");

                entity.Property(e => e.PdvLogin).HasDefaultValueSql("1");

                entity.Property(e => e.PdvRelatorioVendas).HasDefaultValueSql("1");

                entity.Property(e => e.PdvSangria).HasDefaultValueSql("1");

                entity.Property(e => e.PdvSuprimento).HasDefaultValueSql("1");

                entity.Property(e => e.PdvTotaisListaNotas).HasDefaultValueSql("1");

                entity.Property(e => e.RelAlteracaoProdutos).HasDefaultValueSql("1");

                entity.Property(e => e.RelBalanco).HasDefaultValueSql("1");

                entity.Property(e => e.RelClientes).HasDefaultValueSql("1");

                entity.Property(e => e.RelComissao).HasDefaultValueSql("1");

                entity.Property(e => e.RelContas).HasDefaultValueSql("1");

                entity.Property(e => e.RelDre)
                    .HasColumnName("RelDRE")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RelEntradas).HasDefaultValueSql("1");

                entity.Property(e => e.RelEstoque).HasDefaultValueSql("1");

                entity.Property(e => e.RelFluxoCaixa).HasDefaultValueSql("1");

                entity.Property(e => e.RelFornecedores).HasDefaultValueSql("1");

                entity.Property(e => e.RelLucratividade).HasDefaultValueSql("1");

                entity.Property(e => e.RelOs)
                    .HasColumnName("RelOS")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.RelPagamentos).HasDefaultValueSql("1");

                entity.Property(e => e.RelProducao).HasDefaultValueSql("1");

                entity.Property(e => e.RelProdutos).HasDefaultValueSql("1");

                entity.Property(e => e.RelRecebimentos).HasDefaultValueSql("1");

                entity.Property(e => e.RelVendas).HasDefaultValueSql("1");

                entity.Property(e => e.PdvDevolucaoItens)
                .HasDefaultValue(true);

            });

            modelBuilder.Entity<CaLiberacao>(entity =>
            {
                entity.HasKey(e => e.IdcaLiberacao)
                    .HasName("PK_ca_liberacao");

                entity.ToTable("ca_liberacao");

                entity.Property(e => e.IdcaLiberacao).HasColumnName("idca_liberacao");

                entity.Property(e => e.AutorizacaoJaUsada).HasDefaultValueSql("0");

                entity.Property(e => e.Autorizado).HasDefaultValueSql("0");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.DescricaoConfig).HasColumnType("varchar(60)");

                entity.Property(e => e.DhResposta).HasColumnType("datetime");

                entity.Property(e => e.DhSolicitacao)
                    .HasColumnType("datetime");

                entity.Property(e => e.DhUtilizacao).HasColumnType("datetime");

                entity.Property(e => e.IdSaida).HasDefaultValueSql("0");

                entity.Property(e => e.Justificativa).HasColumnType("varchar(200)");

                entity.Property(e => e.MensagemExibida).HasDefaultValueSql("0");

                entity.Property(e => e.NomeAutorizador).HasColumnType("varchar(100)");

                entity.Property(e => e.NomeSolicitante).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<CadCsosn>(entity =>
            {
                entity.HasKey(e => e.IdCsosn)
                    .HasName("PK_cad_csosn");

                entity.ToTable("cad_csosn");

                entity.Property(e => e.IdCsosn).HasColumnName("id_csosn");

                entity.Property(e => e.CodigoCsosn)
                    .IsRequired()
                    .HasColumnName("codigo_csosn")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.DescCsosn)
                    .HasColumnName("desc_csosn")
                    .HasColumnType("text");

                entity.Property(e => e.NomeCsosn)
                    .IsRequired()
                    .HasColumnName("nome_csosn")
                    .HasColumnType("varchar(128)");
            });

            modelBuilder.Entity<CadIbpt>(entity =>
            {
                entity.ToTable("cad_ibpt");

                entity.Property(e => e.Chave)
                    .HasColumnName("chave")
                    .HasColumnType("text");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasColumnName("descricao")
                    .HasColumnType("text");

                entity.Property(e => e.Estadual).HasColumnName("estadual");

                entity.Property(e => e.Ex)
                    .HasColumnName("ex")
                    .HasColumnType("text");

                entity.Property(e => e.Fonte)
                    .HasColumnName("fonte")
                    .HasColumnType("text");

                entity.Property(e => e.Importadosfederal).HasColumnName("importadosfederal");

                entity.Property(e => e.Municipal).HasColumnName("municipal");

                entity.Property(e => e.Nacionalfederal).HasColumnName("nacionalfederal");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Versao)
                    .HasColumnName("versao")
                    .HasColumnType("text");

                entity.Property(e => e.Vigenciafim)
                    .HasColumnName("vigenciafim")
                    .HasColumnType("text");

                entity.Property(e => e.Vigenciainicio)
                    .HasColumnName("vigenciainicio")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Caixa>(entity =>
            {
                entity.HasKey(e => e.Idcaixa)
                    .HasName("PK_caixa");

                entity.ToTable("caixa");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("Iduser_idx");

                entity.Property(e => e.Idcaixa).HasColumnName("idcaixa");

                entity.Property(e => e.Aberto).HasDefaultValueSql("0");

                entity.Property(e => e.Abertura).HasColumnType("datetime");

                entity.Property(e => e.Conferido).HasDefaultValueSql("0");

                entity.Property(e => e.Encerramento).HasColumnType("datetime");

                entity.Property(e => e.Entradas)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Observacao).HasColumnType("varchar(270)");

                entity.Property(e => e.Operador).HasColumnType("varchar(100)");

                entity.Property(e => e.Saidas)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.SaldoFinal)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.SaldoInicial)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Caixa)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("idUser");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_cliente");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.CpfCnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");


                entity.Property(e => e.NomeFantasia).HasColumnType("varchar(200)");

                entity.Property(e => e.NomeOuRazao).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Cobrador>(entity =>
            {
                entity.HasKey(e => e.Idcobrador)
                    .HasName("PK_cobrador");

                entity.ToTable("cobrador");

                entity.Property(e => e.Idcobrador).HasColumnName("idcobrador");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Comissao).HasColumnType("decimal(5,2)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(300)");
            });

            modelBuilder.Entity<Codigos>(entity =>
            {
                entity.ToTable("codigos");

                entity.Property(e => e.Ean).HasColumnType("varchar(13)");
            });

            modelBuilder.Entity<Comanda>(entity =>
            {
                entity.ToTable("comanda");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abertura).HasColumnType("datetime");

                entity.Property(e => e.Cache).HasDefaultValueSql("0");

                entity.Property(e => e.Encerramento).HasColumnType("datetime");

                entity.Property(e => e.Mesa).HasDefaultValueSql("0");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Pago).HasDefaultValueSql("0");

                entity.Property(e => e.Impresso)
                .HasDefaultValue(false);

                entity.Property(e => e.IdVendedor)
                .HasDefaultValue(0);

                entity.Property(e => e.IdUsuario)
                .HasDefaultValue(0);

                entity.Property(e => e.Pessoas)
                .HasDefaultValue(0);

                entity.Property(e => e.Couvert)
                .HasDefaultValue(0);

                entity.Property(e => e.CodigoCliente)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<ComandaItem>(entity =>
            {
                entity.ToTable("comanda_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cancelado).HasDefaultValueSql("0");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.EmProducao).HasDefaultValueSql("0");

                entity.Property(e => e.Entregue).HasDefaultValueSql("0");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Impresso).HasDefaultValueSql("0");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(11,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Unidade).HasColumnType("varchar(45)");

                entity.Property(e => e.Usuario).HasColumnType("varchar(200)");

                entity.Property(e => e.IdVendedor)
                .HasDefaultValue(0);

                entity.Property(e => e.IdUsuario)
                .HasDefaultValue(0);

                entity.Property(e => e.CancelamentoImpresso)
                .HasDefaultValue(false);

                entity.Property(e => e.Carrinho)
                .HasDefaultValue(false);

                entity.Property(e => e.OrigemCarrinho)
                .HasDefaultValue(false);

                entity.Property(e => e.Reimpresso)
                .HasDefaultValue(false);

                entity.Property(e => e.CodigoCliente)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<ComandaItemGrade>(entity =>
            {
                entity.ToTable("comanda_item_grade");

                entity.Property(e => e.Id);

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValue(0);

            });

            modelBuilder.Entity<ComandaPagamento>(entity =>
            {
                entity.ToTable("comanda_pagamento");

                entity.Property(e => e.Cancelado)
                .HasDefaultValue(false);

                entity.Property(e => e.Impresso)
                .HasDefaultValue(false);

                entity.Property(e => e.IdVendedor)
                .HasDefaultValue(0);

                entity.Property(e => e.IdUsuario)
                .HasDefaultValue(0);

                entity.Property(e => e.IdVendedorCancelamento)
                .HasDefaultValue(0);

                entity.Property(e => e.IdUsuarioCancelamento)
                .HasDefaultValue(0);

            });

            modelBuilder.Entity<Comissao>(entity =>
            {
                entity.HasKey(e => e.IdComissao)
                    .HasName("PK_comissao");

                entity.ToTable("comissao");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.IdCobrador).HasDefaultValueSql("0");

                entity.Property(e => e.IdPagamento).HasDefaultValueSql("0");

                entity.Property(e => e.IdRecebimento).HasDefaultValueSql("0");

                entity.Property(e => e.IdVenda).HasDefaultValueSql("0");

                entity.Property(e => e.IdVendedor).HasDefaultValueSql("0");

                entity.Property(e => e.Pago).HasDefaultValueSql("0");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<ConfigApp>(entity =>
            {
                entity.ToTable("config_app");

                entity.Property(e => e.VexExibirEstoque)
                .HasDefaultValue(true);

                entity.Property(e => e.ComTelaGrupoAtiva)
                .HasDefaultValue(false);

            });

            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasKey(e => e.Idconfig)
                    .HasName("PK_config");

                entity.ToTable("config");

                entity.Property(e => e.ComCouvert)
                .HasDefaultValue(0);

                entity.Property(e => e.PdvObrigarCliente)
                .HasDefaultValue(false);

                entity.Property(e => e.AdmPesUltimoCusto)
                .HasDefaultValue(false);

                entity.Property(e => e.AdmPesSaldo)
                .HasDefaultValue(false);

                entity.Property(e => e.FinDiasBloqueioCliente)
                .HasDefaultValue(0);

                entity.Property(e => e.FinClienteEspecial)
                .HasDefaultValue(false);

                entity.Property(e => e.CmdClienteItem)
                .HasDefaultValue(false);

                entity.Property(e => e.FinDiasAtualizarCadastro)
                .HasDefaultValue(0);

                entity.Property(e => e.PdvPromissoriaResumida).HasDefaultValue(false);

                entity.Property(e => e.PdvPromissoriaPrevenda)
                .HasDefaultValue(false);

                entity.Property(e => e.FinPagContaManual).HasDefaultValue(false);

                entity.Property(e => e.FinRecContaManual).HasDefaultValue(false);

                entity.Property(e => e.PdvAlterarEanProduto)
                .HasDefaultValue(false);

                entity.Property(e => e.TipoDocBaixa).HasDefaultValue(0);

                entity.Property(e => e.PdvCpTrocaPerguntar).HasDefaultValue(false);

                entity.Property(e => e.Idconfig).HasColumnName("idconfig");

                entity.Property(e => e.AcrescimoItem).HasDefaultValueSql("0");

                entity.Property(e => e.AdmMarca).HasDefaultValueSql("0");

                entity.Property(e => e.AdmMesas).HasDefaultValueSql("30");

                entity.Property(e => e.AdmZerosNaReferencia).HasDefaultValueSql("1");

                entity.Property(e => e.AtualizacaoAutomatica).HasDefaultValueSql("0");

                entity.Property(e => e.AutoProducao).HasDefaultValueSql("0");

                entity.Property(e => e.NFCeSinc).HasDefaultValue(true);

                entity.Property(e => e.ValidadeCredito).HasDefaultValue(30);

                entity.Property(e => e.MensagemCredito)
                    .HasDefaultValue(true);

                entity.Property(e => e.NFeEnviarBarras).HasDefaultValue(false);

                entity.Property(e => e.NFeEnviarRefrencia).HasDefaultValue(false);

                entity.Property(e => e.PdvListarNFCePrimeiro).HasDefaultValue(false);

                entity.Property(e => e.BalDecimaisPrecoPeso)
                    .HasColumnName("balDecimaisPrecoPeso")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.BalDigitoInicial)
                    .HasColumnName("balDigitoInicial")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.BalDigitosCodigo)
                    .HasColumnName("balDigitosCodigo")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.BalDigitosPrecoPeso)
                    .HasColumnName("balDigitosPrecoPeso")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("6");

                entity.Property(e => e.BalPrecoPeso)
                    .HasColumnName("balPrecoPeso")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Peso");

                entity.Property(e => e.CadClientesInformacoesComplementares)
                    .HasColumnName("cadClientesInformacoesComplementares")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CadProdBarras).HasDefaultValueSql("0");

                entity.Property(e => e.CadProdCustos).HasDefaultValueSql("0");

                entity.Property(e => e.CadProdDescIgual).HasDefaultValueSql("0");

                entity.Property(e => e.CadProdHistorico).HasDefaultValueSql("1");

                entity.Property(e => e.CadProdObs).HasDefaultValueSql("1");

                entity.Property(e => e.CadProdPrecoLista).HasDefaultValueSql("0");

                entity.Property(e => e.CadProdSubgrupo).HasDefaultValueSql("0");

                entity.Property(e => e.CadProdutoEmpresaCusto)
                    .HasColumnName("cadProdutoEmpresaCusto")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CadProdutoPrecoAtacado)
                    .HasColumnName("cadProdutoPrecoAtacado")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CampoQuantidade).HasDefaultValueSql("1");

                entity.Property(e => e.CanhotoPromissoria).HasDefaultValueSql("0");

                entity.Property(e => e.ComServico)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ContagemDocumento)
                    .HasColumnName("contagemDocumento")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ControlePromocao).HasDefaultValueSql("0");

                entity.Property(e => e.DavFonte)
                    .HasColumnName("davFonte")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("Draft Condensed");

                entity.Property(e => e.DavTamanhoLetra)
                    .HasColumnName("davTamanhoLetra")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.DecimaisPreco)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'00'");

                entity.Property(e => e.DecimaisCustoManual)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'00'");

                entity.Property(e => e.DecimaisQuantidade)
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'000'");

                entity.Property(e => e.DescontoItem).HasDefaultValueSql("0");

                entity.Property(e => e.DiretorioBackup).HasColumnType("varchar(200)");

                entity.Property(e => e.DiretorioNotas).HasColumnType("varchar(100)");

                entity.Property(e => e.EmailEmail)
                    .HasColumnName("emailEmail")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.EmailPorta)
                    .HasColumnName("emailPorta")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.EmailRemetente)
                    .HasColumnName("emailRemetente")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.EmailRodape)
                    .HasColumnName("emailRodape")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.EmailSenha)
                    .HasColumnName("emailSenha")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.EmailSmtp)
                    .HasColumnName("emailSmtp")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.EmailSsl)
                    .HasColumnName("emailSSL")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExibirAniversariantesHome).HasDefaultValueSql("1");

                entity.Property(e => e.ExibirBackupHome).HasDefaultValueSql("1");

                entity.Property(e => e.ExibirLotesHome).HasDefaultValueSql("0");

                entity.Property(e => e.ExibirPagamentosHome).HasDefaultValueSql("1");

                entity.Property(e => e.ExibirOrdemEntregaHome).HasDefaultValueSql("0");

                entity.Property(e => e.ExibirRecebimentosHome).HasDefaultValueSql("1");

                entity.Property(e => e.FinCnpjNaLista).HasDefaultValueSql("0");

                entity.Property(e => e.FinComprovanteResumido).HasDefaultValueSql("1");

                entity.Property(e => e.FinControleBoleto).HasDefaultValueSql("0");

                entity.Property(e => e.FinDataOriginalDocParcial)
                    .HasColumnName("finDataOriginalDocParcial")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinLancarPagCaixa).HasDefaultValueSql("0");

                entity.Property(e => e.FinNaoAplicarJuros).HasDefaultValueSql("0");

                entity.Property(e => e.FinPagColunaNfe)
                    .HasColumnName("FinPagColunaNFe")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FinPagColunaObs).HasDefaultValueSql("0");

                entity.Property(e => e.FinRecebido).HasDefaultValueSql("0");

                entity.Property(e => e.IdEmpresaImpressao).HasDefaultValueSql("0");

                entity.Property(e => e.ImpAtualizarTributacao).HasDefaultValueSql("0");

                entity.Property(e => e.ImpBarras).HasDefaultValueSql("0");

                entity.Property(e => e.ImpQuantidadeUnidade).HasDefaultValueSql("0");

                entity.Property(e => e.ImportacaoAtualizarCest)
                    .HasColumnName("importacaoAtualizarCest")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImportacaoAtualizarEan).HasDefaultValueSql("0");

                entity.Property(e => e.ImportacaoAtualizarNcm)
                    .HasColumnName("importacaoAtualizarNcm")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImportacaoCodigoGrupo)
                    .HasColumnName("importacaoCodigoGrupo")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImportacaoCodigoMarca)
                    .HasColumnName("importacaoCodigoMarca")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImportacaoCodigoUnidade)
                    .HasColumnName("importacaoCodigoUnidade")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ImportacaoDecimaisQuantidade)
                    .HasColumnName("importacaoDecimaisQuantidade")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("000");

                entity.Property(e => e.ImportacaoDecimaisValores)
                    .HasColumnName("importacaoDecimaisValores")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("00");

                entity.Property(e => e.ImportacaoIdPc3).HasDefaultValueSql("0");

                entity.Property(e => e.ImportacaoImportarBoletos)
                    .HasColumnName("importacaoImportarBoletos")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ImportacaoLucroAtacado)
                    .HasColumnName("importacaoLucroAtacado")
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("30.00");

                entity.Property(e => e.ImportacaoLucroVarejo)
                    .HasColumnName("importacaoLucroVarejo")
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("30.00");

                entity.Property(e => e.ImportacaoRelacionamentoInteligente)
                    .HasColumnName("importacaoRelacionamentoInteligente")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaisPrecos).HasDefaultValueSql("0");

                entity.Property(e => e.MaisReferencias).HasDefaultValueSql("0");

                entity.Property(e => e.NfBaixaEstoqueDav)
                    .HasColumnName("nfBaixaEstoqueDav")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NfceAmbiente)
                    .HasColumnName("nfceAmbiente")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.NfeAmbiente)
                    .HasColumnName("nfeAmbiente")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.NfeBaixaEstoqueDav).HasDefaultValueSql("0");

                entity.Property(e => e.NfeBloquearSaldoZerado).HasDefaultValueSql("0");

                entity.Property(e => e.NfeGerarBoleto).HasDefaultValueSql("0");

                entity.Property(e => e.NfeLancarCaixa)
                    .HasColumnName("nfeLancarCaixa")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OsBloquearSaldoZerado).HasDefaultValueSql("0");

                entity.Property(e => e.OsIdEmpresaSaldo).HasDefaultValueSql("1");

                entity.Property(e => e.OsObrigarIdentificacao).HasDefaultValueSql("0");

                entity.Property(e => e.OsOrdemAlfabetica).HasDefaultValueSql("0");

                entity.Property(e => e.OsVerificarAberta).HasDefaultValueSql("0");

                entity.Property(e => e.PdvAlterarData).HasDefaultValueSql("0");

                entity.Property(e => e.PdvBalBarras)
                    .HasColumnName("pdvBalBarras")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvBeep)
                    .HasColumnName("pdvBeep")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvBtnPrecos).HasDefaultValueSql("0");

                entity.Property(e => e.PdvCliente).HasDefaultValueSql("0");

                entity.Property(e => e.PdvConfirmacaoUsuario)
                    .HasColumnName("pdvConfirmacaoUsuario")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvCpTrocaDiasValidade).HasDefaultValueSql("30");

                entity.Property(e => e.FinRecConfirmacaoUsuario)
                .HasDefaultValue(false);

                entity.Property(e => e.FinPagConfirmacaoUsuario)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvCpTrocaMensagem).HasColumnType("text");

                entity.Property(e => e.PdvDavBloquearSaldoZerado)
                    .HasColumnName("pdvDavBloquearSaldoZerado")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDavEscolherEmpresa)
                    .HasColumnName("pdvDavEscolherEmpresa")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDavFinalizacaoCompleta)
                    .HasColumnName("pdvDavFinalizacaoCompleta")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDavFonteGrande)
                    .HasColumnName("pdvDavFonteGrande")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDavImprimirFantasia)
                    .HasColumnName("pdvDavImprimirFantasia")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvDavImprimirRazao)
                    .HasColumnName("pdvDavImprimirRazao")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvDavMensagemFixa)
                    .HasColumnName("pdvDavMensagemFixa")
                    .HasColumnType("text");

                entity.Property(e => e.PdvDavMensagemNaoFiscal)
                    .HasColumnName("pdvDavMensagemNaoFiscal")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvDavModelo)
                    .HasColumnName("pdvDavModelo")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvDavMsgImp).HasDefaultValueSql("0");

                entity.Property(e => e.PdvDavPerguntarImprimir)
                    .HasColumnName("pdvDavPerguntarImprimir")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDavProdutoEmDuasLinhas)
                    .HasColumnName("pdvDavProdutoEmDuasLinhas")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDerrubarUsuario).HasDefaultValueSql("0");

                entity.Property(e => e.PdvDesativarFinalizacaoOrc)
                    .HasColumnName("pdvDesativarFinalizacaoOrc")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvDescApenasProdutos)
                    .HasColumnName("pdvDescApenasProdutos")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvEmpresaListaProdutos)
                    .HasColumnName("pdvEmpresaListaProdutos")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvExibirLocal).HasDefaultValueSql("0");

                entity.Property(e => e.PdvExibirMarca)
                    .HasColumnName("pdvExibirMarca")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvExibirNumeroDav)
                    .HasColumnName("pdvExibirNumeroDav")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvExibirPrecoAtacado)
                    .HasColumnName("pdvExibirPrecoAtacado")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvExibirReferencia)
                    .HasColumnName("pdvExibirReferencia")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvExibirReferencia2)
                    .HasColumnName("pdvExibirReferencia2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvExibirReserva).HasDefaultValueSql("0");

                entity.Property(e => e.PdvHabilitarDav)
                    .HasColumnName("pdvHabilitarDav")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvHabilitarNfce)
                    .HasColumnName("pdvHabilitarNfce")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvHabilitarOrc)
                    .HasColumnName("pdvHabilitarOrc")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvImprimirPromissoria)
                    .HasColumnName("pdvImprimirPromissoria")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvInterfaceSimplificada)
                    .HasColumnName("pdvInterfaceSimplificada")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvMascaras).HasDefaultValueSql("1");

                entity.Property(e => e.PdvNaoDestacarAdicional).HasDefaultValueSql("0");

                entity.Property(e => e.PdvNfceBloquearSaldoZerado)
                    .HasColumnName("pdvNfceBloquearSaldoZerado")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PdvNfceEscolherEmpresa).HasDefaultValueSql("0");

                entity.Property(e => e.PdvNfceFonteGrande)
                    .HasColumnName("pdvNfceFonteGrande")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvNfceNaoLancarCaixa)
                    .HasColumnName("pdvNfceNaoLancarCaixa")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvNfceObrigarCpf)
                    .HasColumnName("pdvNfceObrigarCpf")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PdvNfcePerguntarImprimir)
                    .HasColumnName("pdvNfcePerguntarImprimir")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvNfceProdutoEmDuasLinhas)
                    .HasColumnName("pdvNfceProdutoEmDuasLinhas")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvObrigarVendedor).HasDefaultValueSql("0");

                entity.Property(e => e.PdvObrigarVendedorPreVenda).HasDefaultValueSql("1");
                entity.Property(e => e.PdvObrigarVendedorPreVenda)
                .HasDefaultValueSql("1");

                entity.Property(e => e.PdvPreVendaSaldoDav)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvOcultarDav)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvOcultarDescAcre).HasDefaultValueSql("0");

                entity.Property(e => e.PdvOcultarOrc).HasDefaultValueSql("0");

                entity.Property(e => e.PdvOe).HasDefaultValueSql("0");

                entity.Property(e => e.PdvOeAutomatica)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvOePreVenda)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvOrcReferenciaImpressao)
                    .HasColumnName("pdvOrcReferenciaImpressao")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvPagPadrao).HasDefaultValueSql("0");

                entity.Property(e => e.PdvPercentualAprazo)
                    .HasColumnName("pdvPercentualAPrazo")
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PdvTelaAvAp).HasDefaultValueSql("0");

                entity.Property(e => e.PdvTipoAtacado)
                    .HasColumnName("pdvTipoAtacado")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvToleranciaClienteAtraso)
                    .HasColumnName("pdvToleranciaClienteAtraso")
                    .HasDefaultValueSql("7");

                entity.Property(e => e.PdvTotalServicos)
                    .HasColumnName("pdvTotalServicos")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PdvValorAp).HasDefaultValueSql("0");

                entity.Property(e => e.PdvVerificarItemVenda).HasDefaultValueSql("0");

                entity.Property(e => e.PdvViasSangria).HasDefaultValueSql("1");

                entity.Property(e => e.PdvZerarDescontoImportacao).HasDefaultValueSql("1");

                entity.Property(e => e.SalvarPdfNfce).HasDefaultValueSql("0");

                entity.Property(e => e.SalvarPdfNfe).HasDefaultValueSql("1");

                entity.Property(e => e.SepararNotasPorCnpj).HasDefaultValueSql("0");

                entity.Property(e => e.SepararNotasPorDia).HasDefaultValueSql("0");

                entity.Property(e => e.SepararPdfXml).HasDefaultValueSql("1");

                entity.Property(e => e.TeclasTrocoRapido).HasDefaultValueSql("0");

                entity.Property(e => e.TefIdentificador).HasDefaultValueSql("0");

                entity.Property(e => e.TempInformacoesRespTec)
                    .HasColumnName("tempInformacoesRespTec")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TipoEmpresa)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("Geral");

                entity.Property(e => e.TribLicenca).HasColumnType("text");

                entity.Property(e => e.TribToken).HasColumnType("text");

                entity.Property(e => e.ViasComprovanteBaixa).HasDefaultValueSql("1");

                entity.Property(e => e.ViasDav).HasDefaultValueSql("1");

                entity.Property(e => e.DescricaoPreco1)
                .HasColumnType("varchar(100)")
                .HasDefaultValue("Preco Varejo");

                entity.Property(e => e.DescricaoPreco2)
                .HasColumnType("varchar(100)")
                .HasDefaultValue("Preco Atacado");

                entity.Property(e => e.DescricaoPreco3)
                .HasColumnType("varchar(100)")
                .HasDefaultValue("Preco 3");

                entity.Property(e => e.DescricaoPreco4)
                .HasColumnType("varchar(100)")
                .HasDefaultValue("Preco 4");

                entity.Property(e => e.DescricaoPreco5)
                .HasColumnType("varchar(100)")
                .HasDefaultValue("Preco 5");

                entity.Property(e => e.DescricaoPreco6)
                .HasColumnType("varchar(100)")
                .HasDefaultValue("Preco 6");

                entity.Property(e => e.PdvVerificarItens)
                .HasDefaultValue(false);

                entity.Property(e => e.LogoGrande)
                .HasDefaultValue(false);

                entity.Property(e => e.ControleDevolucao)
                .HasDefaultValue(false);

                entity.Property(e => e.NFeRegrasMaisConsult)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvTelaFixarPrecoDocumento)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvDavEditarFinalizado)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvDavViasImpPrevenda)
                .HasDefaultValue(1);

                entity.Property(e => e.PdvDavImpNumeroPrevenda)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvCodificarCusto)
                .HasDefaultValue(false);

                entity.Property(e => e.PdvMensagemPromissoria)
                    .HasColumnType("text");

                entity.Property(e => e.NFeZerarDescAcreImportacao)
                    .HasDefaultValue(false);

                entity.Property(e => e.PdvFiltrarNCFe)
                    .HasDefaultValue(false);

                entity.Property(e => e.PdvDavGuiaConferencia)
                    .HasDefaultValue(false);

                entity.Property(e => e.PdvCashback)
                    .HasDefaultValue(0);

                entity.Property(e => e.PdvCorSaldo)
                    .HasDefaultValue(true);

                entity.Property(e => e.NFeCanhotoResumo)
                    .HasDefaultValue(false);

                entity.Property(e => e.PdvOeVias)
                    .HasDefaultValue(1);

            });

            modelBuilder.Entity<ConfigTef>(entity =>
            {
                entity.ToTable("config_tef");

                entity.Property(e => e.Tipo)
                .HasDefaultValue(BancoERP.Enums.TipoTef.Desativado);

            });

            modelBuilder.Entity<TefControle>(entity =>
            {
                entity.ToTable("tef_controle");

                entity.Property(e => e.Confirmada)
                .HasDefaultValue(false);

                entity.Property(e => e.Valor)
                .HasDefaultValue(0);

            });

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.ToTable("conta");

                entity.Property(e => e.Agencia).HasColumnType("varchar(45)");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Banco).HasColumnType("varchar(100)");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Entrada).HasDefaultValueSql("0");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");

                entity.Property(e => e.Numero).HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(45)");

                entity.Property(e => e.Subconta).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Contabilidade>(entity =>
            {
                entity.ToTable("contabilidade");

                entity.Property(e => e.Logo).HasColumnType("mediumblob");
            });

            modelBuilder.Entity<Contagem>(entity =>
            {
                entity.ToTable("contagem");
            });

            modelBuilder.Entity<ContaMovimentacao>(entity =>
            {
                entity.ToTable("conta_movimentacao");

                entity.Property(e => e.DataMovimentacao).HasColumnType("datetime");

                entity.Property(e => e.DataPagamento).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.IdCaixa).HasColumnType("varchar(45)");

                entity.Property(e => e.IdPagamento).HasColumnType("varchar(45)");

                entity.Property(e => e.IdRecebimento).HasColumnType("varchar(45)");

                entity.Property(e => e.IdVenda).HasColumnType("varchar(45)");

                entity.Property(e => e.Manual).HasDefaultValueSql("0");

                entity.Property(e => e.Numero).HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("text");

                entity.Property(e => e.Valor).HasColumnType("decimal(20,2)");
            });

            modelBuilder.Entity<Contato>(entity =>
            {
                entity.HasKey(e => e.Idcontato)
                    .HasName("PK_contato");

                entity.ToTable("contato");

                entity.Property(e => e.Idcontato).HasColumnName("idcontato");

                entity.Property(e => e.Celular).HasColumnType("varchar(45)");

                entity.Property(e => e.Celular2).HasColumnType("varchar(45)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Excluido)
                    .HasColumnName("excluido")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NomeRepresentante).HasColumnType("varchar(100)");

                entity.Property(e => e.Ramal).HasColumnType("varchar(45)");

                entity.Property(e => e.Telefone).HasColumnType("varchar(45)");

                entity.Property(e => e.Telefone2).HasColumnType("varchar(45)");

                entity.Property(e => e.TelefoneRepresentante).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Controlador>(entity =>
            {
                entity.HasKey(e => e.IdControlador)
                    .HasName("PK_controlador");

                entity.ToTable("controlador");

                entity.Property(e => e.IdControlador).HasColumnName("idControlador");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IpComputador)
                    .HasColumnName("ipComputador")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.MacMaquina)
                    .HasColumnName("macMaquina")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.NomeMaquina)
                    .HasColumnName("nomeMaquina")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.VersaoSistema)
                    .HasColumnName("versaoSistema")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Controlenota>(entity =>
            {
                entity.HasKey(e => e.IdEstabelecimento)
                    .HasName("fk_entradanota_has_estabelecimento_estabelecimento1_idx");

                entity.ToTable("controlenota");

                entity.Property(e => e.IdEstabelecimento).HasColumnName("idEstabelecimento");

                entity.Property(e => e.Cancelada).HasDefaultValueSql("0");

                entity.Property(e => e.DataLiberacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Credito>(entity =>
            {
                entity.ToTable("credito");

                entity.Property(e => e.Cancelado).HasDefaultValueSql("0");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.Valor).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Vencimento).HasColumnType("datetime");

                entity.Property(e => e.IdAdiantamento)
                .HasDefaultValue(0);

            });

            modelBuilder.Entity<Customedio>(entity =>
            {
                entity.HasKey(e => e.Idcustomedio)
                    .HasName("PK_customedio");

                entity.ToTable("customedio");

                entity.HasIndex(e => e.CodigoProduto)
                    .HasName("fk_produto_idx");

                entity.Property(e => e.Idcustomedio).HasColumnName("idcustomedio");

                entity.Property(e => e.DataMovimentacao).HasColumnType("datetime");

                entity.Property(e => e.IdSaida).HasDefaultValueSql("0");

                entity.Property(e => e.Valor)
                .HasColumnType("decimal(11,4)");

                entity.Property(e => e.Quantidade)
                .HasColumnType("decimal(11,3)")
                .HasDefaultValue(1);

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany(p => p.Customedio)
                    .HasPrincipalKey(p => p.Codigo)
                    .HasForeignKey(d => d.CodigoProduto)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_produto");
            });

            modelBuilder.Entity<Despesa>(entity =>
            {
                entity.ToTable("despesa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Dispositivos>(entity =>
            {
                entity.ToTable("dispositivos");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Comanda).HasDefaultValueSql("0");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Identificacao).HasColumnType("varchar(200)");

                entity.Property(e => e.VendaExterna).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("empresa");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.Database).HasColumnType("varchar(100)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Host).HasColumnType("varchar(200)");

                entity.Property(e => e.Razao).HasColumnType("varchar(200)");

                entity.Property(e => e.Senha).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<EmpresaAtividade>(entity =>
            {
                entity.ToTable("empresa_atividade");

                entity.Property(e => e.Codigo).HasColumnType("varchar(45)");

                entity.Property(e => e.Descricao).HasColumnType("text");
            });

            modelBuilder.Entity<EmpresaCnae>(entity =>
            {
                entity.ToTable("empresa_cnae");

                entity.Property(e => e.Codigo).HasColumnType("varchar(45)");

                entity.Property(e => e.Descricao).HasColumnType("text");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.Idendereco)
                    .HasName("PK_endereco");

                entity.ToTable("endereco");

                entity.Property(e => e.Idendereco).HasColumnName("idendereco");

                entity.Property(e => e.Bairro).HasColumnType("varchar(150)");

                entity.Property(e => e.Cep).HasColumnType("varchar(45)");

                entity.Property(e => e.Cidade).HasColumnType("varchar(150)");

                entity.Property(e => e.CodigoMunicipio).HasColumnType("varchar(45)");

                entity.Property(e => e.Complemento).HasColumnType("varchar(400)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Excluido)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Latitude).HasColumnType("decimal(20,15)");

                entity.Property(e => e.Logradouro).HasColumnType("varchar(150)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(20,15)");

                entity.Property(e => e.Numero).HasColumnType("varchar(45)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Uf).HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<Entradaitem>(entity =>
            {
                entity.HasKey(e => e.Identradaitem)
                    .HasName("PK_entradaitem");

                entity.ToTable("entradaitem");

                entity.HasIndex(e => e.IdEntrada)
                    .HasName("IdEntrada_idx");

                entity.Property(e => e.Identradaitem).HasColumnName("identradaitem");

                entity.Property(e => e.BaseIcms)
                .HasColumnType("decimal(15,3)");

                entity.Property(e => e.BaseIcmsSt)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CEnqIpi)
                    .HasColumnName("cEnqIPI")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cest).HasColumnType("varchar(10)");

                entity.Property(e => e.Cfop)
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("5102");

                entity.Property(e => e.CodigoBarras).HasColumnType("varchar(20)");

                entity.Property(e => e.CstCofins).HasDefaultValueSql("99");

                entity.Property(e => e.CstCso).HasColumnType("varchar(4)");

                entity.Property(e => e.CstIpi).HasDefaultValueSql("0");

                entity.Property(e => e.CstPis)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.Desconto)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Desmembrado).HasDefaultValueSql("0");

                entity.Property(e => e.IdOrigem).HasDefaultValueSql("0");

                entity.Property(e => e.ModBcicms)
                    .HasColumnName("ModBCICMS")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ModBcicmsst)
                    .HasColumnName("ModBCICMSST")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Ncm).HasColumnType("varchar(10)");

                entity.Property(e => e.Origem).HasDefaultValueSql("0");

                entity.Property(e => e.OutrasDespesas)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PCofins)
                    .HasColumnName("pCofins")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcms)
                    .HasColumnName("pICMS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcmsst)
                    .HasColumnName("pICMSST")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.PIpi)
                    .HasColumnName("pIPI")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PMvast)
                    .HasColumnName("pMVAST")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PPis)
                    .HasColumnName("pPIS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PRedBc)
                    .HasColumnName("pRedBC")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.PRedBcst)
                    .HasColumnName("pRedBCST")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.PcredSn)
                    .HasColumnName("PCredSN")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(11,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.UnidadeMedida)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Un");

                entity.Property(e => e.VBcCofins)
                    .HasColumnName("vBcCofins")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcipi)
                    .HasColumnName("vBCIPI")
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcpis)
                    .HasColumnName("vBCPIS")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcstret)
                    .HasColumnName("vBCSTRet")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnName("vICMSDeson")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.VIcmsstret)
                    .HasColumnName("vICMSSTRet")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIi)
                    .HasColumnName("vII")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ValorCofins)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIcms)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIcmsSt)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIpi)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorPis)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorSeguro)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorTotTrib)
                .HasColumnType("decimal(15,3)");

                entity.Property(e => e.DescontoRateado)
                .HasColumnType("decimal(15,3)")
                .HasDefaultValue(0);
                entity.Property(e => e.AcrescimoRateado)
                .HasColumnType("decimal(15,3)")
                .HasDefaultValue(0);

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("decimal(15,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.VcredSn)
                    .HasColumnName("VCredSN")
                    .HasColumnType("decimal(13,2)");

                entity.HasOne(d => d.IdEntradaNavigation)
                    .WithMany(p => p.Entradaitem)
                    .HasForeignKey(d => d.IdEntrada)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("IdEntrada");
            });

            modelBuilder.Entity<Entradanota>(entity =>
            {
                entity.HasKey(e => e.Identradanota)
                    .HasName("PK_entradanota");

                entity.ToTable("entradanota");

                entity.Property(e => e.IndPag)
                .HasDefaultValue(0);

                entity.Property(e => e.Identradanota).HasColumnName("identradanota");

                entity.Property(e => e.CMun)
                    .HasColumnName("cMun")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CPais)
                    .HasColumnName("cPais")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.Cancelada).HasDefaultValueSql("0");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.ChaveAcesso).HasColumnType("varchar(44)");

                entity.Property(e => e.CpfCnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.DataChegada).HasColumnType("datetime");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.DhSaiEnt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");

                entity.Property(e => e.FinNfe)
                    .HasColumnName("finNFe")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IdDest).HasDefaultValueSql("1");

                entity.Property(e => e.IdEstrangeiro)
                    .HasColumnName("idEstrangeiro")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IndFinal)
                    .HasColumnName("indFinal")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IndIedest)
                    .HasColumnName("indIEDest")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.IndPres)
                    .HasColumnName("indPres")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Isuf)
                    .HasColumnName("ISUF")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Liberada).HasDefaultValueSql("0");

                entity.Property(e => e.ModFrete)
                    .HasColumnName("modFrete")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.Modelo).HasColumnType("varchar(10)");

                entity.Property(e => e.NatOp)
                    .HasColumnName("natOp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.NomeVendedor).HasColumnType("varchar(60)");

                entity.Property(e => e.NotaImportada).HasDefaultValueSql("0");

                entity.Property(e => e.Nro)
                    .HasColumnName("nro")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Serie).HasColumnType("varchar(4)");

                entity.Property(e => e.Situacao)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Em Digitação");

                entity.Property(e => e.TpAmb)
                    .HasColumnName("tpAmb")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.TpEmis)
                    .HasColumnName("tpEmis")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TpImp)
                    .HasColumnName("tpImp")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TpNf)
                    .HasColumnName("tpNF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.VBc)
                    .HasColumnName("vBC")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VBcst)
                    .HasColumnName("vBCST")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VCofins)
                    .HasColumnName("vCOFINS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VDesc)
                    .HasColumnName("vDesc")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VDesp)
                    .HasColumnName("vDesp")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VFrete)
                    .HasColumnName("vFrete")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcms)
                    .HasColumnName("vICMS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnName("vICMSDeson")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIi)
                    .HasColumnName("vII")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIpi)
                    .HasColumnName("vIPI")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VNf)
                    .HasColumnName("vNF")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VOutro)
                    .HasColumnName("vOutro")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VPis)
                    .HasColumnName("vPIS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VProd)
                    .HasColumnName("vProd")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VSeg)
                    .HasColumnName("vSeg")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VSt)
                    .HasColumnName("vST")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VTotTrib)
                    .HasColumnName("vTotTrib")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VTroco)
                    .HasColumnName("vTroco")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.XCpl)
                    .HasColumnName("xCpl")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XLgr)
                    .HasColumnName("xLgr")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XMun)
                    .HasColumnName("xMun")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.XNome)
                    .HasColumnName("xNome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.XPais)
                    .HasColumnName("xPais")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("BRASIL");
            });

            modelBuilder.Entity<Estabelecimento>(entity =>
            {
                entity.HasKey(e => e.IdEstabelecimento)
                    .HasName("PK_estabelecimento");

                entity.ToTable("estabelecimento");

                entity.HasIndex(e => e.Idcontato)
                    .HasName("fk_empresa_contato1_idx");

                entity.HasIndex(e => e.Idendereco)
                    .HasName("fk_empresa_endereco1_idx");

                entity.Property(e => e.IdEstabelecimento).HasColumnName("idEstabelecimento");

                entity.Property(e => e.AliqCreditoSimples)
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Cnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.CpfCnpjContador).HasColumnType("varchar(45)");

                entity.Property(e => e.Crt)
                    .HasColumnName("CRT")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CscHomo).HasColumnType("varchar(80)");

                entity.Property(e => e.CscProd).HasColumnType("varchar(80)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnName("dataCadastro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.EmailContabilidade).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdCertificado).HasColumnType("varchar(100)");

                entity.Property(e => e.IdCscHomo).HasDefaultValueSql("1");

                entity.Property(e => e.IdCscProd).HasDefaultValueSql("1");

                entity.Property(e => e.Idcontato).HasColumnName("idcontato");

                entity.Property(e => e.Idendereco).HasColumnName("idendereco");

                entity.Property(e => e.Iestadual)
                    .HasColumnName("IEstadual")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Logo).HasColumnType("mediumblob");

                entity.Property(e => e.NomeFantasia).HasColumnType("varchar(200)");

                entity.Property(e => e.NumeroDav).HasDefaultValueSql("1");

                entity.Property(e => e.NumeroNfceHomo).HasDefaultValueSql("0");

                entity.Property(e => e.NumeroNfceProd).HasDefaultValueSql("0");

                entity.Property(e => e.NumeroNfeHomo).HasDefaultValueSql("0");

                entity.Property(e => e.NumeroNfeProd).HasDefaultValueSql("0");

                entity.Property(e => e.NumeroOrc).HasDefaultValueSql("1");

                entity.Property(e => e.PortaAcbr).HasDefaultValueSql("3434");

                entity.Property(e => e.Razao).HasColumnType("varchar(200)");

                entity.Property(e => e.SenhaCertificado).HasColumnType("varchar(45)");

                entity.Property(e => e.SerieNfce).HasDefaultValueSql("1");

                entity.Property(e => e.SerieNfe).HasDefaultValueSql("1");

                entity.Property(e => e.BloquearDFe)
                .HasDefaultValue(false);

                entity.HasOne(d => d.IdcontatoNavigation)
                    .WithMany(p => p.Estabelecimento)
                    .HasForeignKey(d => d.Idcontato)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_empresa_contato1");

                entity.HasOne(d => d.IdenderecoNavigation)
                    .WithMany(p => p.Estabelecimento)
                    .HasForeignKey(d => d.Idendereco)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_empresa_endereco1");
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasKey(e => e.Idestoque)
                    .HasName("PK_estoque");

                entity.ToTable("estoque");

                entity.HasIndex(e => e.CodigoProduto)
                    .HasName("Produto_idx");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("Empresa_idx");

                entity.Property(e => e.Idestoque).HasColumnName("idestoque");

                entity.Property(e => e.Saldo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.SaldoOe)
                    .HasColumnName("SaldoOE")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.SaldoOs)
                    .HasColumnName("SaldoOS")
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany(p => p.EstoqueNavigation)
                    .HasPrincipalKey(p => p.Codigo)
                    .HasForeignKey(d => d.CodigoProduto)
                    .HasConstraintName("Produto");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Estoque)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("Empresa");
            });

            modelBuilder.Entity<Etiqueta>(entity =>
            {
                entity.HasKey(e => e.IdEtiqueta)
                    .HasName("PK_etiqueta");

                entity.ToTable("etiqueta");

                entity.Property(e => e.IdEtiqueta).HasColumnName("idEtiqueta");

                entity.Property(e => e.Codigo).HasColumnType("varchar(45)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(120)");

                entity.Property(e => e.Entrega).HasDefaultValueSql("0");

                entity.Property(e => e.IdSaida).HasDefaultValueSql("0");

                entity.Property(e => e.Quantidade).HasDefaultValueSql("3");

                entity.Property(e => e.Validade).HasColumnType("datetime");
            });

            modelBuilder.Entity<Eventonota>(entity =>
            {
                entity.HasKey(e => e.Ideventonota)
                    .HasName("PK_eventonota");

                entity.ToTable("eventonota");

                entity.Property(e => e.Ideventonota).HasColumnName("ideventonota");

                entity.Property(e => e.Codigo).HasColumnType("varchar(45)");

                entity.Property(e => e.DataEnvio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Tipo).HasColumnType("varchar(100)");

                entity.Property(e => e.Xml).HasColumnType("blob");
            });

            modelBuilder.Entity<Faturanota>(entity =>
            {
                entity.ToTable("faturanota");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Boleto).HasDefaultValueSql("0");

                entity.Property(e => e.DVenc)
                    .HasColumnName("dVenc")
                    .HasColumnType("datetime");

                entity.Property(e => e.NDup).HasColumnName("nDup");

                entity.Property(e => e.NFat)
                    .HasColumnName("nFat")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.VDesc)
                    .HasColumnName("vDesc")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VDup)
                    .HasColumnName("vDup")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.VLiq)
                    .HasColumnName("vLiq")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.VOrig)
                    .HasColumnName("vOrig")
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor)
                    .HasName("PK_fornecedor");

                entity.ToTable("fornecedor");

                entity.HasIndex(e => e.Idcontato)
                    .HasName("fk_fornecedor_contato1_idx");

                entity.HasIndex(e => e.Idendereco)
                    .HasName("fk_fornecedor_endereco1_idx");

                entity.Property(e => e.IdFornecedor).HasColumnName("idFornecedor");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.CpfCnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnName("dataCadastro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Idcontato).HasColumnName("idcontato");

                entity.Property(e => e.Idendereco).HasColumnName("idendereco");

                entity.Property(e => e.NomeFantasia).HasColumnType("varchar(200)");

                entity.Property(e => e.NomeOuRazao).HasColumnType("varchar(200)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(200)");

                entity.Property(e => e.Regime)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Simples");

                entity.Property(e => e.RgIe).HasColumnType("varchar(45)");

                entity.Property(e => e.TipoPessoa)
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("F");

                entity.HasOne(d => d.IdcontatoNavigation)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.Idcontato)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_fornecedor_contato1");

                entity.HasOne(d => d.IdenderecoNavigation)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.Idendereco)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_fornecedor_endereco1");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.ToTable("funcionario");

                entity.HasIndex(e => e.IdContato)
                    .HasName("fk_fornecedor_contato1_idx");

                entity.HasIndex(e => e.IdEndereco)
                    .HasName("fk_fornecedor_endereco1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apelido).HasColumnType("varchar(200)");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Cpf).HasColumnType("varchar(45)");

                entity.Property(e => e.CreditoLimite)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.Nome).HasColumnType("varchar(200)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(200)");

                entity.Property(e => e.Rg).HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdContatoNavigation)
                    .WithMany(p => p.Funcionario)
                    .HasForeignKey(d => d.IdContato)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_funcionario_contato");

                entity.HasOne(d => d.IdEnderecoNavigation)
                    .WithMany(p => p.Funcionario)
                    .HasForeignKey(d => d.IdEndereco)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_funcionadrio_endereco");
            });


            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grade");

                entity.Property(e => e.Idx)
                .HasColumnName("idx");

                entity.Property(e => e.Idy)
                .HasColumnName("idy");

                entity.Property(e => e.Idz)
                .HasDefaultValue(0);

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");

                entity.Property(e => e.Saldo).HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<GradeX>(entity =>
            {
                entity.ToTable("grade_x");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GradeY>(entity =>
            {
                entity.ToTable("grade_y");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<GradeZ>(entity =>
            {
                entity.ToTable("grade_z");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ativa).HasDefaultValue(true);

                entity.Property(e => e.Excluida).HasDefaultValue(false);
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.Idgrupo)
                    .HasName("PK_grupo");

                entity.ToTable("grupo");

                entity.Property(e => e.Idgrupo).HasColumnName("idgrupo");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.Comissao)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Imagem).HasColumnType("longblob");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Impressora>(entity =>
            {
                entity.ToTable("impressora");

                entity.Property(e => e.Automatica).HasDefaultValueSql("0");

                entity.Property(e => e.Caminho).HasColumnType("text");

                entity.Property(e => e.Conta).HasDefaultValueSql("0");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<ImpressoraItem>(entity =>
            {
                entity.ToTable("impressora_item");
            });

            modelBuilder.Entity<Inutilizacao>(entity =>
            {
                entity.Property(e => e.Autorizada)
                .HasDefaultValue(false);

                entity.Property(e => e.tpAmb)
                .HasDefaultValue(2);

                entity.Property(x => x.Xml)
                .HasColumnType("blob");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.Idinventario)
                    .HasName("PK_inventario");

                entity.ToTable("inventario");

                entity.Property(e => e.Idinventario).HasColumnName("idinventario");

                entity.Property(e => e.CompetenciaFim).HasColumnType("datetime");

                entity.Property(e => e.CompetenciaInicio).HasColumnType("datetime");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DataImpressao).HasColumnType("datetime");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Fechado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<InventarioItens>(entity =>
            {
                entity.ToTable("inventario_itens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustoTotal).HasColumnType("decimal(10,3)");

                entity.Property(e => e.CustoUnitario).HasColumnType("decimal(10,3)");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Saldo).HasColumnType("decimal(10,3)");

                entity.Property(e => e.Un).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Localizacao>(entity =>
            {
                entity.ToTable("localizacao");

                entity.Property(e => e.Id)
                .HasColumnName("id");

                entity.Property(e => e.Ativa)
                .HasDefaultValue(true);
            });

            modelBuilder.Entity<LocalizacaoProduto>(entity =>
            {
                entity.ToTable("localizacaoproduto");

                entity.Property(e => e.Id)
                .HasColumnName("id");
            });

            modelBuilder.Entity<LocalizacaoSaldo>(entity =>
            {
                entity.ToTable("localizacaosaldo");

                entity.Property(e => e.Id)
                .HasColumnName("id");

                entity.Property(e => e.Saldo)
                .HasColumnType("decimal(13,3)");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.Idmarca)
                    .HasName("PK_marca");

                entity.ToTable("marca");

                entity.Property(e => e.Idmarca).HasColumnName("idmarca");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });
            modelBuilder.Entity<MDFeConfig>(entity =>
            {
                entity.ToTable("mdfeconfig");
                entity.HasKey(x => x.Id);

                entity.Property(x => x.IdEmpresa)
                .HasDefaultValue(0);

            });

            modelBuilder.Entity<MDFeXml>(entity =>
            {
                entity.ToTable("mdfexml");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Xml)
                .HasColumnType("blob");
                entity.Property(x => x.XmlEncerramento)
                .HasColumnType("blob");
                entity.Property(x => x.XmlCancelamento)
                .HasColumnType("blob");

            });

            modelBuilder.Entity<MDFe>(entity =>
            {
                entity.ToTable("mdfe");
                entity.HasKey(x => x.Id);

                entity.Property(x => x.mod)
                .HasDefaultValue(58);

                entity.Property(x => x.procEmi)
                .HasDefaultValue(0);

                entity.Property(x => x.verProc)
                .HasColumnType("varchar(20)")
                .HasDefaultValueSql("1.0");

            });

            modelBuilder.Entity<MDFeNFe>(entity =>
            {
                entity.ToTable("mdfenfe");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<MDFeVeiculo>(entity =>
            {
                entity.ToTable("mdfeveiculo");
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Metas>(entity =>
            {
                entity.ToTable("metas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodProd).HasDefaultValueSql("0");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(15,3)");

                entity.Property(e => e.Valor)
                .HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<Movimentocaixa>(entity =>
            {
                entity.HasKey(e => e.IdmovimentoCaixa)
                    .HasName("PK_movimentocaixa");

                entity.ToTable("movimentocaixa");

                entity.HasIndex(e => e.IdCaixa)
                    .HasName("Caxa_idx");

                entity.Property(e => e.IdmovimentoCaixa).HasColumnName("idmovimentoCaixa");

                entity.Property(e => e.Cancelado).HasDefaultValueSql("0");

                entity.Property(e => e.DataMovimentacao).HasColumnType("datetime");

                entity.Property(e => e.Hora).HasColumnType("time");

                entity.Property(e => e.IdCaixa).HasColumnName("idCaixa");

                entity.Property(e => e.IdPagamento).HasDefaultValueSql("0");

                entity.Property(e => e.Modelo).HasColumnType("varchar(45)");

                entity.Property(e => e.Natureza)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Venda");

                entity.Property(e => e.NumeroDoc).HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(270)");

                entity.Property(e => e.TipoDocumento).HasColumnType("varchar(50)");

                entity.Property(e => e.TipoEspecifico).HasColumnType("varchar(60)");

                entity.Property(e => e.TipoMovimento).HasColumnType("varchar(45)");

                entity.Property(e => e.Valor).HasColumnType("decimal(20,6)");

                entity.HasOne(d => d.IdCaixaNavigation)
                    .WithMany(p => p.Movimentocaixa)
                    .HasForeignKey(d => d.IdCaixa)
                    .HasConstraintName("Caxa");
            });

            modelBuilder.Entity<Movimentoitens>(entity =>
            {
                entity.HasKey(e => new { e.IdMovimento, e.IdEstabelecimento })
                    .HasName("PK_movimentoitens");

                entity.ToTable("movimentoitens");

                entity.HasIndex(e => e.IdEstabelecimento)
                    .HasName("fk_produto_has_estabelecimento_estabelecimento1_idx");

                entity.Property(e => e.IdMovimento).HasColumnName("idMovimento");

                entity.Property(e => e.IdEstabelecimento).HasColumnName("idEstabelecimento");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IdBalanco).HasDefaultValueSql("0");

                entity.Property(e => e.IdEntrada).HasDefaultValueSql("0");

                entity.Property(e => e.IdSaida).HasDefaultValueSql("0");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.TipoMovimento)
                .HasColumnType("varchar(45)");

                entity.Property(e => e.IdLocalizacaoProduto)
                .HasDefaultValue(0);

                entity.HasOne(d => d.IdEstabelecimentoNavigation)
                    .WithMany(p => p.Movimentoitens)
                    .HasForeignKey(d => d.IdEstabelecimento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_produto_has_estabelecimento_estabelecimento1");
            });

            modelBuilder.Entity<NfReferenciamento>(entity =>
            {
                entity.HasKey(e => e.IdnfReferenciamento)
                    .HasName("PK_nf_referenciamento");

                entity.ToTable("nf_referenciamento");

                entity.Property(e => e.IdnfReferenciamento).HasColumnName("idnf_referenciamento");

                entity.Property(e => e.Chave)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<NfVolume>(entity =>
            {
                entity.ToTable("nf_volume");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Esp)
                    .HasColumnName("esp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.NVol)
                    .HasColumnName("nVol")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.PesoB)
                    .HasColumnName("pesoB")
                    .HasColumnType("decimal(12,3)");

                entity.Property(e => e.PesoL)
                    .HasColumnName("pesoL")
                    .HasColumnType("decimal(12,3)");

                entity.Property(e => e.QVol).HasColumnName("qVol");
            });

            modelBuilder.Entity<Nfse>(entity =>
            {
                entity.ToTable("nfse");

                entity.Property(e => e.Acrescimo).HasColumnType("decimal(15,2)");

                entity.Property(e => e.AliquotaIss).HasColumnType("decimal(5,2)");

                entity.Property(e => e.BaseCalculo).HasColumnType("decimal(15,2)");

                entity.Property(e => e.CancelamentoEnviado).HasDefaultValueSql("0");

                entity.Property(e => e.Cnae).HasColumnType("text");

                entity.Property(e => e.CodigoAtividade).HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoCnae).HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoVerificacao).HasColumnType("varchar(100)");

                entity.Property(e => e.Competencia).HasColumnType("datetime");

                entity.Property(e => e.DataCancelamento).HasColumnType("datetime");

                entity.Property(e => e.Desconto).HasColumnType("decimal(15,2)");

                entity.Property(e => e.DescricaoServico).HasColumnType("text");

                entity.Property(e => e.Emissao).HasColumnType("datetime");

                entity.Property(e => e.JustificativaCancelamento).HasColumnType("text");

                entity.Property(e => e.Modelo).HasColumnType("varchar(45)");

                entity.Property(e => e.MunicipioIncidencia).HasColumnType("varchar(200)");

                entity.Property(e => e.MunicipioPrestacao).HasColumnType("varchar(200)");

                entity.Property(e => e.NumeroProcesso).HasColumnType("varchar(60)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Serie).HasColumnType("varchar(45)");

                entity.Property(e => e.Substituida).HasDefaultValueSql("0");

                entity.Property(e => e.TipoAtividade).HasColumnType("text");

                entity.Property(e => e.TotalNota).HasColumnType("decimal(15,2)");

                entity.Property(e => e.ValorIss).HasColumnType("decimal(15,2)");

                entity.Property(e => e.ValorServico).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Xml).HasColumnType("blob");
            });

            modelBuilder.Entity<NfseConfig>(entity =>
            {
                entity.ToTable("nfse_config");

                entity.Property(e => e.AliquotaIss)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.AliquotaSimples)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Modelo).HasColumnType("varchar(45)");

                entity.Property(e => e.NumeroProcesso).HasColumnType("varchar(60)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Serie).HasColumnType("varchar(45)");

                entity.Property(e => e.Logo).HasColumnType("mediumblob");

                entity.Property(e => e.EmailAutomatico)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<NfseServico>(entity =>
            {
                entity.ToTable("nfse_servico");

                entity.HasIndex(e => e.IdNota)
                    .HasName("fk_nfse_servico_nfse1_idx");

                entity.Property(e => e.Acrescimo).HasColumnType("decimal(15,2)");

                entity.Property(e => e.AliquotaIss).HasColumnType("decimal(5,2)");

                entity.Property(e => e.BaseCalculo).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Desconto).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Total).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Unidade).HasColumnType("varchar(45)");

                entity.Property(e => e.Valor).HasColumnType("decimal(15,2)");

                entity.Property(e => e.ValorIss).HasColumnType("decimal(15,2)");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.NfseServico)
                    .HasForeignKey(d => d.IdNota)
                    .HasConstraintName("Fk_Nota_Servico");
            });

            modelBuilder.Entity<NfseTomador>(entity =>
            {
                entity.ToTable("nfse_tomador");

                entity.HasIndex(e => e.IdNota)
                    .HasName("fk_nfse_tomador_nfse1_idx");

                entity.Property(e => e.Bairro).HasColumnType("varchar(200)");

                entity.Property(e => e.Cep).HasColumnType("varchar(45)");

                entity.Property(e => e.Cidade).HasColumnType("varchar(200)");

                entity.Property(e => e.Complemento).HasColumnType("text");

                entity.Property(e => e.CpfCnpj).HasColumnType("varchar(20)");

                entity.Property(e => e.Email).HasColumnType("varchar(200)");

                entity.Property(e => e.Email2).HasColumnType("varchar(200)");

                entity.Property(e => e.Fantasia).HasColumnType("varchar(200)");

                entity.Property(e => e.Logradouro).HasColumnType("varchar(45)");

                entity.Property(e => e.Numero).HasColumnType("varchar(45)");

                entity.Property(e => e.Razao).HasColumnType("varchar(200)");

                entity.Property(e => e.RgIe).HasColumnType("varchar(45)");

                entity.Property(e => e.Telefone).HasColumnType("varchar(45)");

                entity.Property(e => e.Telefone2).HasColumnType("varchar(45)");

                entity.Property(e => e.Uf).HasColumnType("varchar(2)");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.NfseTomador)
                    .HasForeignKey(d => d.IdNota)
                    .HasConstraintName("Fk_Nota");
            });

            modelBuilder.Entity<NotaMonitor>(entity =>
            {
                entity.ToTable("nota_monitor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ambiente).HasDefaultValueSql("1");

                entity.Property(e => e.Baixada).HasDefaultValueSql("0");

                entity.Property(e => e.CSitNfe).HasColumnName("cSitNFe");

                entity.Property(e => e.ChNfe)
                    .HasColumnName("chNFe")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.DhEmi)
                    .HasColumnName("dhEmi")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhRecbto)
                    .HasColumnName("dhRecbto")
                    .HasColumnType("datetime");

                entity.Property(e => e.DigVal)
                    .HasColumnName("digVal")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Manifestada).HasDefaultValueSql("0");

                entity.Property(e => e.MaxNsu).HasColumnName("maxNSU");

                entity.Property(e => e.NProt)
                    .HasColumnName("nProt")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.TpNf).HasColumnName("tpNF");

                entity.Property(e => e.UltNsu).HasColumnName("ultNSU");

                entity.Property(e => e.VNf)
                    .HasColumnName("vNF")
                    .HasColumnType("decimal(15,2)");

                entity.Property(e => e.XNome)
                    .HasColumnName("xNome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Xml).HasColumnType("mediumblob");
            });

            modelBuilder.Entity<Oe>(entity =>
            {
                entity.ToTable("oe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apelido).HasColumnType("varchar(200)");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DataEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataPrevista).HasColumnType("datetime");

                entity.Property(e => e.Enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Finalizada).HasDefaultValueSql("0");

                entity.Property(e => e.Nome).HasColumnType("varchar(200)");

                entity.Property(e => e.Pendente).HasDefaultValueSql("0");

                entity.Property(e => e.Responsavel).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<OeItens>(entity =>
            {
                entity.ToTable("oe_itens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Idoe).HasColumnName("idoe");

                entity.Property(e => e.QtdEntregue)
                    .HasColumnType("decimal(15,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(15,3)");

                entity.Property(e => e.Un).HasColumnType("varchar(45)");

                entity.Property(e => e.VTotal)
                    .HasColumnName("vTotal")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.VUnitario)
                    .HasColumnName("vUnitario")
                    .HasColumnType("decimal(10,3)");
            });

            modelBuilder.Entity<Os>(entity =>
            {
                entity.ToTable("os");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Revisao)
                .HasDefaultValue(false);

                entity.Property(e => e.Cancelada).HasDefaultValueSql("0");

                entity.Property(e => e.Celular).HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoImp).HasColumnType("varchar(45)");

                entity.Property(e => e.Contato).HasColumnType("varchar(45)");

                entity.Property(e => e.Cor).HasColumnType("varchar(45)");

                entity.Property(e => e.DataChegada).HasColumnType("datetime");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DataFinalizacao).HasColumnType("datetime");

                entity.Property(e => e.Finalizado).HasDefaultValueSql("0");

                entity.Property(e => e.IdVenda).HasDefaultValueSql("0");

                entity.Property(e => e.IdVendedor).HasDefaultValueSql("0");

                entity.Property(e => e.Identificacao).HasColumnType("varchar(100)");

                entity.Property(e => e.Importarda).HasDefaultValueSql("0");

                entity.Property(e => e.Km).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Modelo).HasColumnType("varchar(100)");

                entity.Property(e => e.Observacao).HasColumnType("text");

                entity.Property(e => e.Responsavel).HasColumnType("varchar(100)");

                entity.Property(e => e.Telefone).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<OsItem>(entity =>
            {
                entity.ToTable("os_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acrescimo)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Comissao)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.Desconto)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Observacao).HasColumnType("varchar(200)");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(10,3)");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Un)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Un");
            });

            modelBuilder.Entity<OsVeiculo>(entity =>
            {
                entity.ToTable("os_veiculo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cor).HasColumnType("varchar(100)");

                entity.Property(e => e.Identificacao).HasColumnType("varchar(100)");

                entity.Property(e => e.Km).HasColumnType("decimal(10,0)");

                entity.Property(e => e.Modelo).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasKey(e => e.Idpagamento)
                    .HasName("PK_pagamento");

                entity.ToTable("pagamento");

                entity.HasIndex(e => e.IdtipoDocumento)
                    .HasName("fk_pagamento_tipodocumento1_idx");

                entity.Property(e => e.Idpagamento).HasColumnName("idpagamento");

                entity.Property(e => e.Baixado).HasDefaultValueSql("0");

                entity.Property(e => e.Cancelado).HasDefaultValueSql("0");

                entity.Property(e => e.DataDocumento).HasColumnType("datetime");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.DataPagamento).HasColumnType("datetime");

                entity.Property(e => e.DataVencimento).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.IdDocOriginal).HasDefaultValueSql("0");

                entity.Property(e => e.IdPc3).HasDefaultValueSql("0");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("idtipoDocumento");

                entity.Property(e => e.Nfe).HasColumnType("varchar(45)");

                entity.Property(e => e.NomeOperador).HasColumnType("varchar(60)");

                entity.Property(e => e.NumeroDocumento).HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("text");

                entity.Property(e => e.Pedido).HasColumnType("varchar(45)");

                entity.Property(e => e.Recebido).HasDefaultValueSql("1");

                entity.Property(e => e.Situacao)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Em Aberto");

                entity.Property(e => e.ValorDocumento).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorPagamento).HasColumnType("decimal(20,5)");

                entity.HasOne(d => d.IdtipoDocumentoNavigation)
                    .WithMany(p => p.Pagamento)
                    .HasForeignKey(d => d.IdtipoDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_pagamento_tipodocumento1");
            });

            modelBuilder.Entity<Pagamentovenda>(entity =>
            {
                entity.HasKey(e => e.IdPagamentoVenda)
                    .HasName("PK_pagamentovenda");

                entity.ToTable("pagamentovenda");

                entity.HasIndex(e => e.Idvenda)
                    .HasName("idVenda_idx");

                entity.HasIndex(e => new { e.IdPagamentoVenda, e.IdtipoDocumento })
                    .HasName("idDocumento_idx");

                entity.Property(e => e.IdPagamentoVenda).HasColumnName("idPagamentoVenda");

                entity.Property(e => e.AdicionalParcelamento).HasColumnType("decimal(13,2)");

                entity.Property(e => e.DataVencimento).HasColumnType("datetime");

                entity.Property(e => e.DescontoFp)
                    .HasColumnType("decimal(15,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.DescricaoPagamento).HasColumnType("varchar(45)");

                entity.Property(e => e.DescricaoSefaz).HasColumnType("varchar(45)");

                entity.Property(e => e.IdPc3).HasDefaultValueSql("0");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("idtipoDocumento");

                entity.Property(e => e.Idvenda).HasColumnName("idvenda");

                entity.Property(e => e.NumeroParcela).HasDefaultValueSql("0");

                entity.Property(e => e.Tef).HasDefaultValueSql("0");

                entity.Property(e => e.TefAdquirente).HasColumnType("varchar(100)");

                entity.Property(e => e.TefCodigoControleAc).HasDefaultValueSql("0");

                entity.Property(e => e.TefCodigoControlePayGo).HasColumnType("varchar(30)");

                entity.Property(e => e.TefNsu).HasColumnType("varchar(45)");

                entity.Property(e => e.Valor).HasColumnType("decimal(20,6)");

                entity.Property(e => e.DescontoFixo)
                .HasColumnType("decimal(13,2)")
                .HasDefaultValue(0);

                entity.Property(e => e.AcrescimoFixo)
                .HasColumnType("decimal(13,2)")
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<Parametriza>(entity =>
            {
                entity.ToTable("parametriza");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataEnvio).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pc1>(entity =>
            {
                entity.ToTable("pc1");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Entrada).HasDefaultValueSql("1");

                entity.Property(e => e.Obs).HasColumnType("text");
            });

            modelBuilder.Entity<Pc2>(entity =>
            {
                entity.ToTable("pc2");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Obs).HasColumnType("text");
            });

            modelBuilder.Entity<Pc3>(entity =>
            {
                entity.ToTable("pc3");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Obs).HasColumnType("text");
            });

            modelBuilder.Entity<Pc4>(entity =>
            {
                entity.ToTable("pc4");

                entity.Property(e => e.Ativa).HasDefaultValueSql("1");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Obs).HasColumnType("text");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.ToTable("pedido");

                entity.Property(e => e.Aprovado).HasDefaultValueSql("0");

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.DataEntrega).HasColumnType("datetime");

                entity.Property(e => e.DataRecebimento).HasColumnType("datetime");

                entity.Property(e => e.EmAnalise).HasDefaultValueSql("0");

                entity.Property(e => e.EmTransporte).HasDefaultValueSql("0");

                entity.Property(e => e.Entregue).HasDefaultValueSql("0");

                entity.Property(e => e.IdDispositivo).HasColumnType("varchar(100)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Recebido).HasDefaultValueSql("1");

                entity.Property(e => e.Recusado).HasDefaultValueSql("0");

                entity.Property(e => e.Valor).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Reenviar)
                .HasDefaultValue(false);

                entity.Property(e => e.NFe)
                .HasDefaultValue(false);

                entity.Property(e => e.NFCe)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<PedidoItem>(entity =>
            {
                entity.ToTable("pedido_item");

                entity.Property(e => e.Acrescimo).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Aprovado).HasDefaultValueSql("1");

                entity.Property(e => e.Desconto).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(10,3)");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Unidade).HasColumnType("varchar(45)");

                entity.Property(e => e.Valor).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<PedidoPagamento>(entity =>
            {
                entity.ToTable("pedido_pagamento");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Valor).HasColumnType("decimal(10,2)");
            });
            modelBuilder.Entity<PedidoCompra>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_pedidocompra");

                entity.ToTable("pedidocompra");

                entity.Property(e => e.Enviado)
                .HasDefaultValue(false);

                entity.Property(e => e.Recebido)
                .HasDefaultValue(false);

                entity.Property(e => e.Cancelado)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<PedidoCompraItem>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_pedidocompraitem");

                entity.ToTable("pedidocompraitem");
            });

            modelBuilder.Entity<Perdas>(entity =>
            {
                entity.ToTable("perdas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataBaixa).HasColumnType("datetime");

                entity.Property(e => e.DataCadastro).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(13,3)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Un).HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoCliente)
                .HasDefaultValue(0);

                entity.Property(e => e.CodigoFornecedor)
                .HasDefaultValue(0);

                entity.Property(e => e.Baixado)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<Precomedio>(entity =>
            {
                entity.HasKey(e => e.Idprecomedio)
                    .HasName("PK_precomedio");

                entity.ToTable("precomedio");

                entity.HasIndex(e => e.CodigoProduto)
                    .HasName("fk_Produto_idx");

                entity.HasIndex(e => e.IdVenda)
                    .HasName("fk_CodigoVenda_idx");

                entity.Property(e => e.Idprecomedio).HasColumnName("idprecomedio");

                entity.Property(e => e.DataMovimentacao).HasColumnType("datetime");

                entity.Property(e => e.Valor).HasColumnType("decimal(11,4)");

                entity.HasOne(d => d.CodigoProdutoNavigation)
                    .WithMany(p => p.Precomedio)
                    .HasPrincipalKey(p => p.Codigo)
                    .HasForeignKey(d => d.CodigoProduto)
                    .HasConstraintName("fk_CodigoProdutoVenda");

                entity.HasOne(d => d.IdVendaNavigation)
                    .WithMany(p => p.Precomedio)
                    .HasForeignKey(d => d.IdVenda)
                    .HasConstraintName("fk_CodigoVenda");
            });

            modelBuilder.Entity<ProdMateriaprima>(entity =>
            {
                entity.HasKey(e => e.IdMateriaPrima)
                    .HasName("PK_prod_materiaprima");

                entity.ToTable("prod_materiaprima");

                entity.HasIndex(e => e.IdProdutoProduzido)
                    .HasName("fk_ProdutoProduzido_idx");

                entity.Property(e => e.IdMateriaPrima).HasColumnName("idMateriaPrima");

                entity.Property(e => e.IdEmpresa).HasDefaultValueSql("0");

                entity.Property(e => e.Quantidade)
                .HasColumnType("decimal(20,10)");

                entity.HasOne(d => d.IdProdutoProduzidoNavigation)
                    .WithMany(p => p.ProdMateriaprima)
                    .HasForeignKey(d => d.IdProdutoProduzido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ProdutoProduzido");
            });

            modelBuilder.Entity<ProdNota>(entity =>
            {
                entity.HasKey(e => e.IdprodNota)
                    .HasName("PK_prod_nota");

                entity.ToTable("prod_nota");

                entity.Property(e => e.IdprodNota).HasColumnName("idprod_nota");

                entity.Property(e => e.Cancelada).HasDefaultValueSql("0");

                entity.Property(e => e.CustoTotal)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.DataLancamento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");

                entity.Property(e => e.IdEmpresa).HasDefaultValueSql("0");

                entity.Property(e => e.Liberada).HasDefaultValueSql("0");

                entity.Property(e => e.NomeUsuario).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProdNotamateriaprima>(entity =>
            {
                entity.HasKey(e => e.IdprodNotamateriaprima)
                    .HasName("PK_prod_notamateriaprima");

                entity.ToTable("prod_notamateriaprima");

                entity.HasIndex(e => e.IdProdutoNota)
                    .HasName("fk_ProdutoNota_idx");

                entity.Property(e => e.IdprodNotamateriaprima).HasColumnName("idprod_notamateriaprima");

                entity.Property(e => e.CustoTotal)
                .HasColumnType("decimal(20,10)");

                entity.Property(e => e.CustoUnitario)
                .HasColumnType("decimal(20,10)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Quantidade)
                .HasColumnType("decimal(20,10)");

                entity.Property(e => e.Unidade).HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdProdutoNotaNavigation)
                    .WithMany(p => p.ProdNotamateriaprima)
                    .HasForeignKey(d => d.IdProdutoNota)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ProdutoNota");
            });

            modelBuilder.Entity<ProdNotaprodutos>(entity =>
            {
                entity.HasKey(e => e.IdprodNotaprodutos)
                    .HasName("PK_prod_notaprodutos");

                entity.ToTable("prod_notaprodutos");

                entity.HasIndex(e => e.IdNota)
                    .HasName("fk_NotaProducao_idx");

                entity.Property(e => e.IdprodNotaprodutos).HasColumnName("idprod_notaprodutos");

                entity.Property(e => e.CustoTotal)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.CustoUnitario)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.Unidade).HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdNotaNavigation)
                    .WithMany(p => p.ProdNotaprodutos)
                    .HasForeignKey(d => d.IdNota)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_NotaProducao");
            });

            modelBuilder.Entity<ProdProdutos>(entity =>
            {
                entity.HasKey(e => e.IdProdutoProduzido)
                    .HasName("PK_prod_produtos");

                entity.ToTable("prod_produtos");

                entity.Property(e => e.Custo)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Idproduto)
                    .HasName("PK_produto");

                entity.ToTable("produto");

                entity.HasIndex(e => e.Codigo)
                    .HasName("Codigo_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.CodigoGrupo)
                    .HasName("fk_produto_grupo1_idx");

                entity.HasIndex(e => e.CodigoMarca)
                    .HasName("fk_produto_marca_idx");

                entity.HasIndex(e => e.Idtributacao)
                    .HasName("fk_produto_trubutacao1_idx");

                entity.Property(e => e.Idproduto).HasColumnName("idproduto");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.Balanca).HasDefaultValueSql("0");

                entity.Property(e => e.Barras2).HasColumnType("varchar(20)");

                entity.Property(e => e.Barras3).HasColumnType("varchar(20)");

                entity.Property(e => e.Barras4).HasColumnType("varchar(20)");

                entity.Property(e => e.Barras5).HasColumnType("varchar(20)");

                entity.Property(e => e.Barras6).HasColumnType("varchar(20)");

                entity.Property(e => e.Cest).HasColumnType("varchar(10)");

                entity.Property(e => e.Codigo).IsRequired();

                entity.Property(e => e.CodigoBarras).HasColumnType("varchar(20)");

                entity.Property(e => e.CodigoSubgrupo).HasDefaultValueSql("0");

                entity.Property(e => e.CustoManual)
                    .HasColumnType("decimal(20,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.CustoMedio)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime");

                entity.Property(e => e.DescontoPermitido)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.DiasValidade).HasColumnType("varchar(45)");

                entity.Property(e => e.Estoque)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Estoque2)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.EstoqueMaximo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.EstoqueMinimo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Grade).HasDefaultValueSql("0");

                entity.Property(e => e.Idtributacao).HasColumnName("idtributacao");

                entity.Property(e => e.Local).HasColumnType("varchar(100)");

                entity.Property(e => e.Margem)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.MargemMinima)
                    .HasColumnType("decimal(10,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Mva).HasColumnType("decimal(10,3)");

                entity.Property(e => e.Ncm).HasColumnType("varchar(10)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(1000)");

                entity.Property(e => e.PermitirAlterarDescricao).HasDefaultValueSql("0");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(12,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Preco3)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Preco4)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Preco5)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Preco6)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PrecoAtacado)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.PrecoLivre).HasDefaultValueSql("0");

                entity.Property(e => e.PrecoVarejo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.ProdutoEspecifico).HasDefaultValueSql("0");

                entity.Property(e => e.QuantPreco3)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.QuantPreco4)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.QuantPreco5)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.QuantPreco6)
                    .HasColumnType("decimal(10,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Referencia).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia2).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia3).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia4).HasColumnType("varchar(100)");

                entity.Property(e => e.Referencia5).HasColumnType("varchar(100)");

                entity.Property(e => e.Servico).HasDefaultValueSql("0");

                entity.Property(e => e.UltimoCusto)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValueSql("0.000000");

                entity.Property(e => e.Uso).HasDefaultValueSql("0");

                entity.Property(e => e.VendaFracionada).HasDefaultValueSql("0");

                entity.Property(e => e.Comissao).HasDefaultValueSql("0");

                entity.Property(e => e.Multiplo)
                .HasDefaultValue(1)
                .HasColumnType("decimal(10,3)");

                entity.Property(e => e.TipoItem)
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<ProdutoEspecifico>(entity =>
            {
                entity.ToTable("produto_especifico");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodigoAnp)
                    .HasColumnName("CodigoANP")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoAnvisa)
                    .HasColumnName("CodigoANVISA")
                    .HasColumnType("varchar(13)");

                entity.Property(e => e.DescricaoAnp)
                    .HasColumnName("DescricaoANP")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PercentualGlp)
                    .HasColumnName("PercentualGLP")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PercentualGni)
                    .HasColumnName("PercentualGNi")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PercentualGnn)
                    .HasColumnName("PercentualGNn")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PrecoMaximo)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Tipo).HasColumnType("varchar(45)");

                entity.Property(e => e.ValorPartida)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<SaidaItemProdutoEspecifico>(entity =>
            {
                entity.ToTable("saidaitem_produtoespecifico");

                entity.HasKey(e => e.IdSaidaItemProdutoEspecifico)
                    .HasName("PK_IdSaidaItemProdutoEspecifico");

                entity.Property(e => e.IdSaidaItemProdutoEspecifico).HasColumnName("idSaidaItemProdutoEspecifico");

                entity.Property(e => e.VNChassiDoVeiculo).HasColumnType("varchar(17)");
                entity.Property(e => e.VNCor).HasColumnType("varchar(4)");
                entity.Property(e => e.VNDescricaoCor).HasColumnType("varchar(40)");
                entity.Property(e => e.VNPotenciaMotor).HasColumnType("varchar(4)");
                entity.Property(e => e.VNCilindradas).HasColumnType("varchar(4)");
                entity.Property(e => e.VNPesoLiquido).HasColumnType("varchar(9)");
                entity.Property(e => e.VNPesoBruto).HasColumnType("varchar(9)");
                entity.Property(e => e.VNSerial).HasColumnType("varchar(9)");
                entity.Property(e => e.VNTipoCombustivel).HasColumnType("varchar(2)");
                entity.Property(e => e.VNNumeroMotor).HasColumnType("varchar(21)");
                entity.Property(e => e.VNCapacidadeMaximaTracao).HasColumnType("varchar(9)");
                entity.Property(e => e.VNDistanciaEntreEixos).HasColumnType("varchar(4)");
                entity.Property(e => e.VNTipoPintura).HasColumnType("varchar(1)");
                entity.Property(e => e.VNCondicaoVIN).HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<ProdutoPromocao>(entity =>
            {
                entity.ToTable("produto_promocao");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFim).HasColumnType("datetime");

                entity.Property(e => e.DataInicio).HasColumnType("datetime");

                entity.Property(e => e.Margem).HasColumnType("decimal(6,3)");

                entity.Property(e => e.Valor).HasColumnType("decimal(15,2)");
            });

            modelBuilder.Entity<Produtoinventario>(entity =>
            {
                entity.HasKey(e => e.IdprodutoInventario)
                    .HasName("PK_produtoinventario");

                entity.ToTable("produtoinventario");

                entity.HasIndex(e => e.IdInventario)
                    .HasName("idInventario_idx");

                entity.Property(e => e.IdprodutoInventario).HasColumnName("idprodutoInventario");

                entity.Property(e => e.CustoTotal).HasColumnType("decimal(26,6)");

                entity.Property(e => e.CustoUnitario).HasColumnType("decimal(26,6)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Estoque).HasColumnType("decimal(26,6)");

                entity.Property(e => e.IdInventario).HasColumnName("idInventario");

                entity.Property(e => e.Un).HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdInventarioNavigation)
                    .WithMany(p => p.Produtoinventario)
                    .HasForeignKey(d => d.IdInventario)
                    .HasConstraintName("idInventario");
            });

            modelBuilder.Entity<Recebimento>(entity =>
            {
                entity.HasKey(e => e.Idrecebimento)
                    .HasName("PK_recebimento");

                entity.ToTable("recebimento");

                entity.HasIndex(e => e.IdtipoDocumento)
                    .HasName("fk_recebimento_tipodocumento1_idx");

                entity.Property(e => e.Idrecebimento).HasColumnName("idrecebimento");

                entity.Property(e => e.Baixado).HasDefaultValue(0);

                entity.Property(e => e.Cancelado).HasDefaultValueSql("0");

                entity.Property(e => e.DataDocumento).HasColumnType("datetime");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.DataPagamento).HasColumnType("datetime");

                entity.Property(e => e.DataVencimento).HasColumnType("datetime");

                entity.Property(e => e.Deflacao)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.IdDocOriginal).HasDefaultValueSql("0");

                entity.Property(e => e.IdPc3).HasDefaultValueSql("0");

                entity.Property(e => e.IdPortador).HasDefaultValueSql("0");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("idtipoDocumento");

                entity.Property(e => e.Idvenda).HasColumnName("idvenda");

                entity.Property(e => e.Nfce).HasColumnType("varchar(45)");

                entity.Property(e => e.Nfe).HasColumnType("varchar(45)");

                entity.Property(e => e.NomeOperador).HasColumnType("varchar(60)");

                entity.Property(e => e.NumeroDocumento).HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("text");

                entity.Property(e => e.Parcial).HasDefaultValueSql("0");

                entity.Property(e => e.Pedido).HasColumnType("varchar(45)");

                entity.Property(e => e.ValorDocumento).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorJurosAtraso).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorMultaAtraso).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorOriginal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorPagamento).HasColumnType("decimal(20,5)");

                entity.HasOne(d => d.IdtipoDocumentoNavigation)
                    .WithMany(p => p.Recebimento)
                    .HasForeignKey(d => d.IdtipoDocumento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_recebimento_tipodocumento1");
            });

            modelBuilder.Entity<Recebimento_Prevenda>(entity =>
            {
                entity.ToTable("recebimento_prevenda");

                entity.HasIndex(e => e.IdtipoDocumento)
                    .HasName("fk_recebimento_tipodocumento1_idx");

                entity.Property(e => e.Cancelado).HasDefaultValueSql("0");

                entity.Property(e => e.DataDocumento).HasColumnType("datetime");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.DataVencimento)
                .HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("text");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");
                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("idtipoDocumento");

                entity.Property(e => e.Idvenda).HasColumnName("idvenda");

                entity.Property(e => e.Nfce).HasColumnType("varchar(45)");

                entity.Property(e => e.Nfe).HasColumnType("varchar(45)");

                entity.Property(e => e.NomeOperador).HasColumnType("varchar(60)");

                entity.Property(e => e.NumeroDocumento).HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("text");

                entity.Property(e => e.Parcial).HasDefaultValueSql("0");

                entity.Property(e => e.Pedido).HasColumnType("varchar(45)");

                entity.Property(e => e.ValorDocumento).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorJurosAtraso).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorMultaAtraso).HasColumnType("decimal(20,5)");

                entity.Property(e => e.ValorOriginal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorPagamento).HasColumnType("decimal(20,5)");

            });

            modelBuilder.Entity<Relacionamentoitens>(entity =>
            {
                entity.HasKey(e => e.Idrelacionamento)
                    .HasName("PK_relacionamentoitens");

                entity.ToTable("relacionamentoitens");

                entity.Property(e => e.Idrelacionamento).HasColumnName("idrelacionamento");

                entity.Property(e => e.Cfop)
                .HasColumnType("varchar(45)");

                entity.Property(e => e.CST)
                .HasColumnType("varchar(4)");

                entity.Property(e => e.CnpjFornecedor)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.CodigoBarras).HasColumnType("varchar(20)");

                entity.Property(e => e.CodigoFornecedor)
                    .IsRequired()
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.CodigoProdutoFornecedor)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CodigoProdutoInterno)
                    .IsRequired()
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Desmembrado).HasDefaultValueSql("0");

                entity.Property(e => e.IdOrigem).HasDefaultValueSql("0");

                entity.Property(e => e.ProporcaoChegada)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("1.0000");

                entity.Property(e => e.ProporcaoEntrada)
                    .HasColumnType("decimal(10,4)")
                    .HasDefaultValueSql("1.0000");
            });

            modelBuilder.Entity<Remessa>(entity =>
            {
                entity.ToTable("remessa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataCriacao)
                    .HasColumnType("datetime");

                entity.Property(e => e.DataFinalizacao).HasColumnType("datetime");

                entity.Property(e => e.DataRemessa).HasColumnType("datetime");

                entity.Property(e => e.DataRetorno).HasColumnType("datetime");

                entity.Property(e => e.Enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Finalizada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<RemessaItens>(entity =>
            {
                entity.ToTable("remessa_itens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Margem).HasColumnType("decimal(11,2)");

                entity.Property(e => e.Novo).HasDefaultValueSql("0");

                entity.Property(e => e.PrecoFinal).HasColumnType("decimal(11,3)");

                entity.Property(e => e.PrecoFixo)
                    .HasColumnType("decimal(11,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PrecoNovo).HasDefaultValueSql("0");

                entity.Property(e => e.PrecoOriginal).HasColumnType("decimal(11,3)");

                entity.Property(e => e.QuantidadeRemessa).HasColumnType("decimal(11,3)");

                entity.Property(e => e.QuantidadeRetorno).HasColumnType("decimal(11,3)");

                entity.Property(e => e.Un).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<RemessaPedidos>(entity =>
            {
                entity.ToTable("remessa_pedidos");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<RemessaPedidosItens>(entity =>
            {
                entity.ToTable("remessa_pedidos_itens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Preco).HasColumnType("decimal(15,2)");

                entity.Property(e => e.Quantidade).HasColumnType("decimal(15,3)");
            });

            modelBuilder.Entity<Rota>(entity =>
            {
                entity.HasKey(e => e.Idrota)
                    .HasName("PK_rota");

                entity.ToTable("rota");

                entity.Property(e => e.Idrota).HasColumnName("idrota");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Comissao).HasColumnType("decimal(5,2)");

                entity.Property(e => e.ComissaoDesconto).HasColumnType("decimal(5,2)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Observacao).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Saidaitem>(entity =>
            {
                entity.HasKey(e => e.Idsaidaitem)
                    .HasName("PK_saidaitem");

                entity.ToTable("saidaitem");

                entity.HasIndex(e => e.IdSaida)
                    .HasName("fkSaida_idx");

                entity.Property(e => e.Idsaidaitem).HasColumnName("idsaidaitem");

                entity.Property(e => e.AcrescimoRateado).HasColumnType("decimal(14,4)");

                entity.Property(e => e.BaseIcms)
                .HasColumnType("decimal(13,2)");

                entity.Property(e => e.BaseIcmsSt)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CEnqIpi)
                    .HasColumnName("cEnqIPI")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CProdAnp)
                    .HasColumnName("cProdANP")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CProdAnvisa)
                    .HasColumnName("cProdANVISA")
                    .HasColumnType("varchar(13)");

                entity.Property(e => e.Cest).HasColumnType("varchar(10)");

                entity.Property(e => e.Cfop)
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("5102");

                entity.Property(e => e.CodigoBarras).HasColumnType("varchar(20)");

                entity.Property(e => e.CpTroca).HasDefaultValueSql("0");

                entity.Property(e => e.CstCofins)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.CstCso).HasColumnType("varchar(4)");

                entity.Property(e => e.CstIpi).HasDefaultValueSql("0");

                entity.Property(e => e.CstPis)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.DescAnp)
                    .HasColumnName("descANP")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Desconto)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.DescontoRateado)
                    .HasColumnType("decimal(14,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.IdGrade).HasDefaultValueSql("0");

                entity.Property(e => e.ModBcicms)
                    .HasColumnName("ModBCICMS")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ModBcicmsst)
                    .HasColumnName("ModBCICMSST")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Ncm).HasColumnType("varchar(10)");

                entity.Property(e => e.Origem).HasDefaultValueSql("0");

                entity.Property(e => e.OutrasDespesas)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PCofins)
                    .HasColumnName("pCofins")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PDevol)
                    .HasColumnName("pDevol")
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PGlp)
                    .HasColumnName("pGLP")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PGni)
                    .HasColumnName("pGNi")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PGnn)
                    .HasColumnName("pGNn")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcms)
                    .HasColumnName("pICMS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcmsst)
                    .HasColumnName("pICMSST")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.PIpi)
                    .HasColumnName("pIPI")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PMvast)
                    .HasColumnName("pMVAST")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PPis)
                    .HasColumnName("pPIS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PRedBc)
                    .HasColumnName("pRedBC")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.PRedBcst)
                    .HasColumnName("pRedBCST")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.PcredSn)
                    .HasColumnName("PCredSN")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(11,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TipoProdutoEspecifico).HasColumnType("varchar(100)");

                entity.Property(e => e.TribEstadual)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TribFederal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TribMunicipal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.UnidadeMedida)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Un");

                entity.Property(e => e.VBcCofins)
                    .HasColumnName("vBcCofins")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcipi)
                    .HasColumnName("vBCIPI")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcpis)
                    .HasColumnName("vBCPIS")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcstret)
                    .HasColumnName("vBCSTRet")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnName("vICMSDeson")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.VIcmsstret)
                    .HasColumnName("vICMSSTRet")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIi)
                    .HasColumnName("vII")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.VIpiDevol)
                    .HasColumnName("vIpiDevol")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VPart)
                    .HasColumnName("vPart")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VPmc)
                    .HasColumnName("vPMC")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorCofins)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIcms)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIcmsSt)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIpi)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorPis)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorSeguro)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorTotTrib).HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("decimal(14,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.VcredSn)
                    .HasColumnName("VCredSN")
                    .HasColumnType("decimal(13,2)");

                entity.HasOne(d => d.IdSaidaNavigation)
                    .WithMany(p => p.Saidaitem)
                    .HasForeignKey(d => d.IdSaida)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fkSaida");

                entity.Property(e => e.Verificado)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<Saidanota>(entity =>
            {
                entity.HasKey(e => e.Idsaidanota)
                    .HasName("PK_saidanota");

                entity.ToTable("saidanota");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("fkEmpresa_idx");

                entity.Property(e => e.IndPag)
                .HasDefaultValue(0);

                entity.Property(e => e.ContAutoTentativas).HasDefaultValue(0);

                entity.Property(e => e.Idsaidanota).HasColumnName("idsaidanota");

                entity.Property(e => e.CMun)
                    .HasColumnName("cMun")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CNf)
                    .HasColumnName("cNf")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.CPais)
                    .HasColumnName("cPais")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.CStat)
                    .HasColumnName("cStat")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Cancelada).HasDefaultValueSql("0");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.ChaveAcesso).HasColumnType("varchar(44)");

                entity.Property(e => e.CodSiteMercado).HasColumnType("varchar(100)");

                entity.Property(e => e.CodigoCliente).HasDefaultValueSql("0");

                entity.Property(e => e.CodigoFornecedor).HasDefaultValueSql("0");

                entity.Property(e => e.CodigoVendedor).HasColumnType("varchar(11)");

                entity.Property(e => e.CpfCnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.CpfCnpjTransp).HasColumnType("varchar(45)");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.DataLancamento).HasColumnType("datetime");

                entity.Property(e => e.DhCont)
                    .HasColumnName("dhCont")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhRecbto)
                    .HasColumnName("dhRecbto")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DhSaiEnt).HasColumnType("datetime");

                entity.Property(e => e.DigVal)
                    .HasColumnName("digVal")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DigitadaManualmente).HasDefaultValueSql("0");

                entity.Property(e => e.EmUso).HasDefaultValueSql("0");

                entity.Property(e => e.EmUsoDataHora).HasColumnType("datetime");

                entity.Property(e => e.EmUsoUsuario).HasColumnType("varchar(60)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");

                entity.Property(e => e.FinNfe)
                    .HasColumnName("finNFe")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IdDest).HasDefaultValueSql("1");

                entity.Property(e => e.IdEstrangeiro)
                    .HasColumnName("idEstrangeiro")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IdOs).HasDefaultValueSql("0");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IeTransp).HasColumnType("varchar(14)");

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Importada).HasDefaultValueSql("0");

                entity.Property(e => e.IndFinal)
                    .HasColumnName("indFinal")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IndIedest)
                    .HasColumnName("indIEDest")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.IndPres)
                    .HasColumnName("indPres")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Isuf)
                    .HasColumnName("ISUF")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Liberada).HasDefaultValueSql("0");

                entity.Property(e => e.ModFrete)
                    .HasColumnName("modFrete")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.Modelo).HasColumnType("varchar(10)");

                entity.Property(e => e.NProt)
                    .HasColumnName("nProt")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NatOp)
                    .HasColumnName("natOp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.NomeVendedor).HasColumnType("varchar(60)");

                entity.Property(e => e.Nro)
                    .HasColumnName("nro")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Observacao).HasColumnType("varchar(1000)");

                entity.Property(e => e.PlacaVeic)
                    .HasColumnName("placaVeic")
                    .HasColumnType("varchar(7)");

                entity.Property(e => e.RetContigencia).HasColumnType("text");

                entity.Property(e => e.Rntc).HasColumnType("varchar(20)");

                entity.Property(e => e.Serie).HasColumnType("varchar(4)");

                entity.Property(e => e.Situacao)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Em Digitação");

                entity.Property(e => e.TPag)
                    .HasColumnName("tPag")
                    .HasColumnType("int(2) unsigned zerofill")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.TpAmb)
                    .HasColumnName("tpAmb")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.TpEmis)
                    .HasColumnName("tpEmis")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TpImp)
                    .HasColumnName("tpImp")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TpNf)
                    .HasColumnName("tpNF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.UfTransp).HasColumnType("varchar(2)");

                entity.Property(e => e.UfVeic).HasColumnType("varchar(2)");

                entity.Property(e => e.VBc)
                    .HasColumnName("vBC")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VBcst)
                    .HasColumnName("vBCST")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VCofins)
                    .HasColumnName("vCOFINS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VDesc)
                    .HasColumnName("vDesc")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VDesp)
                    .HasColumnName("vDesp")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VFrete)
                    .HasColumnName("vFrete")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcms)
                    .HasColumnName("vICMS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnName("vICMSDeson")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIi)
                    .HasColumnName("vII")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIpi)
                    .HasColumnName("vIPI")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VNf)
                    .HasColumnName("vNF")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VOutro)
                    .HasColumnName("vOutro")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VPis)
                    .HasColumnName("vPIS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VProd)
                    .HasColumnName("vProd")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VSeg)
                    .HasColumnName("vSeg")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VSt)
                    .HasColumnName("vST")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VTotTrib)
                    .HasColumnName("vTotTrib")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VTroco)
                    .HasColumnName("vTroco")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VendaAberta).HasDefaultValueSql("1");

                entity.Property(e => e.XBairroDest)
                    .HasColumnName("xBairroDest")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XCpl)
                    .HasColumnName("xCpl")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.XEnderTransp)
                    .HasColumnName("xEnderTransp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XJust)
                    .HasColumnName("xJust")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.XLgr)
                    .HasColumnName("xLgr")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XMotivo)
                    .HasColumnName("xMotivo")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.XMun)
                    .HasColumnName("xMun")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.XMunTransp)
                    .HasColumnName("xMunTransp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XNome)
                    .HasColumnName("xNome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.XNomeTransp)
                    .HasColumnName("xNomeTransp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XPais)
                    .HasColumnName("xPais")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("BRASIL");

                entity.Property(e => e.ValorFixoFp)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValue(0);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Saidanota)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("fkEmpresa");

                entity.Property(e => e.ValorTribFederal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValue(0);

                entity.Property(e => e.ValorTribEstadual)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValue(0);

                entity.Property(e => e.ValorTribMunicipal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValue(0);
            });

            modelBuilder.Entity<Saidas>(entity =>
            {
                entity.HasKey(e => new { e.Idproduto, e.IdCliente })
                    .HasName("PK_saidas");

                entity.ToTable("saidas");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_produto_has_cliente_cliente1_idx");

                entity.HasIndex(e => e.Idproduto)
                    .HasName("fk_produto_has_cliente_produto1_idx");

                entity.Property(e => e.Idproduto).HasColumnName("idproduto");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Preco).HasColumnType("decimal(10,4)");

                entity.HasOne(d => d.IdprodutoNavigation)
                    .WithMany(p => p.Saidas)
                    .HasForeignKey(d => d.Idproduto)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_produto_has_cliente_produto1");
            });

            modelBuilder.Entity<Subgrupo>(entity =>
            {
                entity.ToTable("subgrupo");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.Comissao)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TabelaPreco>(entity =>
            {
                entity.ToTable("Tabela_Preco");
            });

            modelBuilder.Entity<TabelaPrecoItem>(entity =>
            {
                entity.ToTable("Tabela_Preco_Item");

                entity.Property(e => e.Custo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.CustoNovo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.CustoNovoFinal)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.CustoAdicionalValor)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.CustoAdicionalPercentual)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco1)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco2)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco3)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco4)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco5)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco6)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco1Novo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco2Novo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco3Novo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco4Novo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco5Novo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco6Novo)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco1Margem)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco2Margem)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco3Margem)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco4Margem)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco5Margem)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);

                entity.Property(e => e.Preco6Margem)
                    .HasColumnType("decimal(20,6)")
                    .HasDefaultValue(0);
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.ToTable("tecnico");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Comissao)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(60)");
            });

            modelBuilder.Entity<TempEntradaitem>(entity =>
            {
                entity.HasKey(e => e.Idtempentradaitem)
                    .HasName("fk_IdTempEntradaItem");

                entity.ToTable("temp_entradaitem");

                entity.Property(e => e.Idtempentradaitem).HasColumnName("idtempentradaitem");

                entity.Property(e => e.BaseIcms).HasColumnType("decimal(13,2)");

                entity.Property(e => e.BaseIcmsSt)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CEnqIpi)
                    .HasColumnName("cEnqIPI")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cest).HasColumnType("varchar(10)");

                entity.Property(e => e.Cfop)
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("5102");

                entity.Property(e => e.CfopEntrada).HasColumnType("varchar(5)");

                entity.Property(e => e.CodigoBarras).HasColumnType("varchar(20)");

                entity.Property(e => e.CodigoProdutoFornecedor).HasColumnType("varchar(40)");

                entity.Property(e => e.CstCofins).HasDefaultValueSql("99");

                entity.Property(e => e.CstCso).HasColumnType("varchar(4)");

                entity.Property(e => e.CstIpi).HasDefaultValueSql("0");

                entity.Property(e => e.CstPis)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.DataLancamento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Desconto)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Desmembrado).HasDefaultValueSql("0");

                entity.Property(e => e.IdOrigem).HasDefaultValueSql("0");

                entity.Property(e => e.ModBcicms)
                    .HasColumnName("ModBCICMS")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.ModBcicmsst)
                    .HasColumnName("ModBCICMSST")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Ncm).HasColumnType("varchar(10)");

                entity.Property(e => e.Origem).HasDefaultValueSql("0");

                entity.Property(e => e.OutrasDespesas)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PCofins)
                    .HasColumnName("pCofins")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcms)
                    .HasColumnName("pICMS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcmsst)
                    .HasColumnName("pICMSST")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.PIpi)
                    .HasColumnName("pIPI")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PMvast)
                    .HasColumnName("pMVAST")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PPis)
                    .HasColumnName("pPIS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PRedBc)
                    .HasColumnName("pRedBC")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.PRedBcst)
                    .HasColumnName("pRedBCST")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.PcredSn)
                    .HasColumnName("PCredSN")
                    .HasColumnType("decimal(6,3)");

                entity.Property(e => e.Quantidade)
                    .HasColumnType("decimal(11,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.UnidadeMedida)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Un");

                entity.Property(e => e.VBcCofins)
                    .HasColumnName("vBcCofins")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcipi)
                    .HasColumnName("vBCIPI")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcpis)
                    .HasColumnName("vBCPIS")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VBcstret)
                    .HasColumnName("vBCSTRet")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnName("vICMSDeson")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.VIcmsstret)
                    .HasColumnName("vICMSSTRet")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIi)
                    .HasColumnName("vII")
                    .HasColumnType("decimal(20,6)");

                entity.Property(e => e.ValorCofins)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIcms)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIcmsSt)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorIpi)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorPis)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorSeguro)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorTotTrib).HasColumnType("decimal(13,2)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("decimal(13,4)")
                    .HasDefaultValueSql("0.0000");

                entity.Property(e => e.VcredSn)
                    .HasColumnName("VCredSN")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.DescontoRateado)
                .HasColumnType("decimal(15,3)")
                .HasDefaultValue(0);

                entity.Property(e => e.AcrescimoRateado)
                .HasColumnType("decimal(15,3)")
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<TempEntradanota>(entity =>
            {
                entity.HasKey(e => e.Idtempentradanota)
                    .HasName("PK_temp_entradanota");

                entity.ToTable("temp_entradanota");

                entity.Property(e => e.Idtempentradanota).HasColumnName("idtempentradanota");

                entity.Property(e => e.CMun)
                    .HasColumnName("cMun")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.CPais)
                    .HasColumnName("cPais")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("1058");

                entity.Property(e => e.Cancelada).HasDefaultValueSql("0");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.ChaveAcesso).HasColumnType("varchar(44)");

                entity.Property(e => e.CpfCnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.DataLancamento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DhSaiEnt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Excluida).HasDefaultValueSql("0");

                entity.Property(e => e.FinNfe)
                    .HasColumnName("finNFe")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Fone)
                    .HasColumnName("fone")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IdDest).HasDefaultValueSql("1");

                entity.Property(e => e.IdEstrangeiro)
                    .HasColumnName("idEstrangeiro")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Ie)
                    .HasColumnName("IE")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Im)
                    .HasColumnName("IM")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.IndFinal)
                    .HasColumnName("indFinal")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IndIedest)
                    .HasColumnName("indIEDest")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.IndPres)
                    .HasColumnName("indPres")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Isuf)
                    .HasColumnName("ISUF")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Liberada).HasDefaultValueSql("0");

                entity.Property(e => e.ModFrete)
                    .HasColumnName("modFrete")
                    .HasDefaultValueSql("9");

                entity.Property(e => e.Modelo).HasColumnType("varchar(10)");

                entity.Property(e => e.NatOp)
                    .HasColumnName("natOp")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.NomeVendedor).HasColumnType("varchar(60)");

                entity.Property(e => e.NotaImportada).HasDefaultValueSql("0");

                entity.Property(e => e.Nro)
                    .HasColumnName("nro")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Serie).HasColumnType("varchar(4)");

                entity.Property(e => e.Situacao)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Em Digitação");

                entity.Property(e => e.TpAmb)
                    .HasColumnName("tpAmb")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.TpEmis)
                    .HasColumnName("tpEmis")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TpImp)
                    .HasColumnName("tpImp")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.TpNf)
                    .HasColumnName("tpNF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.VBc)
                    .HasColumnName("vBC")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VBcst)
                    .HasColumnName("vBCST")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VCofins)
                    .HasColumnName("vCOFINS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VDesc)
                    .HasColumnName("vDesc")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VDesp)
                    .HasColumnName("vDesp")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VFrete)
                    .HasColumnName("vFrete")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcms)
                    .HasColumnName("vICMS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnName("vICMSDeson")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIi)
                    .HasColumnName("vII")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VIpi)
                    .HasColumnName("vIPI")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VNf)
                    .HasColumnName("vNF")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VOutro)
                    .HasColumnName("vOutro")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VPis)
                    .HasColumnName("vPIS")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VProd)
                    .HasColumnName("vProd")
                    .HasColumnType("decimal(13,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.VSeg)
                    .HasColumnName("vSeg")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VSt)
                    .HasColumnName("vST")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VTotTrib)
                    .HasColumnName("vTotTrib")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VTroco)
                    .HasColumnName("vTroco")
                    .HasColumnType("decimal(13,2)");

                entity.Property(e => e.VendaAberta).HasDefaultValueSql("1");

                entity.Property(e => e.XCpl)
                    .HasColumnName("xCpl")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XLgr)
                    .HasColumnName("xLgr")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.XMun)
                    .HasColumnName("xMun")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.XNome)
                    .HasColumnName("xNome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.XPais)
                    .HasColumnName("xPais")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("BRASIL");
            });

            modelBuilder.Entity<Tipodocumento>(entity =>
            {
                entity.HasKey(e => e.IdtipoDocumento)
                    .HasName("PK_tipodocumento");

                entity.ToTable("tipodocumento");

                entity.Property(e => e.IdtipoDocumento).HasColumnName("idtipoDocumento");

                entity.Property(e => e.Acrescimo)
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Deflacao)
                    .HasColumnType("decimal(4,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Desconto)
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.DetalharParcelamento).HasDefaultValueSql("0");

                entity.Property(e => e.DiasDemaisParcelas).HasDefaultValueSql("30");

                entity.Property(e => e.DiasPrimeiraParcela).HasDefaultValueSql("30");

                entity.Property(e => e.DiasToleranciaAtraso).HasDefaultValueSql("5");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.IdPc3).HasDefaultValueSql("0");

                entity.Property(e => e.IdPortador).HasDefaultValueSql("0");

                entity.Property(e => e.JurosAtraso)
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.JurosMes)
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.MultaAtraso)
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.ParcelamentoMaximo).HasDefaultValueSql("1");

                entity.Property(e => e.ParcelamentoPadrao).HasDefaultValueSql("1");

                entity.Property(e => e.PermiteTroco).HasDefaultValueSql("0");

                entity.Property(e => e.PorcentagemAcrescimo).HasColumnType("decimal(5,3)");

                entity.Property(e => e.PorcentagemEntrada)
                    .HasColumnType("decimal(5,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.TPag)
                    .HasColumnName("tPag")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Tef).HasDefaultValueSql("0");

                entity.Property(e => e.TelaParcelamentoCartao).HasDefaultValueSql("0");

                entity.Property(e => e.TelaParcelamentoCheque).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.Property(e => e.TratamentoEspecifico)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("Dinheiro");

                entity.Property(e => e.ValorMinimo)
                    .HasColumnType("decimal(20,5)")
                    .HasDefaultValueSql("0.00000");

                entity.Property(e => e.DiasParaRecebimento)
                    .HasDefaultValue(30);
            });

            modelBuilder.Entity<Transportador>(entity =>
            {
                entity.ToTable("transportador");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Capacidade)
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Carroceria).HasColumnType("varchar(100)");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.IdVendedor).HasDefaultValueSql("0");

                entity.Property(e => e.Obs).HasColumnType("text");

                entity.Property(e => e.Placa).HasColumnType("varchar(45)");

                entity.Property(e => e.PropCpfCnpj).HasColumnType("varchar(14)");

                entity.Property(e => e.PropIe)
                    .HasColumnName("PropIE")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PropTipo).HasColumnType("varchar(45)");

                entity.Property(e => e.PropUf)
                    .HasColumnName("PropUF")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Proprietario).HasColumnType("varchar(200)");

                entity.Property(e => e.Renavam).HasColumnType("varchar(100)");

                entity.Property(e => e.Responsavel).HasColumnType("varchar(100)");

                entity.Property(e => e.Rntrc)
                    .HasColumnName("RNTRC")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Rodado).HasColumnType("varchar(30)");

                entity.Property(e => e.Tara)
                    .HasColumnType("decimal(12,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Terceiro)
                    .HasDefaultValue(false);

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<Tributacao>(entity =>
            {
                entity.HasKey(e => e.Idtributacao)
                    .HasName("PK_tributacao");

                entity.ToTable("tributacao");

                entity.Property(e => e.Idtributacao).HasColumnName("idtributacao");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.CEnqIpi)
                    .HasColumnName("cEnqIpi")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.Cfop)
                    .HasColumnType("varchar(6)")
                    .HasDefaultValueSql("5102");

                entity.Property(e => e.CfopDevolucao).HasColumnType("varchar(6)");

                entity.Property(e => e.CfopDevolucaoFe).HasColumnType("varchar(6)");

                entity.Property(e => e.CfopFe).HasColumnType("varchar(6)");

                entity.Property(e => e.CstCofins)
                    .HasColumnName("CstCOFINS")
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.CstCso)
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("00");

                entity.Property(e => e.CstCsoNfce)
                    .HasColumnName("CstCsoNFCe")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.CstIpi)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.CstPis)
                    .HasColumnType("varchar(3)")
                    .HasDefaultValueSql("99");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.ModBc)
                    .HasColumnName("modBC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModBcst)
                    .HasColumnName("modBCST")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orig)
                    .HasColumnName("orig")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PCofins)
                    .HasColumnName("pCOFINS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcms)
                    .HasColumnName("pICMS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIcmsst)
                    .HasColumnName("pICMSST")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PIpi)
                    .HasColumnName("pIpi")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PPis)
                    .HasColumnName("pPIS")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PRedBc)
                    .HasColumnName("pRedBC")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.PRedBcst)
                    .HasColumnName("pRedBCST")
                    .HasColumnType("decimal(6,3)")
                    .HasDefaultValueSql("0.000");

                entity.Property(e => e.Tipo)
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("ICMS");
            });

            modelBuilder.Entity<Unidademedida>(entity =>
            {
                entity.HasKey(e => e.IdunidadeMedida)
                    .HasName("PK_unidademedida");

                entity.ToTable("unidademedida");

                entity.Property(e => e.IdunidadeMedida).HasColumnName("idunidadeMedida");

                entity.Property(e => e.Ativo)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Atualizacao).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(45)");

                entity.Property(e => e.Excluido)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK_usuario");

                entity.ToTable("usuario");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Chave).HasColumnType("varchar(100)");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Logado).HasDefaultValueSql("0");

                entity.Property(e => e.Login).HasColumnType("varchar(100)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("senha")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Sobrenome).HasColumnType("varchar(100)");

                entity.Property(e => e.CartaoSemSenha)
                .HasDefaultValue(false);

                entity.Property(e => e.UltimaMaquina).HasColumnType("varchar(60)");

                entity.Property(e => e.UltimoAcesso).HasColumnType("datetime");
            });

            modelBuilder.Entity<Validade>(entity =>
            {
                entity.ToTable("validade");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataChegada).HasColumnType("datetime");

                entity.Property(e => e.DataVencimento).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Lote).HasColumnType("varchar(60)");
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.CodigoVendedor)
                    .HasName("PK_vendedor");

                entity.ToTable("vendedor");

                entity.Property(e => e.Ativo).HasDefaultValueSql("1");

                entity.Property(e => e.Comissao)
                    .HasColumnType("decimal(5,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.DataCadastro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Excluido).HasDefaultValueSql("0");

                entity.Property(e => e.Meta)
                    .HasColumnType("decimal(15,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Senha).HasColumnType("varchar(60)");
            });
            modelBuilder.Entity<VendedorRota>(entity =>
            {
                entity.ToTable("vendedor_rota");

                entity.Property(e => e.Excluido)
                .HasDefaultValue(false);
            });

            modelBuilder.Entity<Versao>(entity =>
            {
                entity.HasKey(e => e.Idversao)
                    .HasName("PK_versao");

                entity.ToTable("versao");

                entity.Property(e => e.Idversao).HasColumnName("idversao");

                entity.Property(e => e.DataPrimeiroAcesso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.DataUltimoAcesso).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnType("varchar(45)");

                entity.Property(e => e.Mac).HasColumnType("varchar(45)");

                entity.Property(e => e.Nome).HasColumnType("varchar(45)");

                entity.Property(e => e.Sistema).HasColumnType("varchar(45)");

                entity.Property(e => e.VSistema)
                    .HasColumnName("vSistema")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Xmlnota>(entity =>
            {
                entity.HasKey(e => e.Idxmlnota)
                    .HasName("PK_xmlnota");

                entity.ToTable("xmlnota");

                entity.HasIndex(e => e.Chave)
                    .HasName("Chave_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idxmlnota).HasColumnName("idxmlnota");

                entity.Property(e => e.Chave)
                    .IsRequired()
                    .HasColumnType("varchar(44)");

                entity.Property(e => e.Cnpj).HasColumnType("varchar(45)");

                entity.Property(e => e.DataEmissao).HasColumnType("datetime");

                entity.Property(e => e.DataGravacao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.JustificativaCancelamento).HasColumnType("varchar(60)");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnType("varchar(2)");

                entity.Property(e => e.Numero).HasColumnType("varchar(45)");

                entity.Property(e => e.XmlCancelamento).HasColumnType("blob");
            });


            modelBuilder.Entity<ControleSerie>(entity =>
            {
                entity.ToTable("controleSerie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataDaBaixa).HasColumnType("datetime");

                entity.Property(e => e.DataDeCadastro).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("varchar(200)");

                entity.Property(e => e.Lote).HasColumnType("varchar(60)");

                entity.Property(e => e.UsuarioAtualizacao).HasColumnType("varchar(80)");

                entity.Property(e => e.Serie1).HasColumnType("varchar(80)");

                entity.Property(e => e.Serie2).HasColumnType("varchar(80)");
            });
        }
    }
}
