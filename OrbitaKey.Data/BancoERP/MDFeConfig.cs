using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class MDFeConfig
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        /// <summary>
        /// Id da empresa na API
        /// </summary>
        public string IdEmpresaRef { get; set; }
        public int tpAmb { get; set; }
        public int Numero { get; set; }
        public int Serie { get; set; }
        public int tpEmit { get; set; }
        public int NumeroH { get; set; }
        public int SerieH { get; set; }
    }
}
