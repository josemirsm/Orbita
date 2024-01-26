using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class Inutilizacao
    {
        public int Id { get; set; }
        public int IdSaida { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int tpAmb { get; set; }
        public int Numero { get; set; }
        public int Ano { get; set; }
        public int Serie { get; set; }
        public string Modelo { get; set; }
        public int Inicial { get; set; }
        public int Final { get; set; }
        public DateTime? Data { get; set; }
        public bool Autorizada { get; set; }
        public string Justificativa { get; set; }
        public byte[] Xml { get; set; }
    }
}
