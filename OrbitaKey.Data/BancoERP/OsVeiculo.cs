using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class OsVeiculo
    {
        public int Id { get; set; }
        public int? CodigoCliente { get; set; }
        public string Cor { get; set; }
        public string Identificacao { get; set; }
        public decimal? Km { get; set; }
        public string Modelo { get; set; }
    }
}
