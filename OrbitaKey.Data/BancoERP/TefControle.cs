using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public partial class TefControle
    {
        public int Id { get; set; }
        public Enums.TipoTef Tipo { get; set; }
        public int IdVenda { get; set; }
        public string Nsu { get; set; }
        public bool Confirmada { get; set; }
        public decimal Valor { get; set; }
    }
}
