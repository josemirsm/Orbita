using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class OsItem
    {
        public int Id { get; set; }
        public decimal? Acrescimo { get; set; }
        public int? Codigo { get; set; }
        public decimal? Comissao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public decimal? Desconto { get; set; }
        public string Descricao { get; set; }
        public int? Excluido { get; set; }
        public int? IdMecanico { get; set; }
        public int? IdOs { get; set; }
        public string Observacao { get; set; }
        public decimal? Preco { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? Total { get; set; }
        public string Un { get; set; }
    }
}
