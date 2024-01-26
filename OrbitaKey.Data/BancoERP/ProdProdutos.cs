using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdProdutos
    {
        public ProdProdutos()
        {
            ProdMateriaprima = new HashSet<ProdMateriaprima>();
        }

        public int IdProdutoProduzido { get; set; }
        public int? CodigoProduto { get; set; }
        public decimal? Custo { get; set; }

        public virtual ICollection<ProdMateriaprima> ProdMateriaprima { get; set; }
    }
}
