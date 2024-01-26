using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class NfseConfig
    {
        public int Id { get; set; }
        public decimal? AliquotaIss { get; set; }
        public decimal? AliquotaSimples { get; set; }
        public int? ExibilidadeIss { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IncentivoFiscal { get; set; }
        public int? IssRetido { get; set; }
        public string Modelo { get; set; }
        public int? Numero { get; set; }
        public string NumeroProcesso { get; set; }
        public string Obs { get; set; }
        public int? RegimeEspecialTributario { get; set; }
        public string Serie { get; set; }
        public byte[] Logo { get; set; }
        public string URL { get; set; }
        public bool EmailAutomatico { get; set; }
    }
}
