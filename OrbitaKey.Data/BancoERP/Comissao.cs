using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Comissao
    {
        public int IdComissao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public int? DespesaGerada { get; set; }
        public int? Excluido { get; set; }
        public int? IdCobrador { get; set; }
        public int? IdPagamento { get; set; }
        public int? IdRecebimento { get; set; }
        public int? IdVenda { get; set; }
        public int? IdVendedor { get; set; }
        public int? Pago { get; set; }
        public decimal? Valor { get; set; }
    }
}
