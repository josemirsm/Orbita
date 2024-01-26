using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Recebimento_Prevenda
    {
        public int Id { get; set; }
        public int? Cancelado { get; set; }
        public int? CodigoCliente { get; set; }
        public DateTime? DataDocumento { get; set; }
        public DateTime? DataLancamento { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string Descricao { get; set; }
        public int? Excluido { get; set; }
        public int? IdUsuario { get; set; }
        public int IdtipoDocumento { get; set; }
        public int? Idvenda { get; set; }
        public string Nfce { get; set; }
        public string Nfe { get; set; }
        public string NomeOperador { get; set; }
        public string NumeroDocumento { get; set; }
        public int? NumeroParcela { get; set; }
        public string Observacao { get; set; }
        public int? Parcial { get; set; }
        public string Pedido { get; set; }
        public int? QuantidadeParcelas { get; set; }
        public decimal? ValorDocumento { get; set; }
        public decimal? ValorJurosAtraso { get; set; }
        public decimal? ValorMultaAtraso { get; set; }
        public decimal? ValorOriginal { get; set; }
        public decimal? ValorPagamento { get; set; }
    }
}
