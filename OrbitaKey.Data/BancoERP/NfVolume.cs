using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class NfVolume
    {
        public int Id { get; set; }
        public string Esp { get; set; }
        public int? IdSaida { get; set; }
        public string Marca { get; set; }
        public string NVol { get; set; }
        public decimal? PesoB { get; set; }
        public decimal? PesoL { get; set; }
        public int? QVol { get; set; }
    }
}
