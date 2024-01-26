using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Vendedor
    {
        public int CodigoVendedor { get; set; }
        public int? Ativo { get; set; }
        public decimal? Comissao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? Excluido { get; set; }
        public decimal? Meta { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
