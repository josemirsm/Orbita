using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class Adiantamento
    {
        public int Id { get; set; }
        public int IdDocumento { get; set; }
        public int IdOs { get; set; }
        public int IdPreproducao { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
