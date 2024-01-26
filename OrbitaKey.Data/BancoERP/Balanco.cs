using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Balanco
    {
        public int Idbalanco { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdUsuario { get; set; }
        public int? Liberada { get; set; }
    }
}
