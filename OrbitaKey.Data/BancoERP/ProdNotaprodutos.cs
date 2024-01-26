using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdNotaprodutos
    {
        /// <summary>
        /// Produtos das notas de produção
        /// </summary>
        public ProdNotaprodutos()
        {
            ProdNotamateriaprima = new HashSet<ProdNotamateriaprima>();
        }

        public int IdprodNotaprodutos { get; set; }
        public int? CodigoProduto { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? CustoUnitario { get; set; }
        public string Descricao { get; set; }
        public int? IdNota { get; set; }
        public decimal? Quantidade { get; set; }
        public string Unidade { get; set; }
        public int? IdGrade { get; set; }
        public int? IdProdPreproducao { get; set; }

        public virtual ICollection<ProdNotamateriaprima> ProdNotamateriaprima { get; set; }
        public virtual ProdNota IdNotaNavigation { get; set; }
    }
}
