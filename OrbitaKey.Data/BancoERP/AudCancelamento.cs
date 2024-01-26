using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class AudCancelamento
    {
        public int Id { get; set; }
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public string Detalhamento { get; set; }
        public int? IdCompra { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdVenda { get; set; }
        public string NomeUsuario { get; set; }
    }
}
