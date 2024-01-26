using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Customedio
    {
        public int Idcustomedio { get; set; }
        public int CodigoProduto { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public int? IdBalanco { get; set; }
        public int? IdCompra { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdProducao { get; set; }
        public int? IdSaida { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }

        public virtual Produto CodigoProdutoNavigation { get; set; }
    }
}
