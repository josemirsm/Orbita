using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ConfigTef
    {
        public int Id { get; set; }
        public Enums.TipoTef Tipo { get; set; }
        public string Ip { get; set; }
        public string Empresa { get; set; }
        public string Estacao { get; set; }
        public string MensagemPinPad { get; set; }
    }
}
