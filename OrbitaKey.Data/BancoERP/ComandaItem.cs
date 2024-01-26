using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ComandaItem
    {
        public int Id { get; set; }
        public bool Cancelado { get; set; }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public bool EmProducao { get; set; }
        public bool Entregue { get; set; }
        public bool Excluido { get; set; }
        public DateTime? Hora { get; set; }
        public int? IdComanda { get; set; }
        public bool Impresso { get; set; }
        public string Obs { get; set; }
        public decimal? Preco { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? Total { get; set; }
        public string Unidade { get; set; }
        public string Usuario { get; set; }
        public int IdVendedor { get; set; }
        public int IdUsuario { get; set; }
        public bool CancelamentoImpresso { get; set; }
        public string CancelamentoPessoa { get; set; }
        public DateTime? CancelamentoData { get; set; }
        public bool Carrinho { get; set; }
        /// <summary>
        /// Indica que o produto foi inserido por um carrinho
        /// </summary>
        public bool OrigemCarrinho { get; set; }
        public bool Reimpresso { get; set; }
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
    }
}
