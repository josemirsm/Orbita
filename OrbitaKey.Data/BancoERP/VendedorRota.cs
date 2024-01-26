using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class VendedorRota
    {
        public int Id { get; set; }
        public int RotaId { get; set; }
        public int VendedorId { get; set; }
        public DateTime Data { get; set; }
        public bool Excluido { get; set; }
    }
}
