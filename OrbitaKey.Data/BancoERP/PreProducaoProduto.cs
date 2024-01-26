using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class PreProducaoProduto
    {
        public int Id { get; set; }
        public int IdPreproducao { get; set; }
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
        public string Descricao { get; set; }
        public string Un { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public int Prioridade { get; set; }
        public int Finalizado { get; set; }
        public int IdUsuario { get; set; }
        public string Obs { get; set; }
        public int? IdGrade { get; set; }
        /// <summary>
        /// Id do produto acabado usado para criar a pré-produção
        /// </summary>
        public int IdProdutoProducao { get; set; }
    }
}
