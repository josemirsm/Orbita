using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Saidas
    {
        public int Idproduto { get; set; }
        public int IdCliente { get; set; }
        public decimal? Preco { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Produto IdprodutoNavigation { get; set; }
    }
}
