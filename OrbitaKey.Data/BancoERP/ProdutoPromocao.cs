using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdutoPromocao
    {
        public int Id { get; set; }
        public bool? Ativa { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime? DataInicio { get; set; }
        public decimal? Margem { get; set; }
        public decimal? Valor { get; set; }
    }
}
