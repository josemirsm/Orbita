using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class InventarioItens
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? CustoUnitario { get; set; }
        public string Descricao { get; set; }
        public int? IdInventario { get; set; }
        public decimal? Saldo { get; set; }
        public string Un { get; set; }
    }
}
