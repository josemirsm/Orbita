using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class CaApp
    {
        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public bool CmdRemoverProdutoProducao { get; set; }
        public bool CmdEditarProdutoProducao { get; set; }
        public bool CmdRemoverProdutoEntregue { get; set; }
        public bool CmdEditarProdutoEntregue { get; set; }
        public bool CmdFinalizarComanda { get; set; }
        /// <summary>
        /// Quando ativo restringe os vendedores a ver apenas os clientes da propria rota
        /// </summary>
        public bool VexControleRota { get; set; }
    }
}
