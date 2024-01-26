using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Controlenota
    {
        public int IdEstabelecimento { get; set; }
        public int? Cancelada { get; set; }
        public DateTime? DataLiberacao { get; set; }
    }
}
