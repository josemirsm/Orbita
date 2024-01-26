using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Cobrador
    {
        public int Idcobrador { get; set; }
        public int Ativo { get; set; }
        public decimal? Comissao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int Excluido { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
    }
}
