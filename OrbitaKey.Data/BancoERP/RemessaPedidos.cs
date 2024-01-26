using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class RemessaPedidos
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdRemessa { get; set; }
    }
}
