using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Saidanota
    {
        public Saidanota()
        {
            Precomedio = new HashSet<Precomedio>();
            Saidaitem = new HashSet<Saidaitem>();
        }

        public int Idsaidanota { get; set; }
        public string CMun { get; set; }
        public string CNf { get; set; }
        public string CPais { get; set; }
        public string CStat { get; set; }
        public int? Cancelada { get; set; }
        public string Cep { get; set; }
        public string ChaveAcesso { get; set; }
        public string CodSiteMercado { get; set; }
        public int? CodigoCliente { get; set; }
        public int? CodigoFornecedor { get; set; }
        public string CodigoVendedor { get; set; }
        public string CpfCnpj { get; set; }
        public string CpfCnpjTransp { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public DateTime? DhCont { get; set; }
        public string DhRecbto { get; set; }
        public DateTime? DhSaiEnt { get; set; }
        public string DigVal { get; set; }
        public int? DigitadaManualmente { get; set; }
        public bool? EmUso { get; set; }
        public DateTime? EmUsoDataHora { get; set; }
        public string EmUsoUsuario { get; set; }
        public string Email { get; set; }
        public int? Excluida { get; set; }
        public int? FinNfe { get; set; }
        public string Fone { get; set; }
        public int? IdComanda { get; set; }
        public int? IdVendaExterna { get; set; }
        public int? IdDest { get; set; }
        public int? IdEmpresa { get; set; }
        public string IdEstrangeiro { get; set; }
        public int? IdOs { get; set; }
        public int? IdXml { get; set; }
        public int Idusuario { get; set; }
        public string Ie { get; set; }
        public string IeTransp { get; set; }
        public string Im { get; set; }
        public int? Importada { get; set; }
        public int? IndFinal { get; set; }
        public int? IndIedest { get; set; }
        public int? IndPres { get; set; }
        public string Isuf { get; set; }
        public int? Liberada { get; set; }
        public int? ModFrete { get; set; }
        public string Modelo { get; set; }
        public string NProt { get; set; }
        public string NatOp { get; set; }
        public string NomeVendedor { get; set; }
        public string Nro { get; set; }
        public int? NumeroNf { get; set; }
        public string Observacao { get; set; }
        public string PlacaVeic { get; set; }
        public string RetContigencia { get; set; }
        public string Rntc { get; set; }
        public string Serie { get; set; }
        public string Situacao { get; set; }
        public int? TPag { get; set; }
        public int? TpAmb { get; set; }
        public int? TpEmis { get; set; }
        public int? TpImp { get; set; }
        public int? TpNf { get; set; }
        public string Uf { get; set; }
        public string UfTransp { get; set; }
        public string UfVeic { get; set; }
        public decimal? VBc { get; set; }
        public decimal? VBcst { get; set; }
        public decimal? VCofins { get; set; }
        public decimal? VDesc { get; set; }
        public decimal? VDesp { get; set; }
        public decimal? VFrete { get; set; }
        public decimal? VIcms { get; set; }
        public decimal? VIcmsdeson { get; set; }
        public decimal? VIi { get; set; }
        public decimal? VIpi { get; set; }
        public decimal? VNf { get; set; }
        public decimal? VOutro { get; set; }
        public decimal? VPis { get; set; }
        public decimal? VProd { get; set; }
        public decimal? VSeg { get; set; }
        public decimal? VSt { get; set; }
        public decimal? VTotTrib { get; set; }
        public decimal? VTroco { get; set; }
        public int? VendaAberta { get; set; }
        public string XBairroDest { get; set; }
        public string XCpl { get; set; }
        public string XEnderTransp { get; set; }
        public string XJust { get; set; }
        public string XLgr { get; set; }
        public string XMotivo { get; set; }
        public string XMun { get; set; }
        public string XMunTransp { get; set; }
        public string XNome { get; set; }
        public string XNomeTransp { get; set; }
        public string XPais { get; set; }
        public int ContAutoTentativas { get; set; }
        public string ContAutoRetorno { get; set; }
        public string InfAdFisco { get; set; }
        public string InfCpl { get; set; }
        /// <summary>
        /// 0 - A Vista
        /// 1 - A prazo
        /// 9 - Sem pagamento
        /// </summary>
        public int IndPag { get; set; }
        public string JustificativaDevolucao { get; set; }
        /// <summary>
        /// Este campo será usado quando o cliente usar a opção de fixar o preço por forma de pagamento. 
        /// Com ele será possível saber passar este valor do ponto de venda para o caixa
        /// </summary>
        public decimal ValorFixoFp { get; set; }
        /// <summary>
        /// Usado para gravar o número original do DAV na pré-venda.
        /// Isso vai facilitar o rastreio quando a venda for liberada como NFCe ou Orçamento.
        /// </summary>
        public string NumeroDavOriginal { get; set; }

        /// <summary>
        /// Valor aproximado dos tributos Federais
        /// </summary>
        public decimal ValorTribFederal { get; set; }
        /// <summary>
        /// Valor aproximado dos tributos Estaduais
        /// </summary>
        public decimal ValorTribEstadual { get; set; }
        /// <summary>
        /// Valor aproximado dos tributos Minicipais
        /// </summary>
        public decimal ValorTribMunicipal { get; set; }

        /// <summary>
        /// Id do Dav que foi usado para gerar o NFCe. 
        /// Usar para saber se ja foi transmitido um NFCe para o DAV em questão
        /// </summary>
        public int IdDavOriginal { get; set; }

        public virtual ICollection<Precomedio> Precomedio { get; set; }
        public virtual ICollection<Saidaitem> Saidaitem { get; set; }
        public virtual ICollection<SaidaItemProdutoEspecifico> ProdutosEspecificos { get; set; }
        public virtual Estabelecimento IdEmpresaNavigation { get; set; }
    }
}
