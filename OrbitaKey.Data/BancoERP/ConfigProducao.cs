using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class ConfigProducao
    {
        public int Id { get; set; }
        public decimal CustoOperacional { get; set; }
        public decimal Frete { get; set; }
        public decimal IPI { get; set; }
        public decimal ICMS { get; set; }
        public decimal MVA { get; set; }

        /// <summary>
        /// Quantidade de decimais para a quantidade da materia prima
        /// </summary>
        public string DecimaisQuantidade { get; set; }
        /// <summary>
        /// Quantidade de decimais para o custo da materia prima
        /// </summary>
        public string DecimaisCusto { get; set; }
    }
}
