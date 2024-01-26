using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ContaMovimentacao
    {
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public int? CodigoCliente { get; set; }
        public int? CodigoFornecedor { get; set; }
        public DateTime? DataMovimentacao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string Descricao { get; set; }
        public string IdCaixa { get; set; }
        public int? IdConta { get; set; }
        public string IdPagamento { get; set; }
        public string IdRecebimento { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? IdUsuario { get; set; }
        public string IdVenda { get; set; }
        public bool Manual { get; set; }
        public string Numero { get; set; }
        public string Observacao { get; set; }
        public int? Tipo { get; set; }
        public decimal? Valor { get; set; }
    }
}
