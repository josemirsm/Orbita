using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Tributacao
    {
        public int Idtributacao { get; set; }
        public DateTime? Atualizacao { get; set; }
        public string CEnqIpi { get; set; }
        public string Cfop { get; set; }
        /// <summary>
        /// O antigo CFOP será deixado para NFCe e este será usado para NFe para não precisar mexer no sistma de vendas
        /// </summary>
        public string CfopNFe { get; set; }
        public string CfopDevolucao { get; set; }
        public string CfopDevolucaoFe { get; set; }
        public string CfopFe { get; set; }
        public string CstCofins { get; set; }
        public string CstCso { get; set; }
        public string CstCsoNfce { get; set; }
        public string CstIpi { get; set; }
        public string CstPis { get; set; }
        public string Descricao { get; set; }
        public int? Excluido { get; set; }
        public int? ModBc { get; set; }
        public int? ModBcst { get; set; }
        public int? Orig { get; set; }
        public decimal? PCofins { get; set; }
        public decimal? PIcms { get; set; }
        public decimal? PIcmsst { get; set; }
        public decimal? PIpi { get; set; }
        public decimal? PPis { get; set; }
        public decimal? PRedBc { get; set; }
        public decimal? PRedBcst { get; set; }
        public string Tipo { get; set; }
        public string Guid { get; set; }
    }
}
