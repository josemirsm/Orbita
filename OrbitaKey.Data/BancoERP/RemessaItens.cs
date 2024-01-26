using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class RemessaItens
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public int? IdRemessa { get; set; }
        public decimal? Margem { get; set; }
        public bool? Novo { get; set; }
        public decimal? PrecoFinal { get; set; }
        public decimal? PrecoFixo { get; set; }
        public bool? PrecoNovo { get; set; }
        public decimal? PrecoOriginal { get; set; }
        public decimal? QuantidadeRemessa { get; set; }
        public decimal? QuantidadeRetorno { get; set; }
        public string Un { get; set; }
    }
}
