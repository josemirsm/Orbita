using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Produtoinventario
    {
        public int IdprodutoInventario { get; set; }
        public int? Codigo { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? CustoUnitario { get; set; }
        public string Descricao { get; set; }
        public decimal? Estoque { get; set; }
        public int? IdInventario { get; set; }
        public string Un { get; set; }

        public virtual Inventario IdInventarioNavigation { get; set; }
    }
}
