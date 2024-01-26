using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Tecnico
    {
        public int Id { get; set; }
        public int? Ativo { get; set; }
        public int Codigo { get; set; }
        public decimal? Comissao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? Excluido { get; set; }
        public string Nome { get; set; }
    }
}
