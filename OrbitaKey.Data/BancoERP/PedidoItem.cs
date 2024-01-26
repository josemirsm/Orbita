using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class PedidoItem
    {
        public int Id { get; set; }
        public decimal? Acrescimo { get; set; }
        public bool? Aprovado { get; set; }
        public int? CdProduto { get; set; }
        public decimal? Desconto { get; set; }
        public string Descricao { get; set; }
        public int? IdMobile { get; set; }
        public int? IdPedido { get; set; }
        public string Obs { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Total { get; set; }
        public string Unidade { get; set; }
        public decimal? Valor { get; set; }
        public string Guid { get; set; }
        public string GuidPedido { get; set; }
    }
}
