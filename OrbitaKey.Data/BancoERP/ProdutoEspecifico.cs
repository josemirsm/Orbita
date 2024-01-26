using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdutoEspecifico
    {
        public int Id { get; set; }
        public string CodigoAnp { get; set; }
        public string CodigoAnvisa { get; set; }
        public string DescricaoAnp { get; set; }
        public decimal? PercentualGlp { get; set; }
        public decimal? PercentualGni { get; set; }
        public decimal? PercentualGnn { get; set; }
        public decimal? PrecoMaximo { get; set; }
        public string Tipo { get; set; }
        public decimal? ValorPartida { get; set; }
    }
}
