using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdNotamateriaprima
    {
        public int IdprodNotamateriaprima { get; set; }
        public int? CodigoProduto { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? CustoUnitario { get; set; }
        public string Descricao { get; set; }
        public int? IdProdutoNota { get; set; }
        public decimal? Quantidade { get; set; }
        public string Unidade { get; set; }

        public virtual ProdNotaprodutos IdProdutoNotaNavigation { get; set; }
    }
}
