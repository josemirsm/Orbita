using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Impressora
    {
        public int Id { get; set; }
        public bool? Automatica { get; set; }
        public string Caminho { get; set; }
        public bool? Conta { get; set; }
        public string Descricao { get; set; }
    }
}
