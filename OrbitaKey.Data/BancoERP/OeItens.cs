using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class OeItens
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Entregue { get; set; }
        public int? IdSaidaItem { get; set; }
        public int? Idoe { get; set; }
        public decimal? QtdEntregue { get; set; }
        public decimal? Quantidade { get; set; }
        public string Un { get; set; }
        public decimal? VTotal { get; set; }
        public decimal? VUnitario { get; set; }
        public string Obs { get; set; }
    }
}
