using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class BiVenda
    {
        public int Id { get; set; }
        public string? Guid { get; set; }
        public string? Cnpj { get; set; }
        public int? RepresentanteId { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? DataCompetencia { get; set; }
        public string? Modelo { get; set; }
        public int? Quantidade { get; set; }
        public decimal? Valor { get; set; }
        /// <summary>
        /// define se a venda fiscal é lançada no caixa
        /// </summary>
        public sbyte? FiscalCaixa { get; set; }
    }
}
