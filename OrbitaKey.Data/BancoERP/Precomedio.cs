using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Precomedio
    {
        public int Idprecomedio { get; set; }
        public int CodigoProduto { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public int IdVenda { get; set; }
        public decimal Valor { get; set; }

        public virtual Produto CodigoProdutoNavigation { get; set; }
        public virtual Saidanota IdVendaNavigation { get; set; }
    }
}
