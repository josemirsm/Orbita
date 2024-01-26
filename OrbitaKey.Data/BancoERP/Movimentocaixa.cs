using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Movimentocaixa
    {
        public int IdmovimentoCaixa { get; set; }
        public int? Cancelado { get; set; }
        public DateTime? DataMovimentacao { get; set; }
        public TimeSpan? Hora { get; set; }
        public int? IdCaixa { get; set; }
        public int? IdPagamento { get; set; }
        public int? IdRecebimento { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? IdVenda { get; set; }
        public int? IdAdiantamento { get; set; }
        public int? IdCredito { get; set; }
        public string Modelo { get; set; }
        public string Natureza { get; set; }
        public string NumeroDoc { get; set; }
        public string Observacao { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoEspecifico { get; set; }
        public string TipoMovimento { get; set; }
        public decimal? Valor { get; set; }

        public virtual Caixa IdCaixaNavigation { get; set; }
    }
}
