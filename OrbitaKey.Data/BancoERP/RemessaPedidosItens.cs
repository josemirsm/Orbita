using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class RemessaPedidosItens
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public int? IdRemessaPedido { get; set; }
        public decimal? Preco { get; set; }
        public decimal? Quantidade { get; set; }
    }
}
