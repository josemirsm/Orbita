using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class BalancoItem
    {
        public int IdItemBalanco { get; set; }
        public int? CodigoBalanco { get; set; }
        public int? CodigoProduto { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? CustoUnitario { get; set; }
        public int? IdBalanco { get; set; }
        public int? IdUsuario { get; set; }
        public decimal? Preco { get; set; }
        public decimal? Quantidade { get; set; }
        public int? Sequencia { get; set; }
        public int? IdGrade { get; set; }
        public int IdLocalizacaoProduto { get; set; }
    }
}
