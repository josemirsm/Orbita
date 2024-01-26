using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Versao
    {
        public int Idversao { get; set; }
        public string? Nome { get; set; }
        public string? Mac { get; set; }
        public string? Ip { get; set; }
        public DateTime? DataUltimoAcesso { get; set; }
        public DateTime? DataPrimeiroAcesso { get; set; }
        public string? Sistema { get; set; }
        public string? VSistema { get; set; }
    }
}
