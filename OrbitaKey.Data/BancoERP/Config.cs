using OrbitaKey.Data.BancoERP.Enums;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Config
    {
        public int Idconfig { get; set; }
        public int? AcrescimoItem { get; set; }
        public bool AdmMarca { get; set; }
        public int? AdmMesas { get; set; }
        public int? AdmZerosNaReferencia { get; set; }
        public int? AtualizacaoAutomatica { get; set; }
        public bool AutoProducao { get; set; }
        public string BalDecimaisPrecoPeso { get; set; }
        public string BalDigitoInicial { get; set; }
        public string BalDigitosCodigo { get; set; }
        public string BalDigitosPrecoPeso { get; set; }
        public string BalPrecoPeso { get; set; }
        public int? CadClientesInformacoesComplementares { get; set; }
        public bool CadProdBarras { get; set; }
        public bool CadProdCustos { get; set; }
        public bool CadProdDescIgual { get; set; }
        public bool CadProdHistorico { get; set; }
        public bool CadProdObs { get; set; }
        public bool CadProdPrecoLista { get; set; }
        public bool CadProdSubgrupo { get; set; }
        public int? CadProdutoEmpresaCusto { get; set; }
        public int? CadProdutoPrecoAtacado { get; set; }
        public int? CampoQuantidade { get; set; }
        public int? CanhotoPromissoria { get; set; }
        public decimal? ComServico { get; set; }
        public int ContagemDocumento { get; set; }
        public bool ControlePromocao { get; set; }
        public string DavFonte { get; set; }
        public int? DavTamanhoLetra { get; set; }
        public string DecimaisPreco { get; set; }
        public string DecimaisQuantidade { get; set; }
        public int? DescontoItem { get; set; }
        public string DiretorioBackup { get; set; }
        public string DiretorioNotas { get; set; }
        public string EmailEmail { get; set; }
        public string EmailPorta { get; set; }
        public string EmailRemetente { get; set; }
        public string EmailRodape { get; set; }
        public string EmailSenha { get; set; }
        public string EmailSmtp { get; set; }
        public int? EmailSsl { get; set; }
        public int? ExibirAniversariantesHome { get; set; }
        public int? ExibirBackupHome { get; set; }
        public int? ExibirLotesHome { get; set; }
        public int? ExibirPagamentosHome { get; set; }
        public bool ExibirOrdemEntregaHome { get; set; }
        public int? ExibirRecebimentosHome { get; set; }
        public bool FinCnpjNaLista { get; set; }
        public bool FinComprovanteResumido { get; set; }
        public bool FinControleBoleto { get; set; }
        public int? FinDataOriginalDocParcial { get; set; }
        public bool FinLancarPagCaixa { get; set; }
        public bool FinNaoAplicarJuros { get; set; }
        public bool FinPagColunaNfe { get; set; }
        public bool FinPagColunaObs { get; set; }
        public bool FinRecebido { get; set; }
        public int? IdEmpresaDav { get; set; }
        public int? IdEmpresaImpressao { get; set; }
        public int? IdEmpresaNf { get; set; }
        public bool ImpAtualizarTributacao { get; set; }
        public bool ImpBarras { get; set; }
        public bool ImpQuantidadeUnidade { get; set; }
        public int? ImportacaoAtualizarCest { get; set; }
        public bool ImportacaoAtualizarEan { get; set; }
        public int? ImportacaoAtualizarNcm { get; set; }
        public int? ImportacaoCodigoGrupo { get; set; }
        public int? ImportacaoCodigoMarca { get; set; }
        public int? ImportacaoCodigoUnidade { get; set; }
        public string ImportacaoDecimaisQuantidade { get; set; }
        public string ImportacaoDecimaisValores { get; set; }
        public int? ImportacaoIdPc3 { get; set; }
        public int? ImportacaoImportarBoletos { get; set; }
        public decimal? ImportacaoLucroAtacado { get; set; }
        public decimal? ImportacaoLucroVarejo { get; set; }
        public int? ImportacaoRelacionamentoInteligente { get; set; }
        public int? MaisPrecos { get; set; }
        public int? MaisReferencias { get; set; }
        public int? NfBaixaEstoqueDav { get; set; }
        public int? NfceAmbiente { get; set; }
        public int? NfeAmbiente { get; set; }
        public bool NfeBaixaEstoqueDav { get; set; }
        public int? NfeBloquearSaldoZerado { get; set; }
        public bool NfeGerarBoleto { get; set; }
        public int? NfeLancarCaixa { get; set; }
        public int? OsBloquearSaldoZerado { get; set; }
        public int? OsIdEmpresaSaldo { get; set; }
        public string OsMensagemFixa { get; set; }
        public bool OsObrigarIdentificacao { get; set; }
        public bool OsOrdemAlfabetica { get; set; }
        public bool OsVerificarAberta { get; set; }
        public bool PdvAlterarData { get; set; }
        public int? PdvBalBarras { get; set; }
        public int? PdvBeep { get; set; }
        public bool PdvBtnPrecos { get; set; }
        public bool PdvCliente { get; set; }
        public int? PdvConfirmacaoUsuario { get; set; }
        /// <summary>
        /// Solicitar configrmacao de usuario na baixa de recebimento
        /// </summary>
        public bool FinRecConfirmacaoUsuario { get; set; }
        /// <summary>
        /// Solicitar configrmacao de usuario na baixa de pagamento
        /// </summary>
        public bool FinPagConfirmacaoUsuario { get; set; }
        public int? PdvCpTrocaDiasValidade { get; set; }
        public string PdvCpTrocaMensagem { get; set; }
        public bool PdvCpTrocaPerguntar { get; set; }
        public int? PdvDavBloquearSaldoZerado { get; set; }
        public int? PdvDavEscolherEmpresa { get; set; }
        public int? PdvDavFinalizacaoCompleta { get; set; }
        public int? PdvDavFonteGrande { get; set; }
        public int? PdvDavImprimirFantasia { get; set; }
        public int? PdvDavImprimirRazao { get; set; }
        public string PdvDavMensagemFixa { get; set; }
        public int? PdvDavMensagemNaoFiscal { get; set; }
        public int? PdvDavModelo { get; set; }
        public bool PdvDavMsgImp { get; set; }
        public int? PdvDavPerguntarImprimir { get; set; }
        public int? PdvDavProdutoEmDuasLinhas { get; set; }
        public bool PdvDerrubarUsuario { get; set; }
        public int? PdvDesativarFinalizacaoOrc { get; set; }
        public int? PdvDescApenasProdutos { get; set; }
        public int? PdvEmpresaListaProdutos { get; set; }
        public bool PdvExibirLocal { get; set; }
        public int? PdvExibirMarca { get; set; }
        public int? PdvExibirNumeroDav { get; set; }
        public int? PdvExibirPrecoAtacado { get; set; }
        public int? PdvExibirReferencia { get; set; }
        public int? PdvExibirReferencia2 { get; set; }
        public bool PdvExibirReserva { get; set; }
        public int? PdvHabilitarDav { get; set; }
        public int? PdvHabilitarNfce { get; set; }
        public int? PdvHabilitarOrc { get; set; }
        public int? PdvImprimirPromissoria { get; set; }
        public int? PdvInterfaceSimplificada { get; set; }
        public bool PdvMascaras { get; set; }
        public bool PdvNaoDestacarAdicional { get; set; }
        public int? PdvNfceBloquearSaldoZerado { get; set; }
        public bool PdvNfceEscolherEmpresa { get; set; }
        public int? PdvNfceFonteGrande { get; set; }
        public int? PdvNfceNaoLancarCaixa { get; set; }
        public decimal? PdvNfceObrigarCpf { get; set; }
        public int? PdvNfcePerguntarImprimir { get; set; }
        public int? PdvNfceProdutoEmDuasLinhas { get; set; }
        public bool PdvObrigarVendedor { get; set; }
        public bool PdvObrigarVendedorPreVenda { get; set; }
        /// <summary>
        /// Restring os usuário de Pré-Venda a ver aepans o saldo da empresa configurada ara DAV
        /// </summary>
        public bool PdvPreVendaSaldoDav { get; set; }
        public bool PdvOcultarDav { get; set; }
        public bool PdvOcultarDescAcre { get; set; }
        public bool PdvOcultarOrc { get; set; }
        public bool PdvOe { get; set; }
        /// <summary>
        /// Permite a impressão da Ordem de entraga direto no balcão de Pré-Venda
        /// </summary>
        public bool PdvOePreVenda { get; set; }
        /// <summary>
        /// Cria uma OE automaticamente com todos os produtos da venda
        /// </summary>
        public bool PdvOeAutomatica { get; set; }
        public bool PdvOrcOcultarValorProduto { get; set; }
        public int? PdvOrcReferenciaImpressao { get; set; }
        public int? PdvPagPadrao { get; set; }
        public decimal? PdvPercentualAprazo { get; set; }
        public bool PdvTelaAvAp { get; set; }
        public int? PdvTipoAtacado { get; set; }
        public int? PdvToleranciaClienteAtraso { get; set; }
        public int? PdvTotalServicos { get; set; }
        public bool PdvValorAp { get; set; }
        public int? PdvVerificarItemVenda { get; set; }
        public int? PdvViasSangria { get; set; }
        public bool PdvZerarDescontoImportacao { get; set; }
        public int? SalvarPdfNfce { get; set; }
        public int? SalvarPdfNfe { get; set; }
        public int? SepararNotasPorCnpj { get; set; }
        public int? SepararNotasPorDia { get; set; }
        public int? SepararPdfXml { get; set; }
        public int? TeclasTrocoRapido { get; set; }
        public int? TefIdentificador { get; set; }
        public int? TempInformacoesRespTec { get; set; }
        public string TipoEmpresa { get; set; }
        public string TribLicenca { get; set; }
        public string TribToken { get; set; }
        public int? ViasComprovanteBaixa { get; set; }
        /// <summary>
        /// Quantidade de vias da impressão do DAV Finalizado
        /// </summary>
        public int? ViasDav { get; set; }
        public bool NFeSinc { get; set; }
        public bool NFCeSinc { get; set; }
        public int ValidadeCredito { get; set; }
        /// <summary>
        /// Quando ativado, gera crédito para o cliente em vez de fazer sangria
        /// </summary>
        public bool Credito { get; set; }
        public bool MensagemCredito { get; set; }
        public bool PdvDavAvisarSaldo { get; set; }
        public bool PdvNfceAvisarSaldo { get; set; }
        /// <summary>
        /// Em casos de uso de grade, é interessante enviar para o cliente final a referencia do produto em vez de enviar o código interno para possibilitar o relacionamento dos produtos na importação
        /// </summary>
        public bool NFeEnviarRefrencia { get; set; }
        public bool PdvListarNFCePrimeiro { get; set; }
        public bool NFeEnviarBarras { get; set; }
        /// <summary>
        /// Tipo de documento padrão para baixa de documentos
        /// </summary>
        public int TipoDocBaixa { get; set; }
        /// <summary>
        /// Define se ao alterar o código de barras de um produto inserido na venda irá alterar também no cadastro do produto
        /// </summary>
        public bool PdvAlterarEanProduto { get; set; }
        /// <summary>
        /// Lançamento automático no controle de contas manual
        /// </summary>
        public bool FinRecContaManual { get; set; }
        /// <summary>
        /// Lançamento automático no controle de contas manual
        /// </summary>
        public bool FinPagContaManual { get; set; }
        public decimal ComCouvert { get; set; }
        public bool PdvPromissoriaResumida { get; set; }
        /// <summary>
        /// Define se a promissõria deverá ser impressa na pré-venda, antes da liberação no caixa.
        /// </summary>
        public bool PdvPromissoriaPrevenda { get; set; }
        public bool PdvObrigarCliente { get; set; }
        /// <summary>
        /// Ultimo custo no campo de pesquisa dos produtos na entrada de nota
        /// </summary>
        public bool AdmPesUltimoCusto { get; set; }
        /// <summary>
        /// Saldo no campo de pesquisa dos produtos na entrada de nota
        /// </summary>
        public bool AdmPesSaldo { get; set; }
        /// <summary>
        /// Dias para bloqueio de clientes inadimplestes
        /// </summary>
        public int FinDiasBloqueioCliente { get; set; }
        /// <summary>
        /// Dias para obrigar a atualizção do cadastro de clientes
        /// </summary>
        public int FinDiasAtualizarCadastro { get; set; }

        /// <summary>
        /// Permitir vendas a prazo para cliente especial inadimplente e sem limite de crédito
        /// </summary>
        public int FinClienteEspecial { get; set; }

        /// <summary>
        /// Permitir a informação do cliente em cada item inserido na mesa
        /// </summary>
        public bool CmdClienteItem { get; set; }

        /// <summary>
        /// Configuração do tamanho de fonte
        /// </summary>
        public TamanhoFonteEnum CmdTamanhoFonte { get; set; }


        /// <summary>
        /// Configuração do tamanho do papel
        /// </summary>
        public TamanhoPapelEnum CmdTamanhoPapel { get; set; }

        /// <summary>
        /// Permitir o envio de vários itens na mesma impressao
        /// </summary>
        public bool CmdImpressaoCarrinho { get; set; }
        public string DescricaoPreco1 { get; set; }
        public string DescricaoPreco2 { get; set; }
        public string DescricaoPreco3 { get; set; }
        public string DescricaoPreco4 { get; set; }
        public string DescricaoPreco5 { get; set; }
        public string DescricaoPreco6 { get; set; }
        /// <summary>
        /// Obrigar a confirmação dos produtos vindos de uma pré-venda
        /// </summary>
        public bool PdvVerificarItens { get; set; }
        /// <summary>
        /// Define o tamanho da logo a ser usada na impressão térmica
        /// </summary>
        public bool LogoGrande { get; set; }
        public bool ControleDevolucao { get; set; }
        /// <summary>
        /// Regras de validação +Consult para NFe
        /// </summary>
        public bool NFeRegrasMaisConsult { get; set; }
        /// <summary>
        /// Quando ativada abre uma tela com o valo da venda em cada forma de pagamento,
        /// fazendo com que o preço fique fixado independete da forma de pagamento posterior
        /// </summary>
        public bool PdvTelaFixarPrecoDocumento { get; set; }
        /// <summary>
        /// Faz com que apareça na lista de notas do PDV a opção de editar DAV ja liberado.
        /// </summary>
        public bool PdvDavEditarFinalizado { get; set; }
        /// <summary>
        /// Quantidade de vias para impressão do DAV ainda em Pré-Venda
        /// </summary>
        public int PdvDavViasImpPrevenda { get; set; }
        /// <summary>
        /// Quando configurado para apenas exibir o número do DAV, em vez de imprimir a venda. 
        /// Imprime uma guia com o número, para o usuário não ter que escrever manualmente
        /// </summary>
        public bool PdvDavImpNumeroPrevenda { get; set; }

        /// <summary>
        /// Codifica o custo do produto na tela de vendas, para evitar que o cliente veja.
        /// 1234567890 = ABCDEFGHIJ
        /// </summary>
        public bool PdvCodificarCusto { get; set; }

        /// <summary>
        /// Mensagem padrão para a promissória, por padrão usada para avisar de júros e multa
        /// </summary>
        public string PdvMensagemPromissoria { get; set; }

        /// <summary>
        /// Zera os Descontos e Acréscimos na importação de vendas do PDV para NFe
        /// </summary>
        public bool NFeZerarDescAcreImportacao { get; set; }

        /// <summary>
        /// Deixa o filtro de NFCe ativo ao abrir a lista de notas do PDV
        /// </summary>
        public bool PdvFiltrarNCFe { get; set; }

        /// <summary>
        /// Ativa uma guia de coneferência de entrega do pedido ao cliente final.
        /// A princípio será usado apenas no modelo de DAV A4 Com Promissória.
        /// </summary>
        public bool PdvDavGuiaConferencia { get; set; }

        /// <summary>
        /// Percentual da venda que será lançada como cashback do sistema de crédito
        /// </summary>
        public decimal PdvCashback { get; set; }

        /// <summary>
        /// Define uma cor para os prdutos que estão com saldo negativo na lista de pesquisa
        /// </summary>
        public bool PdvCorSaldo { get; set; }

        /// <summary>
        /// Exibe no canhoto da NFe um resumo com a data e valor da nota.
        /// </summary>
        public bool NFeCanhotoResumo { get; set; }

        /// <summary>
        /// Define a quantidade de decimais da mascara do custo manual no cadastro de produtos
        /// </summary>
        public string DecimaisCustoManual { get; set; }

        /// <summary>
        /// Define se o PDV deve ser iniciado automaticamente em modo de contingência
        /// </summary>
        public bool PdvContingenciaAutomatica { get; set; }

        /// <summary>
        /// Veficiar se já existe um produto cadastrado com a referência que está sendo usada
        /// </summary>
        public bool VerificarReferencia { get; set; }
        /// <summary>
        /// Valor de a prazo na impressão do DAV
        /// </summary>
        public bool PdvDavImpValorAp { get; set; }
        /// <summary>
        /// Calcular imposto no DAV para evitar diferença entre o calculado com acréscimos no DAV e ST na NFe
        /// </summary>
        public bool PdvDavImposto { get; set; }

        /// <summary>
        /// Permite que o usuário insira um vendedor sem por a senha
        /// </summary>
        public bool PdvVendedorSemSenha { get; set; }

        /// <summary>
        /// Vias para impressão da OE
        /// </summary>
        public int PdvOeVias { get; set; }
        /// <summary>
        /// Mensagem padrão fixa para NFe
        /// </summary>
        public string NFeMensagemFixa { get; set; }
    }
}
