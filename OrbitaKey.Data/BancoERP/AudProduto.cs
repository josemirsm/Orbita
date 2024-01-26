using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class AudProduto
    {
        public int Id { get; set; }
        public string Barras { get; set; }
        public string Cest { get; set; }
        public int? Codigo { get; set; }
        public decimal? CustoManual { get; set; }
        public decimal? CustoMedio { get; set; }
        public DateTime? Data { get; set; }
        /// <summary>
        /// Define se a alteração foi no desconto ou valor
        /// </summary>
        public bool? DescValor { get; set; }
        public decimal? DescontoMaximo { get; set; }
        public bool? Descri { get; set; }
        public string Descricao { get; set; }
        public string Grupo { get; set; }
        public int? IdProduto { get; set; }
        public int? IdTributacao { get; set; }
        public string Marca { get; set; }
        public string Ncm { get; set; }
        public bool? Parametriza { get; set; }
        public decimal? Preco1 { get; set; }
        public decimal? Preco2 { get; set; }
        public decimal? Preco3 { get; set; }
        public decimal? Preco4 { get; set; }
        public decimal? Preco5 { get; set; }
        public decimal? Preco6 { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Referencia4 { get; set; }
        public string Referencia5 { get; set; }
        public decimal? UltimoCusto { get; set; }
        public string Unidade { get; set; }
        public string Usuario { get; set; }
        public bool? Valor { get; set; }
    }
}
