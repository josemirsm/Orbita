using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public partial class PedidoCompra
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataPedido { get; set; }
        public int? CodigoFornecedor { get; set; }
        public bool Recebido { get; set; }
        public bool Enviado { get; set; }
        public bool Cancelado { get; set; }
    }
}
