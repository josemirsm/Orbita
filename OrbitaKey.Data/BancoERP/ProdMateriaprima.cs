using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdMateriaprima
    {
        public int IdMateriaPrima { get; set; }
        public int? CodigoMateriaPrima { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdProdutoProduzido { get; set; }
        public decimal? Quantidade { get; set; }

        public virtual ProdProdutos IdProdutoProduzidoNavigation { get; set; }
    }
}
