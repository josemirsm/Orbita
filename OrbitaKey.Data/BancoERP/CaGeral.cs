using OrbitaKey.Data.BancoERP;
namespace OrbitaKey.Data.BancoERP
{
    /// <summary>
    /// Controle de acesso geral
    /// </summary>
    public partial class CaGeral
    {
        public int IdcaGeral { get; set; }
        public int? AdmAlterarRemessa { get; set; }
        public int? AdmApenasNfe { get; set; }
        public int? AdmLogin { get; set; }
        public int? CadClientes { get; set; }
        public int? CadEmpresa { get; set; }
        public int? CadFormaPagamento { get; set; }
        public int? CadProdutos { get; set; }
        public int? CadUsuarios { get; set; }
        public int? EstAjustarEstoque { get; set; }
        public int? EstCancelarNotaEntrada { get; set; }
        public int? EstExcluirNotaEntrada { get; set; }
        public int? FinAgruparRecebimento { get; set; }
        public int? FinBaixaPagamentos { get; set; }
        public int? FinBaixaRecebimentos { get; set; }
        public int? FinCaixa { get; set; }
        public int? FinCriarPagamento { get; set; }
        public int? FinCriarRecebimento { get; set; }
        public int? FinExcluirPagamento { get; set; }
        public int? FinExcluirRecebimento { get; set; }
        public bool? FinPagResumo { get; set; }
        public int? FinPagamentos { get; set; }
        public decimal? FinRecDescontoMaximo { get; set; }
        public bool? FinRecResumo { get; set; }
        public int? FinRecebimentos { get; set; }
        public int? FinRestaurarPagamento { get; set; }
        public int? FinRestaurarRecebimento { get; set; }
        public bool? FinTelaBaixaRecebimento { get; set; }
        public int? FinZerarMultaJuros { get; set; }
        public bool FinBaixaCaixaFechado { get; set; }
        public bool FinBloquearCliente { get; set; }

        public int IdUsuario { get; set; }
        public int? PdvAlterarAdicionalParcelamento { get; set; }
        public int? PdvAlterarPrecoProduto { get; set; }
        public int? PdvAlterarQuantidade { get; set; }
        public int? PdvCaixaCego { get; set; }
        public int? PdvCaixaOutrasDatas { get; set; }
        public int? PdvCaixaTodos { get; set; }
        public int? PdvCancelarDav { get; set; }
        public int? PdvCancelarItem { get; set; }
        public int? PdvCancelarNfce { get; set; }
        public int? PdvCancelarVendaAberta { get; set; }
        public int? PdvClienteInadimplente { get; set; }
        public int? PdvConfiguracoes { get; set; }
        public int? PdvControlarCaixa { get; set; }
        public int? PdvCusto { get; set; }
        public decimal? PdvDescontoMaximo { get; set; }
        public int? PdvEditarPrecoProdutoInserido { get; set; }
        public int? PdvEmitirDav { get; set; }
        public int? PdvEmitirNfce { get; set; }
        public int? PdvEmitirOrcamento { get; set; }
        public int? PdvExcederDescontoItem { get; set; }
        public int? PdvExcederLimiteCliente { get; set; }
        public bool PdvImprimirCaixaCego { get; set; }
        public bool PdvListarProdutos { get; set; }
        public int? PdvListaNotasData { get; set; }
        public int? PdvLogin { get; set; }
        public int? PdvRelatorioVendas { get; set; }
        public int? PdvSangria { get; set; }
        public int? PdvSuprimento { get; set; }
        public int? PdvTotaisListaNotas { get; set; }
        public bool? RelAlteracaoProdutos { get; set; }
        public bool? RelBalanco { get; set; }
        public int? RelClientes { get; set; }
        public bool? RelComissao { get; set; }
        public bool? RelContas { get; set; }
        public bool? RelDre { get; set; }
        public bool? RelEntradas { get; set; }
        public int? RelEstoque { get; set; }
        public bool? RelFluxoCaixa { get; set; }
        public bool? RelFornecedores { get; set; }
        public bool? RelLucratividade { get; set; }
        public bool? RelOs { get; set; }
        public bool? RelPagamentos { get; set; }
        public bool? RelProducao { get; set; }
        public bool? RelProdutos { get; set; }
        public bool? RelRecebimentos { get; set; }
        public bool? RelVendas { get; set; }
        public bool PdvDavDetalhar { get; set; }
        public bool PdvDavReimprimir { get; set; }
        public bool PdvDavImportar { get; set; }
        public bool PdvImportarNFCe { get; set; }
        public bool OsCancelar { get; set; }
        public bool OsExcluirItem { get; set; }
        public bool OsEditarItem { get; set; }
        public bool AdmDashboard { get; set; }
        public bool PdvDevolucaoItens { get; set; }
        /// <summary>
        /// Permite restringir para que o usuário só veja as vendas proprias
        /// </summary>
        public bool PdvVendasTodosUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
