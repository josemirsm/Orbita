﻿using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Pc3
    {
        public int Id { get; set; }
        public bool? Ativa { get; set; }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public int? IdPc2 { get; set; }
        public string Obs { get; set; }
    }
}
