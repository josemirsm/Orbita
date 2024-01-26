using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class AuxCest
    {
        public int Id { get; set; }
        public string Cest { get; set; }
        public string Descricao { get; set; }
        public int? Ncm { get; set; }
        public string Segmento { get; set; }
    }
}
