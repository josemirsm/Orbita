using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class MDFeNFe
    {        
        public int Id { get; set; }
        public string chNFe { get; set; }
        public int IdMDFe { get; set; }        
        public int Numero { get; set; }
        public int Serie { get; set; }
        public decimal Peso { get; set; }
        public decimal Valor { get; set; }
    }
}
