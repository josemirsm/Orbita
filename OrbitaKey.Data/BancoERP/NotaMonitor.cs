using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class NotaMonitor
    {
        public int Id { get; set; }
        public int? Ambiente { get; set; }
        public int? Baixada { get; set; }
        public int? CSitNfe { get; set; }
        public string ChNfe { get; set; }
        public string Cnpj { get; set; }
        public DateTime? DhEmi { get; set; }
        public DateTime? DhRecbto { get; set; }
        public string DigVal { get; set; }
        public int? IdEmpresa { get; set; }
        public string Ie { get; set; }
        public int? Manifestada { get; set; }
        public int? MaxNsu { get; set; }
        public string NProt { get; set; }
        public int? Nsu { get; set; }
        public int? Numero { get; set; }
        public string Obs { get; set; }
        public int? TpNf { get; set; }
        public int? UltNsu { get; set; }
        public decimal? VNf { get; set; }
        public string XNome { get; set; }
        public byte[] Xml { get; set; }
    }
}
