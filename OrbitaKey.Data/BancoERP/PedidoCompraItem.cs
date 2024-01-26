using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public partial class PedidoCompraItem
    {
        public int Id { get; set; }
        public int IdPedidoCompra { get; set; }
        public int Codigo { get; set; }
        public decimal Quantidade { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
    }
}
