using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class PedidoPagamento
    {
        public int Id { get; set; }
        public int? CdTipodocumento { get; set; }
        public string Descricao { get; set; }
        public int? IdMobile { get; set; }
        public int? IdPedido { get; set; }
        public int? Ordem { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? Desconto { get; set; }
        public int NumeroParcela { get; set; }
        public int QuantidadeParcelas { get; set; }
        public string Guid { get; set; }
        public string GuidPedido { get; set; }
    }
}
