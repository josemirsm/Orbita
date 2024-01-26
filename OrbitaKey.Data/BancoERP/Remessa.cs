using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Remessa
    {
        public int Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public DateTime? DataRemessa { get; set; }
        public DateTime? DataRetorno { get; set; }
        public int? Enviada { get; set; }
        public int? Finalizada { get; set; }
        public int? IdRota { get; set; }
        public int? IdTransportador { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdVendedor { get; set; }
    }
}
