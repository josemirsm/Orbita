using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Relacionamentoitens
    {
        public int Idrelacionamento { get; set; }
        public string Cfop { get; set; }
        
        public string CnpjFornecedor { get; set; }
        public string CodigoBarras { get; set; }
        public string CodigoFornecedor { get; set; }
        public string CodigoProdutoFornecedor { get; set; }
        public string CodigoProdutoInterno { get; set; }
        public bool Desmembrado { get; set; }
        public int? IdOrigem { get; set; }
        public decimal? ProporcaoChegada { get; set; }
        public decimal? ProporcaoEntrada { get; set; }
        public string CST { get; set; }
        public decimal? PIcms { get; set; }
        public decimal? PIcmsST { get; set; }
        public int IdGrade { get; set; }
    }
}
