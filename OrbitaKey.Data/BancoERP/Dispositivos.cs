using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Dispositivos
    {
        public int Id { get; set; }
        public bool? Ativo { get; set; }
        public bool? Comanda { get; set; }
        public string Descricao { get; set; }
        public string Identificacao { get; set; }
        public bool? VendaExterna { get; set; }
    }
}
