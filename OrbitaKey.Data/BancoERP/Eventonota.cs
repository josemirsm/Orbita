using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Eventonota
    {
        public int Ideventonota { get; set; }
        public string Codigo { get; set; }
        public DateTime? DataEnvio { get; set; }
        public string Descricao { get; set; }
        public int? IdSaida { get; set; }
        public int? Sequencia { get; set; }
        public string Tipo { get; set; }
        public byte[] Xml { get; set; }
    }
}
