using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class Contagem
    {
        public int Id { get; set; }
        public int IdCaixa { get; set; }
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        public decimal Contabilizado { get; set; }
        public decimal Contado { get; set; }
        public DateTime Data { get; set; }
    }
}
