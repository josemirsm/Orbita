using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Saidaitem
    {
        public int Idsaidaitem { get; set; }
        public int? IdProdutoEspecifico { get; set; }
        public decimal? AcrescimoRateado { get; set; }
        public decimal? BaseIcms { get; set; }
        public decimal? BaseIcmsSt { get; set; }
        public int? CEnqIpi { get; set; }
        public string CProdAnp { get; set; }
        public string CProdAnvisa { get; set; }
        public string Cest { get; set; }
        public string Cfop { get; set; }
        public int Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public bool CpTroca { get; set; }
        public string CstCofins { get; set; }
        public string CstCso { get; set; }
        public int? CstIpi { get; set; }
        public string CstPis { get; set; }
        public DateTime? DataLancamento { get; set; }
        public string DescAnp { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? DescontoRateado { get; set; }
        public string Descricao { get; set; }
        public int? IdGrade { get; set; }
        public int IdSaida { get; set; }
        public string ModBcicms { get; set; }
        public string ModBcicmsst { get; set; }
        public string Ncm { get; set; }
        public int? Origem { get; set; }
        public decimal? OutrasDespesas { get; set; }
        public decimal? PCofins { get; set; }
        public decimal? PDevol { get; set; }
        public decimal? PGlp { get; set; }
        public decimal? PGni { get; set; }
        public decimal? PGnn { get; set; }
        public decimal? PIcms { get; set; }
        public decimal? PIcmsst { get; set; }
        public decimal? PIpi { get; set; }
        public decimal? PMvast { get; set; }
        public decimal? PPis { get; set; }
        public decimal? PRedBc { get; set; }
        public decimal? PRedBcst { get; set; }
        public decimal? PcredSn { get; set; }
        public decimal? Quantidade { get; set; }
        public int? Sequencia { get; set; }
        public decimal? SubTotal { get; set; }
        public string TipoProdutoEspecifico { get; set; }
        public decimal? TribEstadual { get; set; }
        public decimal? TribFederal { get; set; }
        public decimal? TribMunicipal { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal? VBcCofins { get; set; }
        public decimal? VBcipi { get; set; }
        public decimal? VBcpis { get; set; }
        public decimal? VBcstret { get; set; }
        public decimal? VIcmsdeson { get; set; }
        public decimal? VIcmsstret { get; set; }
        public decimal? VIi { get; set; }
        public decimal? VIpiDevol { get; set; }
        public decimal? VPart { get; set; }
        public decimal? VPmc { get; set; }
        public decimal? ValorCofins { get; set; }
        public decimal? ValorFrete { get; set; }
        public decimal? ValorIcms { get; set; }
        public decimal? ValorIcmsSt { get; set; }
        public decimal? ValorIpi { get; set; }
        public decimal? ValorPis { get; set; }
        public decimal? ValorSeguro { get; set; }
        public decimal? ValorTotTrib { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? VcredSn { get; set; }
        public bool Atacado { get; set; }
        public string Referencia { get; set; }
        public bool Verificado { get; set; }

        public virtual Saidanota IdSaidaNavigation { get; set; }
    }
}
