using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Os
    {
        public int Id { get; set; }
        public int? Cancelada { get; set; }
        public string Celular { get; set; }
        public int? CodigoCliente { get; set; }
        public string CodigoImp { get; set; }
        public string Contato { get; set; }
        public string Cor { get; set; }
        public DateTime? DataChegada { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public string Detalhamento { get; set; }
        public int? Finalizado { get; set; }
        public int? IdMecanico { get; set; }
        public int? IdVeiculo { get; set; }
        public int? IdVenda { get; set; }
        public int? IdVendedor { get; set; }
        public string Identificacao { get; set; }
        public int? Importarda { get; set; }
        public decimal? Km { get; set; }
        public string Modelo { get; set; }
        public string Observacao { get; set; }
        public string ProblemaConstatado { get; set; }
        public string ProblemaInformado { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        /// <summary>
        /// Indicação de que é uma revisão
        /// </summary>
        public bool Revisao { get; set; }
    }
}
