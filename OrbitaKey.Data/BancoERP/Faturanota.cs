using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Faturanota
    {
        public int Id { get; set; }
        public bool Boleto { get; set; }
        public DateTime? DVenc { get; set; }
        public int? IdEntrada { get; set; }
        public int? IdSaida { get; set; }
        public int? NDup { get; set; }
        public string NFat { get; set; }
        public decimal? VDesc { get; set; }
        public decimal? VDup { get; set; }
        public decimal? VLiq { get; set; }
        public decimal? VOrig { get; set; }
    }
}
