using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Controlador
    {
        public int IdControlador { get; set; }
        public int? IdCliente { get; set; }
        public string IpComputador { get; set; }
        public string MacMaquina { get; set; }
        public string NomeMaquina { get; set; }
        public string VersaoSistema { get; set; }
    }
}
