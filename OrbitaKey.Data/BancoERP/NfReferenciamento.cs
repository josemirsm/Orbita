using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class NfReferenciamento
    {
        public int IdnfReferenciamento { get; set; }
        public string Chave { get; set; }
        public int? IdNota { get; set; }
    }
}
