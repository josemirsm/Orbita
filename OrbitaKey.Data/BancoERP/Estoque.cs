using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Estoque
    {
        public int Idestoque { get; set; }
        public int? CodigoProduto { get; set; }
        public int? IdEmpresa { get; set; }

        public decimal? Saldo { get; set; }
        public decimal? SaldoOe { get; set; }
        public decimal? SaldoOs { get; set; }

        public virtual Produto CodigoProdutoNavigation { get; set; }
        public virtual Estabelecimento IdEmpresaNavigation { get; set; }
    }
}
