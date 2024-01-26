using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Grade
    {
        public int Id { get; set; }
        public int? Idx { get; set; }
        public int? Idy { get; set; }
        public int Idz { get; set; }
        public bool Ativa { get; set; }
        public int? Codigo { get; set; }
        public bool Excluida { get; set; }
        public int? IdEmpresa { get; set; }
        public decimal? Saldo { get; set; }
        public string Referencia { get; set; }
        public string Barras { get; set; }
        public decimal Preco { get; set; }
    }
}
