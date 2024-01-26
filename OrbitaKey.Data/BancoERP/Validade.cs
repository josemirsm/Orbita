using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Validade
    {
        public int Id { get; set; }
        public bool? Baixado { get; set; }
        public int? Codigo { get; set; }
        public int? CodigoFornecedor { get; set; }
        public DateTime? DataChegada { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string Descricao { get; set; }
        public int? IdNota { get; set; }
        public string Lote { get; set; }
    }
}
