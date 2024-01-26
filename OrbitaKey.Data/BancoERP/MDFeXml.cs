using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class MDFeXml
    {        
        public int Id { get; set; }
        public int IdMDFe { get; set; }        
        public int Numero { get; set; }
        public int Serie { get; set; }
        public string Chave { get; set; }
        public byte[] Xml { get; set; }
        public byte[] XmlEncerramento { get; set; }
        public byte[] XmlCancelamento { get; set; }
    }
}
