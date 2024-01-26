using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Xmlnota
    {
        public int Idxmlnota { get; set; }
        public string Chave { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime? DataGravacao { get; set; }
        public int? IdSaida { get; set; }
        public string JustificativaCancelamento { get; set; }
        public string Modelo { get; set; }
        public string Numero { get; set; }
        public byte[] Xml { get; set; }
        public byte[] XmlCancelamento { get; set; }
    }
}
